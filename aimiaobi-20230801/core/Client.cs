// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AiMiaoBi20230801.Models;

namespace AlibabaCloud.SDK.AiMiaoBi20230801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aimiaobi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>添加文档到数据集</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDocumentResponse
        /// </returns>
        public AddDatasetDocumentResponse AddDatasetDocumentWithOptions(AddDatasetDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddDatasetDocumentShrinkRequest request = new AddDatasetDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Document))
            {
                request.DocumentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Document, "Document", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentShrink))
            {
                body["Document"] = request.DocumentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatasetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文档到数据集</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDocumentResponse
        /// </returns>
        public async Task<AddDatasetDocumentResponse> AddDatasetDocumentWithOptionsAsync(AddDatasetDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddDatasetDocumentShrinkRequest request = new AddDatasetDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Document))
            {
                request.DocumentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Document, "Document", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentShrink))
            {
                body["Document"] = request.DocumentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatasetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文档到数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDocumentResponse
        /// </returns>
        public AddDatasetDocumentResponse AddDatasetDocument(AddDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDatasetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文档到数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDocumentResponse
        /// </returns>
        public async Task<AddDatasetDocumentResponse> AddDatasetDocumentAsync(AddDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDatasetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public CancelAsyncTaskResponse CancelAsyncTaskWithOptions(CancelAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public async Task<CancelAsyncTaskResponse> CancelAsyncTaskWithOptionsAsync(CancelAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public CancelAsyncTaskResponse CancelAsyncTask(CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAsyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public async Task<CancelAsyncTaskResponse> CancelAsyncTaskAsync(CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAuditTaskResponse
        /// </returns>
        public CancelAuditTaskResponse CancelAuditTaskWithOptions(CancelAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAuditTaskId))
            {
                body["ContentAuditTaskId"] = request.ContentAuditTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAuditTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAuditTaskResponse
        /// </returns>
        public async Task<CancelAuditTaskResponse> CancelAuditTaskWithOptionsAsync(CancelAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAuditTaskId))
            {
                body["ContentAuditTaskId"] = request.ContentAuditTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelAuditTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAuditTaskResponse
        /// </returns>
        public CancelAuditTaskResponse CancelAuditTask(CancelAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAuditTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelAuditTaskResponse
        /// </returns>
        public async Task<CancelAuditTaskResponse> CancelAuditTaskAsync(CancelAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAuditTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearIntervenesResponse
        /// </returns>
        public ClearIntervenesResponse ClearIntervenesWithOptions(ClearIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearIntervenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ClearIntervenesResponse
        /// </returns>
        public async Task<ClearIntervenesResponse> ClearIntervenesWithOptionsAsync(ClearIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearIntervenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearIntervenesResponse
        /// </returns>
        public ClearIntervenesResponse ClearIntervenes(ClearIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearIntervenesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>清除所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ClearIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ClearIntervenesResponse
        /// </returns>
        public async Task<ClearIntervenesResponse> ClearIntervenesAsync(ClearIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearIntervenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDatasetWithOptions(CreateDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDatasetShrinkRequest request = new CreateDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetConfig))
            {
                request.DatasetConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetConfig, "DatasetConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentHandleConfig))
            {
                request.DocumentHandleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentHandleConfig, "DocumentHandleConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetConfigShrink))
            {
                body["DatasetConfig"] = request.DatasetConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetType))
            {
                body["DatasetType"] = request.DatasetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentHandleConfigShrink))
            {
                body["DocumentHandleConfig"] = request.DocumentHandleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(CreateDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDatasetShrinkRequest request = new CreateDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetConfig))
            {
                request.DatasetConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetConfig, "DatasetConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentHandleConfig))
            {
                request.DocumentHandleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentHandleConfig, "DocumentHandleConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetConfigShrink))
            {
                body["DatasetConfig"] = request.DatasetConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetType))
            {
                body["DatasetType"] = request.DatasetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentHandleConfigShrink))
            {
                body["DocumentHandleConfig"] = request.DocumentHandleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeType))
            {
                body["InvokeType"] = request.InvokeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGeneratedContentResponse
        /// </returns>
        public CreateGeneratedContentResponse CreateGeneratedContentWithOptions(CreateGeneratedContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGeneratedContentShrinkRequest request = new CreateGeneratedContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentDomain))
            {
                body["ContentDomain"] = request.ContentDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentText))
            {
                body["ContentText"] = request.ContentText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGeneratedContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-创建</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGeneratedContentResponse
        /// </returns>
        public async Task<CreateGeneratedContentResponse> CreateGeneratedContentWithOptionsAsync(CreateGeneratedContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGeneratedContentShrinkRequest request = new CreateGeneratedContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentDomain))
            {
                body["ContentDomain"] = request.ContentDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentText))
            {
                body["ContentText"] = request.ContentText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGeneratedContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGeneratedContentResponse
        /// </returns>
        public CreateGeneratedContentResponse CreateGeneratedContent(CreateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGeneratedContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGeneratedContentResponse
        /// </returns>
        public async Task<CreateGeneratedContentResponse> CreateGeneratedContentAsync(CreateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGeneratedContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenResponse
        /// </returns>
        public CreateTokenResponse CreateTokenWithOptions(CreateTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateToken",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenResponse
        /// </returns>
        public async Task<CreateTokenResponse> CreateTokenWithOptionsAsync(CreateTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateToken",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenResponse
        /// </returns>
        public CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTokenResponse
        /// </returns>
        public async Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTextResponse
        /// </returns>
        public DeleteCustomTextResponse DeleteCustomTextWithOptions(DeleteCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTextResponse
        /// </returns>
        public async Task<DeleteCustomTextResponse> DeleteCustomTextWithOptionsAsync(DeleteCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTextResponse
        /// </returns>
        public DeleteCustomTextResponse DeleteCustomText(DeleteCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTextResponse
        /// </returns>
        public async Task<DeleteCustomTextResponse> DeleteCustomTextAsync(DeleteCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据主题删除自定义主题事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicByTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicByTopicResponse
        /// </returns>
        public DeleteCustomTopicByTopicResponse DeleteCustomTopicByTopicWithOptions(DeleteCustomTopicByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTopicByTopic",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTopicByTopicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据主题删除自定义主题事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicByTopicRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicByTopicResponse
        /// </returns>
        public async Task<DeleteCustomTopicByTopicResponse> DeleteCustomTopicByTopicWithOptionsAsync(DeleteCustomTopicByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTopicByTopic",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTopicByTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据主题删除自定义主题事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicByTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicByTopicResponse
        /// </returns>
        public DeleteCustomTopicByTopicResponse DeleteCustomTopicByTopic(DeleteCustomTopicByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTopicByTopicWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据主题删除自定义主题事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicByTopicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicByTopicResponse
        /// </returns>
        public async Task<DeleteCustomTopicByTopicResponse> DeleteCustomTopicByTopicAsync(DeleteCustomTopicByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTopicByTopicWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据自定义观点ID删除自定义观点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicViewPointByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicViewPointByIdResponse
        /// </returns>
        public DeleteCustomTopicViewPointByIdResponse DeleteCustomTopicViewPointByIdWithOptions(DeleteCustomTopicViewPointByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTopicViewPointById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTopicViewPointByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据自定义观点ID删除自定义观点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicViewPointByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicViewPointByIdResponse
        /// </returns>
        public async Task<DeleteCustomTopicViewPointByIdResponse> DeleteCustomTopicViewPointByIdWithOptionsAsync(DeleteCustomTopicViewPointByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTopicViewPointById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTopicViewPointByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据自定义观点ID删除自定义观点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicViewPointByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicViewPointByIdResponse
        /// </returns>
        public DeleteCustomTopicViewPointByIdResponse DeleteCustomTopicViewPointById(DeleteCustomTopicViewPointByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTopicViewPointByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据自定义观点ID删除自定义观点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomTopicViewPointByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomTopicViewPointByIdResponse
        /// </returns>
        public async Task<DeleteCustomTopicViewPointByIdResponse> DeleteCustomTopicViewPointByIdAsync(DeleteCustomTopicViewPointByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTopicViewPointByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDatasetWithOptions(DeleteDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(DeleteDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetDocumentResponse
        /// </returns>
        public DeleteDatasetDocumentResponse DeleteDatasetDocumentWithOptions(DeleteDatasetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUuid))
            {
                body["DocUuid"] = request.DocUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetDocumentResponse
        /// </returns>
        public async Task<DeleteDatasetDocumentResponse> DeleteDatasetDocumentWithOptionsAsync(DeleteDatasetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUuid))
            {
                body["DocUuid"] = request.DocUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetDocumentResponse
        /// </returns>
        public DeleteDatasetDocumentResponse DeleteDatasetDocument(DeleteDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatasetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetDocumentResponse
        /// </returns>
        public async Task<DeleteDatasetDocumentResponse> DeleteDatasetDocumentAsync(DeleteDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatasetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读删除多个文档</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDocsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocsResponse
        /// </returns>
        public DeleteDocsResponse DeleteDocsWithOptions(DeleteDocsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDocsShrinkRequest request = new DeleteDocsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读删除多个文档</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDocsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocsResponse
        /// </returns>
        public async Task<DeleteDocsResponse> DeleteDocsWithOptionsAsync(DeleteDocsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDocsShrinkRequest request = new DeleteDocsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读删除多个文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocsResponse
        /// </returns>
        public DeleteDocsResponse DeleteDocs(DeleteDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDocsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读删除多个文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocsResponse
        /// </returns>
        public async Task<DeleteDocsResponse> DeleteDocsAsync(DeleteDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDocsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGeneratedContentResponse
        /// </returns>
        public DeleteGeneratedContentResponse DeleteGeneratedContentWithOptions(DeleteGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGeneratedContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGeneratedContentResponse
        /// </returns>
        public async Task<DeleteGeneratedContentResponse> DeleteGeneratedContentWithOptionsAsync(DeleteGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGeneratedContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGeneratedContentResponse
        /// </returns>
        public DeleteGeneratedContentResponse DeleteGeneratedContent(DeleteGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGeneratedContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-删除。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGeneratedContentResponse
        /// </returns>
        public async Task<DeleteGeneratedContentResponse> DeleteGeneratedContentAsync(DeleteGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGeneratedContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInterveneRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInterveneRuleResponse
        /// </returns>
        public DeleteInterveneRuleResponse DeleteInterveneRuleWithOptions(DeleteInterveneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInterveneRule",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInterveneRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInterveneRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInterveneRuleResponse
        /// </returns>
        public async Task<DeleteInterveneRuleResponse> DeleteInterveneRuleWithOptionsAsync(DeleteInterveneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInterveneRule",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInterveneRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInterveneRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInterveneRuleResponse
        /// </returns>
        public DeleteInterveneRuleResponse DeleteInterveneRule(DeleteInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInterveneRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInterveneRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInterveneRuleResponse
        /// </returns>
        public async Task<DeleteInterveneRuleResponse> DeleteInterveneRuleAsync(DeleteInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInterveneRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID删除素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMaterialByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMaterialByIdResponse
        /// </returns>
        public DeleteMaterialByIdResponse DeleteMaterialByIdWithOptions(DeleteMaterialByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMaterialById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMaterialByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID删除素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMaterialByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMaterialByIdResponse
        /// </returns>
        public async Task<DeleteMaterialByIdResponse> DeleteMaterialByIdWithOptionsAsync(DeleteMaterialByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMaterialById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMaterialByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID删除素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMaterialByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMaterialByIdResponse
        /// </returns>
        public DeleteMaterialByIdResponse DeleteMaterialById(DeleteMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMaterialByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID删除素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMaterialByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMaterialByIdResponse
        /// </returns>
        public async Task<DeleteMaterialByIdResponse> DeleteMaterialByIdAsync(DeleteMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMaterialByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStyleLearningResultResponse
        /// </returns>
        public DeleteStyleLearningResultResponse DeleteStyleLearningResultWithOptions(DeleteStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStyleLearningResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStyleLearningResultResponse
        /// </returns>
        public async Task<DeleteStyleLearningResultResponse> DeleteStyleLearningResultWithOptionsAsync(DeleteStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStyleLearningResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStyleLearningResultResponse
        /// </returns>
        public DeleteStyleLearningResultResponse DeleteStyleLearningResult(DeleteStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStyleLearningResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStyleLearningResultResponse
        /// </returns>
        public async Task<DeleteStyleLearningResultResponse> DeleteStyleLearningResultAsync(DeleteStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStyleLearningResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从链接中提取文档内容</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DocumentExtractionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentExtractionResponse
        /// </returns>
        public DocumentExtractionResponse DocumentExtractionWithOptions(DocumentExtractionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DocumentExtractionShrinkRequest request = new DocumentExtractionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Urls))
            {
                request.UrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Urls, "Urls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlsShrink))
            {
                body["Urls"] = request.UrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentExtraction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentExtractionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从链接中提取文档内容</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DocumentExtractionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentExtractionResponse
        /// </returns>
        public async Task<DocumentExtractionResponse> DocumentExtractionWithOptionsAsync(DocumentExtractionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DocumentExtractionShrinkRequest request = new DocumentExtractionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Urls))
            {
                request.UrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Urls, "Urls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlsShrink))
            {
                body["Urls"] = request.UrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentExtraction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentExtractionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从链接中提取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentExtractionRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentExtractionResponse
        /// </returns>
        public DocumentExtractionResponse DocumentExtraction(DocumentExtractionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocumentExtractionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从链接中提取文档内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DocumentExtractionRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentExtractionResponse
        /// </returns>
        public async Task<DocumentExtractionResponse> DocumentExtractionAsync(DocumentExtractionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocumentExtractionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ExportAnalysisTagDetailByTaskIdResponse ExportAnalysisTagDetailByTaskIdWithOptions(ExportAnalysisTagDetailByTaskIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportAnalysisTagDetailByTaskIdShrinkRequest request = new ExportAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnalysisTagDetailByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnalysisTagDetailByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ExportAnalysisTagDetailByTaskIdResponse> ExportAnalysisTagDetailByTaskIdWithOptionsAsync(ExportAnalysisTagDetailByTaskIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportAnalysisTagDetailByTaskIdShrinkRequest request = new ExportAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnalysisTagDetailByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnalysisTagDetailByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ExportAnalysisTagDetailByTaskIdResponse ExportAnalysisTagDetailByTaskId(ExportAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportAnalysisTagDetailByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ExportAnalysisTagDetailByTaskIdResponse> ExportAnalysisTagDetailByTaskIdAsync(ExportAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportAnalysisTagDetailByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-导出。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportGeneratedContentResponse
        /// </returns>
        public ExportGeneratedContentResponse ExportGeneratedContentWithOptions(ExportGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportGeneratedContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-导出。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportGeneratedContentResponse
        /// </returns>
        public async Task<ExportGeneratedContentResponse> ExportGeneratedContentWithOptionsAsync(ExportGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportGeneratedContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-导出。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportGeneratedContentResponse
        /// </returns>
        public ExportGeneratedContentResponse ExportGeneratedContent(ExportGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportGeneratedContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-导出。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportGeneratedContentResponse
        /// </returns>
        public async Task<ExportGeneratedContentResponse> ExportGeneratedContentAsync(ExportGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportGeneratedContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出选题策划文档，响应为一个可公开访问的URL。一小时后失效</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportHotTopicPlanningProposalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportHotTopicPlanningProposalsResponse
        /// </returns>
        public ExportHotTopicPlanningProposalsResponse ExportHotTopicPlanningProposalsWithOptions(ExportHotTopicPlanningProposalsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportHotTopicPlanningProposalsShrinkRequest request = new ExportHotTopicPlanningProposalsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Titles))
            {
                request.TitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Titles, "Titles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                body["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitlesShrink))
            {
                body["Titles"] = request.TitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewPointType))
            {
                body["ViewPointType"] = request.ViewPointType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportHotTopicPlanningProposals",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportHotTopicPlanningProposalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出选题策划文档，响应为一个可公开访问的URL。一小时后失效</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportHotTopicPlanningProposalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportHotTopicPlanningProposalsResponse
        /// </returns>
        public async Task<ExportHotTopicPlanningProposalsResponse> ExportHotTopicPlanningProposalsWithOptionsAsync(ExportHotTopicPlanningProposalsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportHotTopicPlanningProposalsShrinkRequest request = new ExportHotTopicPlanningProposalsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Titles))
            {
                request.TitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Titles, "Titles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportType))
            {
                body["ExportType"] = request.ExportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitlesShrink))
            {
                body["Titles"] = request.TitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewPointType))
            {
                body["ViewPointType"] = request.ViewPointType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportHotTopicPlanningProposals",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportHotTopicPlanningProposalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出选题策划文档，响应为一个可公开访问的URL。一小时后失效</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportHotTopicPlanningProposalsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportHotTopicPlanningProposalsResponse
        /// </returns>
        public ExportHotTopicPlanningProposalsResponse ExportHotTopicPlanningProposals(ExportHotTopicPlanningProposalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportHotTopicPlanningProposalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出选题策划文档，响应为一个可公开访问的URL。一小时后失效</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportHotTopicPlanningProposalsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportHotTopicPlanningProposalsResponse
        /// </returns>
        public async Task<ExportHotTopicPlanningProposalsResponse> ExportHotTopicPlanningProposalsAsync(ExportHotTopicPlanningProposalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportHotTopicPlanningProposalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportIntervenesResponse
        /// </returns>
        public ExportIntervenesResponse ExportIntervenesWithOptions(ExportIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportIntervenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportIntervenesResponse
        /// </returns>
        public async Task<ExportIntervenesResponse> ExportIntervenesWithOptionsAsync(ExportIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportIntervenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportIntervenesResponse
        /// </returns>
        public ExportIntervenesResponse ExportIntervenes(ExportIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportIntervenesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出所有干预内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportIntervenesResponse
        /// </returns>
        public async Task<ExportIntervenesResponse> ExportIntervenesAsync(ExportIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportIntervenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反馈某次生成的结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FeedbackDialogueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FeedbackDialogueResponse
        /// </returns>
        public FeedbackDialogueResponse FeedbackDialogueWithOptions(FeedbackDialogueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FeedbackDialogueShrinkRequest request = new FeedbackDialogueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RatingTags))
            {
                request.RatingTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RatingTags, "RatingTags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerResponse))
            {
                body["CustomerResponse"] = request.CustomerResponse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodText))
            {
                body["GoodText"] = request.GoodText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedResponse))
            {
                body["ModifiedResponse"] = request.ModifiedResponse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                body["Rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatingTagsShrink))
            {
                body["RatingTags"] = request.RatingTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FeedbackDialogue",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FeedbackDialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反馈某次生成的结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FeedbackDialogueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FeedbackDialogueResponse
        /// </returns>
        public async Task<FeedbackDialogueResponse> FeedbackDialogueWithOptionsAsync(FeedbackDialogueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FeedbackDialogueShrinkRequest request = new FeedbackDialogueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RatingTags))
            {
                request.RatingTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RatingTags, "RatingTags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerResponse))
            {
                body["CustomerResponse"] = request.CustomerResponse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodText))
            {
                body["GoodText"] = request.GoodText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifiedResponse))
            {
                body["ModifiedResponse"] = request.ModifiedResponse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                body["Rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatingTagsShrink))
            {
                body["RatingTags"] = request.RatingTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FeedbackDialogue",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FeedbackDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反馈某次生成的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// FeedbackDialogueResponse
        /// </returns>
        public FeedbackDialogueResponse FeedbackDialogue(FeedbackDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FeedbackDialogueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反馈某次生成的结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FeedbackDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// FeedbackDialogueResponse
        /// </returns>
        public async Task<FeedbackDialogueResponse> FeedbackDialogueAsync(FeedbackDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FeedbackDialogueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片任务执行结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FetchImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchImageTaskResponse
        /// </returns>
        public FetchImageTaskResponse FetchImageTaskWithOptions(FetchImageTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FetchImageTaskShrinkRequest request = new FetchImageTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "TaskIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleTaskId))
            {
                body["ArticleTaskId"] = request.ArticleTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                body["TaskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchImageTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchImageTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片任务执行结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FetchImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FetchImageTaskResponse
        /// </returns>
        public async Task<FetchImageTaskResponse> FetchImageTaskWithOptionsAsync(FetchImageTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FetchImageTaskShrinkRequest request = new FetchImageTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "TaskIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleTaskId))
            {
                body["ArticleTaskId"] = request.ArticleTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                body["TaskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchImageTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchImageTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片任务执行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchImageTaskResponse
        /// </returns>
        public FetchImageTaskResponse FetchImageTask(FetchImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchImageTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片任务执行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FetchImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// FetchImageTaskResponse
        /// </returns>
        public async Task<FetchImageTaskResponse> FetchImageTaskAsync(FetchImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchImageTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成临时可访问的公开url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFileUrlByKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateFileUrlByKeyResponse
        /// </returns>
        public GenerateFileUrlByKeyResponse GenerateFileUrlByKeyWithOptions(GenerateFileUrlByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateFileUrlByKey",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateFileUrlByKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成临时可访问的公开url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFileUrlByKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateFileUrlByKeyResponse
        /// </returns>
        public async Task<GenerateFileUrlByKeyResponse> GenerateFileUrlByKeyWithOptionsAsync(GenerateFileUrlByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateFileUrlByKey",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateFileUrlByKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成临时可访问的公开url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFileUrlByKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateFileUrlByKeyResponse
        /// </returns>
        public GenerateFileUrlByKeyResponse GenerateFileUrlByKey(GenerateFileUrlByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateFileUrlByKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成临时可访问的公开url</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateFileUrlByKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateFileUrlByKeyResponse
        /// </returns>
        public async Task<GenerateFileUrlByKeyResponse> GenerateFileUrlByKeyAsync(GenerateFileUrlByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateFileUrlByKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能配图，图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageTaskResponse
        /// </returns>
        public GenerateImageTaskResponse GenerateImageTaskWithOptions(GenerateImageTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateImageTaskShrinkRequest request = new GenerateImageTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParagraphList))
            {
                request.ParagraphListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParagraphList, "ParagraphList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleTaskId))
            {
                body["ArticleTaskId"] = request.ArticleTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParagraphListShrink))
            {
                body["ParagraphList"] = request.ParagraphListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["Style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能配图，图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateImageTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageTaskResponse
        /// </returns>
        public async Task<GenerateImageTaskResponse> GenerateImageTaskWithOptionsAsync(GenerateImageTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateImageTaskShrinkRequest request = new GenerateImageTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParagraphList))
            {
                request.ParagraphListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParagraphList, "ParagraphList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleTaskId))
            {
                body["ArticleTaskId"] = request.ArticleTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParagraphListShrink))
            {
                body["ParagraphList"] = request.ParagraphListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["Style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateImageTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateImageTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能配图，图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageTaskResponse
        /// </returns>
        public GenerateImageTaskResponse GenerateImageTask(GenerateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateImageTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能配图，图片生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateImageTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateImageTaskResponse
        /// </returns>
        public async Task<GenerateImageTaskResponse> GenerateImageTaskAsync(GenerateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateImageTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成上传配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadConfigResponse
        /// </returns>
        public GenerateUploadConfigResponse GenerateUploadConfigWithOptions(GenerateUploadConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDir))
            {
                body["ParentDir"] = request.ParentDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成上传配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadConfigResponse
        /// </returns>
        public async Task<GenerateUploadConfigResponse> GenerateUploadConfigWithOptionsAsync(GenerateUploadConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDir))
            {
                body["ParentDir"] = request.ParentDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成上传配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadConfigResponse
        /// </returns>
        public GenerateUploadConfigResponse GenerateUploadConfig(GenerateUploadConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成上传配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadConfigResponse
        /// </returns>
        public async Task<GenerateUploadConfigResponse> GenerateUploadConfigAsync(GenerateUploadConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视角生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateViewPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateViewPointResponse
        /// </returns>
        public GenerateViewPointResponse GenerateViewPointWithOptions(GenerateViewPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateViewPointShrinkRequest request = new GenerateViewPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateViewPoint",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateViewPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视角生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateViewPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateViewPointResponse
        /// </returns>
        public async Task<GenerateViewPointResponse> GenerateViewPointWithOptionsAsync(GenerateViewPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateViewPointShrinkRequest request = new GenerateViewPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateViewPoint",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateViewPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视角生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateViewPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateViewPointResponse
        /// </returns>
        public GenerateViewPointResponse GenerateViewPoint(GenerateViewPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateViewPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视角生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateViewPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateViewPointResponse
        /// </returns>
        public async Task<GenerateViewPointResponse> GenerateViewPointAsync(GenerateViewPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateViewPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某次标签挖掘结果分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoriesByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCategoriesByTaskIdResponse
        /// </returns>
        public GetCategoriesByTaskIdResponse GetCategoriesByTaskIdWithOptions(GetCategoriesByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoriesByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoriesByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某次标签挖掘结果分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoriesByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCategoriesByTaskIdResponse
        /// </returns>
        public async Task<GetCategoriesByTaskIdResponse> GetCategoriesByTaskIdWithOptionsAsync(GetCategoriesByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCategoriesByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoriesByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某次标签挖掘结果分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoriesByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCategoriesByTaskIdResponse
        /// </returns>
        public GetCategoriesByTaskIdResponse GetCategoriesByTaskId(GetCategoriesByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCategoriesByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某次标签挖掘结果分类</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoriesByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCategoriesByTaskIdResponse
        /// </returns>
        public async Task<GetCategoriesByTaskIdResponse> GetCategoriesByTaskIdAsync(GetCategoriesByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCategoriesByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义播报单任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomHotTopicBroadcastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomHotTopicBroadcastJobResponse
        /// </returns>
        public GetCustomHotTopicBroadcastJobResponse GetCustomHotTopicBroadcastJobWithOptions(GetCustomHotTopicBroadcastJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomHotTopicBroadcastJob",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomHotTopicBroadcastJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义播报单任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomHotTopicBroadcastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomHotTopicBroadcastJobResponse
        /// </returns>
        public async Task<GetCustomHotTopicBroadcastJobResponse> GetCustomHotTopicBroadcastJobWithOptionsAsync(GetCustomHotTopicBroadcastJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomHotTopicBroadcastJob",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomHotTopicBroadcastJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义播报单任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomHotTopicBroadcastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomHotTopicBroadcastJobResponse
        /// </returns>
        public GetCustomHotTopicBroadcastJobResponse GetCustomHotTopicBroadcastJob(GetCustomHotTopicBroadcastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomHotTopicBroadcastJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义播报单任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomHotTopicBroadcastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomHotTopicBroadcastJobResponse
        /// </returns>
        public async Task<GetCustomHotTopicBroadcastJobResponse> GetCustomHotTopicBroadcastJobAsync(GetCustomHotTopicBroadcastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomHotTopicBroadcastJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTextResponse
        /// </returns>
        public GetCustomTextResponse GetCustomTextWithOptions(GetCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTextResponse
        /// </returns>
        public async Task<GetCustomTextResponse> GetCustomTextWithOptionsAsync(GetCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTextResponse
        /// </returns>
        public GetCustomTextResponse GetCustomText(GetCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTextResponse
        /// </returns>
        public async Task<GetCustomTextResponse> GetCustomTextAsync(GetCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponse GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTopicSelectionPerspectiveAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<GetCustomTopicSelectionPerspectiveAnalysisTaskResponse> GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTopicSelectionPerspectiveAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponse GetCustomTopicSelectionPerspectiveAnalysisTask(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取自定义选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<GetCustomTopicSelectionPerspectiveAnalysisTaskResponse> GetCustomTopicSelectionPerspectiveAnalysisTaskAsync(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统数据源配置和个人配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataSourceOrderConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceOrderConfigResponse
        /// </returns>
        public GetDataSourceOrderConfigResponse GetDataSourceOrderConfigWithOptions(GetDataSourceOrderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateTechnology))
            {
                body["GenerateTechnology"] = request.GenerateTechnology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSourceOrderConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceOrderConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统数据源配置和个人配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataSourceOrderConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceOrderConfigResponse
        /// </returns>
        public async Task<GetDataSourceOrderConfigResponse> GetDataSourceOrderConfigWithOptionsAsync(GetDataSourceOrderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateTechnology))
            {
                body["GenerateTechnology"] = request.GenerateTechnology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSourceOrderConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceOrderConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统数据源配置和个人配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataSourceOrderConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceOrderConfigResponse
        /// </returns>
        public GetDataSourceOrderConfigResponse GetDataSourceOrderConfig(GetDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataSourceOrderConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统数据源配置和个人配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataSourceOrderConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceOrderConfigResponse
        /// </returns>
        public async Task<GetDataSourceOrderConfigResponse> GetDataSourceOrderConfigAsync(GetDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataSourceOrderConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDatasetWithOptions(GetDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(GetDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDataset(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetDocumentResponse
        /// </returns>
        public GetDatasetDocumentResponse GetDatasetDocumentWithOptions(GetDatasetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUuid))
            {
                body["DocUuid"] = request.DocUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetDocumentResponse
        /// </returns>
        public async Task<GetDatasetDocumentResponse> GetDatasetDocumentWithOptionsAsync(GetDatasetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUuid))
            {
                body["DocUuid"] = request.DocUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetDocumentResponse
        /// </returns>
        public GetDatasetDocumentResponse GetDatasetDocument(GetDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatasetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetDocumentResponse
        /// </returns>
        public async Task<GetDatasetDocumentResponse> GetDatasetDocumentAsync(GetDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatasetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档聚合任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocClusterTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocClusterTaskResponse
        /// </returns>
        public GetDocClusterTaskResponse GetDocClusterTaskWithOptions(GetDocClusterTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocClusterTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocClusterTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档聚合任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocClusterTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocClusterTaskResponse
        /// </returns>
        public async Task<GetDocClusterTaskResponse> GetDocClusterTaskWithOptionsAsync(GetDocClusterTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocClusterTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocClusterTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档聚合任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocClusterTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocClusterTaskResponse
        /// </returns>
        public GetDocClusterTaskResponse GetDocClusterTask(GetDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocClusterTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档聚合任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocClusterTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocClusterTaskResponse
        /// </returns>
        public async Task<GetDocClusterTaskResponse> GetDocClusterTaskAsync(GetDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocClusterTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocInfoResponse
        /// </returns>
        public GetDocInfoResponse GetDocInfoWithOptions(GetDocInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocInfo",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocInfoResponse
        /// </returns>
        public async Task<GetDocInfoResponse> GetDocInfoWithOptionsAsync(GetDocInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocInfo",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocInfoResponse
        /// </returns>
        public GetDocInfoResponse GetDocInfo(GetDocInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocInfoResponse
        /// </returns>
        public async Task<GetDocInfoResponse> GetDocInfoAsync(GetDocInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业VOC分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public GetEnterpriseVocAnalysisTaskResponse GetEnterpriseVocAnalysisTaskWithOptions(GetEnterpriseVocAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseVocAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseVocAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业VOC分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<GetEnterpriseVocAnalysisTaskResponse> GetEnterpriseVocAnalysisTaskWithOptionsAsync(GetEnterpriseVocAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseVocAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseVocAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业VOC分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public GetEnterpriseVocAnalysisTaskResponse GetEnterpriseVocAnalysisTask(GetEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEnterpriseVocAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业VOC分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<GetEnterpriseVocAnalysisTaskResponse> GetEnterpriseVocAnalysisTaskAsync(GetEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEnterpriseVocAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获得文档字数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileContentLengthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileContentLengthResponse
        /// </returns>
        public GetFileContentLengthResponse GetFileContentLengthWithOptions(GetFileContentLengthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileContentLength",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileContentLengthResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获得文档字数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileContentLengthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileContentLengthResponse
        /// </returns>
        public async Task<GetFileContentLengthResponse> GetFileContentLengthWithOptionsAsync(GetFileContentLengthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileContentLength",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileContentLengthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获得文档字数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileContentLengthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileContentLengthResponse
        /// </returns>
        public GetFileContentLengthResponse GetFileContentLength(GetFileContentLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileContentLengthWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获得文档字数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileContentLengthRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileContentLengthResponse
        /// </returns>
        public async Task<GetFileContentLengthResponse> GetFileContentLengthAsync(GetFileContentLengthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileContentLengthWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-查询详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneratedContentResponse
        /// </returns>
        public GetGeneratedContentResponse GetGeneratedContentWithOptions(GetGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneratedContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-查询详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGeneratedContentResponse
        /// </returns>
        public async Task<GetGeneratedContentResponse> GetGeneratedContentWithOptionsAsync(GetGeneratedContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGeneratedContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-查询详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGeneratedContentResponse
        /// </returns>
        public GetGeneratedContentResponse GetGeneratedContent(GetGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGeneratedContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-查询详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGeneratedContentResponse
        /// </returns>
        public async Task<GetGeneratedContentResponse> GetGeneratedContentAsync(GetGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGeneratedContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询新闻播报单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotTopicBroadcastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotTopicBroadcastResponse
        /// </returns>
        public GetHotTopicBroadcastResponse GetHotTopicBroadcastWithOptions(GetHotTopicBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotTopicBroadcastShrinkRequest request = new GetHotTopicBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Locations))
            {
                request.LocationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Locations, "Locations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForCustomSummaryStyleConfig))
            {
                request.StepForCustomSummaryStyleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForCustomSummaryStyleConfig, "StepForCustomSummaryStyleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForNewsBroadcastContentConfig))
            {
                request.StepForNewsBroadcastContentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForNewsBroadcastContentConfig, "StepForNewsBroadcastContentConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalcTotalToken))
            {
                body["CalcTotalToken"] = request.CalcTotalToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["HotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationQuery))
            {
                body["LocationQuery"] = request.LocationQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationsShrink))
            {
                body["Locations"] = request.LocationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForCustomSummaryStyleConfigShrink))
            {
                body["StepForCustomSummaryStyleConfig"] = request.StepForCustomSummaryStyleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForNewsBroadcastContentConfigShrink))
            {
                body["StepForNewsBroadcastContentConfig"] = request.StepForNewsBroadcastContentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotTopicBroadcast",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotTopicBroadcastResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询新闻播报单</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetHotTopicBroadcastRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotTopicBroadcastResponse
        /// </returns>
        public async Task<GetHotTopicBroadcastResponse> GetHotTopicBroadcastWithOptionsAsync(GetHotTopicBroadcastRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetHotTopicBroadcastShrinkRequest request = new GetHotTopicBroadcastShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Locations))
            {
                request.LocationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Locations, "Locations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForCustomSummaryStyleConfig))
            {
                request.StepForCustomSummaryStyleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForCustomSummaryStyleConfig, "StepForCustomSummaryStyleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForNewsBroadcastContentConfig))
            {
                request.StepForNewsBroadcastContentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForNewsBroadcastContentConfig, "StepForNewsBroadcastContentConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalcTotalToken))
            {
                body["CalcTotalToken"] = request.CalcTotalToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["HotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationQuery))
            {
                body["LocationQuery"] = request.LocationQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationsShrink))
            {
                body["Locations"] = request.LocationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForCustomSummaryStyleConfigShrink))
            {
                body["StepForCustomSummaryStyleConfig"] = request.StepForCustomSummaryStyleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForNewsBroadcastContentConfigShrink))
            {
                body["StepForNewsBroadcastContentConfig"] = request.StepForNewsBroadcastContentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotTopicBroadcast",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotTopicBroadcastResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询新闻播报单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotTopicBroadcastRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotTopicBroadcastResponse
        /// </returns>
        public GetHotTopicBroadcastResponse GetHotTopicBroadcast(GetHotTopicBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotTopicBroadcastWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询新闻播报单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHotTopicBroadcastRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotTopicBroadcastResponse
        /// </returns>
        public async Task<GetHotTopicBroadcastResponse> GetHotTopicBroadcastAsync(GetHotTopicBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotTopicBroadcastWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneGlobalReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneGlobalReplyResponse
        /// </returns>
        public GetInterveneGlobalReplyResponse GetInterveneGlobalReplyWithOptions(GetInterveneGlobalReplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneGlobalReply",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneGlobalReplyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneGlobalReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneGlobalReplyResponse
        /// </returns>
        public async Task<GetInterveneGlobalReplyResponse> GetInterveneGlobalReplyWithOptionsAsync(GetInterveneGlobalReplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneGlobalReply",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneGlobalReplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneGlobalReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneGlobalReplyResponse
        /// </returns>
        public GetInterveneGlobalReplyResponse GetInterveneGlobalReply(GetInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneGlobalReplyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneGlobalReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneGlobalReplyResponse
        /// </returns>
        public async Task<GetInterveneGlobalReplyResponse> GetInterveneGlobalReplyAsync(GetInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneGlobalReplyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneImportTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneImportTaskInfoResponse
        /// </returns>
        public GetInterveneImportTaskInfoResponse GetInterveneImportTaskInfoWithOptions(GetInterveneImportTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneImportTaskInfo",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneImportTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneImportTaskInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneImportTaskInfoResponse
        /// </returns>
        public async Task<GetInterveneImportTaskInfoResponse> GetInterveneImportTaskInfoWithOptionsAsync(GetInterveneImportTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneImportTaskInfo",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneImportTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneImportTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneImportTaskInfoResponse
        /// </returns>
        public GetInterveneImportTaskInfoResponse GetInterveneImportTaskInfo(GetInterveneImportTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneImportTaskInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneImportTaskInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneImportTaskInfoResponse
        /// </returns>
        public async Task<GetInterveneImportTaskInfoResponse> GetInterveneImportTaskInfoAsync(GetInterveneImportTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneImportTaskInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneRuleDetailResponse
        /// </returns>
        public GetInterveneRuleDetailResponse GetInterveneRuleDetailWithOptions(GetInterveneRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneRuleDetail",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneRuleDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneRuleDetailResponse
        /// </returns>
        public async Task<GetInterveneRuleDetailResponse> GetInterveneRuleDetailWithOptionsAsync(GetInterveneRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneRuleDetail",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneRuleDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneRuleDetailResponse
        /// </returns>
        public GetInterveneRuleDetailResponse GetInterveneRuleDetail(GetInterveneRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneRuleDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项规则详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneRuleDetailResponse
        /// </returns>
        public async Task<GetInterveneRuleDetailResponse> GetInterveneRuleDetailAsync(GetInterveneRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneRuleDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预导入模版文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneTemplateFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneTemplateFileUrlResponse
        /// </returns>
        public GetInterveneTemplateFileUrlResponse GetInterveneTemplateFileUrlWithOptions(GetInterveneTemplateFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneTemplateFileUrl",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneTemplateFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预导入模版文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneTemplateFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneTemplateFileUrlResponse
        /// </returns>
        public async Task<GetInterveneTemplateFileUrlResponse> GetInterveneTemplateFileUrlWithOptionsAsync(GetInterveneTemplateFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInterveneTemplateFileUrl",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterveneTemplateFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预导入模版文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneTemplateFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneTemplateFileUrlResponse
        /// </returns>
        public GetInterveneTemplateFileUrlResponse GetInterveneTemplateFileUrl(GetInterveneTemplateFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneTemplateFileUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预导入模版文件下载地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterveneTemplateFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterveneTemplateFileUrlResponse
        /// </returns>
        public async Task<GetInterveneTemplateFileUrlResponse> GetInterveneTemplateFileUrlAsync(GetInterveneTemplateFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneTemplateFileUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取素材内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaterialByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaterialByIdResponse
        /// </returns>
        public GetMaterialByIdResponse GetMaterialByIdWithOptions(GetMaterialByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMaterialById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaterialByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取素材内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaterialByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMaterialByIdResponse
        /// </returns>
        public async Task<GetMaterialByIdResponse> GetMaterialByIdWithOptionsAsync(GetMaterialByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMaterialById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMaterialByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取素材内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaterialByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaterialByIdResponse
        /// </returns>
        public GetMaterialByIdResponse GetMaterialById(GetMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMaterialByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取素材内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMaterialByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMaterialByIdResponse
        /// </returns>
        public async Task<GetMaterialByIdResponse> GetMaterialByIdAsync(GetMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMaterialByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPropertiesResponse
        /// </returns>
        public GetPropertiesResponse GetPropertiesWithOptions(GetPropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProperties",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPropertiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPropertiesResponse
        /// </returns>
        public async Task<GetPropertiesResponse> GetPropertiesWithOptionsAsync(GetPropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProperties",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPropertiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPropertiesResponse
        /// </returns>
        public GetPropertiesResponse GetProperties(GetPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPropertiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前用户的配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPropertiesResponse
        /// </returns>
        public async Task<GetPropertiesResponse> GetPropertiesAsync(GetPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPropertiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmartClipTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmartClipTaskResponse
        /// </returns>
        public GetSmartClipTaskResponse GetSmartClipTaskWithOptions(GetSmartClipTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmartClipTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartClipTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmartClipTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSmartClipTaskResponse
        /// </returns>
        public async Task<GetSmartClipTaskResponse> GetSmartClipTaskWithOptionsAsync(GetSmartClipTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmartClipTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartClipTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmartClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmartClipTaskResponse
        /// </returns>
        public GetSmartClipTaskResponse GetSmartClipTask(GetSmartClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartClipTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSmartClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSmartClipTaskResponse
        /// </returns>
        public async Task<GetSmartClipTaskResponse> GetSmartClipTaskAsync(GetSmartClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartClipTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStyleLearningResultResponse
        /// </returns>
        public GetStyleLearningResultResponse GetStyleLearningResultWithOptions(GetStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStyleLearningResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStyleLearningResultResponse
        /// </returns>
        public async Task<GetStyleLearningResultResponse> GetStyleLearningResultWithOptionsAsync(GetStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStyleLearningResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStyleLearningResultResponse
        /// </returns>
        public GetStyleLearningResultResponse GetStyleLearningResult(GetStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStyleLearningResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStyleLearningResultResponse
        /// </returns>
        public async Task<GetStyleLearningResultResponse> GetStyleLearningResultAsync(GetStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStyleLearningResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取热点事件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicByIdResponse
        /// </returns>
        public GetTopicByIdResponse GetTopicByIdWithOptions(GetTopicByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取热点事件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicByIdResponse
        /// </returns>
        public async Task<GetTopicByIdResponse> GetTopicByIdWithOptionsAsync(GetTopicByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicById",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取热点事件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicByIdResponse
        /// </returns>
        public GetTopicByIdResponse GetTopicById(GetTopicByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取热点事件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicByIdResponse
        /// </returns>
        public async Task<GetTopicByIdResponse> GetTopicByIdAsync(GetTopicByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public GetTopicSelectionPerspectiveAnalysisTaskResponse GetTopicSelectionPerspectiveAnalysisTaskWithOptions(GetTopicSelectionPerspectiveAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSelectionPerspectiveAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<GetTopicSelectionPerspectiveAnalysisTaskResponse> GetTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(GetTopicSelectionPerspectiveAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSelectionPerspectiveAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public GetTopicSelectionPerspectiveAnalysisTaskResponse GetTopicSelectionPerspectiveAnalysisTask(GetTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题视角分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<GetTopicSelectionPerspectiveAnalysisTaskResponse> GetTopicSelectionPerspectiveAnalysisTaskAsync(GetTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileResponse
        /// </returns>
        public ImportInterveneFileResponse ImportInterveneFileWithOptions(ImportInterveneFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportInterveneFile",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportInterveneFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileResponse
        /// </returns>
        public async Task<ImportInterveneFileResponse> ImportInterveneFileWithOptionsAsync(ImportInterveneFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportInterveneFile",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportInterveneFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileResponse
        /// </returns>
        public ImportInterveneFileResponse ImportInterveneFile(ImportInterveneFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportInterveneFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileResponse
        /// </returns>
        public async Task<ImportInterveneFileResponse> ImportInterveneFileAsync(ImportInterveneFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportInterveneFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileAsyncResponse
        /// </returns>
        public ImportInterveneFileAsyncResponse ImportInterveneFileAsyncWithOptions(ImportInterveneFileAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportInterveneFileAsync",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportInterveneFileAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileAsyncResponse
        /// </returns>
        public async Task<ImportInterveneFileAsyncResponse> ImportInterveneFileAsyncWithOptionsAsync(ImportInterveneFileAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportInterveneFileAsync",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportInterveneFileAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileAsyncResponse
        /// </returns>
        public ImportInterveneFileAsyncResponse ImportInterveneFileAsync(ImportInterveneFileAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportInterveneFileAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步导入干预文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportInterveneFileAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportInterveneFileAsyncResponse
        /// </returns>
        public async Task<ImportInterveneFileAsyncResponse> ImportInterveneFileAsyncAsync(ImportInterveneFileAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportInterveneFileAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertInterveneGlobalReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneGlobalReplyResponse
        /// </returns>
        public InsertInterveneGlobalReplyResponse InsertInterveneGlobalReplyWithOptions(InsertInterveneGlobalReplyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertInterveneGlobalReplyShrinkRequest request = new InsertInterveneGlobalReplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReplyMessagList))
            {
                request.ReplyMessagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReplyMessagList, "ReplyMessagList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyMessagListShrink))
            {
                body["ReplyMessagList"] = request.ReplyMessagListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertInterveneGlobalReply",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertInterveneGlobalReplyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertInterveneGlobalReplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneGlobalReplyResponse
        /// </returns>
        public async Task<InsertInterveneGlobalReplyResponse> InsertInterveneGlobalReplyWithOptionsAsync(InsertInterveneGlobalReplyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertInterveneGlobalReplyShrinkRequest request = new InsertInterveneGlobalReplyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReplyMessagList))
            {
                request.ReplyMessagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReplyMessagList, "ReplyMessagList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyMessagListShrink))
            {
                body["ReplyMessagList"] = request.ReplyMessagListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertInterveneGlobalReply",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertInterveneGlobalReplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertInterveneGlobalReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneGlobalReplyResponse
        /// </returns>
        public InsertInterveneGlobalReplyResponse InsertInterveneGlobalReply(InsertInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertInterveneGlobalReplyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置干预全局回复</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertInterveneGlobalReplyRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneGlobalReplyResponse
        /// </returns>
        public async Task<InsertInterveneGlobalReplyResponse> InsertInterveneGlobalReplyAsync(InsertInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertInterveneGlobalReplyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入干预规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertInterveneRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneRuleResponse
        /// </returns>
        public InsertInterveneRuleResponse InsertInterveneRuleWithOptions(InsertInterveneRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertInterveneRuleShrinkRequest request = new InsertInterveneRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InterveneRuleConfig))
            {
                request.InterveneRuleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InterveneRuleConfig, "InterveneRuleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterveneRuleConfigShrink))
            {
                body["InterveneRuleConfig"] = request.InterveneRuleConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertInterveneRule",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertInterveneRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入干预规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InsertInterveneRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneRuleResponse
        /// </returns>
        public async Task<InsertInterveneRuleResponse> InsertInterveneRuleWithOptionsAsync(InsertInterveneRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertInterveneRuleShrinkRequest request = new InsertInterveneRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InterveneRuleConfig))
            {
                request.InterveneRuleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InterveneRuleConfig, "InterveneRuleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterveneRuleConfigShrink))
            {
                body["InterveneRuleConfig"] = request.InterveneRuleConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertInterveneRule",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertInterveneRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertInterveneRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneRuleResponse
        /// </returns>
        public InsertInterveneRuleResponse InsertInterveneRule(InsertInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertInterveneRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>插入干预规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertInterveneRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertInterveneRuleResponse
        /// </returns>
        public async Task<InsertInterveneRuleResponse> InsertInterveneRuleAsync(InsertInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertInterveneRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ListAnalysisTagDetailByTaskIdResponse ListAnalysisTagDetailByTaskIdWithOptions(ListAnalysisTagDetailByTaskIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAnalysisTagDetailByTaskIdShrinkRequest request = new ListAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalysisTagDetailByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisTagDetailByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ListAnalysisTagDetailByTaskIdResponse> ListAnalysisTagDetailByTaskIdWithOptionsAsync(ListAnalysisTagDetailByTaskIdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAnalysisTagDetailByTaskIdShrinkRequest request = new ListAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "Categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["Categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnalysisTagDetailByTaskId",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisTagDetailByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ListAnalysisTagDetailByTaskIdResponse ListAnalysisTagDetailByTaskId(ListAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnalysisTagDetailByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取企业VOC分析任务明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ListAnalysisTagDetailByTaskIdResponse> ListAnalysisTagDetailByTaskIdAsync(ListAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnalysisTagDetailByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAsyncTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public ListAsyncTasksResponse ListAsyncTasksWithOptions(ListAsyncTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAsyncTasksShrinkRequest request = new ListAsyncTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskStatusList))
            {
                request.TaskStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskStatusList, "TaskStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTypeList))
            {
                request.TaskTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTypeList, "TaskTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                body["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusListShrink))
            {
                body["TaskStatusList"] = request.TaskStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypeListShrink))
            {
                body["TaskTypeList"] = request.TaskTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAsyncTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public async Task<ListAsyncTasksResponse> ListAsyncTasksWithOptionsAsync(ListAsyncTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAsyncTasksShrinkRequest request = new ListAsyncTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskStatusList))
            {
                request.TaskStatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskStatusList, "TaskStatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTypeList))
            {
                request.TaskTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTypeList, "TaskTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                body["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatusListShrink))
            {
                body["TaskStatusList"] = request.TaskStatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypeListShrink))
            {
                body["TaskTypeList"] = request.TaskTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsyncTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsyncTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public ListAsyncTasksResponse ListAsyncTasks(ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsyncTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsyncTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsyncTasksResponse
        /// </returns>
        public async Task<ListAsyncTasksResponse> ListAsyncTasksAsync(ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsyncTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统自定义预设</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBuildConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBuildConfigsResponse
        /// </returns>
        public ListBuildConfigsResponse ListBuildConfigsWithOptions(ListBuildConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuildConfigs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuildConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统自定义预设</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBuildConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBuildConfigsResponse
        /// </returns>
        public async Task<ListBuildConfigsResponse> ListBuildConfigsWithOptionsAsync(ListBuildConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBuildConfigs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBuildConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统自定义预设</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBuildConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBuildConfigsResponse
        /// </returns>
        public ListBuildConfigsResponse ListBuildConfigs(ListBuildConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBuildConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统自定义预设</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBuildConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBuildConfigsResponse
        /// </returns>
        public async Task<ListBuildConfigsResponse> ListBuildConfigsAsync(ListBuildConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBuildConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义文本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomTextResponse
        /// </returns>
        public ListCustomTextResponse ListCustomTextWithOptions(ListCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义文本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomTextResponse
        /// </returns>
        public async Task<ListCustomTextResponse> ListCustomTextWithOptionsAsync(ListCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义文本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomTextResponse
        /// </returns>
        public ListCustomTextResponse ListCustomText(ListCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义文本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomTextResponse
        /// </returns>
        public async Task<ListCustomTextResponse> ListCustomTextAsync(ListCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义视角列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCustomViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomViewPointsResponse
        /// </returns>
        public ListCustomViewPointsResponse ListCustomViewPointsWithOptions(ListCustomViewPointsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCustomViewPointsShrinkRequest request = new ListCustomViewPointsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attitudes))
            {
                request.AttitudesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attitudes, "Attitudes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attitude))
            {
                body["Attitude"] = request.Attitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttitudesShrink))
            {
                body["Attitudes"] = request.AttitudesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                body["TopicId"] = request.TopicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomViewPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义视角列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCustomViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomViewPointsResponse
        /// </returns>
        public async Task<ListCustomViewPointsResponse> ListCustomViewPointsWithOptionsAsync(ListCustomViewPointsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCustomViewPointsShrinkRequest request = new ListCustomViewPointsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attitudes))
            {
                request.AttitudesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attitudes, "Attitudes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attitude))
            {
                body["Attitude"] = request.Attitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttitudesShrink))
            {
                body["Attitudes"] = request.AttitudesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                body["TopicId"] = request.TopicId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomViewPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomViewPointsResponse
        /// </returns>
        public ListCustomViewPointsResponse ListCustomViewPoints(ListCustomViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomViewPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomViewPointsResponse
        /// </returns>
        public async Task<ListCustomViewPointsResponse> ListCustomViewPointsAsync(ListCustomViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomViewPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集文档列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDatasetDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetDocumentsResponse
        /// </returns>
        public ListDatasetDocumentsResponse ListDatasetDocumentsWithOptions(ListDatasetDocumentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDatasetDocumentsShrinkRequest request = new ListDatasetDocumentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeFields))
            {
                request.ExcludeFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeFields, "ExcludeFields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeFields))
            {
                request.IncludeFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeFields, "IncludeFields", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFieldsShrink))
            {
                body["ExcludeFields"] = request.ExcludeFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFieldsShrink))
            {
                body["IncludeFields"] = request.IncludeFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集文档列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDatasetDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetDocumentsResponse
        /// </returns>
        public async Task<ListDatasetDocumentsResponse> ListDatasetDocumentsWithOptionsAsync(ListDatasetDocumentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDatasetDocumentsShrinkRequest request = new ListDatasetDocumentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeFields))
            {
                request.ExcludeFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeFields, "ExcludeFields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeFields))
            {
                request.IncludeFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeFields, "IncludeFields", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeFieldsShrink))
            {
                body["ExcludeFields"] = request.ExcludeFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFieldsShrink))
            {
                body["IncludeFields"] = request.IncludeFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetDocumentsResponse
        /// </returns>
        public ListDatasetDocumentsResponse ListDatasetDocuments(ListDatasetDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasetDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetDocumentsResponse
        /// </returns>
        public async Task<ListDatasetDocumentsResponse> ListDatasetDocumentsAsync(ListDatasetDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasetDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasetsWithOptions(ListDatasetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetType))
            {
                body["DatasetType"] = request.DatasetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeConfig))
            {
                body["IncludeConfig"] = request.IncludeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(ListDatasetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetType))
            {
                body["DatasetType"] = request.DatasetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeConfig))
            {
                body["IncludeConfig"] = request.IncludeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialoguesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialoguesResponse
        /// </returns>
        public ListDialoguesResponse ListDialoguesWithOptions(ListDialoguesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueType))
            {
                body["DialogueType"] = request.DialogueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDialogues",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialoguesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialoguesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDialoguesResponse
        /// </returns>
        public async Task<ListDialoguesResponse> ListDialoguesWithOptionsAsync(ListDialoguesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueType))
            {
                body["DialogueType"] = request.DialogueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDialogues",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDialoguesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialoguesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialoguesResponse
        /// </returns>
        public ListDialoguesResponse ListDialogues(ListDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDialoguesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDialoguesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDialoguesResponse
        /// </returns>
        public async Task<ListDialoguesResponse> ListDialoguesAsync(ListDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDialoguesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDocsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocsResponse
        /// </returns>
        public ListDocsResponse ListDocsWithOptions(ListDocsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDocsShrinkRequest request = new ListDocsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Statuses))
            {
                request.StatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Statuses, "Statuses", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusesShrink))
            {
                body["Statuses"] = request.StatusesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDocsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocsResponse
        /// </returns>
        public async Task<ListDocsResponse> ListDocsWithOptionsAsync(ListDocsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDocsShrinkRequest request = new ListDocsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Statuses))
            {
                request.StatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Statuses, "Statuses", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocName))
            {
                body["DocName"] = request.DocName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                body["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusesShrink))
            {
                body["Statuses"] = request.StatusesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocs",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocsResponse
        /// </returns>
        public ListDocsResponse ListDocs(ListDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDocsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读获取文档列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocsResponse
        /// </returns>
        public async Task<ListDocsResponse> ListDocsAsync(ListDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDocsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新颖视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFreshViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFreshViewPointsResponse
        /// </returns>
        public ListFreshViewPointsResponse ListFreshViewPointsWithOptions(ListFreshViewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFreshViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFreshViewPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新颖视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFreshViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFreshViewPointsResponse
        /// </returns>
        public async Task<ListFreshViewPointsResponse> ListFreshViewPointsWithOptionsAsync(ListFreshViewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFreshViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFreshViewPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新颖视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFreshViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFreshViewPointsResponse
        /// </returns>
        public ListFreshViewPointsResponse ListFreshViewPoints(ListFreshViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFreshViewPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新颖视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFreshViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFreshViewPointsResponse
        /// </returns>
        public async Task<ListFreshViewPointsResponse> ListFreshViewPointsAsync(ListFreshViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFreshViewPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGeneratedContentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGeneratedContentsResponse
        /// </returns>
        public ListGeneratedContentsResponse ListGeneratedContentsWithOptions(ListGeneratedContentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentDomain))
            {
                body["ContentDomain"] = request.ContentDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGeneratedContents",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGeneratedContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGeneratedContentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGeneratedContentsResponse
        /// </returns>
        public async Task<ListGeneratedContentsResponse> ListGeneratedContentsWithOptionsAsync(ListGeneratedContentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentDomain))
            {
                body["ContentDomain"] = request.ContentDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGeneratedContents",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGeneratedContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGeneratedContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGeneratedContentsResponse
        /// </returns>
        public ListGeneratedContentsResponse ListGeneratedContents(ListGeneratedContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGeneratedContentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGeneratedContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGeneratedContentsResponse
        /// </returns>
        public async Task<ListGeneratedContentsResponse> ListGeneratedContentsAsync(ListGeneratedContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGeneratedContentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分类的热点新闻</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotNewsWithTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotNewsWithTypeResponse
        /// </returns>
        public ListHotNewsWithTypeResponse ListHotNewsWithTypeWithOptions(ListHotNewsWithTypeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotNewsWithTypeShrinkRequest request = new ListHotNewsWithTypeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NewsTypes))
            {
                request.NewsTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NewsTypes, "NewsTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewsType))
            {
                body["NewsType"] = request.NewsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewsTypesShrink))
            {
                body["NewsTypes"] = request.NewsTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotNewsWithType",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotNewsWithTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分类的热点新闻</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotNewsWithTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotNewsWithTypeResponse
        /// </returns>
        public async Task<ListHotNewsWithTypeResponse> ListHotNewsWithTypeWithOptionsAsync(ListHotNewsWithTypeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotNewsWithTypeShrinkRequest request = new ListHotNewsWithTypeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NewsTypes))
            {
                request.NewsTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NewsTypes, "NewsTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewsType))
            {
                body["NewsType"] = request.NewsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewsTypesShrink))
            {
                body["NewsTypes"] = request.NewsTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotNewsWithType",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotNewsWithTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分类的热点新闻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotNewsWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotNewsWithTypeResponse
        /// </returns>
        public ListHotNewsWithTypeResponse ListHotNewsWithType(ListHotNewsWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotNewsWithTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取分类的热点新闻</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotNewsWithTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotNewsWithTypeResponse
        /// </returns>
        public async Task<ListHotNewsWithTypeResponse> ListHotNewsWithTypeAsync(ListHotNewsWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotNewsWithTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有平台热榜源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotSourcesResponse
        /// </returns>
        public ListHotSourcesResponse ListHotSourcesWithOptions(ListHotSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotSources",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有平台热榜源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotSourcesResponse
        /// </returns>
        public async Task<ListHotSourcesResponse> ListHotSourcesWithOptionsAsync(ListHotSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotSources",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有平台热榜源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotSourcesResponse
        /// </returns>
        public ListHotSourcesResponse ListHotSources(ListHotSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有平台热榜源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotSourcesResponse
        /// </returns>
        public async Task<ListHotSourcesResponse> ListHotSourcesAsync(ListHotSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点事件列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotTopicsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicsResponse
        /// </returns>
        public ListHotTopicsResponse ListHotTopicsWithOptions(ListHotTopicsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotTopicsShrinkRequest request = new ListHotTopicsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIds))
            {
                request.TopicIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIds, "TopicIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdsShrink))
            {
                body["TopicIds"] = request.TopicIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuery))
            {
                body["TopicQuery"] = request.TopicQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithNews))
            {
                body["WithNews"] = request.WithNews;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotTopics",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotTopicsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点事件列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListHotTopicsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicsResponse
        /// </returns>
        public async Task<ListHotTopicsResponse> ListHotTopicsWithOptionsAsync(ListHotTopicsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListHotTopicsShrinkRequest request = new ListHotTopicsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIds))
            {
                request.TopicIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIds, "TopicIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdsShrink))
            {
                body["TopicIds"] = request.TopicIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuery))
            {
                body["TopicQuery"] = request.TopicQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithNews))
            {
                body["WithNews"] = request.WithNews;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotTopics",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotTopicsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicsResponse
        /// </returns>
        public ListHotTopicsResponse ListHotTopics(ListHotTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotTopicsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点事件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicsResponse
        /// </returns>
        public async Task<ListHotTopicsResponse> ListHotTopicsAsync(ListHotTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotTopicsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热门视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotViewPointsResponse
        /// </returns>
        public ListHotViewPointsResponse ListHotViewPointsWithOptions(ListHotViewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotViewPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热门视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotViewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotViewPointsResponse
        /// </returns>
        public async Task<ListHotViewPointsResponse> ListHotViewPointsWithOptionsAsync(ListHotViewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotViewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotViewPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热门视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotViewPointsResponse
        /// </returns>
        public ListHotViewPointsResponse ListHotViewPoints(ListHotViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotViewPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>热门视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotViewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotViewPointsResponse
        /// </returns>
        public async Task<ListHotViewPointsResponse> ListHotViewPointsAsync(ListHotViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotViewPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项目数量列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneCntRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneCntResponse
        /// </returns>
        public ListInterveneCntResponse ListInterveneCntWithOptions(ListInterveneCntRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneCnt",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneCntResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项目数量列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneCntRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneCntResponse
        /// </returns>
        public async Task<ListInterveneCntResponse> ListInterveneCntWithOptionsAsync(ListInterveneCntRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneCnt",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneCntResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项目数量列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneCntRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneCntResponse
        /// </returns>
        public ListInterveneCntResponse ListInterveneCnt(ListInterveneCntRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneCntWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项目数量列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneCntRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneCntResponse
        /// </returns>
        public async Task<ListInterveneCntResponse> ListInterveneCntAsync(ListInterveneCntRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneCntWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneImportTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneImportTasksResponse
        /// </returns>
        public ListInterveneImportTasksResponse ListInterveneImportTasksWithOptions(ListInterveneImportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneImportTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneImportTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneImportTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneImportTasksResponse
        /// </returns>
        public async Task<ListInterveneImportTasksResponse> ListInterveneImportTasksWithOptionsAsync(ListInterveneImportTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneImportTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneImportTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneImportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneImportTasksResponse
        /// </returns>
        public ListInterveneImportTasksResponse ListInterveneImportTasks(ListInterveneImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneImportTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得导入任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneImportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneImportTasksResponse
        /// </returns>
        public async Task<ListInterveneImportTasksResponse> ListInterveneImportTasksAsync(ListInterveneImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneImportTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneRulesResponse
        /// </returns>
        public ListInterveneRulesResponse ListInterveneRulesWithOptions(ListInterveneRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneRules",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneRulesResponse
        /// </returns>
        public async Task<ListInterveneRulesResponse> ListInterveneRulesWithOptionsAsync(ListInterveneRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterveneRules",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterveneRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneRulesResponse
        /// </returns>
        public ListInterveneRulesResponse ListInterveneRules(ListInterveneRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInterveneRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInterveneRulesResponse
        /// </returns>
        public async Task<ListInterveneRulesResponse> ListInterveneRulesAsync(ListInterveneRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntervenesResponse
        /// </returns>
        public ListIntervenesResponse ListIntervenesWithOptions(ListIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterveneType))
            {
                body["InterveneType"] = request.InterveneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervenesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntervenesResponse
        /// </returns>
        public async Task<ListIntervenesResponse> ListIntervenesWithOptionsAsync(ListIntervenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterveneType))
            {
                body["InterveneType"] = request.InterveneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervenes",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntervenesResponse
        /// </returns>
        public ListIntervenesResponse ListIntervenes(ListIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervenesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得干预项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntervenesResponse
        /// </returns>
        public async Task<ListIntervenesResponse> ListIntervenesAsync(ListIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervenesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询素材列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMaterialDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMaterialDocumentsResponse
        /// </returns>
        public ListMaterialDocumentsResponse ListMaterialDocumentsWithOptions(ListMaterialDocumentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMaterialDocumentsShrinkRequest request = new ListMaterialDocumentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocTypeList))
            {
                request.DocTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocTypeList, "DocTypeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocTypeListShrink))
            {
                body["DocTypeList"] = request.DocTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneratePublicUrl))
            {
                body["GeneratePublicUrl"] = request.GeneratePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeEnd))
            {
                body["UpdateTimeEnd"] = request.UpdateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeStart))
            {
                body["UpdateTimeStart"] = request.UpdateTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMaterialDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMaterialDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询素材列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMaterialDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMaterialDocumentsResponse
        /// </returns>
        public async Task<ListMaterialDocumentsResponse> ListMaterialDocumentsWithOptionsAsync(ListMaterialDocumentsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMaterialDocumentsShrinkRequest request = new ListMaterialDocumentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocTypeList))
            {
                request.DocTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocTypeList, "DocTypeList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["CreateTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocTypeListShrink))
            {
                body["DocTypeList"] = request.DocTypeListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneratePublicUrl))
            {
                body["GeneratePublicUrl"] = request.GeneratePublicUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeEnd))
            {
                body["UpdateTimeEnd"] = request.UpdateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeStart))
            {
                body["UpdateTimeStart"] = request.UpdateTimeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMaterialDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMaterialDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询素材列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaterialDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMaterialDocumentsResponse
        /// </returns>
        public ListMaterialDocumentsResponse ListMaterialDocuments(ListMaterialDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMaterialDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询素材列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaterialDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMaterialDocumentsResponse
        /// </returns>
        public async Task<ListMaterialDocumentsResponse> ListMaterialDocumentsAsync(ListMaterialDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMaterialDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题策划列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlanningProposalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlanningProposalResponse
        /// </returns>
        public ListPlanningProposalResponse ListPlanningProposalWithOptions(ListPlanningProposalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlanningProposalShrinkRequest request = new ListPlanningProposalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Titles))
            {
                request.TitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Titles, "Titles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitlesShrink))
            {
                body["Titles"] = request.TitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewPointType))
            {
                body["ViewPointType"] = request.ViewPointType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlanningProposal",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlanningProposalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题策划列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlanningProposalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlanningProposalResponse
        /// </returns>
        public async Task<ListPlanningProposalResponse> ListPlanningProposalWithOptionsAsync(ListPlanningProposalRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlanningProposalShrinkRequest request = new ListPlanningProposalShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomViewPointIds))
            {
                request.CustomViewPointIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomViewPointIds, "CustomViewPointIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Titles))
            {
                request.TitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Titles, "Titles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointId))
            {
                body["CustomViewPointId"] = request.CustomViewPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomViewPointIdsShrink))
            {
                body["CustomViewPointIds"] = request.CustomViewPointIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitlesShrink))
            {
                body["Titles"] = request.TitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewPointType))
            {
                body["ViewPointType"] = request.ViewPointType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlanningProposal",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlanningProposalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题策划列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlanningProposalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlanningProposalResponse
        /// </returns>
        public ListPlanningProposalResponse ListPlanningProposal(ListPlanningProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlanningProposalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取选题策划列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlanningProposalRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlanningProposalResponse
        /// </returns>
        public async Task<ListPlanningProposalResponse> ListPlanningProposalAsync(ListPlanningProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlanningProposalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询搜索生成任务对话详情中数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialogueDatasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialogueDatasResponse
        /// </returns>
        public ListSearchTaskDialogueDatasResponse ListSearchTaskDialogueDatasWithOptions(ListSearchTaskDialogueDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultimodalSearchType))
            {
                body["MultimodalSearchType"] = request.MultimodalSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["OriginalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchModel))
            {
                body["SearchModel"] = request.SearchModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchModelDataValue))
            {
                body["SearchModelDataValue"] = request.SearchModelDataValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTaskDialogueDatas",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTaskDialogueDatasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询搜索生成任务对话详情中数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialogueDatasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialogueDatasResponse
        /// </returns>
        public async Task<ListSearchTaskDialogueDatasResponse> ListSearchTaskDialogueDatasWithOptionsAsync(ListSearchTaskDialogueDatasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultimodalSearchType))
            {
                body["MultimodalSearchType"] = request.MultimodalSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["OriginalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchModel))
            {
                body["SearchModel"] = request.SearchModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchModelDataValue))
            {
                body["SearchModelDataValue"] = request.SearchModelDataValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTaskDialogueDatas",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTaskDialogueDatasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询搜索生成任务对话详情中数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialogueDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialogueDatasResponse
        /// </returns>
        public ListSearchTaskDialogueDatasResponse ListSearchTaskDialogueDatas(ListSearchTaskDialogueDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSearchTaskDialogueDatasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询搜索生成任务对话详情中数据列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialogueDatasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialogueDatasResponse
        /// </returns>
        public async Task<ListSearchTaskDialogueDatasResponse> ListSearchTaskDialogueDatasAsync(ListSearchTaskDialogueDatasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSearchTaskDialogueDatasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialoguesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialoguesResponse
        /// </returns>
        public ListSearchTaskDialoguesResponse ListSearchTaskDialoguesWithOptions(ListSearchTaskDialoguesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTaskDialogues",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTaskDialoguesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialoguesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialoguesResponse
        /// </returns>
        public async Task<ListSearchTaskDialoguesResponse> ListSearchTaskDialoguesWithOptionsAsync(ListSearchTaskDialoguesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTaskDialogues",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTaskDialoguesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialoguesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialoguesResponse
        /// </returns>
        public ListSearchTaskDialoguesResponse ListSearchTaskDialogues(ListSearchTaskDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSearchTaskDialoguesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTaskDialoguesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTaskDialoguesResponse
        /// </returns>
        public async Task<ListSearchTaskDialoguesResponse> ListSearchTaskDialoguesAsync(ListSearchTaskDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSearchTaskDialoguesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成历史任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSearchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTasksResponse
        /// </returns>
        public ListSearchTasksResponse ListSearchTasksWithOptions(ListSearchTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSearchTasksShrinkRequest request = new ListSearchTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DialogueTypes))
            {
                request.DialogueTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DialogueTypes, "DialogueTypes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTypesShrink))
            {
                body["DialogueTypes"] = request.DialogueTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成历史任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSearchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTasksResponse
        /// </returns>
        public async Task<ListSearchTasksResponse> ListSearchTasksWithOptionsAsync(ListSearchTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSearchTasksShrinkRequest request = new ListSearchTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DialogueTypes))
            {
                request.DialogueTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DialogueTypes, "DialogueTypes", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTypesShrink))
            {
                body["DialogueTypes"] = request.DialogueTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchTasks",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成历史任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTasksResponse
        /// </returns>
        public ListSearchTasksResponse ListSearchTasks(ListSearchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSearchTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询妙搜搜索生成历史任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSearchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSearchTasksResponse
        /// </returns>
        public async Task<ListSearchTasksResponse> ListSearchTasksAsync(ListSearchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSearchTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStyleLearningResultResponse
        /// </returns>
        public ListStyleLearningResultResponse ListStyleLearningResultWithOptions(ListStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStyleLearningResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStyleLearningResultResponse
        /// </returns>
        public async Task<ListStyleLearningResultResponse> ListStyleLearningResultWithOptionsAsync(ListStyleLearningResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStyleLearningResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStyleLearningResultResponse
        /// </returns>
        public ListStyleLearningResultResponse ListStyleLearningResult(ListStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStyleLearningResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体学习分析结果列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStyleLearningResultResponse
        /// </returns>
        public async Task<ListStyleLearningResultResponse> ListStyleLearningResultAsync(ListStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStyleLearningResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>时效性视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTimedViewAttitudeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTimedViewAttitudeResponse
        /// </returns>
        public ListTimedViewAttitudeResponse ListTimedViewAttitudeWithOptions(ListTimedViewAttitudeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTimedViewAttitude",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTimedViewAttitudeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>时效性视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTimedViewAttitudeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTimedViewAttitudeResponse
        /// </returns>
        public async Task<ListTimedViewAttitudeResponse> ListTimedViewAttitudeWithOptionsAsync(ListTimedViewAttitudeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTimedViewAttitude",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTimedViewAttitudeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>时效性视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTimedViewAttitudeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTimedViewAttitudeResponse
        /// </returns>
        public ListTimedViewAttitudeResponse ListTimedViewAttitude(ListTimedViewAttitudeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTimedViewAttitudeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>时效性视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTimedViewAttitudeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTimedViewAttitudeResponse
        /// </returns>
        public async Task<ListTimedViewAttitudeResponse> ListTimedViewAttitudeAsync(ListTimedViewAttitudeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTimedViewAttitudeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点推荐事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRecommendEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicRecommendEventListResponse
        /// </returns>
        public ListTopicRecommendEventListResponse ListTopicRecommendEventListWithOptions(ListTopicRecommendEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicRecommendEventList",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicRecommendEventListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点推荐事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRecommendEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicRecommendEventListResponse
        /// </returns>
        public async Task<ListTopicRecommendEventListResponse> ListTopicRecommendEventListWithOptionsAsync(ListTopicRecommendEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicRecommendEventList",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicRecommendEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点推荐事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRecommendEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicRecommendEventListResponse
        /// </returns>
        public ListTopicRecommendEventListResponse ListTopicRecommendEventList(ListTopicRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicRecommendEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热点推荐事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicRecommendEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicRecommendEventListResponse
        /// </returns>
        public async Task<ListTopicRecommendEventListResponse> ListTopicRecommendEventListAsync(ListTopicRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicRecommendEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题事件推荐观点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicViewPointRecommendEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicViewPointRecommendEventListResponse
        /// </returns>
        public ListTopicViewPointRecommendEventListResponse ListTopicViewPointRecommendEventListWithOptions(ListTopicViewPointRecommendEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicViewPointRecommendEventList",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicViewPointRecommendEventListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题事件推荐观点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicViewPointRecommendEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTopicViewPointRecommendEventListResponse
        /// </returns>
        public async Task<ListTopicViewPointRecommendEventListResponse> ListTopicViewPointRecommendEventListWithOptionsAsync(ListTopicViewPointRecommendEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicViewPointRecommendEventList",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicViewPointRecommendEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题事件推荐观点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicViewPointRecommendEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicViewPointRecommendEventListResponse
        /// </returns>
        public ListTopicViewPointRecommendEventListResponse ListTopicViewPointRecommendEventList(ListTopicViewPointRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicViewPointRecommendEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取主题事件推荐观点列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTopicViewPointRecommendEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTopicViewPointRecommendEventListResponse
        /// </returns>
        public async Task<ListTopicViewPointRecommendEventListResponse> ListTopicViewPointRecommendEventListAsync(ListTopicViewPointRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicViewPointRecommendEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统所有实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVersionsResponse
        /// </returns>
        public ListVersionsResponse ListVersionsWithOptions(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersions",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统所有实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVersionsResponse
        /// </returns>
        public async Task<ListVersionsResponse> ListVersionsWithOptionsAsync(ListVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVersions",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统所有实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVersionsResponse
        /// </returns>
        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取系统所有实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVersionsResponse
        /// </returns>
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网友视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWebReviewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebReviewPointsResponse
        /// </returns>
        public ListWebReviewPointsResponse ListWebReviewPointsWithOptions(ListWebReviewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebReviewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebReviewPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网友视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWebReviewPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebReviewPointsResponse
        /// </returns>
        public async Task<ListWebReviewPointsResponse> ListWebReviewPointsWithOptionsAsync(ListWebReviewPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebReviewPoints",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebReviewPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网友视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWebReviewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebReviewPointsResponse
        /// </returns>
        public ListWebReviewPointsResponse ListWebReviewPoints(ListWebReviewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWebReviewPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>网友视角列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWebReviewPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebReviewPointsResponse
        /// </returns>
        public async Task<ListWebReviewPointsResponse> ListWebReviewPointsAsync(ListWebReviewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWebReviewPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWritingStylesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWritingStylesResponse
        /// </returns>
        public ListWritingStylesResponse ListWritingStylesWithOptions(ListWritingStylesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWritingStyles",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWritingStylesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWritingStylesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWritingStylesResponse
        /// </returns>
        public async Task<ListWritingStylesResponse> ListWritingStylesWithOptionsAsync(ListWritingStylesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWritingStyles",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWritingStylesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWritingStylesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWritingStylesResponse
        /// </returns>
        public ListWritingStylesResponse ListWritingStyles(ListWritingStylesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWritingStylesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWritingStylesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWritingStylesResponse
        /// </returns>
        public async Task<ListWritingStylesResponse> ListWritingStylesAsync(ListWritingStylesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWritingStylesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据taskId查询异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResponse
        /// </returns>
        public QueryAsyncTaskResponse QueryAsyncTaskWithOptions(QueryAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据taskId查询异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResponse
        /// </returns>
        public async Task<QueryAsyncTaskResponse> QueryAsyncTaskWithOptionsAsync(QueryAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据taskId查询异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResponse
        /// </returns>
        public QueryAsyncTaskResponse QueryAsyncTask(QueryAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAsyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据taskId查询异步任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResponse
        /// </returns>
        public async Task<QueryAsyncTaskResponse> QueryAsyncTaskAsync(QueryAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审核结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuditTaskResponse
        /// </returns>
        public QueryAuditTaskResponse QueryAuditTaskWithOptions(QueryAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAuditTaskId))
            {
                body["ContentAuditTaskId"] = request.ContentAuditTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuditTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审核结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuditTaskResponse
        /// </returns>
        public async Task<QueryAuditTaskResponse> QueryAuditTaskWithOptionsAsync(QueryAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAuditTaskId))
            {
                body["ContentAuditTaskId"] = request.ContentAuditTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuditTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审核结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuditTaskResponse
        /// </returns>
        public QueryAuditTaskResponse QueryAuditTask(QueryAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuditTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审核结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuditTaskResponse
        /// </returns>
        public async Task<QueryAuditTaskResponse> QueryAuditTaskAsync(QueryAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuditTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容缩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAbbreviationContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunAbbreviationContentResponse
        /// </returns>
        public RunAbbreviationContentResponse RunAbbreviationContentWithOptions(RunAbbreviationContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunAbbreviationContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunAbbreviationContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容缩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAbbreviationContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunAbbreviationContentResponse
        /// </returns>
        public async Task<RunAbbreviationContentResponse> RunAbbreviationContentWithOptionsAsync(RunAbbreviationContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunAbbreviationContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunAbbreviationContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容缩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAbbreviationContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunAbbreviationContentResponse
        /// </returns>
        public RunAbbreviationContentResponse RunAbbreviationContent(RunAbbreviationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunAbbreviationContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容缩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunAbbreviationContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunAbbreviationContentResponse
        /// </returns>
        public async Task<RunAbbreviationContentResponse> RunAbbreviationContentAsync(RunAbbreviationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunAbbreviationContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读生成书籍脑图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookBrainmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookBrainmapResponse
        /// </returns>
        public RunBookBrainmapResponse RunBookBrainmapWithOptions(RunBookBrainmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNumber))
            {
                body["NodeNumber"] = request.NodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookBrainmap",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookBrainmapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读生成书籍脑图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookBrainmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookBrainmapResponse
        /// </returns>
        public async Task<RunBookBrainmapResponse> RunBookBrainmapWithOptionsAsync(RunBookBrainmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNumber))
            {
                body["NodeNumber"] = request.NodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookBrainmap",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookBrainmapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读生成书籍脑图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookBrainmapRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookBrainmapResponse
        /// </returns>
        public RunBookBrainmapResponse RunBookBrainmap(RunBookBrainmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunBookBrainmapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读生成书籍脑图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookBrainmapRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookBrainmapResponse
        /// </returns>
        public async Task<RunBookBrainmapResponse> RunBookBrainmapAsync(RunBookBrainmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunBookBrainmapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookIntroductionResponse
        /// </returns>
        public RunBookIntroductionResponse RunBookIntroductionWithOptions(RunBookIntroductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookIntroductionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookIntroductionResponse
        /// </returns>
        public async Task<RunBookIntroductionResponse> RunBookIntroductionWithOptionsAsync(RunBookIntroductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookIntroductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookIntroductionResponse
        /// </returns>
        public RunBookIntroductionResponse RunBookIntroduction(RunBookIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunBookIntroductionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookIntroductionResponse
        /// </returns>
        public async Task<RunBookIntroductionResponse> RunBookIntroductionAsync(RunBookIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunBookIntroductionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookSmartCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookSmartCardResponse
        /// </returns>
        public RunBookSmartCardResponse RunBookSmartCardWithOptions(RunBookSmartCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookSmartCard",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookSmartCardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookSmartCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunBookSmartCardResponse
        /// </returns>
        public async Task<RunBookSmartCardResponse> RunBookSmartCardWithOptionsAsync(RunBookSmartCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunBookSmartCard",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunBookSmartCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookSmartCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookSmartCardResponse
        /// </returns>
        public RunBookSmartCardResponse RunBookSmartCard(RunBookSmartCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunBookSmartCardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>书籍智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunBookSmartCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RunBookSmartCardResponse
        /// </returns>
        public async Task<RunBookSmartCardResponse> RunBookSmartCardAsync(RunBookSmartCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunBookSmartCardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户之声预测</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunCommentGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public RunCommentGenerationResponse RunCommentGenerationWithOptions(RunCommentGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommentGenerationShrinkRequest request = new RunCommentGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LengthRange))
            {
                request.LengthRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LengthRange, "LengthRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sentiment))
            {
                request.SentimentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sentiment, "Sentiment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Type))
            {
                request.TypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Type, "Type", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEmoji))
            {
                body["AllowEmoji"] = request.AllowEmoji;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LengthRangeShrink))
            {
                body["LengthRange"] = request.LengthRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumComments))
            {
                body["NumComments"] = request.NumComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SentimentShrink))
            {
                body["Sentiment"] = request.SentimentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["SourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["Style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeShrink))
            {
                body["Type"] = request.TypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommentGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommentGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户之声预测</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunCommentGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public async Task<RunCommentGenerationResponse> RunCommentGenerationWithOptionsAsync(RunCommentGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommentGenerationShrinkRequest request = new RunCommentGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LengthRange))
            {
                request.LengthRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LengthRange, "LengthRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sentiment))
            {
                request.SentimentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sentiment, "Sentiment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Type))
            {
                request.TypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Type, "Type", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowEmoji))
            {
                body["AllowEmoji"] = request.AllowEmoji;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LengthRangeShrink))
            {
                body["LengthRange"] = request.LengthRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumComments))
            {
                body["NumComments"] = request.NumComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SentimentShrink))
            {
                body["Sentiment"] = request.SentimentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["SourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["Style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeShrink))
            {
                body["Type"] = request.TypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommentGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommentGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户之声预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public RunCommentGenerationResponse RunCommentGeneration(RunCommentGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommentGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户之声预测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public async Task<RunCommentGenerationResponse> RunCommentGenerationAsync(RunCommentGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommentGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContinueContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContinueContentResponse
        /// </returns>
        public RunContinueContentResponse RunContinueContentWithOptions(RunContinueContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContinueContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContinueContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContinueContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContinueContentResponse
        /// </returns>
        public async Task<RunContinueContentResponse> RunContinueContentWithOptionsAsync(RunContinueContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContinueContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContinueContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContinueContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContinueContentResponse
        /// </returns>
        public RunContinueContentResponse RunContinueContent(RunContinueContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunContinueContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContinueContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContinueContentResponse
        /// </returns>
        public async Task<RunContinueContentResponse> RunContinueContentAsync(RunContinueContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunContinueContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义热点话题分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicAnalysisResponse
        /// </returns>
        public RunCustomHotTopicAnalysisResponse RunCustomHotTopicAnalysisWithOptions(RunCustomHotTopicAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AskUser))
            {
                body["AskUser"] = request.AskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAnalysisExistsTopic))
            {
                body["ForceAnalysisExistsTopic"] = request.ForceAnalysisExistsTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBack))
            {
                body["UserBack"] = request.UserBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCustomHotTopicAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCustomHotTopicAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义热点话题分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicAnalysisResponse
        /// </returns>
        public async Task<RunCustomHotTopicAnalysisResponse> RunCustomHotTopicAnalysisWithOptionsAsync(RunCustomHotTopicAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AskUser))
            {
                body["AskUser"] = request.AskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceAnalysisExistsTopic))
            {
                body["ForceAnalysisExistsTopic"] = request.ForceAnalysisExistsTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBack))
            {
                body["UserBack"] = request.UserBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCustomHotTopicAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCustomHotTopicAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义热点话题分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicAnalysisResponse
        /// </returns>
        public RunCustomHotTopicAnalysisResponse RunCustomHotTopicAnalysis(RunCustomHotTopicAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCustomHotTopicAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义热点话题分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicAnalysisResponse
        /// </returns>
        public async Task<RunCustomHotTopicAnalysisResponse> RunCustomHotTopicAnalysisAsync(RunCustomHotTopicAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCustomHotTopicAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义选题视角分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicViewPointAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicViewPointAnalysisResponse
        /// </returns>
        public RunCustomHotTopicViewPointAnalysisResponse RunCustomHotTopicViewPointAnalysisWithOptions(RunCustomHotTopicViewPointAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AskUser))
            {
                body["AskUser"] = request.AskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["SearchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAskUser))
            {
                body["SkipAskUser"] = request.SkipAskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                body["TopicId"] = request.TopicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBack))
            {
                body["UserBack"] = request.UserBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCustomHotTopicViewPointAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCustomHotTopicViewPointAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义选题视角分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicViewPointAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicViewPointAnalysisResponse
        /// </returns>
        public async Task<RunCustomHotTopicViewPointAnalysisResponse> RunCustomHotTopicViewPointAnalysisWithOptionsAsync(RunCustomHotTopicViewPointAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AskUser))
            {
                body["AskUser"] = request.AskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["SearchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAskUser))
            {
                body["SkipAskUser"] = request.SkipAskUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicId))
            {
                body["TopicId"] = request.TopicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicSource))
            {
                body["TopicSource"] = request.TopicSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicVersion))
            {
                body["TopicVersion"] = request.TopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBack))
            {
                body["UserBack"] = request.UserBack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCustomHotTopicViewPointAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCustomHotTopicViewPointAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义选题视角分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicViewPointAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicViewPointAnalysisResponse
        /// </returns>
        public RunCustomHotTopicViewPointAnalysisResponse RunCustomHotTopicViewPointAnalysis(RunCustomHotTopicViewPointAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCustomHotTopicViewPointAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自定义选题视角分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCustomHotTopicViewPointAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCustomHotTopicViewPointAnalysisResponse
        /// </returns>
        public async Task<RunCustomHotTopicViewPointAnalysisResponse> RunCustomHotTopicViewPointAnalysisAsync(RunCustomHotTopicViewPointAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCustomHotTopicViewPointAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读脑图生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocBrainmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocBrainmapResponse
        /// </returns>
        public RunDocBrainmapResponse RunDocBrainmapWithOptions(RunDocBrainmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNumber))
            {
                body["NodeNumber"] = request.NodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["referenceContent"] = request.ReferenceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocBrainmap",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocBrainmapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读脑图生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocBrainmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocBrainmapResponse
        /// </returns>
        public async Task<RunDocBrainmapResponse> RunDocBrainmapWithOptionsAsync(RunDocBrainmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNumber))
            {
                body["NodeNumber"] = request.NodeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["referenceContent"] = request.ReferenceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocBrainmap",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocBrainmapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读脑图生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocBrainmapRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocBrainmapResponse
        /// </returns>
        public RunDocBrainmapResponse RunDocBrainmap(RunDocBrainmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocBrainmapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读脑图生成接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocBrainmapRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocBrainmapResponse
        /// </returns>
        public async Task<RunDocBrainmapResponse> RunDocBrainmapAsync(RunDocBrainmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocBrainmapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocIntroductionResponse
        /// </returns>
        public RunDocIntroductionResponse RunDocIntroductionWithOptions(RunDocIntroductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntroductionPrompt))
            {
                body["IntroductionPrompt"] = request.IntroductionPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["referenceContent"] = request.ReferenceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocIntroductionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocIntroductionResponse
        /// </returns>
        public async Task<RunDocIntroductionResponse> RunDocIntroductionWithOptionsAsync(RunDocIntroductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntroductionPrompt))
            {
                body["IntroductionPrompt"] = request.IntroductionPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["referenceContent"] = request.ReferenceContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocIntroductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocIntroductionResponse
        /// </returns>
        public RunDocIntroductionResponse RunDocIntroduction(RunDocIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocIntroductionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档导读接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocIntroductionResponse
        /// </returns>
        public async Task<RunDocIntroductionResponse> RunDocIntroductionAsync(RunDocIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocIntroductionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读问答接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunDocQaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocQaResponse
        /// </returns>
        public RunDocQaResponse RunDocQaWithOptions(RunDocQaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunDocQaShrinkRequest request = new RunDocQaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConversationContexts))
            {
                request.ConversationContextsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConversationContexts, "ConversationContexts", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                body["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationContextsShrink))
            {
                body["ConversationContexts"] = request.ConversationContextsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSource))
            {
                body["SearchSource"] = request.SearchSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocQa",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocQaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读问答接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunDocQaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocQaResponse
        /// </returns>
        public async Task<RunDocQaResponse> RunDocQaWithOptionsAsync(RunDocQaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunDocQaShrinkRequest request = new RunDocQaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConversationContexts))
            {
                request.ConversationContextsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConversationContexts, "ConversationContexts", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                body["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationContextsShrink))
            {
                body["ConversationContexts"] = request.ConversationContextsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSource))
            {
                body["SearchSource"] = request.SearchSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocQa",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocQaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读问答接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocQaRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocQaResponse
        /// </returns>
        public RunDocQaResponse RunDocQa(RunDocQaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocQaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读问答接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocQaRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocQaResponse
        /// </returns>
        public async Task<RunDocQaResponse> RunDocQaAsync(RunDocQaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocQaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSmartCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocSmartCardResponse
        /// </returns>
        public RunDocSmartCardResponse RunDocSmartCardWithOptions(RunDocSmartCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocSmartCard",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocSmartCardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSmartCardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocSmartCardResponse
        /// </returns>
        public async Task<RunDocSmartCardResponse> RunDocSmartCardWithOptionsAsync(RunDocSmartCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocSmartCard",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocSmartCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSmartCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocSmartCardResponse
        /// </returns>
        public RunDocSmartCardResponse RunDocSmartCard(RunDocSmartCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocSmartCardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSmartCardRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocSmartCardResponse
        /// </returns>
        public async Task<RunDocSmartCardResponse> RunDocSmartCardAsync(RunDocSmartCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocSmartCardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档总结摘要接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocSummaryResponse
        /// </returns>
        public RunDocSummaryResponse RunDocSummaryWithOptions(RunDocSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendContent))
            {
                body["RecommendContent"] = request.RecommendContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocSummary",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档总结摘要接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocSummaryResponse
        /// </returns>
        public async Task<RunDocSummaryResponse> RunDocSummaryWithOptionsAsync(RunDocSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendContent))
            {
                body["RecommendContent"] = request.RecommendContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocSummary",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档总结摘要接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocSummaryResponse
        /// </returns>
        public RunDocSummaryResponse RunDocSummary(RunDocSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档总结摘要接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocSummaryResponse
        /// </returns>
        public async Task<RunDocSummaryResponse> RunDocSummaryAsync(RunDocSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档翻译接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocTranslationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocTranslationResponse
        /// </returns>
        public RunDocTranslationResponse RunDocTranslationWithOptions(RunDocTranslationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendContent))
            {
                body["RecommendContent"] = request.RecommendContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransType))
            {
                body["TransType"] = request.TransType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocTranslation",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocTranslationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档翻译接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocTranslationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocTranslationResponse
        /// </returns>
        public async Task<RunDocTranslationResponse> RunDocTranslationWithOptionsAsync(RunDocTranslationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CleanCache))
            {
                body["CleanCache"] = request.CleanCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendContent))
            {
                body["RecommendContent"] = request.RecommendContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransType))
            {
                body["TransType"] = request.TransType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocTranslation",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocTranslationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档翻译接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocTranslationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocTranslationResponse
        /// </returns>
        public RunDocTranslationResponse RunDocTranslation(RunDocTranslationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocTranslationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档翻译接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocTranslationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocTranslationResponse
        /// </returns>
        public async Task<RunDocTranslationResponse> RunDocTranslationAsync(RunDocTranslationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocTranslationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocWashingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocWashingResponse
        /// </returns>
        public RunDocWashingResponse RunDocWashingWithOptions(RunDocWashingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTypeName))
            {
                body["WritingTypeName"] = request.WritingTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTypeRefDoc))
            {
                body["WritingTypeRefDoc"] = request.WritingTypeRefDoc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocWashing",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocWashingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocWashingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDocWashingResponse
        /// </returns>
        public async Task<RunDocWashingResponse> RunDocWashingWithOptionsAsync(RunDocWashingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordNumber))
            {
                body["WordNumber"] = request.WordNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTypeName))
            {
                body["WritingTypeName"] = request.WritingTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTypeRefDoc))
            {
                body["WritingTypeRefDoc"] = request.WritingTypeRefDoc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDocWashing",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDocWashingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocWashingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocWashingResponse
        /// </returns>
        public RunDocWashingResponse RunDocWashing(RunDocWashingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDocWashingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDocWashingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDocWashingResponse
        /// </returns>
        public async Task<RunDocWashingResponse> RunDocWashingAsync(RunDocWashingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDocWashingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容扩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunExpandContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunExpandContentResponse
        /// </returns>
        public RunExpandContentResponse RunExpandContentWithOptions(RunExpandContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunExpandContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunExpandContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容扩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunExpandContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunExpandContentResponse
        /// </returns>
        public async Task<RunExpandContentResponse> RunExpandContentWithOptionsAsync(RunExpandContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunExpandContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunExpandContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容扩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunExpandContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunExpandContentResponse
        /// </returns>
        public RunExpandContentResponse RunExpandContent(RunExpandContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunExpandContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容扩写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunExpandContentRequest
        /// </param>
        /// 
        /// <returns>
        /// RunExpandContentResponse
        /// </returns>
        public async Task<RunExpandContentResponse> RunExpandContentAsync(RunExpandContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunExpandContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读猜你想问接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunGenerateQuestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunGenerateQuestionsResponse
        /// </returns>
        public RunGenerateQuestionsResponse RunGenerateQuestionsWithOptions(RunGenerateQuestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunGenerateQuestions",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunGenerateQuestionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读猜你想问接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunGenerateQuestionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunGenerateQuestionsResponse
        /// </returns>
        public async Task<RunGenerateQuestionsResponse> RunGenerateQuestionsWithOptionsAsync(RunGenerateQuestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunGenerateQuestions",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunGenerateQuestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读猜你想问接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunGenerateQuestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// RunGenerateQuestionsResponse
        /// </returns>
        public RunGenerateQuestionsResponse RunGenerateQuestions(RunGenerateQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunGenerateQuestionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读猜你想问接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunGenerateQuestionsRequest
        /// </param>
        /// 
        /// <returns>
        /// RunGenerateQuestionsResponse
        /// </returns>
        public async Task<RunGenerateQuestionsResponse> RunGenerateQuestionsAsync(RunGenerateQuestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunGenerateQuestionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档关键词抽取接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotwordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotwordResponse
        /// </returns>
        public RunHotwordResponse RunHotwordWithOptions(RunHotwordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotword",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotwordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档关键词抽取接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotwordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotwordResponse
        /// </returns>
        public async Task<RunHotwordResponse> RunHotwordWithOptionsAsync(RunHotwordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["DocId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceContent))
            {
                body["ReferenceContent"] = request.ReferenceContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotword",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotwordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档关键词抽取接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotwordRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotwordResponse
        /// </returns>
        public RunHotwordResponse RunHotword(RunHotwordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunHotwordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读文档关键词抽取接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotwordRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotwordResponse
        /// </returns>
        public async Task<RunHotwordResponse> RunHotwordAsync(RunHotwordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunHotwordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-抽取关键词</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunKeywordsExtractionGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunKeywordsExtractionGenerationResponse
        /// </returns>
        public RunKeywordsExtractionGenerationResponse RunKeywordsExtractionGenerationWithOptions(RunKeywordsExtractionGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunKeywordsExtractionGenerationShrinkRequest request = new RunKeywordsExtractionGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunKeywordsExtractionGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunKeywordsExtractionGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-抽取关键词</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunKeywordsExtractionGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunKeywordsExtractionGenerationResponse
        /// </returns>
        public async Task<RunKeywordsExtractionGenerationResponse> RunKeywordsExtractionGenerationWithOptionsAsync(RunKeywordsExtractionGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunKeywordsExtractionGenerationShrinkRequest request = new RunKeywordsExtractionGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunKeywordsExtractionGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunKeywordsExtractionGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-抽取关键词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunKeywordsExtractionGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunKeywordsExtractionGenerationResponse
        /// </returns>
        public RunKeywordsExtractionGenerationResponse RunKeywordsExtractionGeneration(RunKeywordsExtractionGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunKeywordsExtractionGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-抽取关键词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunKeywordsExtractionGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunKeywordsExtractionGenerationResponse
        /// </returns>
        public async Task<RunKeywordsExtractionGenerationResponse> RunKeywordsExtractionGenerationAsync(RunKeywordsExtractionGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunKeywordsExtractionGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档批量导读</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunMultiDocIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMultiDocIntroductionResponse
        /// </returns>
        public RunMultiDocIntroductionResponse RunMultiDocIntroductionWithOptions(RunMultiDocIntroductionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMultiDocIntroductionShrinkRequest request = new RunMultiDocIntroductionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMultiDocIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMultiDocIntroductionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档批量导读</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunMultiDocIntroductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMultiDocIntroductionResponse
        /// </returns>
        public async Task<RunMultiDocIntroductionResponse> RunMultiDocIntroductionWithOptionsAsync(RunMultiDocIntroductionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMultiDocIntroductionShrinkRequest request = new RunMultiDocIntroductionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocIds))
            {
                request.DocIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocIds, "DocIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdsShrink))
            {
                body["DocIds"] = request.DocIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPointPrompt))
            {
                body["KeyPointPrompt"] = request.KeyPointPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryPrompt))
            {
                body["SummaryPrompt"] = request.SummaryPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMultiDocIntroduction",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMultiDocIntroductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档批量导读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMultiDocIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMultiDocIntroductionResponse
        /// </returns>
        public RunMultiDocIntroductionResponse RunMultiDocIntroduction(RunMultiDocIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunMultiDocIntroductionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档批量导读</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMultiDocIntroductionRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMultiDocIntroductionResponse
        /// </returns>
        public async Task<RunMultiDocIntroductionResponse> RunMultiDocIntroductionAsync(RunMultiDocIntroductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunMultiDocIntroductionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙搜-智能搜索生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchGenerationResponse
        /// </returns>
        public RunSearchGenerationResponse RunSearchGenerationWithOptions(RunSearchGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchGenerationShrinkRequest request = new RunSearchGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentContext))
            {
                request.AgentContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentContext, "AgentContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChatConfig))
            {
                request.ChatConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChatConfig, "ChatConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentContextShrink))
            {
                body["AgentContext"] = request.AgentContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfigShrink))
            {
                body["ChatConfig"] = request.ChatConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["OriginalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙搜-智能搜索生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchGenerationResponse
        /// </returns>
        public async Task<RunSearchGenerationResponse> RunSearchGenerationWithOptionsAsync(RunSearchGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchGenerationShrinkRequest request = new RunSearchGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AgentContext))
            {
                request.AgentContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AgentContext, "AgentContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChatConfig))
            {
                request.ChatConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChatConfig, "ChatConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentContextShrink))
            {
                body["AgentContext"] = request.AgentContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfigShrink))
            {
                body["ChatConfig"] = request.ChatConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["OriginalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙搜-智能搜索生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchGenerationResponse
        /// </returns>
        public RunSearchGenerationResponse RunSearchGeneration(RunSearchGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSearchGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙搜-智能搜索生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchGenerationResponse
        /// </returns>
        public async Task<RunSearchGenerationResponse> RunSearchGenerationAsync(RunSearchGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSearchGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙搜-文搜文</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchSimilarArticlesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchSimilarArticlesResponse
        /// </returns>
        public RunSearchSimilarArticlesResponse RunSearchSimilarArticlesWithOptions(RunSearchSimilarArticlesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchSimilarArticlesShrinkRequest request = new RunSearchSimilarArticlesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChatConfig))
            {
                request.ChatConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChatConfig, "ChatConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfigShrink))
            {
                body["ChatConfig"] = request.ChatConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchSimilarArticles",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchSimilarArticlesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙搜-文搜文</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchSimilarArticlesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchSimilarArticlesResponse
        /// </returns>
        public async Task<RunSearchSimilarArticlesResponse> RunSearchSimilarArticlesWithOptionsAsync(RunSearchSimilarArticlesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchSimilarArticlesShrinkRequest request = new RunSearchSimilarArticlesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChatConfig))
            {
                request.ChatConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChatConfig, "ChatConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatConfigShrink))
            {
                body["ChatConfig"] = request.ChatConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchSimilarArticles",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchSimilarArticlesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙搜-文搜文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchSimilarArticlesRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchSimilarArticlesResponse
        /// </returns>
        public RunSearchSimilarArticlesResponse RunSearchSimilarArticles(RunSearchSimilarArticlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSearchSimilarArticlesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙搜-文搜文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchSimilarArticlesRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchSimilarArticlesResponse
        /// </returns>
        public async Task<RunSearchSimilarArticlesResponse> RunSearchSimilarArticlesAsync(RunSearchSimilarArticlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSearchSimilarArticlesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-分步骤写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStepByStepWritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStepByStepWritingResponse
        /// </returns>
        public RunStepByStepWritingResponse RunStepByStepWritingWithOptions(RunStepByStepWritingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStepByStepWritingShrinkRequest request = new RunStepByStepWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingConfig))
            {
                request.WritingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingConfig, "WritingConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSessionId))
            {
                body["OriginSessionId"] = request.OriginSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingConfigShrink))
            {
                body["WritingConfig"] = request.WritingConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStepByStepWriting",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStepByStepWritingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-分步骤写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStepByStepWritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStepByStepWritingResponse
        /// </returns>
        public async Task<RunStepByStepWritingResponse> RunStepByStepWritingWithOptionsAsync(RunStepByStepWritingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStepByStepWritingShrinkRequest request = new RunStepByStepWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingConfig))
            {
                request.WritingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingConfig, "WritingConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSessionId))
            {
                body["OriginSessionId"] = request.OriginSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingConfigShrink))
            {
                body["WritingConfig"] = request.WritingConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStepByStepWriting",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStepByStepWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-分步骤写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStepByStepWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStepByStepWritingResponse
        /// </returns>
        public RunStepByStepWritingResponse RunStepByStepWriting(RunStepByStepWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunStepByStepWritingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-分步骤写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStepByStepWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStepByStepWritingResponse
        /// </returns>
        public async Task<RunStepByStepWritingResponse> RunStepByStepWritingAsync(RunStepByStepWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunStepByStepWritingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容特点分析</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStyleFeatureAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStyleFeatureAnalysisResponse
        /// </returns>
        public RunStyleFeatureAnalysisResponse RunStyleFeatureAnalysisWithOptions(RunStyleFeatureAnalysisRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleFeatureAnalysisShrinkRequest request = new RunStyleFeatureAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MaterialIds))
            {
                request.MaterialIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MaterialIds, "MaterialIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIdsShrink))
            {
                body["MaterialIds"] = request.MaterialIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleFeatureAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleFeatureAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容特点分析</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStyleFeatureAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStyleFeatureAnalysisResponse
        /// </returns>
        public async Task<RunStyleFeatureAnalysisResponse> RunStyleFeatureAnalysisWithOptionsAsync(RunStyleFeatureAnalysisRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleFeatureAnalysisShrinkRequest request = new RunStyleFeatureAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MaterialIds))
            {
                request.MaterialIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MaterialIds, "MaterialIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIdsShrink))
            {
                body["MaterialIds"] = request.MaterialIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleFeatureAnalysis",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleFeatureAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容特点分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStyleFeatureAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStyleFeatureAnalysisResponse
        /// </returns>
        public RunStyleFeatureAnalysisResponse RunStyleFeatureAnalysis(RunStyleFeatureAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunStyleFeatureAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容特点分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStyleFeatureAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStyleFeatureAnalysisResponse
        /// </returns>
        public async Task<RunStyleFeatureAnalysisResponse> RunStyleFeatureAnalysisAsync(RunStyleFeatureAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunStyleFeatureAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSummaryGenerateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSummaryGenerateResponse
        /// </returns>
        public RunSummaryGenerateResponse RunSummaryGenerateWithOptions(RunSummaryGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSummaryGenerate",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSummaryGenerateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSummaryGenerateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSummaryGenerateResponse
        /// </returns>
        public async Task<RunSummaryGenerateResponse> RunSummaryGenerateWithOptionsAsync(RunSummaryGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSummaryGenerate",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSummaryGenerateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSummaryGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSummaryGenerateResponse
        /// </returns>
        public RunSummaryGenerateResponse RunSummaryGenerate(RunSummaryGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSummaryGenerateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内容摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSummaryGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSummaryGenerateResponse
        /// </returns>
        public async Task<RunSummaryGenerateResponse> RunSummaryGenerateAsync(RunSummaryGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSummaryGenerateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-文本润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTextPolishingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTextPolishingResponse
        /// </returns>
        public RunTextPolishingResponse RunTextPolishingWithOptions(RunTextPolishingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTextPolishing",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTextPolishingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-文本润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTextPolishingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTextPolishingResponse
        /// </returns>
        public async Task<RunTextPolishingResponse> RunTextPolishingWithOptionsAsync(RunTextPolishingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTextPolishing",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTextPolishingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-文本润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTextPolishingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTextPolishingResponse
        /// </returns>
        public RunTextPolishingResponse RunTextPolishing(RunTextPolishingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTextPolishingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创作-文本润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTextPolishingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTextPolishingResponse
        /// </returns>
        public async Task<RunTextPolishingResponse> RunTextPolishingAsync(RunTextPolishingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTextPolishingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙笔：标题生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTitleGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTitleGenerationResponse
        /// </returns>
        public RunTitleGenerationResponse RunTitleGenerationWithOptions(RunTitleGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTitleGenerationShrinkRequest request = new RunTitleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeduplicatedTitles))
            {
                request.DeduplicatedTitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeduplicatedTitles, "DeduplicatedTitles", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeduplicatedTitlesShrink))
            {
                body["DeduplicatedTitles"] = request.DeduplicatedTitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitleCount))
            {
                body["TitleCount"] = request.TitleCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTitleGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTitleGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙笔：标题生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTitleGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTitleGenerationResponse
        /// </returns>
        public async Task<RunTitleGenerationResponse> RunTitleGenerationWithOptionsAsync(RunTitleGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTitleGenerationShrinkRequest request = new RunTitleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeduplicatedTitles))
            {
                request.DeduplicatedTitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeduplicatedTitles, "DeduplicatedTitles", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeduplicatedTitlesShrink))
            {
                body["DeduplicatedTitles"] = request.DeduplicatedTitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitleCount))
            {
                body["TitleCount"] = request.TitleCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTitleGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTitleGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙笔：标题生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTitleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTitleGenerationResponse
        /// </returns>
        public RunTitleGenerationResponse RunTitleGeneration(RunTitleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTitleGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙笔：标题生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTitleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTitleGenerationResponse
        /// </returns>
        public async Task<RunTitleGenerationResponse> RunTitleGenerationAsync(RunTitleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTitleGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-中英文翻译</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTranslateGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTranslateGenerationResponse
        /// </returns>
        public RunTranslateGenerationResponse RunTranslateGenerationWithOptions(RunTranslateGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTranslateGenerationShrinkRequest request = new RunTranslateGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTranslateGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTranslateGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-中英文翻译</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTranslateGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTranslateGenerationResponse
        /// </returns>
        public async Task<RunTranslateGenerationResponse> RunTranslateGenerationWithOptionsAsync(RunTranslateGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTranslateGenerationShrinkRequest request = new RunTranslateGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTranslateGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTranslateGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-中英文翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTranslateGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTranslateGenerationResponse
        /// </returns>
        public RunTranslateGenerationResponse RunTranslateGeneration(RunTranslateGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTranslateGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-中英文翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTranslateGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTranslateGenerationResponse
        /// </returns>
        public async Task<RunTranslateGenerationResponse> RunTranslateGenerationAsync(RunTranslateGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTranslateGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-文风改写</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWriteToneGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWriteToneGenerationResponse
        /// </returns>
        public RunWriteToneGenerationResponse RunWriteToneGenerationWithOptions(RunWriteToneGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWriteToneGenerationShrinkRequest request = new RunWriteToneGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWriteToneGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWriteToneGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-文风改写</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWriteToneGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWriteToneGenerationResponse
        /// </returns>
        public async Task<RunWriteToneGenerationResponse> RunWriteToneGenerationWithOptionsAsync(RunWriteToneGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWriteToneGenerationShrinkRequest request = new RunWriteToneGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWriteToneGeneration",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWriteToneGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-文风改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWriteToneGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWriteToneGenerationResponse
        /// </returns>
        public RunWriteToneGenerationResponse RunWriteToneGeneration(RunWriteToneGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunWriteToneGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI妙笔-创作-文风改写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWriteToneGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWriteToneGenerationResponse
        /// </returns>
        public async Task<RunWriteToneGenerationResponse> RunWriteToneGenerationAsync(RunWriteToneGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunWriteToneGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWritingResponse
        /// </returns>
        public RunWritingResponse RunWritingWithOptions(RunWritingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWritingShrinkRequest request = new RunWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingConfig))
            {
                request.WritingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingConfig, "WritingConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSessionId))
            {
                body["OriginSessionId"] = request.OriginSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingConfigShrink))
            {
                body["WritingConfig"] = request.WritingConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWriting",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWritingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWritingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWritingResponse
        /// </returns>
        public async Task<RunWritingResponse> RunWritingWithOptionsAsync(RunWritingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWritingShrinkRequest request = new RunWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceData))
            {
                request.ReferenceDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceData, "ReferenceData", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingConfig))
            {
                request.WritingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingConfig, "WritingConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginSessionId))
            {
                body["OriginSessionId"] = request.OriginSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceDataShrink))
            {
                body["ReferenceData"] = request.ReferenceDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingConfigShrink))
            {
                body["WritingConfig"] = request.WritingConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWriting",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWritingResponse
        /// </returns>
        public RunWritingResponse RunWriting(RunWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunWritingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunWritingResponse
        /// </returns>
        public async Task<RunWritingResponse> RunWritingAsync(RunWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunWritingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWritingV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWritingV2Response
        /// </returns>
        public RunWritingV2Response RunWritingV2WithOptions(RunWritingV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWritingV2ShrinkRequest request = new RunWritingV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Articles))
            {
                request.ArticlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Articles, "Articles", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MiniDocs))
            {
                request.MiniDocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MiniDocs, "MiniDocs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Outlines))
            {
                request.OutlinesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Outlines, "Outlines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchSources))
            {
                request.SearchSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchSources, "SearchSources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Summarization))
            {
                request.SummarizationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Summarization, "Summarization", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingParams))
            {
                request.WritingParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingParams, "WritingParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticlesShrink))
            {
                body["Articles"] = request.ArticlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeWriting))
            {
                body["DistributeWriting"] = request.DistributeWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GcNumberSize))
            {
                body["GcNumberSize"] = request.GcNumberSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GcNumberSizeTag))
            {
                body["GcNumberSizeTag"] = request.GcNumberSizeTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniDocsShrink))
            {
                body["MiniDocs"] = request.MiniDocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutlinesShrink))
            {
                body["Outlines"] = request.OutlinesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptMode))
            {
                body["PromptMode"] = request.PromptMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSourcesShrink))
            {
                body["SearchSources"] = request.SearchSourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Step))
            {
                body["Step"] = request.Step;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummarizationShrink))
            {
                body["Summarization"] = request.SummarizationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSearch))
            {
                body["UseSearch"] = request.UseSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingParamsShrink))
            {
                body["WritingParams"] = request.WritingParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingScene))
            {
                body["WritingScene"] = request.WritingScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingStyle))
            {
                body["WritingStyle"] = request.WritingStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWritingV2",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWritingV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunWritingV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunWritingV2Response
        /// </returns>
        public async Task<RunWritingV2Response> RunWritingV2WithOptionsAsync(RunWritingV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunWritingV2ShrinkRequest request = new RunWritingV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Articles))
            {
                request.ArticlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Articles, "Articles", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MiniDocs))
            {
                request.MiniDocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MiniDocs, "MiniDocs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Outlines))
            {
                request.OutlinesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Outlines, "Outlines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchSources))
            {
                request.SearchSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchSources, "SearchSources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Summarization))
            {
                request.SummarizationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Summarization, "Summarization", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WritingParams))
            {
                request.WritingParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WritingParams, "WritingParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticlesShrink))
            {
                body["Articles"] = request.ArticlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeWriting))
            {
                body["DistributeWriting"] = request.DistributeWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GcNumberSize))
            {
                body["GcNumberSize"] = request.GcNumberSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GcNumberSizeTag))
            {
                body["GcNumberSizeTag"] = request.GcNumberSizeTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniDocsShrink))
            {
                body["MiniDocs"] = request.MiniDocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutlinesShrink))
            {
                body["Outlines"] = request.OutlinesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptMode))
            {
                body["PromptMode"] = request.PromptMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSourcesShrink))
            {
                body["SearchSources"] = request.SearchSourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Step))
            {
                body["Step"] = request.Step;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummarizationShrink))
            {
                body["Summarization"] = request.SummarizationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSearch))
            {
                body["UseSearch"] = request.UseSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingParamsShrink))
            {
                body["WritingParams"] = request.WritingParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingScene))
            {
                body["WritingScene"] = request.WritingScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingStyle))
            {
                body["WritingStyle"] = request.WritingStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunWritingV2",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunWritingV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWritingV2Request
        /// </param>
        /// 
        /// <returns>
        /// RunWritingV2Response
        /// </returns>
        public RunWritingV2Response RunWritingV2(RunWritingV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunWritingV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直接写作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunWritingV2Request
        /// </param>
        /// 
        /// <returns>
        /// RunWritingV2Response
        /// </returns>
        public async Task<RunWritingV2Response> RunWritingV2Async(RunWritingV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunWritingV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveCustomTextResponse
        /// </returns>
        public SaveCustomTextResponse SaveCustomTextWithOptions(SaveCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCustomTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveCustomTextResponse
        /// </returns>
        public async Task<SaveCustomTextResponse> SaveCustomTextWithOptionsAsync(SaveCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCustomTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveCustomTextResponse
        /// </returns>
        public SaveCustomTextResponse SaveCustomText(SaveCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveCustomTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveCustomTextResponse
        /// </returns>
        public async Task<SaveCustomTextResponse> SaveCustomTextAsync(SaveCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveCustomTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户的信源配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveDataSourceOrderConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveDataSourceOrderConfigResponse
        /// </returns>
        public SaveDataSourceOrderConfigResponse SaveDataSourceOrderConfigWithOptions(SaveDataSourceOrderConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveDataSourceOrderConfigShrinkRequest request = new SaveDataSourceOrderConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserConfigDataSourceList))
            {
                request.UserConfigDataSourceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserConfigDataSourceList, "UserConfigDataSourceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateTechnology))
            {
                body["GenerateTechnology"] = request.GenerateTechnology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConfigDataSourceListShrink))
            {
                body["UserConfigDataSourceList"] = request.UserConfigDataSourceListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveDataSourceOrderConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveDataSourceOrderConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户的信源配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveDataSourceOrderConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveDataSourceOrderConfigResponse
        /// </returns>
        public async Task<SaveDataSourceOrderConfigResponse> SaveDataSourceOrderConfigWithOptionsAsync(SaveDataSourceOrderConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveDataSourceOrderConfigShrinkRequest request = new SaveDataSourceOrderConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserConfigDataSourceList))
            {
                request.UserConfigDataSourceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserConfigDataSourceList, "UserConfigDataSourceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateTechnology))
            {
                body["GenerateTechnology"] = request.GenerateTechnology;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConfigDataSourceListShrink))
            {
                body["UserConfigDataSourceList"] = request.UserConfigDataSourceListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveDataSourceOrderConfig",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveDataSourceOrderConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户的信源配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDataSourceOrderConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveDataSourceOrderConfigResponse
        /// </returns>
        public SaveDataSourceOrderConfigResponse SaveDataSourceOrderConfig(SaveDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDataSourceOrderConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存用户的信源配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDataSourceOrderConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveDataSourceOrderConfigResponse
        /// </returns>
        public async Task<SaveDataSourceOrderConfigResponse> SaveDataSourceOrderConfigAsync(SaveDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDataSourceOrderConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存素材</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveMaterialDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMaterialDocumentResponse
        /// </returns>
        public SaveMaterialDocumentResponse SaveMaterialDocumentWithOptions(SaveMaterialDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveMaterialDocumentShrinkRequest request = new SaveMaterialDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocKeywords))
            {
                request.DocKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocKeywords, "DocKeywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Author))
            {
                body["Author"] = request.Author;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BothSavePrivateAndShare))
            {
                body["BothSavePrivateAndShare"] = request.BothSavePrivateAndShare;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKeywordsShrink))
            {
                body["DocKeywords"] = request.DocKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUrl))
            {
                body["ExternalUrl"] = request.ExternalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubTime))
            {
                body["PubTime"] = request.PubTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFrom))
            {
                body["SrcFrom"] = request.SrcFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["TextContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMaterialDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMaterialDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存素材</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveMaterialDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveMaterialDocumentResponse
        /// </returns>
        public async Task<SaveMaterialDocumentResponse> SaveMaterialDocumentWithOptionsAsync(SaveMaterialDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveMaterialDocumentShrinkRequest request = new SaveMaterialDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocKeywords))
            {
                request.DocKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocKeywords, "DocKeywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Author))
            {
                body["Author"] = request.Author;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BothSavePrivateAndShare))
            {
                body["BothSavePrivateAndShare"] = request.BothSavePrivateAndShare;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKeywordsShrink))
            {
                body["DocKeywords"] = request.DocKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUrl))
            {
                body["ExternalUrl"] = request.ExternalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubTime))
            {
                body["PubTime"] = request.PubTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFrom))
            {
                body["SrcFrom"] = request.SrcFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["TextContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveMaterialDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveMaterialDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaterialDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMaterialDocumentResponse
        /// </returns>
        public SaveMaterialDocumentResponse SaveMaterialDocument(SaveMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMaterialDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveMaterialDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveMaterialDocumentResponse
        /// </returns>
        public async Task<SaveMaterialDocumentResponse> SaveMaterialDocumentAsync(SaveMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMaterialDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文体</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStyleLearningResultResponse
        /// </returns>
        public SaveStyleLearningResultResponse SaveStyleLearningResultWithOptions(SaveStyleLearningResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveStyleLearningResultShrinkRequest request = new SaveStyleLearningResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomTextIdList))
            {
                request.CustomTextIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomTextIdList, "CustomTextIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MaterialIdList))
            {
                request.MaterialIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MaterialIdList, "MaterialIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                body["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AigcResult))
            {
                body["AigcResult"] = request.AigcResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTextIdListShrink))
            {
                body["CustomTextIdList"] = request.CustomTextIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIdListShrink))
            {
                body["MaterialIdList"] = request.MaterialIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteResult))
            {
                body["RewriteResult"] = request.RewriteResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleName))
            {
                body["StyleName"] = request.StyleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStyleLearningResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文体</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveStyleLearningResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveStyleLearningResultResponse
        /// </returns>
        public async Task<SaveStyleLearningResultResponse> SaveStyleLearningResultWithOptionsAsync(SaveStyleLearningResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveStyleLearningResultShrinkRequest request = new SaveStyleLearningResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomTextIdList))
            {
                request.CustomTextIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomTextIdList, "CustomTextIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MaterialIdList))
            {
                request.MaterialIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MaterialIdList, "MaterialIdList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                body["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AigcResult))
            {
                body["AigcResult"] = request.AigcResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTextIdListShrink))
            {
                body["CustomTextIdList"] = request.CustomTextIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIdListShrink))
            {
                body["MaterialIdList"] = request.MaterialIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteResult))
            {
                body["RewriteResult"] = request.RewriteResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleName))
            {
                body["StyleName"] = request.StyleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveStyleLearningResult",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveStyleLearningResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStyleLearningResultResponse
        /// </returns>
        public SaveStyleLearningResultResponse SaveStyleLearningResult(SaveStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveStyleLearningResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存自定义文体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveStyleLearningResultRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveStyleLearningResultResponse
        /// </returns>
        public async Task<SaveStyleLearningResultResponse> SaveStyleLearningResultAsync(SaveStyleLearningResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveStyleLearningResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDatasetDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchDatasetDocumentsResponse
        /// </returns>
        public SearchDatasetDocumentsResponse SearchDatasetDocumentsWithOptions(SearchDatasetDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend1))
            {
                body["Extend1"] = request.Extend1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDatasetDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDatasetDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDatasetDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchDatasetDocumentsResponse
        /// </returns>
        public async Task<SearchDatasetDocumentsResponse> SearchDatasetDocumentsWithOptionsAsync(SearchDatasetDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend1))
            {
                body["Extend1"] = request.Extend1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchDatasetDocuments",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchDatasetDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDatasetDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchDatasetDocumentsResponse
        /// </returns>
        public SearchDatasetDocumentsResponse SearchDatasetDocuments(SearchDatasetDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchDatasetDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchDatasetDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchDatasetDocumentsResponse
        /// </returns>
        public async Task<SearchDatasetDocumentsResponse> SearchDatasetDocumentsAsync(SearchDatasetDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchDatasetDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchNewsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchNewsResponse
        /// </returns>
        public SearchNewsResponse SearchNewsWithOptions(SearchNewsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchNewsShrinkRequest request = new SearchNewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchSources))
            {
                request.SearchSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchSources, "SearchSources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterNotNull))
            {
                body["FilterNotNull"] = request.FilterNotNull;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSourcesShrink))
            {
                body["SearchSources"] = request.SearchSourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchNews",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchNewsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchNewsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchNewsResponse
        /// </returns>
        public async Task<SearchNewsResponse> SearchNewsWithOptionsAsync(SearchNewsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchNewsShrinkRequest request = new SearchNewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchSources))
            {
                request.SearchSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchSources, "SearchSources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterNotNull))
            {
                body["FilterNotNull"] = request.FilterNotNull;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeContent))
            {
                body["IncludeContent"] = request.IncludeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchSourcesShrink))
            {
                body["SearchSources"] = request.SearchSourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchNews",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchNewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchNewsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchNewsResponse
        /// </returns>
        public SearchNewsResponse SearchNews(SearchNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchNewsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchNewsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchNewsResponse
        /// </returns>
        public async Task<SearchNewsResponse> SearchNewsAsync(SearchNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchNewsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsyncTaskResponse
        /// </returns>
        public SubmitAsyncTaskResponse SubmitAsyncTaskWithOptions(SubmitAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                body["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecuteTime))
            {
                body["TaskExecuteTime"] = request.TaskExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParam))
            {
                body["TaskParam"] = request.TaskParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsyncTaskResponse
        /// </returns>
        public async Task<SubmitAsyncTaskResponse> SubmitAsyncTaskWithOptionsAsync(SubmitAsyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCode))
            {
                body["TaskCode"] = request.TaskCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecuteTime))
            {
                body["TaskExecuteTime"] = request.TaskExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskParam))
            {
                body["TaskParam"] = request.TaskParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAsyncTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsyncTaskResponse
        /// </returns>
        public SubmitAsyncTaskResponse SubmitAsyncTask(SubmitAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAsyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAsyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAsyncTaskResponse
        /// </returns>
        public async Task<SubmitAsyncTaskResponse> SubmitAsyncTaskAsync(SubmitAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAsyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAuditTaskResponse
        /// </returns>
        public SubmitAuditTaskResponse SubmitAuditTaskWithOptions(SubmitAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAuditTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAuditTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAuditTaskResponse
        /// </returns>
        public async Task<SubmitAuditTaskResponse> SubmitAuditTaskWithOptionsAsync(SubmitAuditTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["ArticleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAuditTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAuditTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAuditTaskResponse
        /// </returns>
        public SubmitAuditTaskResponse SubmitAuditTask(SubmitAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAuditTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审核任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAuditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAuditTaskResponse
        /// </returns>
        public async Task<SubmitAuditTaskResponse> SubmitAuditTaskAsync(SubmitAuditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAuditTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义播报单任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitCustomHotTopicBroadcastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomHotTopicBroadcastJobResponse
        /// </returns>
        public SubmitCustomHotTopicBroadcastJobResponse SubmitCustomHotTopicBroadcastJobWithOptions(SubmitCustomHotTopicBroadcastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitCustomHotTopicBroadcastJobShrinkRequest request = new SubmitCustomHotTopicBroadcastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotTopicBroadcastConfig))
            {
                request.HotTopicBroadcastConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotTopicBroadcastConfig, "HotTopicBroadcastConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicBroadcastConfigShrink))
            {
                body["HotTopicBroadcastConfig"] = request.HotTopicBroadcastConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["HotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomHotTopicBroadcastJob",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomHotTopicBroadcastJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义播报单任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitCustomHotTopicBroadcastJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomHotTopicBroadcastJobResponse
        /// </returns>
        public async Task<SubmitCustomHotTopicBroadcastJobResponse> SubmitCustomHotTopicBroadcastJobWithOptionsAsync(SubmitCustomHotTopicBroadcastJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitCustomHotTopicBroadcastJobShrinkRequest request = new SubmitCustomHotTopicBroadcastJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotTopicBroadcastConfig))
            {
                request.HotTopicBroadcastConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotTopicBroadcastConfig, "HotTopicBroadcastConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Topics))
            {
                request.TopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Topics, "Topics", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicBroadcastConfigShrink))
            {
                body["HotTopicBroadcastConfig"] = request.HotTopicBroadcastConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["HotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicsShrink))
            {
                body["Topics"] = request.TopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomHotTopicBroadcastJob",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomHotTopicBroadcastJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义播报单任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCustomHotTopicBroadcastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomHotTopicBroadcastJobResponse
        /// </returns>
        public SubmitCustomHotTopicBroadcastJobResponse SubmitCustomHotTopicBroadcastJob(SubmitCustomHotTopicBroadcastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCustomHotTopicBroadcastJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义播报单任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCustomHotTopicBroadcastJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomHotTopicBroadcastJobResponse
        /// </returns>
        public async Task<SubmitCustomHotTopicBroadcastJobResponse> SubmitCustomHotTopicBroadcastJobAsync(SubmitCustomHotTopicBroadcastJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCustomHotTopicBroadcastJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义热点选题视角分析任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitCustomTopicSelectionPerspectiveAnalysisTaskShrinkRequest request = new SubmitCustomTopicSelectionPerspectiveAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义热点选题视角分析任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse> SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitCustomTopicSelectionPerspectiveAnalysisTaskShrinkRequest request = new SubmitCustomTopicSelectionPerspectiveAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义热点选题视角分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse SubmitCustomTopicSelectionPerspectiveAnalysisTask(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交自定义热点选题视角分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse> SubmitCustomTopicSelectionPerspectiveAnalysisTaskAsync(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文档聚合任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitDocClusterTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocClusterTaskResponse
        /// </returns>
        public SubmitDocClusterTaskResponse SubmitDocClusterTaskWithOptions(SubmitDocClusterTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDocClusterTaskShrinkRequest request = new SubmitDocClusterTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryLength))
            {
                body["SummaryLength"] = request.SummaryLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitleLength))
            {
                body["TitleLength"] = request.TitleLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicCount))
            {
                body["TopicCount"] = request.TopicCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocClusterTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocClusterTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文档聚合任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitDocClusterTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocClusterTaskResponse
        /// </returns>
        public async Task<SubmitDocClusterTaskResponse> SubmitDocClusterTaskWithOptionsAsync(SubmitDocClusterTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDocClusterTaskShrinkRequest request = new SubmitDocClusterTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SummaryLength))
            {
                body["SummaryLength"] = request.SummaryLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TitleLength))
            {
                body["TitleLength"] = request.TitleLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicCount))
            {
                body["TopicCount"] = request.TopicCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocClusterTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocClusterTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文档聚合任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocClusterTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocClusterTaskResponse
        /// </returns>
        public SubmitDocClusterTaskResponse SubmitDocClusterTask(SubmitDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocClusterTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交文档聚合任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocClusterTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocClusterTaskResponse
        /// </returns>
        public async Task<SubmitDocClusterTaskResponse> SubmitDocClusterTaskAsync(SubmitDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDocClusterTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public SubmitEnterpriseVocAnalysisTaskResponse SubmitEnterpriseVocAnalysisTaskWithOptions(SubmitEnterpriseVocAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitEnterpriseVocAnalysisTaskShrinkRequest request = new SubmitEnterpriseVocAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContentTags))
            {
                request.ContentTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContentTags, "ContentTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "FilterTags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentTagsShrink))
            {
                body["ContentTags"] = request.ContentTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["FilterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                body["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositiveSample))
            {
                body["PositiveSample"] = request.PositiveSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositiveSampleFileKey))
            {
                body["PositiveSampleFileKey"] = request.PositiveSampleFileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEnterpriseVocAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEnterpriseVocAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitEnterpriseVocAnalysisTaskResponse> SubmitEnterpriseVocAnalysisTaskWithOptionsAsync(SubmitEnterpriseVocAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitEnterpriseVocAnalysisTaskShrinkRequest request = new SubmitEnterpriseVocAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContentTags))
            {
                request.ContentTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContentTags, "ContentTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "Contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "FilterTags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentTagsShrink))
            {
                body["ContentTags"] = request.ContentTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["Contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["FilterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                body["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositiveSample))
            {
                body["PositiveSample"] = request.PositiveSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositiveSampleFileKey))
            {
                body["PositiveSampleFileKey"] = request.PositiveSampleFileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEnterpriseVocAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEnterpriseVocAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public SubmitEnterpriseVocAnalysisTaskResponse SubmitEnterpriseVocAnalysisTask(SubmitEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEnterpriseVocAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitEnterpriseVocAnalysisTaskResponse> SubmitEnterpriseVocAnalysisTaskAsync(SubmitEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEnterpriseVocAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitSmartClipTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmartClipTaskResponse
        /// </returns>
        public SubmitSmartClipTaskResponse SubmitSmartClipTaskWithOptions(SubmitSmartClipTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmartClipTaskShrinkRequest request = new SubmitSmartClipTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EditingConfig))
            {
                request.EditingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EditingConfig, "EditingConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputConfig))
            {
                request.InputConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputConfig, "InputConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputConfig))
            {
                request.OutputConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputConfig, "OutputConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfigShrink))
            {
                body["EditingConfig"] = request.EditingConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendParam))
            {
                body["ExtendParam"] = request.ExtendParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfigShrink))
            {
                body["InputConfig"] = request.InputConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfigShrink))
            {
                body["OutputConfig"] = request.OutputConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmartClipTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmartClipTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitSmartClipTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmartClipTaskResponse
        /// </returns>
        public async Task<SubmitSmartClipTaskResponse> SubmitSmartClipTaskWithOptionsAsync(SubmitSmartClipTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmartClipTaskShrinkRequest request = new SubmitSmartClipTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EditingConfig))
            {
                request.EditingConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EditingConfig, "EditingConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputConfig))
            {
                request.InputConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputConfig, "InputConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputConfig))
            {
                request.OutputConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputConfig, "OutputConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfigShrink))
            {
                body["EditingConfig"] = request.EditingConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendParam))
            {
                body["ExtendParam"] = request.ExtendParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfigShrink))
            {
                body["InputConfig"] = request.InputConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfigShrink))
            {
                body["OutputConfig"] = request.OutputConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSmartClipTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmartClipTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSmartClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmartClipTaskResponse
        /// </returns>
        public SubmitSmartClipTaskResponse SubmitSmartClipTask(SubmitSmartClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmartClipTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交一键成片剪辑任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitSmartClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSmartClipTaskResponse
        /// </returns>
        public async Task<SubmitSmartClipTaskResponse> SubmitSmartClipTaskAsync(SubmitSmartClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmartClipTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交选题热点分析任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public SubmitTopicSelectionPerspectiveAnalysisTaskResponse SubmitTopicSelectionPerspectiveAnalysisTaskWithOptions(SubmitTopicSelectionPerspectiveAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest request = new SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PerspectiveTypes))
            {
                request.PerspectiveTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PerspectiveTypes, "PerspectiveTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveTypesShrink))
            {
                body["PerspectiveTypes"] = request.PerspectiveTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTopicSelectionPerspectiveAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交选题热点分析任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitTopicSelectionPerspectiveAnalysisTaskResponse> SubmitTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(SubmitTopicSelectionPerspectiveAnalysisTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest request = new SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Documents))
            {
                request.DocumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Documents, "Documents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PerspectiveTypes))
            {
                request.PerspectiveTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PerspectiveTypes, "PerspectiveTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentsShrink))
            {
                body["Documents"] = request.DocumentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerspectiveTypesShrink))
            {
                body["PerspectiveTypes"] = request.PerspectiveTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTopicSelectionPerspectiveAnalysisTask",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTopicSelectionPerspectiveAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交选题热点分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public SubmitTopicSelectionPerspectiveAnalysisTaskResponse SubmitTopicSelectionPerspectiveAnalysisTask(SubmitTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交选题热点分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTopicSelectionPerspectiveAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTopicSelectionPerspectiveAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitTopicSelectionPerspectiveAnalysisTaskResponse> SubmitTopicSelectionPerspectiveAnalysisTaskAsync(SubmitTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomTextResponse
        /// </returns>
        public UpdateCustomTextResponse UpdateCustomTextWithOptions(UpdateCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomTextResponse
        /// </returns>
        public async Task<UpdateCustomTextResponse> UpdateCustomTextWithOptionsAsync(UpdateCustomTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomText",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomTextResponse
        /// </returns>
        public UpdateCustomTextResponse UpdateCustomText(UpdateCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义文本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomTextRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomTextResponse
        /// </returns>
        public async Task<UpdateCustomTextResponse> UpdateCustomTextAsync(UpdateCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-更新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDatasetWithOptions(UpdateDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDatasetShrinkRequest request = new UpdateDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetConfig))
            {
                request.DatasetConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetConfig, "DatasetConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetConfigShrink))
            {
                body["DatasetConfig"] = request.DatasetConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-更新</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(UpdateDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDatasetShrinkRequest request = new UpdateDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DatasetConfig))
            {
                request.DatasetConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DatasetConfig, "DatasetConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetConfigShrink))
            {
                body["DatasetConfig"] = request.DatasetConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetDescription))
            {
                body["DatasetDescription"] = request.DatasetDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchDatasetEnable))
            {
                body["SearchDatasetEnable"] = request.SearchDatasetEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>数据集管理-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据集文档</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetDocumentResponse
        /// </returns>
        public UpdateDatasetDocumentResponse UpdateDatasetDocumentWithOptions(UpdateDatasetDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDatasetDocumentShrinkRequest request = new UpdateDatasetDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Document))
            {
                request.DocumentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Document, "Document", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentShrink))
            {
                body["Document"] = request.DocumentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据集文档</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDatasetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetDocumentResponse
        /// </returns>
        public async Task<UpdateDatasetDocumentResponse> UpdateDatasetDocumentWithOptionsAsync(UpdateDatasetDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDatasetDocumentShrinkRequest request = new UpdateDatasetDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Document))
            {
                request.DocumentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Document, "Document", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentShrink))
            {
                body["Document"] = request.DocumentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetDocumentResponse
        /// </returns>
        public UpdateDatasetDocumentResponse UpdateDatasetDocument(UpdateDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDatasetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据集文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetDocumentResponse
        /// </returns>
        public async Task<UpdateDatasetDocumentResponse> UpdateDatasetDocumentAsync(UpdateDatasetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDatasetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-更新。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGeneratedContentResponse
        /// </returns>
        public UpdateGeneratedContentResponse UpdateGeneratedContentWithOptions(UpdateGeneratedContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGeneratedContentShrinkRequest request = new UpdateGeneratedContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentText))
            {
                body["ContentText"] = request.ContentText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGeneratedContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-更新。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateGeneratedContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGeneratedContentResponse
        /// </returns>
        public async Task<UpdateGeneratedContentResponse> UpdateGeneratedContentWithOptionsAsync(UpdateGeneratedContentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateGeneratedContentShrinkRequest request = new UpdateGeneratedContentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keywords))
            {
                request.KeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keywords, "Keywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentText))
            {
                body["ContentText"] = request.ContentText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsShrink))
            {
                body["Keywords"] = request.KeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGeneratedContent",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGeneratedContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-更新。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGeneratedContentResponse
        /// </returns>
        public UpdateGeneratedContentResponse UpdateGeneratedContent(UpdateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGeneratedContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档管理-更新。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGeneratedContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGeneratedContentResponse
        /// </returns>
        public async Task<UpdateGeneratedContentResponse> UpdateGeneratedContentAsync(UpdateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGeneratedContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID更新素材</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateMaterialDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMaterialDocumentResponse
        /// </returns>
        public UpdateMaterialDocumentResponse UpdateMaterialDocumentWithOptions(UpdateMaterialDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMaterialDocumentShrinkRequest request = new UpdateMaterialDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocKeywords))
            {
                request.DocKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocKeywords, "DocKeywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Author))
            {
                body["Author"] = request.Author;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKeywordsShrink))
            {
                body["DocKeywords"] = request.DocKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUrl))
            {
                body["ExternalUrl"] = request.ExternalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubTime))
            {
                body["PubTime"] = request.PubTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFrom))
            {
                body["SrcFrom"] = request.SrcFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["TextContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMaterialDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMaterialDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID更新素材</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateMaterialDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMaterialDocumentResponse
        /// </returns>
        public async Task<UpdateMaterialDocumentResponse> UpdateMaterialDocumentWithOptionsAsync(UpdateMaterialDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMaterialDocumentShrinkRequest request = new UpdateMaterialDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocKeywords))
            {
                request.DocKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocKeywords, "DocKeywords", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Author))
            {
                body["Author"] = request.Author;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocKeywordsShrink))
            {
                body["DocKeywords"] = request.DocKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocType))
            {
                body["DocType"] = request.DocType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUrl))
            {
                body["ExternalUrl"] = request.ExternalUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HtmlContent))
            {
                body["HtmlContent"] = request.HtmlContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubTime))
            {
                body["PubTime"] = request.PubTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareAttr))
            {
                body["ShareAttr"] = request.ShareAttr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcFrom))
            {
                body["SrcFrom"] = request.SrcFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                body["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["TextContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMaterialDocument",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMaterialDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID更新素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMaterialDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMaterialDocumentResponse
        /// </returns>
        public UpdateMaterialDocumentResponse UpdateMaterialDocument(UpdateMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMaterialDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID更新素材</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMaterialDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMaterialDocumentResponse
        /// </returns>
        public async Task<UpdateMaterialDocumentResponse> UpdateMaterialDocumentAsync(UpdateMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMaterialDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传书籍</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadBookResponse
        /// </returns>
        public UploadBookResponse UploadBookWithOptions(UploadBookRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadBookShrinkRequest request = new UploadBookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Docs))
            {
                request.DocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Docs, "Docs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocsShrink))
            {
                body["Docs"] = request.DocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadBook",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadBookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传书籍</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadBookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadBookResponse
        /// </returns>
        public async Task<UploadBookResponse> UploadBookWithOptionsAsync(UploadBookRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadBookShrinkRequest request = new UploadBookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Docs))
            {
                request.DocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Docs, "Docs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocsShrink))
            {
                body["Docs"] = request.DocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadBook",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传书籍</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBookRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadBookResponse
        /// </returns>
        public UploadBookResponse UploadBook(UploadBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadBookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传书籍</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadBookRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadBookResponse
        /// </returns>
        public async Task<UploadBookResponse> UploadBookAsync(UploadBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadBookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传文档接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadDocRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocResponse
        /// </returns>
        public UploadDocResponse UploadDocWithOptions(UploadDocRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadDocShrinkRequest request = new UploadDocShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Docs))
            {
                request.DocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Docs, "Docs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocsShrink))
            {
                body["Docs"] = request.DocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDoc",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传文档接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadDocRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocResponse
        /// </returns>
        public async Task<UploadDocResponse> UploadDocWithOptionsAsync(UploadDocRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadDocShrinkRequest request = new UploadDocShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Docs))
            {
                request.DocsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Docs, "Docs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocsShrink))
            {
                body["Docs"] = request.DocsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDoc",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传文档接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocResponse
        /// </returns>
        public UploadDocResponse UploadDoc(UploadDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDocWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>妙读上传文档接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocResponse
        /// </returns>
        public async Task<UploadDocResponse> UploadDocAsync(UploadDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDocWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验企业VOC上传模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateUploadTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateUploadTemplateResponse
        /// </returns>
        public ValidateUploadTemplateResponse ValidateUploadTemplateWithOptions(ValidateUploadTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateUploadTemplate",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateUploadTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验企业VOC上传模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateUploadTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateUploadTemplateResponse
        /// </returns>
        public async Task<ValidateUploadTemplateResponse> ValidateUploadTemplateWithOptionsAsync(ValidateUploadTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["FileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateUploadTemplate",
                Version = "2023-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateUploadTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验企业VOC上传模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateUploadTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateUploadTemplateResponse
        /// </returns>
        public ValidateUploadTemplateResponse ValidateUploadTemplate(ValidateUploadTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateUploadTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验企业VOC上传模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateUploadTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateUploadTemplateResponse
        /// </returns>
        public async Task<ValidateUploadTemplateResponse> ValidateUploadTemplateAsync(ValidateUploadTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateUploadTemplateWithOptionsAsync(request, runtime);
        }

    }
}
