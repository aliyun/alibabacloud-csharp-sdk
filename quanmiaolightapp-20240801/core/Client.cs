// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quanmiaolightapp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>取消异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelAsyncTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public CancelAsyncTaskResponse CancelAsyncTaskWithOptions(string workspaceId, CancelAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/cancelAsyncTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
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
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelAsyncTaskResponse
        /// </returns>
        public async Task<CancelAsyncTaskResponse> CancelAsyncTaskWithOptionsAsync(string workspaceId, CancelAsyncTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelAsyncTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/cancelAsyncTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
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
        public CancelAsyncTaskResponse CancelAsyncTask(string workspaceId, CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelAsyncTaskWithOptions(workspaceId, request, headers, runtime);
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
        public async Task<CancelAsyncTaskResponse> CancelAsyncTaskAsync(string workspaceId, CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelAsyncTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出挖掘任务明细</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ExportAnalysisTagDetailByTaskIdResponse ExportAnalysisTagDetailByTaskIdWithOptions(string workspaceId, ExportAnalysisTagDetailByTaskIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportAnalysisTagDetailByTaskIdShrinkRequest request = new ExportAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnalysisTagDetailByTaskId",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/exportAnalysisTagDetailByTaskId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnalysisTagDetailByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出挖掘任务明细</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ExportAnalysisTagDetailByTaskIdResponse> ExportAnalysisTagDetailByTaskIdWithOptionsAsync(string workspaceId, ExportAnalysisTagDetailByTaskIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportAnalysisTagDetailByTaskIdShrinkRequest request = new ExportAnalysisTagDetailByTaskIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Categories))
            {
                request.CategoriesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Categories, "categories", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoriesShrink))
            {
                body["categories"] = request.CategoriesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportAnalysisTagDetailByTaskId",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/exportAnalysisTagDetailByTaskId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportAnalysisTagDetailByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出挖掘任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ExportAnalysisTagDetailByTaskIdResponse ExportAnalysisTagDetailByTaskId(string workspaceId, ExportAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportAnalysisTagDetailByTaskIdWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导出挖掘任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ExportAnalysisTagDetailByTaskIdResponse> ExportAnalysisTagDetailByTaskIdAsync(string workspaceId, ExportAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportAnalysisTagDetailByTaskIdWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻播报-抽取分类获取播报热点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateBroadcastNewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateBroadcastNewsResponse
        /// </returns>
        public GenerateBroadcastNewsResponse GenerateBroadcastNewsWithOptions(string workspaceId, GenerateBroadcastNewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateBroadcastNews",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/GenerateBroadcastNews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateBroadcastNewsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻播报-抽取分类获取播报热点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateBroadcastNewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateBroadcastNewsResponse
        /// </returns>
        public async Task<GenerateBroadcastNewsResponse> GenerateBroadcastNewsWithOptionsAsync(string workspaceId, GenerateBroadcastNewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateBroadcastNews",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/GenerateBroadcastNews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateBroadcastNewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻播报-抽取分类获取播报热点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateBroadcastNewsRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateBroadcastNewsResponse
        /// </returns>
        public GenerateBroadcastNewsResponse GenerateBroadcastNews(string workspaceId, GenerateBroadcastNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateBroadcastNewsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新闻播报-抽取分类获取播报热点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateBroadcastNewsRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateBroadcastNewsResponse
        /// </returns>
        public async Task<GenerateBroadcastNewsResponse> GenerateBroadcastNewsAsync(string workspaceId, GenerateBroadcastNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateBroadcastNewsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘-获取示例输出格式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateOutputFormatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateOutputFormatResponse
        /// </returns>
        public GenerateOutputFormatResponse GenerateOutputFormatWithOptions(string workspaceId, GenerateOutputFormatRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateOutputFormatShrinkRequest request = new GenerateOutputFormatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateOutputFormat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/generateOutputFormat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOutputFormatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘-获取示例输出格式</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenerateOutputFormatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateOutputFormatResponse
        /// </returns>
        public async Task<GenerateOutputFormatResponse> GenerateOutputFormatWithOptionsAsync(string workspaceId, GenerateOutputFormatRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateOutputFormatShrinkRequest request = new GenerateOutputFormatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateOutputFormat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/generateOutputFormat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOutputFormatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘-获取示例输出格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOutputFormatRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateOutputFormatResponse
        /// </returns>
        public GenerateOutputFormatResponse GenerateOutputFormat(string workspaceId, GenerateOutputFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateOutputFormatWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘-获取示例输出格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOutputFormatRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateOutputFormatResponse
        /// </returns>
        public async Task<GenerateOutputFormatResponse> GenerateOutputFormatAsync(string workspaceId, GenerateOutputFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateOutputFormatWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业VOC分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public GetEnterpriseVocAnalysisTaskResponse GetEnterpriseVocAnalysisTaskWithOptions(string workspaceId, GetEnterpriseVocAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEnterpriseVocAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/getEnterpriseVocAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<GetEnterpriseVocAnalysisTaskResponse> GetEnterpriseVocAnalysisTaskWithOptionsAsync(string workspaceId, GetEnterpriseVocAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetEnterpriseVocAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/getEnterpriseVocAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
        public GetEnterpriseVocAnalysisTaskResponse GetEnterpriseVocAnalysisTask(string workspaceId, GetEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnterpriseVocAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
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
        public async Task<GetEnterpriseVocAnalysisTaskResponse> GetEnterpriseVocAnalysisTaskAsync(string workspaceId, GetEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnterpriseVocAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagMiningAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTagMiningAnalysisTaskResponse
        /// </returns>
        public GetTagMiningAnalysisTaskResponse GetTagMiningAnalysisTaskWithOptions(string workspaceId, GetTagMiningAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTagMiningAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/getTagMiningAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTagMiningAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagMiningAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTagMiningAnalysisTaskResponse
        /// </returns>
        public async Task<GetTagMiningAnalysisTaskResponse> GetTagMiningAnalysisTaskWithOptionsAsync(string workspaceId, GetTagMiningAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTagMiningAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/getTagMiningAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTagMiningAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagMiningAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTagMiningAnalysisTaskResponse
        /// </returns>
        public GetTagMiningAnalysisTaskResponse GetTagMiningAnalysisTask(string workspaceId, GetTagMiningAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTagMiningAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagMiningAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTagMiningAnalysisTaskResponse
        /// </returns>
        public async Task<GetTagMiningAnalysisTaskResponse> GetTagMiningAnalysisTaskAsync(string workspaceId, GetTagMiningAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTagMiningAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-获取配置</para>
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
        /// GetVideoAnalysisConfigResponse
        /// </returns>
        public GetVideoAnalysisConfigResponse GetVideoAnalysisConfigWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoAnalysisConfig",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/getVideoAnalysisConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoAnalysisConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-获取配置</para>
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
        /// GetVideoAnalysisConfigResponse
        /// </returns>
        public async Task<GetVideoAnalysisConfigResponse> GetVideoAnalysisConfigWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoAnalysisConfig",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/getVideoAnalysisConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoAnalysisConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-获取配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVideoAnalysisConfigResponse
        /// </returns>
        public GetVideoAnalysisConfigResponse GetVideoAnalysisConfig(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoAnalysisConfigWithOptions(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-获取配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetVideoAnalysisConfigResponse
        /// </returns>
        public async Task<GetVideoAnalysisConfigResponse> GetVideoAnalysisConfigAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoAnalysisConfigWithOptionsAsync(workspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-获取视频理解异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoAnalysisTaskResponse
        /// </returns>
        public GetVideoAnalysisTaskResponse GetVideoAnalysisTaskWithOptions(string workspaceId, GetVideoAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/getVideoAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-获取视频理解异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoAnalysisTaskResponse
        /// </returns>
        public async Task<GetVideoAnalysisTaskResponse> GetVideoAnalysisTaskWithOptionsAsync(string workspaceId, GetVideoAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/getVideoAnalysisTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-获取视频理解异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoAnalysisTaskResponse
        /// </returns>
        public GetVideoAnalysisTaskResponse GetVideoAnalysisTask(string workspaceId, GetVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVideoAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-获取视频理解异步任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoAnalysisTaskResponse
        /// </returns>
        public async Task<GetVideoAnalysisTaskResponse> GetVideoAnalysisTaskAsync(string workspaceId, GetVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVideoAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析结果明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ListAnalysisTagDetailByTaskIdResponse ListAnalysisTagDetailByTaskIdWithOptions(string workspaceId, ListAnalysisTagDetailByTaskIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAnalysisTagDetailByTaskId",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/listAnalysisTagDetailByTaskId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisTagDetailByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析结果明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ListAnalysisTagDetailByTaskIdResponse> ListAnalysisTagDetailByTaskIdWithOptionsAsync(string workspaceId, ListAnalysisTagDetailByTaskIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAnalysisTagDetailByTaskId",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/listAnalysisTagDetailByTaskId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnalysisTagDetailByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析结果明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public ListAnalysisTagDetailByTaskIdResponse ListAnalysisTagDetailByTaskId(string workspaceId, ListAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnalysisTagDetailByTaskIdWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取挖掘分析结果明细列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnalysisTagDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnalysisTagDetailByTaskIdResponse
        /// </returns>
        public async Task<ListAnalysisTagDetailByTaskIdResponse> ListAnalysisTagDetailByTaskIdAsync(string workspaceId, ListAnalysisTagDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnalysisTagDetailByTaskIdWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-新闻播报-获取热点话题摘要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicSummariesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicSummariesResponse
        /// </returns>
        public ListHotTopicSummariesResponse ListHotTopicSummariesWithOptions(string workspaceId, ListHotTopicSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopic))
            {
                body["hotTopic"] = request.HotTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotTopicSummaries",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/listHotTopicSummaries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotTopicSummariesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-新闻播报-获取热点话题摘要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicSummariesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicSummariesResponse
        /// </returns>
        public async Task<ListHotTopicSummariesResponse> ListHotTopicSummariesWithOptionsAsync(string workspaceId, ListHotTopicSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopic))
            {
                body["hotTopic"] = request.HotTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotTopicSummaries",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/listHotTopicSummaries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotTopicSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-新闻播报-获取热点话题摘要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicSummariesResponse
        /// </returns>
        public ListHotTopicSummariesResponse ListHotTopicSummaries(string workspaceId, ListHotTopicSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHotTopicSummariesWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-新闻播报-获取热点话题摘要列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHotTopicSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotTopicSummariesResponse
        /// </returns>
        public async Task<ListHotTopicSummariesResponse> ListHotTopicSummariesAsync(string workspaceId, ListHotTopicSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHotTopicSummariesWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业VOC分析</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunEnterpriseVocAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunEnterpriseVocAnalysisResponse
        /// </returns>
        public RunEnterpriseVocAnalysisResponse RunEnterpriseVocAnalysisWithOptions(string workspaceId, RunEnterpriseVocAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunEnterpriseVocAnalysisShrinkRequest request = new RunEnterpriseVocAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "filterTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProxy))
            {
                body["akProxy"] = request.AkProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["filterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunEnterpriseVocAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runEnterpriseVocAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunEnterpriseVocAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业VOC分析</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunEnterpriseVocAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunEnterpriseVocAnalysisResponse
        /// </returns>
        public async Task<RunEnterpriseVocAnalysisResponse> RunEnterpriseVocAnalysisWithOptionsAsync(string workspaceId, RunEnterpriseVocAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunEnterpriseVocAnalysisShrinkRequest request = new RunEnterpriseVocAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "filterTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProxy))
            {
                body["akProxy"] = request.AkProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["filterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunEnterpriseVocAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runEnterpriseVocAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunEnterpriseVocAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业VOC分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunEnterpriseVocAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunEnterpriseVocAnalysisResponse
        /// </returns>
        public RunEnterpriseVocAnalysisResponse RunEnterpriseVocAnalysis(string workspaceId, RunEnterpriseVocAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunEnterpriseVocAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>企业VOC分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunEnterpriseVocAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunEnterpriseVocAnalysisResponse
        /// </returns>
        public async Task<RunEnterpriseVocAnalysisResponse> RunEnterpriseVocAnalysisAsync(string workspaceId, RunEnterpriseVocAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunEnterpriseVocAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunHotTopicChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicChatResponse
        /// </returns>
        public RunHotTopicChatResponse RunHotTopicChatWithOptions(string workspaceId, RunHotTopicChatRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunHotTopicChatShrinkRequest request = new RunHotTopicChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotTopics))
            {
                request.HotTopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotTopics, "hotTopics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "messages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForBroadcastContentConfig))
            {
                request.StepForBroadcastContentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForBroadcastContentConfig, "stepForBroadcastContentConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicsShrink))
            {
                body["hotTopics"] = request.HotTopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                body["messages"] = request.MessagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForBroadcastContentConfigShrink))
            {
                body["stepForBroadcastContentConfig"] = request.StepForBroadcastContentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotTopicChat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runHotTopicChat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotTopicChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-问答</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunHotTopicChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicChatResponse
        /// </returns>
        public async Task<RunHotTopicChatResponse> RunHotTopicChatWithOptionsAsync(string workspaceId, RunHotTopicChatRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunHotTopicChatShrinkRequest request = new RunHotTopicChatShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HotTopics))
            {
                request.HotTopicsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HotTopics, "hotTopics", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "messages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForBroadcastContentConfig))
            {
                request.StepForBroadcastContentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForBroadcastContentConfig, "stepForBroadcastContentConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicsShrink))
            {
                body["hotTopics"] = request.HotTopicsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                body["messages"] = request.MessagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForBroadcastContentConfigShrink))
            {
                body["stepForBroadcastContentConfig"] = request.StepForBroadcastContentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotTopicChat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runHotTopicChat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotTopicChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotTopicChatRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicChatResponse
        /// </returns>
        public RunHotTopicChatResponse RunHotTopicChat(string workspaceId, RunHotTopicChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunHotTopicChatWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotTopicChatRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicChatResponse
        /// </returns>
        public async Task<RunHotTopicChatResponse> RunHotTopicChatAsync(string workspaceId, RunHotTopicChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunHotTopicChatWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-热点摘要生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunHotTopicSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicSummaryResponse
        /// </returns>
        public RunHotTopicSummaryResponse RunHotTopicSummaryWithOptions(string workspaceId, RunHotTopicSummaryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunHotTopicSummaryShrinkRequest request = new RunHotTopicSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForCustomSummaryStyleConfig))
            {
                request.StepForCustomSummaryStyleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForCustomSummaryStyleConfig, "stepForCustomSummaryStyleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIds))
            {
                request.TopicIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIds, "topicIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForCustomSummaryStyleConfigShrink))
            {
                body["stepForCustomSummaryStyleConfig"] = request.StepForCustomSummaryStyleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdsShrink))
            {
                body["topicIds"] = request.TopicIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotTopicSummary",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runHotTopicSummary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotTopicSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-热点摘要生成</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunHotTopicSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicSummaryResponse
        /// </returns>
        public async Task<RunHotTopicSummaryResponse> RunHotTopicSummaryWithOptionsAsync(string workspaceId, RunHotTopicSummaryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunHotTopicSummaryShrinkRequest request = new RunHotTopicSummaryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StepForCustomSummaryStyleConfig))
            {
                request.StepForCustomSummaryStyleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StepForCustomSummaryStyleConfig, "stepForCustomSummaryStyleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopicIds))
            {
                request.TopicIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopicIds, "topicIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTopicVersion))
            {
                body["hotTopicVersion"] = request.HotTopicVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepForCustomSummaryStyleConfigShrink))
            {
                body["stepForCustomSummaryStyleConfig"] = request.StepForCustomSummaryStyleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicIdsShrink))
            {
                body["topicIds"] = request.TopicIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunHotTopicSummary",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runHotTopicSummary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunHotTopicSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-热点摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotTopicSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicSummaryResponse
        /// </returns>
        public RunHotTopicSummaryResponse RunHotTopicSummary(string workspaceId, RunHotTopicSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunHotTopicSummaryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-热点播报-热点摘要生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunHotTopicSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunHotTopicSummaryResponse
        /// </returns>
        public async Task<RunHotTopicSummaryResponse> RunHotTopicSummaryAsync(string workspaceId, RunHotTopicSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunHotTopicSummaryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销信息抽取服务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunMarketingInformationExtractRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationExtractResponse
        /// </returns>
        public RunMarketingInformationExtractResponse RunMarketingInformationExtractWithOptions(string workspaceId, RunMarketingInformationExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMarketingInformationExtractShrinkRequest request = new RunMarketingInformationExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMaterials))
            {
                request.SourceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMaterials, "sourceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                body["extractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterialsShrink))
            {
                body["sourceMaterials"] = request.SourceMaterialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationExtract",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationExtract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationExtractResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销信息抽取服务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunMarketingInformationExtractRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationExtractResponse
        /// </returns>
        public async Task<RunMarketingInformationExtractResponse> RunMarketingInformationExtractWithOptionsAsync(string workspaceId, RunMarketingInformationExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMarketingInformationExtractShrinkRequest request = new RunMarketingInformationExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMaterials))
            {
                request.SourceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMaterials, "sourceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                body["extractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterialsShrink))
            {
                body["sourceMaterials"] = request.SourceMaterialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationExtract",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationExtract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationExtractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销信息抽取服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationExtractResponse
        /// </returns>
        public RunMarketingInformationExtractResponse RunMarketingInformationExtract(string workspaceId, RunMarketingInformationExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunMarketingInformationExtractWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销信息抽取服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationExtractResponse
        /// </returns>
        public async Task<RunMarketingInformationExtractResponse> RunMarketingInformationExtractAsync(string workspaceId, RunMarketingInformationExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunMarketingInformationExtractWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案写作服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationWritingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationWritingResponse
        /// </returns>
        public RunMarketingInformationWritingResponse RunMarketingInformationWritingWithOptions(string workspaceId, RunMarketingInformationWritingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLimitation))
            {
                body["customLimitation"] = request.CustomLimitation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputExample))
            {
                body["inputExample"] = request.InputExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputExample))
            {
                body["outputExample"] = request.OutputExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingType))
            {
                body["writingType"] = request.WritingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationWritingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案写作服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationWritingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationWritingResponse
        /// </returns>
        public async Task<RunMarketingInformationWritingResponse> RunMarketingInformationWritingWithOptionsAsync(string workspaceId, RunMarketingInformationWritingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLimitation))
            {
                body["customLimitation"] = request.CustomLimitation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputExample))
            {
                body["inputExample"] = request.InputExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputExample))
            {
                body["outputExample"] = request.OutputExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingType))
            {
                body["writingType"] = request.WritingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案写作服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationWritingResponse
        /// </returns>
        public RunMarketingInformationWritingResponse RunMarketingInformationWriting(string workspaceId, RunMarketingInformationWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunMarketingInformationWritingWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案写作服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunMarketingInformationWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunMarketingInformationWritingResponse
        /// </returns>
        public async Task<RunMarketingInformationWritingResponse> RunMarketingInformationWritingAsync(string workspaceId, RunMarketingInformationWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunMarketingInformationWritingWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-网络内容审核</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunNetworkContentAuditRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunNetworkContentAuditResponse
        /// </returns>
        public RunNetworkContentAuditResponse RunNetworkContentAuditWithOptions(string workspaceId, RunNetworkContentAuditRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunNetworkContentAuditShrinkRequest request = new RunNetworkContentAuditShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunNetworkContentAudit",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runNetworkContentAudit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunNetworkContentAuditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-网络内容审核</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunNetworkContentAuditRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunNetworkContentAuditResponse
        /// </returns>
        public async Task<RunNetworkContentAuditResponse> RunNetworkContentAuditWithOptionsAsync(string workspaceId, RunNetworkContentAuditRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunNetworkContentAuditShrinkRequest request = new RunNetworkContentAuditShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunNetworkContentAudit",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runNetworkContentAudit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunNetworkContentAuditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-网络内容审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunNetworkContentAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// RunNetworkContentAuditResponse
        /// </returns>
        public RunNetworkContentAuditResponse RunNetworkContentAudit(string workspaceId, RunNetworkContentAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunNetworkContentAuditWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-网络内容审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunNetworkContentAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// RunNetworkContentAuditResponse
        /// </returns>
        public async Task<RunNetworkContentAuditResponse> RunNetworkContentAuditAsync(string workspaceId, RunNetworkContentAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunNetworkContentAuditWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>长剧本创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptChatResponse
        /// </returns>
        public RunScriptChatResponse RunScriptChatWithOptions(string workspaceId, RunScriptChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptChat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptChat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>长剧本创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptChatResponse
        /// </returns>
        public async Task<RunScriptChatResponse> RunScriptChatWithOptionsAsync(string workspaceId, RunScriptChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptChat",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptChat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>长剧本创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptChatRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptChatResponse
        /// </returns>
        public RunScriptChatResponse RunScriptChat(string workspaceId, RunScriptChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptChatWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>长剧本创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptChatRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptChatResponse
        /// </returns>
        public async Task<RunScriptChatResponse> RunScriptChatAsync(string workspaceId, RunScriptChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptChatWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptContinueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptContinueResponse
        /// </returns>
        public RunScriptContinueResponse RunScriptContinueWithOptions(string workspaceId, RunScriptContinueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvidedContent))
            {
                body["userProvidedContent"] = request.UserProvidedContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptContinue",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptContinue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptContinueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptContinueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptContinueResponse
        /// </returns>
        public async Task<RunScriptContinueResponse> RunScriptContinueWithOptionsAsync(string workspaceId, RunScriptContinueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvidedContent))
            {
                body["userProvidedContent"] = request.UserProvidedContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptContinue",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptContinue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptContinueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptContinueRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptContinueResponse
        /// </returns>
        public RunScriptContinueResponse RunScriptContinue(string workspaceId, RunScriptContinueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptContinueWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本续写</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptContinueRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptContinueResponse
        /// </returns>
        public async Task<RunScriptContinueResponse> RunScriptContinueAsync(string workspaceId, RunScriptContinueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptContinueWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本策划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptPlanningRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptPlanningResponse
        /// </returns>
        public RunScriptPlanningResponse RunScriptPlanningWithOptions(string workspaceId, RunScriptPlanningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalNote))
            {
                body["additionalNote"] = request.AdditionalNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueInScene))
            {
                body["dialogueInScene"] = request.DialogueInScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotConflict))
            {
                body["plotConflict"] = request.PlotConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                body["scriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptShotCount))
            {
                body["scriptShotCount"] = request.ScriptShotCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptPlanning",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptPlanning",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptPlanningResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本策划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptPlanningRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptPlanningResponse
        /// </returns>
        public async Task<RunScriptPlanningResponse> RunScriptPlanningWithOptionsAsync(string workspaceId, RunScriptPlanningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalNote))
            {
                body["additionalNote"] = request.AdditionalNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueInScene))
            {
                body["dialogueInScene"] = request.DialogueInScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotConflict))
            {
                body["plotConflict"] = request.PlotConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                body["scriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptShotCount))
            {
                body["scriptShotCount"] = request.ScriptShotCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptPlanning",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptPlanning",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptPlanningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本策划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptPlanningRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptPlanningResponse
        /// </returns>
        public RunScriptPlanningResponse RunScriptPlanning(string workspaceId, RunScriptPlanningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptPlanningWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本策划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptPlanningRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptPlanningResponse
        /// </returns>
        public async Task<RunScriptPlanningResponse> RunScriptPlanningAsync(string workspaceId, RunScriptPlanningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptPlanningWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本对话内容的整理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptRefineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptRefineResponse
        /// </returns>
        public RunScriptRefineResponse RunScriptRefineWithOptions(string workspaceId, RunScriptRefineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptRefine",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptRefine",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptRefineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本对话内容的整理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptRefineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunScriptRefineResponse
        /// </returns>
        public async Task<RunScriptRefineResponse> RunScriptRefineWithOptionsAsync(string workspaceId, RunScriptRefineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptRefine",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptRefine",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptRefineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本对话内容的整理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptRefineRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptRefineResponse
        /// </returns>
        public RunScriptRefineResponse RunScriptRefine(string workspaceId, RunScriptRefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptRefineWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>剧本对话内容的整理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunScriptRefineRequest
        /// </param>
        /// 
        /// <returns>
        /// RunScriptRefineResponse
        /// </returns>
        public async Task<RunScriptRefineResponse> RunScriptRefineAsync(string workspaceId, RunScriptRefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptRefineWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文体学习和写作推理服务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStyleWritingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStyleWritingResponse
        /// </returns>
        public RunStyleWritingResponse RunStyleWritingWithOptions(string workspaceId, RunStyleWritingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleWritingShrinkRequest request = new RunStyleWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LearningSamples))
            {
                request.LearningSamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LearningSamples, "learningSamples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceMaterials))
            {
                request.ReferenceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceMaterials, "referenceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningSamplesShrink))
            {
                body["learningSamples"] = request.LearningSamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStage))
            {
                body["processStage"] = request.ProcessStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSearch))
            {
                body["useSearch"] = request.UseSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTheme))
            {
                body["writingTheme"] = request.WritingTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runStyleWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleWritingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文体学习和写作推理服务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunStyleWritingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunStyleWritingResponse
        /// </returns>
        public async Task<RunStyleWritingResponse> RunStyleWritingWithOptionsAsync(string workspaceId, RunStyleWritingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleWritingShrinkRequest request = new RunStyleWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LearningSamples))
            {
                request.LearningSamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LearningSamples, "learningSamples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceMaterials))
            {
                request.ReferenceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceMaterials, "referenceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningSamplesShrink))
            {
                body["learningSamples"] = request.LearningSamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStage))
            {
                body["processStage"] = request.ProcessStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSearch))
            {
                body["useSearch"] = request.UseSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTheme))
            {
                body["writingTheme"] = request.WritingTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runStyleWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文体学习和写作推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStyleWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStyleWritingResponse
        /// </returns>
        public RunStyleWritingResponse RunStyleWriting(string workspaceId, RunStyleWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunStyleWritingWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文体学习和写作推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunStyleWritingRequest
        /// </param>
        /// 
        /// <returns>
        /// RunStyleWritingResponse
        /// </returns>
        public async Task<RunStyleWritingResponse> RunStyleWritingAsync(string workspaceId, RunStyleWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunStyleWritingWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTagMiningAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTagMiningAnalysisResponse
        /// </returns>
        public RunTagMiningAnalysisResponse RunTagMiningAnalysisWithOptions(string workspaceId, RunTagMiningAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTagMiningAnalysisShrinkRequest request = new RunTagMiningAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTagMiningAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runTagMiningAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTagMiningAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunTagMiningAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunTagMiningAnalysisResponse
        /// </returns>
        public async Task<RunTagMiningAnalysisResponse> RunTagMiningAnalysisWithOptionsAsync(string workspaceId, RunTagMiningAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTagMiningAnalysisShrinkRequest request = new RunTagMiningAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunTagMiningAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runTagMiningAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunTagMiningAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTagMiningAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTagMiningAnalysisResponse
        /// </returns>
        public RunTagMiningAnalysisResponse RunTagMiningAnalysis(string workspaceId, RunTagMiningAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunTagMiningAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunTagMiningAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunTagMiningAnalysisResponse
        /// </returns>
        public async Task<RunTagMiningAnalysisResponse> RunTagMiningAnalysisAsync(string workspaceId, RunTagMiningAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunTagMiningAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-视频理解</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunVideoAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunVideoAnalysisResponse
        /// </returns>
        public RunVideoAnalysisResponse RunVideoAnalysisWithOptions(string workspaceId, RunVideoAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunVideoAnalysisShrinkRequest request = new RunVideoAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeGenerateOptions))
            {
                request.ExcludeGenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeGenerateOptions, "excludeGenerateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FrameSampleMethod))
            {
                request.FrameSampleMethodShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FrameSampleMethod, "frameSampleMethod", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextProcessTasks))
            {
                request.TextProcessTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextProcessTasks, "textProcessTasks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoCaptionInfo))
            {
                request.VideoCaptionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoCaptionInfo, "videoCaptionInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoRoles))
            {
                request.VideoRolesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoRoles, "videoRoles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeGenerateOptionsShrink))
            {
                body["excludeGenerateOptions"] = request.ExcludeGenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdentitySimilarityMinScore))
            {
                body["faceIdentitySimilarityMinScore"] = request.FaceIdentitySimilarityMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameSampleMethodShrink))
            {
                body["frameSampleMethod"] = request.FrameSampleMethodShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotInterval))
            {
                body["snapshotInterval"] = request.SnapshotInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitInterval))
            {
                body["splitInterval"] = request.SplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextProcessTasksShrink))
            {
                body["textProcessTasks"] = request.TextProcessTasksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCaptionInfoShrink))
            {
                body["videoCaptionInfo"] = request.VideoCaptionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoExtraInfo))
            {
                body["videoExtraInfo"] = request.VideoExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoRolesShrink))
            {
                body["videoRoles"] = request.VideoRolesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoShotFaceIdentityCount))
            {
                body["videoShotFaceIdentityCount"] = request.VideoShotFaceIdentityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunVideoAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runVideoAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunVideoAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-视频理解</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunVideoAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunVideoAnalysisResponse
        /// </returns>
        public async Task<RunVideoAnalysisResponse> RunVideoAnalysisWithOptionsAsync(string workspaceId, RunVideoAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunVideoAnalysisShrinkRequest request = new RunVideoAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeGenerateOptions))
            {
                request.ExcludeGenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeGenerateOptions, "excludeGenerateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FrameSampleMethod))
            {
                request.FrameSampleMethodShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FrameSampleMethod, "frameSampleMethod", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextProcessTasks))
            {
                request.TextProcessTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextProcessTasks, "textProcessTasks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoCaptionInfo))
            {
                request.VideoCaptionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoCaptionInfo, "videoCaptionInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoRoles))
            {
                request.VideoRolesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoRoles, "videoRoles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeGenerateOptionsShrink))
            {
                body["excludeGenerateOptions"] = request.ExcludeGenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdentitySimilarityMinScore))
            {
                body["faceIdentitySimilarityMinScore"] = request.FaceIdentitySimilarityMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameSampleMethodShrink))
            {
                body["frameSampleMethod"] = request.FrameSampleMethodShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotInterval))
            {
                body["snapshotInterval"] = request.SnapshotInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitInterval))
            {
                body["splitInterval"] = request.SplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextProcessTasksShrink))
            {
                body["textProcessTasks"] = request.TextProcessTasksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCaptionInfoShrink))
            {
                body["videoCaptionInfo"] = request.VideoCaptionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoExtraInfo))
            {
                body["videoExtraInfo"] = request.VideoExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoRolesShrink))
            {
                body["videoRoles"] = request.VideoRolesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoShotFaceIdentityCount))
            {
                body["videoShotFaceIdentityCount"] = request.VideoShotFaceIdentityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunVideoAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runVideoAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunVideoAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-视频理解</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunVideoAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunVideoAnalysisResponse
        /// </returns>
        public RunVideoAnalysisResponse RunVideoAnalysis(string workspaceId, RunVideoAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunVideoAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-视频理解</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunVideoAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunVideoAnalysisResponse
        /// </returns>
        public async Task<RunVideoAnalysisResponse> RunVideoAnalysisAsync(string workspaceId, RunVideoAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunVideoAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交企业VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public SubmitEnterpriseVocAnalysisTaskResponse SubmitEnterpriseVocAnalysisTaskWithOptions(string workspaceId, SubmitEnterpriseVocAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitEnterpriseVocAnalysisTaskShrinkRequest request = new SubmitEnterpriseVocAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "filterTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["filterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEnterpriseVocAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/submitEnterpriseVocAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEnterpriseVocAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交企业VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitEnterpriseVocAnalysisTaskResponse> SubmitEnterpriseVocAnalysisTaskWithOptionsAsync(string workspaceId, SubmitEnterpriseVocAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitEnterpriseVocAnalysisTaskShrinkRequest request = new SubmitEnterpriseVocAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterTags))
            {
                request.FilterTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterTags, "filterTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTagsShrink))
            {
                body["filterTags"] = request.FilterTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEnterpriseVocAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/submitEnterpriseVocAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEnterpriseVocAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交企业VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public SubmitEnterpriseVocAnalysisTaskResponse SubmitEnterpriseVocAnalysisTask(string workspaceId, SubmitEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitEnterpriseVocAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交企业VOC异步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEnterpriseVocAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEnterpriseVocAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitEnterpriseVocAnalysisTaskResponse> SubmitEnterpriseVocAnalysisTaskAsync(string workspaceId, SubmitEnterpriseVocAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitEnterpriseVocAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTagMiningAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTagMiningAnalysisTaskResponse
        /// </returns>
        public SubmitTagMiningAnalysisTaskResponse SubmitTagMiningAnalysisTaskWithOptions(string workspaceId, SubmitTagMiningAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTagMiningAnalysisTaskShrinkRequest request = new SubmitTagMiningAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTagMiningAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/submitTagMiningAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTagMiningAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitTagMiningAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTagMiningAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitTagMiningAnalysisTaskResponse> SubmitTagMiningAnalysisTaskWithOptionsAsync(string workspaceId, SubmitTagMiningAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTagMiningAnalysisTaskShrinkRequest request = new SubmitTagMiningAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contents))
            {
                request.ContentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contents, "contents", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                body["businessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentsShrink))
            {
                body["contents"] = request.ContentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["extraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["outputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTagMiningAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/submitTagMiningAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTagMiningAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTagMiningAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTagMiningAnalysisTaskResponse
        /// </returns>
        public SubmitTagMiningAnalysisTaskResponse SubmitTagMiningAnalysisTask(string workspaceId, SubmitTagMiningAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitTagMiningAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-标签挖掘</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTagMiningAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTagMiningAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitTagMiningAnalysisTaskResponse> SubmitTagMiningAnalysisTaskAsync(string workspaceId, SubmitTagMiningAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitTagMiningAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-提交视频理解任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoAnalysisTaskResponse
        /// </returns>
        public SubmitVideoAnalysisTaskResponse SubmitVideoAnalysisTaskWithOptions(string workspaceId, SubmitVideoAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitVideoAnalysisTaskShrinkRequest request = new SubmitVideoAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeGenerateOptions))
            {
                request.ExcludeGenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeGenerateOptions, "excludeGenerateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FrameSampleMethod))
            {
                request.FrameSampleMethodShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FrameSampleMethod, "frameSampleMethod", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextProcessTasks))
            {
                request.TextProcessTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextProcessTasks, "textProcessTasks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoCaptionInfo))
            {
                request.VideoCaptionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoCaptionInfo, "videoCaptionInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoRoles))
            {
                request.VideoRolesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoRoles, "videoRoles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeduplicationId))
            {
                body["deduplicationId"] = request.DeduplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeGenerateOptionsShrink))
            {
                body["excludeGenerateOptions"] = request.ExcludeGenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdentitySimilarityMinScore))
            {
                body["faceIdentitySimilarityMinScore"] = request.FaceIdentitySimilarityMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameSampleMethodShrink))
            {
                body["frameSampleMethod"] = request.FrameSampleMethodShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotInterval))
            {
                body["snapshotInterval"] = request.SnapshotInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitInterval))
            {
                body["splitInterval"] = request.SplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextProcessTasksShrink))
            {
                body["textProcessTasks"] = request.TextProcessTasksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCaptionInfoShrink))
            {
                body["videoCaptionInfo"] = request.VideoCaptionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoExtraInfo))
            {
                body["videoExtraInfo"] = request.VideoExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoRolesShrink))
            {
                body["videoRoles"] = request.VideoRolesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoShotFaceIdentityCount))
            {
                body["videoShotFaceIdentityCount"] = request.VideoShotFaceIdentityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/submitVideoAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-提交视频理解任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitVideoAnalysisTaskResponse> SubmitVideoAnalysisTaskWithOptionsAsync(string workspaceId, SubmitVideoAnalysisTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitVideoAnalysisTaskShrinkRequest request = new SubmitVideoAnalysisTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeGenerateOptions))
            {
                request.ExcludeGenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeGenerateOptions, "excludeGenerateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FrameSampleMethod))
            {
                request.FrameSampleMethodShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FrameSampleMethod, "frameSampleMethod", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextProcessTasks))
            {
                request.TextProcessTasksShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextProcessTasks, "textProcessTasks", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoCaptionInfo))
            {
                request.VideoCaptionInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoCaptionInfo, "videoCaptionInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoRoles))
            {
                request.VideoRolesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoRoles, "videoRoles", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeduplicationId))
            {
                body["deduplicationId"] = request.DeduplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeGenerateOptionsShrink))
            {
                body["excludeGenerateOptions"] = request.ExcludeGenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdentitySimilarityMinScore))
            {
                body["faceIdentitySimilarityMinScore"] = request.FaceIdentitySimilarityMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameSampleMethodShrink))
            {
                body["frameSampleMethod"] = request.FrameSampleMethodShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotInterval))
            {
                body["snapshotInterval"] = request.SnapshotInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitInterval))
            {
                body["splitInterval"] = request.SplitInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextProcessTasksShrink))
            {
                body["textProcessTasks"] = request.TextProcessTasksShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCaptionInfoShrink))
            {
                body["videoCaptionInfo"] = request.VideoCaptionInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoExtraInfo))
            {
                body["videoExtraInfo"] = request.VideoExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoRolesShrink))
            {
                body["videoRoles"] = request.VideoRolesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoShotFaceIdentityCount))
            {
                body["videoShotFaceIdentityCount"] = request.VideoShotFaceIdentityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/submitVideoAnalysisTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-提交视频理解任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoAnalysisTaskResponse
        /// </returns>
        public SubmitVideoAnalysisTaskResponse SubmitVideoAnalysisTask(string workspaceId, SubmitVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitVideoAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>轻应用-提交视频理解任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoAnalysisTaskResponse
        /// </returns>
        public async Task<SubmitVideoAnalysisTaskResponse> SubmitVideoAnalysisTaskAsync(string workspaceId, SubmitVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitVideoAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-更新配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisConfigResponse
        /// </returns>
        public UpdateVideoAnalysisConfigResponse UpdateVideoAnalysisConfigWithOptions(string workspaceId, UpdateVideoAnalysisConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncConcurrency))
            {
                body["asyncConcurrency"] = request.AsyncConcurrency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoAnalysisConfig",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/updateVideoAnalysisConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoAnalysisConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-更新配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisConfigResponse
        /// </returns>
        public async Task<UpdateVideoAnalysisConfigResponse> UpdateVideoAnalysisConfigWithOptionsAsync(string workspaceId, UpdateVideoAnalysisConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsyncConcurrency))
            {
                body["asyncConcurrency"] = request.AsyncConcurrency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoAnalysisConfig",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/updateVideoAnalysisConfig",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoAnalysisConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-更新配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisConfigResponse
        /// </returns>
        public UpdateVideoAnalysisConfigResponse UpdateVideoAnalysisConfig(string workspaceId, UpdateVideoAnalysisConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVideoAnalysisConfigWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-更新配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisConfigResponse
        /// </returns>
        public async Task<UpdateVideoAnalysisConfigResponse> UpdateVideoAnalysisConfigAsync(string workspaceId, UpdateVideoAnalysisConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVideoAnalysisConfigWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-修改任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisTaskResponse
        /// </returns>
        public UpdateVideoAnalysisTaskResponse UpdateVideoAnalysisTaskWithOptions(string workspaceId, UpdateVideoAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/updateVideoAnalysisTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-修改任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisTaskResponse
        /// </returns>
        public async Task<UpdateVideoAnalysisTaskResponse> UpdateVideoAnalysisTaskWithOptionsAsync(string workspaceId, UpdateVideoAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoAnalysisTask",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/videoAnalysis/updateVideoAnalysisTask",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-修改任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisTaskResponse
        /// </returns>
        public UpdateVideoAnalysisTaskResponse UpdateVideoAnalysisTask(string workspaceId, UpdateVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVideoAnalysisTaskWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频理解-修改任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVideoAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVideoAnalysisTaskResponse
        /// </returns>
        public async Task<UpdateVideoAnalysisTaskResponse> UpdateVideoAnalysisTaskAsync(string workspaceId, UpdateVideoAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVideoAnalysisTaskWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
