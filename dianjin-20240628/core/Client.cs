// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DianJin20240628.Models;

namespace AlibabaCloud.SDK.DianJin20240628
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dianjin", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public CreateFinReportSummaryTaskResponse CreateFinReportSummaryTaskWithOptions(string workspaceId, CreateFinReportSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                body["endPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                body["startPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFinReportSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFinReportSummaryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public async Task<CreateFinReportSummaryTaskResponse> CreateFinReportSummaryTaskWithOptionsAsync(string workspaceId, CreateFinReportSummaryTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTable))
            {
                body["enableTable"] = request.EnableTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                body["endPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                body["instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                body["startPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFinReportSummaryTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFinReportSummaryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public CreateFinReportSummaryTaskResponse CreateFinReportSummaryTask(string workspaceId, CreateFinReportSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFinReportSummaryTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建财报总结任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFinReportSummaryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFinReportSummaryTaskResponse
        /// </returns>
        public async Task<CreateFinReportSummaryTaskResponse> CreateFinReportSummaryTaskAsync(string workspaceId, CreateFinReportSummaryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFinReportSummaryTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public CreateLibraryResponse CreateLibraryWithOptions(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public CreateLibraryResponse CreateLibrary(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLibraryResponse
        /// </returns>
        public async Task<CreateLibraryResponse> CreateLibraryAsync(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public CreatePdfTranslateTaskResponse CreatePdfTranslateTaskWithOptions(string workspaceId, CreatePdfTranslateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                body["knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateTo))
            {
                body["translateTo"] = request.TranslateTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdfTranslateTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/pdfTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdfTranslateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public async Task<CreatePdfTranslateTaskResponse> CreatePdfTranslateTaskWithOptionsAsync(string workspaceId, CreatePdfTranslateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                body["knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateTo))
            {
                body["translateTo"] = request.TranslateTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdfTranslateTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/pdfTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdfTranslateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public CreatePdfTranslateTaskResponse CreatePdfTranslateTask(string workspaceId, CreatePdfTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePdfTranslateTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建PDF翻译任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePdfTranslateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePdfTranslateTaskResponse
        /// </returns>
        public async Task<CreatePdfTranslateTaskResponse> CreatePdfTranslateTaskAsync(string workspaceId, CreatePdfTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePdfTranslateTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public CreatePredefinedDocumentResponse CreatePredefinedDocumentWithOptions(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentWithOptionsAsync(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public CreatePredefinedDocumentResponse CreatePredefinedDocument(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePredefinedDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建预定义文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePredefinedDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePredefinedDocumentResponse
        /// </returns>
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentAsync(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePredefinedDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocumentWithOptions(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentWithOptionsAsync(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocument(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentAsync(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public DeleteLibraryResponse DeleteLibraryWithOptions(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public async Task<DeleteLibraryResponse> DeleteLibraryWithOptionsAsync(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public DeleteLibraryResponse DeleteLibrary(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLibraryResponse
        /// </returns>
        public async Task<DeleteLibraryResponse> DeleteLibraryAsync(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public EvictTaskResponse EvictTaskWithOptions(string workspaceId, EvictTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EvictTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/evict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvictTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public async Task<EvictTaskResponse> EvictTaskWithOptionsAsync(string workspaceId, EvictTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EvictTask",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/evict",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvictTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public EvictTaskResponse EvictTask(string workspaceId, EvictTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EvictTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中断任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EvictTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// EvictTaskResponse
        /// </returns>
        public async Task<EvictTaskResponse> EvictTaskAsync(string workspaceId, EvictTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EvictTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
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
        /// GetAppConfigResponse
        /// </returns>
        public GetAppConfigResponse GetAppConfigWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
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
        /// GetAppConfigResponse
        /// </returns>
        public async Task<GetAppConfigResponse> GetAppConfigWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAppConfigResponse
        /// </returns>
        public GetAppConfigResponse GetAppConfig(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppConfigWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取app配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAppConfigResponse
        /// </returns>
        public async Task<GetAppConfigResponse> GetAppConfigAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppConfigWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public GetDocumentChunkListResponse GetDocumentChunkListWithOptions(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListWithOptionsAsync(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public GetDocumentChunkListResponse GetDocumentChunkList(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentChunkListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档的chunk列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentChunkListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentChunkListResponse
        /// </returns>
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListAsync(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentChunkListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public GetDocumentListResponse GetDocumentListWithOptions(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public async Task<GetDocumentListResponse> GetDocumentListWithOptionsAsync(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public GetDocumentListResponse GetDocumentList(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentListResponse
        /// </returns>
        public async Task<GetDocumentListResponse> GetDocumentListAsync(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public GetDocumentUrlResponse GetDocumentUrlWithOptions(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public async Task<GetDocumentUrlResponse> GetDocumentUrlWithOptionsAsync(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public GetDocumentUrlResponse GetDocumentUrl(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentUrlWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档URL</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentUrlResponse
        /// </returns>
        public async Task<GetDocumentUrlResponse> GetDocumentUrlAsync(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentUrlWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public GetFilterDocumentListResponse GetFilterDocumentListWithOptions(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
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
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListWithOptionsAsync(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
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
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public GetFilterDocumentListResponse GetFilterDocumentList(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFilterDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>带条件的分页查询文档库的文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFilterDocumentListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFilterDocumentListResponse
        /// </returns>
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListAsync(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFilterDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public GetHistoryListByBizTypeResponse GetHistoryListByBizTypeWithOptions(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeWithOptionsAsync(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public GetHistoryListByBizTypeResponse GetHistoryListByBizType(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHistoryListByBizTypeWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoryListByBizTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryListByBizTypeResponse
        /// </returns>
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeAsync(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHistoryListByBizTypeWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public GetLibraryResponse GetLibraryWithOptions(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public async Task<GetLibraryResponse> GetLibraryWithOptionsAsync(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public GetLibraryResponse GetLibrary(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档库配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryResponse
        /// </returns>
        public async Task<GetLibraryResponse> GetLibraryAsync(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public GetLibraryListResponse GetLibraryListWithOptions(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public async Task<GetLibraryListResponse> GetLibraryListWithOptionsAsync(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public GetLibraryListResponse GetLibraryList(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryListWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询文档库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLibraryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLibraryListResponse
        /// </returns>
        public async Task<GetLibraryListResponse> GetLibraryListAsync(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public GetParseResultResponse GetParseResultWithOptions(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public async Task<GetParseResultResponse> GetParseResultWithOptionsAsync(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public GetParseResultResponse GetParseResult(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetParseResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取解析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParseResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParseResultResponse
        /// </returns>
        public async Task<GetParseResultResponse> GetParseResultAsync(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetParseResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public GetSummaryTaskResultResponse GetSummaryTaskResultWithOptions(string workspaceId, GetSummaryTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSummaryTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public async Task<GetSummaryTaskResultResponse> GetSummaryTaskResultWithOptionsAsync(string workspaceId, GetSummaryTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSummaryTaskResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/summary/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSummaryTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public GetSummaryTaskResultResponse GetSummaryTaskResult(string workspaceId, GetSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSummaryTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSummaryTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSummaryTaskResultResponse
        /// </returns>
        public async Task<GetSummaryTaskResultResponse> GetSummaryTaskResultAsync(string workspaceId, GetSummaryTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSummaryTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public GetTaskResultResponse GetTaskResultWithOptions(string workspaceId, GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/result",
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
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<GetTaskResultResponse> GetTaskResultWithOptionsAsync(string workspaceId, GetTaskResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/result",
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
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public GetTaskResultResponse GetTaskResult(string workspaceId, GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskResultWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResultResponse
        /// </returns>
        public async Task<GetTaskResultResponse> GetTaskResultAsync(string workspaceId, GetTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatusWithOptions(string workspaceId, GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTaskStatus",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(string workspaceId, GetTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTaskStatus",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public GetTaskStatusResponse GetTaskStatus(string workspaceId, GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskStatusWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取财报总结任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusResponse
        /// </returns>
        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(string workspaceId, GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskStatusWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public InvokePluginResponse InvokePluginWithOptions(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public async Task<InvokePluginResponse> InvokePluginWithOptionsAsync(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public InvokePluginResponse InvokePlugin(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokePluginWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插件调试接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvokePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokePluginResponse
        /// </returns>
        public async Task<InvokePluginResponse> InvokePluginAsync(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokePluginWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public PreviewDocumentResponse PreviewDocumentWithOptions(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public async Task<PreviewDocumentResponse> PreviewDocumentWithOptionsAsync(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public PreviewDocumentResponse PreviewDocument(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewDocumentResponse
        /// </returns>
        public async Task<PreviewDocumentResponse> PreviewDocumentAsync(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public ReIndexResponse ReIndexWithOptions(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public async Task<ReIndexResponse> ReIndexWithOptionsAsync(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public ReIndexResponse ReIndex(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReIndexWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新索引</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReIndexResponse
        /// </returns>
        public async Task<ReIndexResponse> ReIndexAsync(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReIndexWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public RecallDocumentResponse RecallDocumentWithOptions(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public async Task<RecallDocumentResponse> RecallDocumentWithOptionsAsync(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public RecallDocumentResponse RecallDocument(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecallDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档召回。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecallDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// RecallDocumentResponse
        /// </returns>
        public async Task<RecallDocumentResponse> RecallDocumentAsync(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecallDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public RecognizeIntentionResponse RecognizeIntentionWithOptions(string workspaceId, RecognizeIntentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conversation))
            {
                body["conversation"] = request.Conversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIntentionList))
            {
                body["globalIntentionList"] = request.GlobalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HierarchicalIntentionList))
            {
                body["hierarchicalIntentionList"] = request.HierarchicalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionList))
            {
                body["intentionList"] = request.IntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIntention",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/recog/intent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIntentionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public async Task<RecognizeIntentionResponse> RecognizeIntentionWithOptionsAsync(string workspaceId, RecognizeIntentionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Analysis))
            {
                body["analysis"] = request.Analysis;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conversation))
            {
                body["conversation"] = request.Conversation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIntentionList))
            {
                body["globalIntentionList"] = request.GlobalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HierarchicalIntentionList))
            {
                body["hierarchicalIntentionList"] = request.HierarchicalIntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionList))
            {
                body["intentionList"] = request.IntentionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpType))
            {
                body["opType"] = request.OpType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recommend))
            {
                body["recommend"] = request.Recommend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIntention",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/recog/intent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIntentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public RecognizeIntentionResponse RecognizeIntention(string workspaceId, RecognizeIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecognizeIntentionWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>意图识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecognizeIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecognizeIntentionResponse
        /// </returns>
        public async Task<RecognizeIntentionResponse> RecognizeIntentionAsync(string workspaceId, RecognizeIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecognizeIntentionWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public RunChatResultGenerationResponse RunChatResultGenerationWithOptions(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationWithOptionsAsync(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public RunChatResultGenerationResponse RunChatResultGeneration(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunChatResultGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunChatResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunChatResultGenerationResponse
        /// </returns>
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationAsync(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunChatResultGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public RunLibraryChatGenerationResponse RunLibraryChatGenerationWithOptions(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationWithOptionsAsync(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public RunLibraryChatGenerationResponse RunLibraryChatGeneration(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunLibraryChatGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取生成式对话结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLibraryChatGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLibraryChatGenerationResponse
        /// </returns>
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationAsync(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunLibraryChatGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocumentWithOptions(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentWithOptionsAsync(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocument(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentAsync(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public UpdateLibraryResponse UpdateLibraryWithOptions(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public async Task<UpdateLibraryResponse> UpdateLibraryWithOptionsAsync(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public UpdateLibraryResponse UpdateLibrary(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新文档库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLibraryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLibraryResponse
        /// </returns>
        public async Task<UpdateLibraryResponse> UpdateLibraryAsync(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocumentWithOptions(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentWithOptionsAsync(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocument(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传文档到文档库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentAsync(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public UploadDocumentResponse UploadDocumentAdvance(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "DianJin",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                uploadDocumentReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadDocumentResponse uploadDocumentResp = UploadDocumentWithOptions(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

        public async Task<UploadDocumentResponse> UploadDocumentAdvanceAsync(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "DianJin",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                uploadDocumentReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadDocumentResponse uploadDocumentResp = await UploadDocumentWithOptionsAsync(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

    }
}
