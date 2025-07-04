// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IntelligentCreation20240313.Models;

namespace AlibabaCloud.SDK.IntelligentCreation20240313
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("intelligentcreation", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>添加文案反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTextFeedbackRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTextFeedbackResponse
        /// </returns>
        public AddTextFeedbackResponse AddTextFeedbackWithOptions(AddTextFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                body["quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextId))
            {
                body["textId"] = request.TextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTextFeedback",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/addTextFeedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTextFeedbackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文案反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTextFeedbackRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddTextFeedbackResponse
        /// </returns>
        public async Task<AddTextFeedbackResponse> AddTextFeedbackWithOptionsAsync(AddTextFeedbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                body["quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextId))
            {
                body["textId"] = request.TextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTextFeedback",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/addTextFeedback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTextFeedbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文案反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTextFeedbackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTextFeedbackResponse
        /// </returns>
        public AddTextFeedbackResponse AddTextFeedback(AddTextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddTextFeedbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加文案反馈</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddTextFeedbackRequest
        /// </param>
        /// 
        /// <returns>
        /// AddTextFeedbackResponse
        /// </returns>
        public async Task<AddTextFeedbackResponse> AddTextFeedbackAsync(AddTextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddTextFeedbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加知识文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddDocumentResponse
        /// </returns>
        public BatchAddDocumentResponse BatchAddDocumentWithOptions(string knowledgeBaseId, BatchAddDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDocumentInfos))
            {
                body["addDocumentInfos"] = request.AddDocumentInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddDocument",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/documents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加知识文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddDocumentResponse
        /// </returns>
        public async Task<BatchAddDocumentResponse> BatchAddDocumentWithOptionsAsync(string knowledgeBaseId, BatchAddDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddDocumentInfos))
            {
                body["addDocumentInfos"] = request.AddDocumentInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddDocument",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/documents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加知识文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddDocumentResponse
        /// </returns>
        public BatchAddDocumentResponse BatchAddDocument(string knowledgeBaseId, BatchAddDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchAddDocumentWithOptions(knowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加知识文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddDocumentResponse
        /// </returns>
        public async Task<BatchAddDocumentResponse> BatchAddDocumentAsync(string knowledgeBaseId, BatchAddDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchAddDocumentWithOptionsAsync(knowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布剧本任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateAICoachTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateAICoachTaskResponse
        /// </returns>
        public BatchCreateAICoachTaskResponse BatchCreateAICoachTaskWithOptions(BatchCreateAICoachTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                body["scriptRecordId"] = request.ScriptRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentIds))
            {
                body["studentIds"] = request.StudentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentList))
            {
                body["studentList"] = request.StudentList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateAICoachTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/batchCreateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateAICoachTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布剧本任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateAICoachTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateAICoachTaskResponse
        /// </returns>
        public async Task<BatchCreateAICoachTaskResponse> BatchCreateAICoachTaskWithOptionsAsync(BatchCreateAICoachTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                body["scriptRecordId"] = request.ScriptRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentIds))
            {
                body["studentIds"] = request.StudentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentList))
            {
                body["studentList"] = request.StudentList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateAICoachTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/batchCreateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateAICoachTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布剧本任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateAICoachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateAICoachTaskResponse
        /// </returns>
        public BatchCreateAICoachTaskResponse BatchCreateAICoachTask(BatchCreateAICoachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchCreateAICoachTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发布剧本任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateAICoachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateAICoachTaskResponse
        /// </returns>
        public async Task<BatchCreateAICoachTaskResponse> BatchCreateAICoachTaskAsync(BatchCreateAICoachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchCreateAICoachTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetProjectTaskResponse
        /// </returns>
        public BatchGetProjectTaskResponse BatchGetProjectTaskWithOptions(BatchGetProjectTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetProjectTaskShrinkRequest request = new BatchGetProjectTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/batchGetProjectTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetProjectTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetProjectTaskResponse
        /// </returns>
        public async Task<BatchGetProjectTaskResponse> BatchGetProjectTaskWithOptionsAsync(BatchGetProjectTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetProjectTaskShrinkRequest request = new BatchGetProjectTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/batchGetProjectTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetProjectTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetProjectTaskResponse
        /// </returns>
        public BatchGetProjectTaskResponse BatchGetProjectTask(BatchGetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetProjectTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetProjectTaskResponse
        /// </returns>
        public async Task<BatchGetProjectTaskResponse> BatchGetProjectTaskAsync(BatchGetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetTrainTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetTrainTaskResponse
        /// </returns>
        public BatchGetTrainTaskResponse BatchGetTrainTaskWithOptions(BatchGetTrainTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetTrainTaskShrinkRequest request = new BatchGetTrainTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                query["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetTrainTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/train/task/batchGetTrainTaskInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetTrainTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetTrainTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetTrainTaskResponse
        /// </returns>
        public async Task<BatchGetTrainTaskResponse> BatchGetTrainTaskWithOptionsAsync(BatchGetTrainTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetTrainTaskShrinkRequest request = new BatchGetTrainTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                query["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetTrainTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/train/task/batchGetTrainTaskInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetTrainTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetTrainTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetTrainTaskResponse
        /// </returns>
        public BatchGetTrainTaskResponse BatchGetTrainTask(BatchGetTrainTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetTrainTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetTrainTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetTrainTaskResponse
        /// </returns>
        public async Task<BatchGetTrainTaskResponse> BatchGetTrainTaskAsync(BatchGetTrainTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetTrainTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频切片任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetVideoClipTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoClipTaskResponse
        /// </returns>
        public BatchGetVideoClipTaskResponse BatchGetVideoClipTaskWithOptions(BatchGetVideoClipTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetVideoClipTaskShrinkRequest request = new BatchGetVideoClipTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetVideoClipTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/clip/batchGetVideoClipTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetVideoClipTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频切片任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchGetVideoClipTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoClipTaskResponse
        /// </returns>
        public async Task<BatchGetVideoClipTaskResponse> BatchGetVideoClipTaskWithOptionsAsync(BatchGetVideoClipTaskRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetVideoClipTaskShrinkRequest request = new BatchGetVideoClipTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIdList))
            {
                request.TaskIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIdList, "taskIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdListShrink))
            {
                query["taskIdList"] = request.TaskIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetVideoClipTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/clip/batchGetVideoClipTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetVideoClipTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频切片任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetVideoClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoClipTaskResponse
        /// </returns>
        public BatchGetVideoClipTaskResponse BatchGetVideoClipTask(BatchGetVideoClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetVideoClipTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询视频切片任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGetVideoClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoClipTaskResponse
        /// </returns>
        public async Task<BatchGetVideoClipTaskResponse> BatchGetVideoClipTaskAsync(BatchGetVideoClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetVideoClipTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询文案</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryIndividuationTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryIndividuationTextResponse
        /// </returns>
        public BatchQueryIndividuationTextResponse BatchQueryIndividuationTextWithOptions(BatchQueryIndividuationTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryIndividuationTextShrinkRequest request = new BatchQueryIndividuationTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextIdList))
            {
                request.TextIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextIdList, "textIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextIdListShrink))
            {
                query["textIdList"] = request.TextIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryIndividuationText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/batchQueryText",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryIndividuationTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询文案</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryIndividuationTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryIndividuationTextResponse
        /// </returns>
        public async Task<BatchQueryIndividuationTextResponse> BatchQueryIndividuationTextWithOptionsAsync(BatchQueryIndividuationTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryIndividuationTextShrinkRequest request = new BatchQueryIndividuationTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TextIdList))
            {
                request.TextIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TextIdList, "textIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextIdListShrink))
            {
                query["textIdList"] = request.TextIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryIndividuationText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/batchQueryText",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryIndividuationTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryIndividuationTextRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryIndividuationTextResponse
        /// </returns>
        public BatchQueryIndividuationTextResponse BatchQueryIndividuationText(BatchQueryIndividuationTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchQueryIndividuationTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryIndividuationTextRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryIndividuationTextResponse
        /// </returns>
        public async Task<BatchQueryIndividuationTextResponse> BatchQueryIndividuationTextAsync(BatchQueryIndividuationTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchQueryIndividuationTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查会话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSessionResponse
        /// </returns>
        public CheckSessionResponse CheckSessionWithOptions(CheckSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/checkSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查会话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSessionResponse
        /// </returns>
        public async Task<CheckSessionResponse> CheckSessionWithOptionsAsync(CheckSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/checkSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查会话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSessionResponse
        /// </returns>
        public CheckSessionResponse CheckSession(CheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查会话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSessionResponse
        /// </returns>
        public async Task<CheckSessionResponse> CheckSessionAsync(CheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员关闭会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseAICoachTaskSessionResponse
        /// </returns>
        public CloseAICoachTaskSessionResponse CloseAICoachTaskSessionWithOptions(CloseAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/closeSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseAICoachTaskSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员关闭会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseAICoachTaskSessionResponse
        /// </returns>
        public async Task<CloseAICoachTaskSessionResponse> CloseAICoachTaskSessionWithOptionsAsync(CloseAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/closeSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseAICoachTaskSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员关闭会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseAICoachTaskSessionResponse
        /// </returns>
        public CloseAICoachTaskSessionResponse CloseAICoachTaskSession(CloseAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseAICoachTaskSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员关闭会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseAICoachTaskSessionResponse
        /// </returns>
        public async Task<CloseAICoachTaskSessionResponse> CloseAICoachTaskSessionAsync(CloseAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseAICoachTaskSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本数量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountTextResponse
        /// </returns>
        public CountTextResponse CountTextWithOptions(CountTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                query["style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/countText",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本数量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountTextResponse
        /// </returns>
        public async Task<CountTextResponse> CountTextWithOptionsAsync(CountTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                query["style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/countText",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本数量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CountTextResponse
        /// </returns>
        public CountTextResponse CountText(CountTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CountTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文本数量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTextRequest
        /// </param>
        /// 
        /// <returns>
        /// CountTextResponse
        /// </returns>
        public async Task<CountTextResponse> CountTextAsync(CountTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CountTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskResponse
        /// </returns>
        public CreateAICoachTaskResponse CreateAICoachTaskWithOptions(CreateAICoachTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                body["scriptRecordId"] = request.ScriptRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentAudioUrl))
            {
                body["studentAudioUrl"] = request.StudentAudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                body["studentId"] = request.StudentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAICoachTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/createTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAICoachTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskResponse
        /// </returns>
        public async Task<CreateAICoachTaskResponse> CreateAICoachTaskWithOptionsAsync(CreateAICoachTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                body["scriptRecordId"] = request.ScriptRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentAudioUrl))
            {
                body["studentAudioUrl"] = request.StudentAudioUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                body["studentId"] = request.StudentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAICoachTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/createTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAICoachTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskResponse
        /// </returns>
        public CreateAICoachTaskResponse CreateAICoachTask(CreateAICoachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAICoachTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskResponse
        /// </returns>
        public async Task<CreateAICoachTaskResponse> CreateAICoachTaskAsync(CreateAICoachTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAICoachTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员开启对练会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskSessionResponse
        /// </returns>
        public CreateAICoachTaskSessionResponse CreateAICoachTaskSessionWithOptions(CreateAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/startSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAICoachTaskSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员开启对练会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskSessionResponse
        /// </returns>
        public async Task<CreateAICoachTaskSessionResponse> CreateAICoachTaskSessionWithOptionsAsync(CreateAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/startSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAICoachTaskSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员开启对练会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskSessionResponse
        /// </returns>
        public CreateAICoachTaskSessionResponse CreateAICoachTaskSession(CreateAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAICoachTaskSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员开启对练会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAICoachTaskSessionResponse
        /// </returns>
        public async Task<CreateAICoachTaskSessionResponse> CreateAICoachTaskSessionAsync(CreateAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAICoachTaskSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnchorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnchorResponse
        /// </returns>
        public CreateAnchorResponse CreateAnchorWithOptions(CreateAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorCategory))
            {
                body["anchorCategory"] = request.AnchorCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorMaterialName))
            {
                body["anchorMaterialName"] = request.AnchorMaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalHumanType))
            {
                body["digitalHumanType"] = request.DigitalHumanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOssKey))
            {
                body["videoOssKey"] = request.VideoOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnchor",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/anchorOpen/createAnchor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnchorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnchorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAnchorResponse
        /// </returns>
        public async Task<CreateAnchorResponse> CreateAnchorWithOptionsAsync(CreateAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorCategory))
            {
                body["anchorCategory"] = request.AnchorCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorMaterialName))
            {
                body["anchorMaterialName"] = request.AnchorMaterialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalHumanType))
            {
                body["digitalHumanType"] = request.DigitalHumanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoOssKey))
            {
                body["videoOssKey"] = request.VideoOssKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnchor",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/anchorOpen/createAnchor",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAnchorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnchorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnchorResponse
        /// </returns>
        public CreateAnchorResponse CreateAnchor(CreateAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnchorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建照片数字人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAnchorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAnchorResponse
        /// </returns>
        public async Task<CreateAnchorResponse> CreateAnchorAsync(CreateAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnchorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建配图生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIllustrationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIllustrationTaskResponse
        /// </returns>
        public CreateIllustrationTaskResponse CreateIllustrationTaskWithOptions(string textId, CreateIllustrationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIllustrationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建配图生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIllustrationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIllustrationTaskResponse
        /// </returns>
        public async Task<CreateIllustrationTaskResponse> CreateIllustrationTaskWithOptionsAsync(string textId, CreateIllustrationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIllustrationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建配图生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIllustrationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIllustrationTaskResponse
        /// </returns>
        public CreateIllustrationTaskResponse CreateIllustrationTask(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIllustrationTaskWithOptions(textId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建配图生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIllustrationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIllustrationTaskResponse
        /// </returns>
        public async Task<CreateIllustrationTaskResponse> CreateIllustrationTaskAsync(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIllustrationTaskWithOptionsAsync(textId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationProjectResponse
        /// </returns>
        public CreateIndividuationProjectResponse CreateIndividuationProjectWithOptions(CreateIndividuationProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectInfo))
            {
                body["projectInfo"] = request.ProjectInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Purpose))
            {
                body["purpose"] = request.Purpose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndividuationProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndividuationProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationProjectResponse
        /// </returns>
        public async Task<CreateIndividuationProjectResponse> CreateIndividuationProjectWithOptionsAsync(CreateIndividuationProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectInfo))
            {
                body["projectInfo"] = request.ProjectInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Purpose))
            {
                body["purpose"] = request.Purpose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndividuationProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndividuationProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationProjectResponse
        /// </returns>
        public CreateIndividuationProjectResponse CreateIndividuationProject(CreateIndividuationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndividuationProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationProjectResponse
        /// </returns>
        public async Task<CreateIndividuationProjectResponse> CreateIndividuationProjectAsync(CreateIndividuationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndividuationProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationTextTaskResponse
        /// </returns>
        public CreateIndividuationTextTaskResponse CreateIndividuationTextTaskWithOptions(CreateIndividuationTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdPack))
            {
                body["crowdPack"] = request.CrowdPack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndividuationTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/createTextTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndividuationTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationTextTaskResponse
        /// </returns>
        public async Task<CreateIndividuationTextTaskResponse> CreateIndividuationTextTaskWithOptionsAsync(CreateIndividuationTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdPack))
            {
                body["crowdPack"] = request.CrowdPack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndividuationTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/createTextTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndividuationTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationTextTaskResponse
        /// </returns>
        public CreateIndividuationTextTaskResponse CreateIndividuationTextTask(CreateIndividuationTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndividuationTextTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIndividuationTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndividuationTextTaskResponse
        /// </returns>
        public async Task<CreateIndividuationTextTaskResponse> CreateIndividuationTextTaskAsync(CreateIndividuationTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndividuationTextTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductImageResponse
        /// </returns>
        public CreateProductImageResponse CreateProductImageWithOptions(CreateProductImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundDescription))
            {
                body["backgroundDescription"] = request.BackgroundDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundPriority))
            {
                body["backgroundPriority"] = request.BackgroundPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundUrl))
            {
                body["backgroundUrl"] = request.BackgroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighlightText))
            {
                body["highlightText"] = request.HighlightText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTitle))
            {
                body["subTitle"] = request.SubTitle;
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
                Action = "CreateProductImage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/products",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductImageResponse
        /// </returns>
        public async Task<CreateProductImageResponse> CreateProductImageWithOptionsAsync(CreateProductImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundDescription))
            {
                body["backgroundDescription"] = request.BackgroundDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundPriority))
            {
                body["backgroundPriority"] = request.BackgroundPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundUrl))
            {
                body["backgroundUrl"] = request.BackgroundUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighlightText))
            {
                body["highlightText"] = request.HighlightText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCount))
            {
                body["imageCount"] = request.ImageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTitle))
            {
                body["subTitle"] = request.SubTitle;
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
                Action = "CreateProductImage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/products",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductImageResponse
        /// </returns>
        public CreateProductImageResponse CreateProductImage(CreateProductImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProductImageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建产品图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductImageResponse
        /// </returns>
        public async Task<CreateProductImageResponse> CreateProductImageAsync(CreateProductImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProductImageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写实人像创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRealisticPortraitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRealisticPortraitResponse
        /// </returns>
        public CreateRealisticPortraitResponse CreateRealisticPortraitWithOptions(CreateRealisticPortraitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ages))
            {
                body["ages"] = request.Ages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cloth))
            {
                body["cloth"] = request.Cloth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                body["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Custom))
            {
                body["custom"] = request.Custom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Face))
            {
                body["face"] = request.Face;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Figure))
            {
                body["figure"] = request.Figure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HairColor))
            {
                body["hairColor"] = request.HairColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hairstyle))
            {
                body["hairstyle"] = request.Hairstyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                body["numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealisticPortrait",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/realistic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealisticPortraitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写实人像创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRealisticPortraitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRealisticPortraitResponse
        /// </returns>
        public async Task<CreateRealisticPortraitResponse> CreateRealisticPortraitWithOptionsAsync(CreateRealisticPortraitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ages))
            {
                body["ages"] = request.Ages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cloth))
            {
                body["cloth"] = request.Cloth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                body["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Custom))
            {
                body["custom"] = request.Custom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Face))
            {
                body["face"] = request.Face;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Figure))
            {
                body["figure"] = request.Figure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HairColor))
            {
                body["hairColor"] = request.HairColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hairstyle))
            {
                body["hairstyle"] = request.Hairstyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                body["numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRealisticPortrait",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/realistic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRealisticPortraitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写实人像创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRealisticPortraitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRealisticPortraitResponse
        /// </returns>
        public CreateRealisticPortraitResponse CreateRealisticPortrait(CreateRealisticPortraitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRealisticPortraitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写实人像创作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRealisticPortraitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRealisticPortraitResponse
        /// </returns>
        public async Task<CreateRealisticPortraitResponse> CreateRealisticPortraitAsync(CreateRealisticPortraitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRealisticPortraitWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文案生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextTaskResponse
        /// </returns>
        public CreateTextTaskResponse CreateTextTaskWithOptions(CreateTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文案生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextTaskResponse
        /// </returns>
        public async Task<CreateTextTaskResponse> CreateTextTaskWithOptionsAsync(CreateTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文案生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextTaskResponse
        /// </returns>
        public CreateTextTaskResponse CreateTextTask(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTextTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文案生成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextTaskResponse
        /// </returns>
        public async Task<CreateTextTaskResponse> CreateTextTaskAsync(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTextTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainTaskResponse
        /// </returns>
        public CreateTrainTaskResponse CreateTrainTaskWithOptions(CreateTrainTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                body["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                body["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceGender))
            {
                body["voiceGender"] = request.VoiceGender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceLanguage))
            {
                body["voiceLanguage"] = request.VoiceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                body["voiceName"] = request.VoiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoicePath))
            {
                body["voicePath"] = request.VoicePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrainTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/train/task/createTrainTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainTaskResponse
        /// </returns>
        public async Task<CreateTrainTaskResponse> CreateTrainTaskWithOptionsAsync(CreateTrainTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                body["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                body["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                body["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceGender))
            {
                body["voiceGender"] = request.VoiceGender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceLanguage))
            {
                body["voiceLanguage"] = request.VoiceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                body["voiceName"] = request.VoiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoicePath))
            {
                body["voicePath"] = request.VoicePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrainTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/train/task/createTrainTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrainTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainTaskResponse
        /// </returns>
        public CreateTrainTaskResponse CreateTrainTask(CreateTrainTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrainTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交声音复刻任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrainTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrainTaskResponse
        /// </returns>
        public async Task<CreateTrainTaskResponse> CreateTrainTaskAsync(CreateTrainTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrainTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频切片任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoClipTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoClipTaskResponse
        /// </returns>
        public CreateVideoClipTaskResponse CreateVideoClipTaskWithOptions(CreateVideoClipTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                body["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeys))
            {
                body["ossKeys"] = request.OssKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requirement))
            {
                body["requirement"] = request.Requirement;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoClipTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/clip/createVideoClipTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoClipTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频切片任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoClipTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoClipTaskResponse
        /// </returns>
        public async Task<CreateVideoClipTaskResponse> CreateVideoClipTaskWithOptionsAsync(CreateVideoClipTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunMainId))
            {
                body["aliyunMainId"] = request.AliyunMainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKeys))
            {
                body["ossKeys"] = request.OssKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Requirement))
            {
                body["requirement"] = request.Requirement;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoClipTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/clip/createVideoClipTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoClipTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频切片任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoClipTaskResponse
        /// </returns>
        public CreateVideoClipTaskResponse CreateVideoClipTask(CreateVideoClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVideoClipTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交视频切片任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVideoClipTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVideoClipTaskResponse
        /// </returns>
        public async Task<CreateVideoClipTaskResponse> CreateVideoClipTaskAsync(CreateVideoClipTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVideoClipTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationProjectResponse
        /// </returns>
        public DeleteIndividuationProjectResponse DeleteIndividuationProjectWithOptions(DeleteIndividuationProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndividuationProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/deleteProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndividuationProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationProjectResponse
        /// </returns>
        public async Task<DeleteIndividuationProjectResponse> DeleteIndividuationProjectWithOptionsAsync(DeleteIndividuationProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndividuationProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/deleteProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndividuationProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationProjectResponse
        /// </returns>
        public DeleteIndividuationProjectResponse DeleteIndividuationProject(DeleteIndividuationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndividuationProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationProjectResponse
        /// </returns>
        public async Task<DeleteIndividuationProjectResponse> DeleteIndividuationProjectAsync(DeleteIndividuationProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndividuationProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationTextResponse
        /// </returns>
        public DeleteIndividuationTextResponse DeleteIndividuationTextWithOptions(DeleteIndividuationTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextIdList))
            {
                body["textIdList"] = request.TextIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndividuationText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/deleteText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndividuationTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationTextResponse
        /// </returns>
        public async Task<DeleteIndividuationTextResponse> DeleteIndividuationTextWithOptionsAsync(DeleteIndividuationTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextIdList))
            {
                body["textIdList"] = request.TextIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndividuationText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/deleteText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndividuationTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationTextResponse
        /// </returns>
        public DeleteIndividuationTextResponse DeleteIndividuationText(DeleteIndividuationTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndividuationTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除个性化文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIndividuationTextRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndividuationTextResponse
        /// </returns>
        public async Task<DeleteIndividuationTextResponse> DeleteIndividuationTextAsync(DeleteIndividuationTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndividuationTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档信息与状态</para>
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
        /// DescribeDocumentResponse
        /// </returns>
        public DescribeDocumentResponse DescribeDocumentWithOptions(string knowledgeBaseId, string documentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDocument",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/documents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(documentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档信息与状态</para>
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
        /// DescribeDocumentResponse
        /// </returns>
        public async Task<DescribeDocumentResponse> DescribeDocumentWithOptionsAsync(string knowledgeBaseId, string documentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDocument",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/documents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(documentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档信息与状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public DescribeDocumentResponse DescribeDocument(string knowledgeBaseId, string documentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDocumentWithOptions(knowledgeBaseId, documentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文档信息与状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public async Task<DescribeDocumentResponse> DescribeDocumentAsync(string knowledgeBaseId, string documentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDocumentWithOptionsAsync(knowledgeBaseId, documentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员完成会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishAICoachTaskSessionResponse
        /// </returns>
        public FinishAICoachTaskSessionResponse FinishAICoachTaskSessionWithOptions(FinishAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/finishSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishAICoachTaskSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员完成会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishAICoachTaskSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishAICoachTaskSessionResponse
        /// </returns>
        public async Task<FinishAICoachTaskSessionResponse> FinishAICoachTaskSessionWithOptionsAsync(FinishAICoachTaskSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishAICoachTaskSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/finishSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishAICoachTaskSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员完成会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishAICoachTaskSessionResponse
        /// </returns>
        public FinishAICoachTaskSessionResponse FinishAICoachTaskSession(FinishAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FinishAICoachTaskSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员完成会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishAICoachTaskSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishAICoachTaskSessionResponse
        /// </returns>
        public async Task<FinishAICoachTaskSessionResponse> FinishAICoachTaskSessionAsync(FinishAICoachTaskSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FinishAICoachTaskSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取考核点详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachAssessmentPointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachAssessmentPointResponse
        /// </returns>
        public GetAICoachAssessmentPointResponse GetAICoachAssessmentPointWithOptions(GetAICoachAssessmentPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointId))
            {
                query["pointId"] = request.PointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachAssessmentPoint",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getAssessmentPoint",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachAssessmentPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取考核点详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachAssessmentPointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachAssessmentPointResponse
        /// </returns>
        public async Task<GetAICoachAssessmentPointResponse> GetAICoachAssessmentPointWithOptionsAsync(GetAICoachAssessmentPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointId))
            {
                query["pointId"] = request.PointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachAssessmentPoint",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getAssessmentPoint",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachAssessmentPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取考核点详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachAssessmentPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachAssessmentPointResponse
        /// </returns>
        public GetAICoachAssessmentPointResponse GetAICoachAssessmentPoint(GetAICoachAssessmentPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachAssessmentPointWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取考核点详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachAssessmentPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachAssessmentPointResponse
        /// </returns>
        public async Task<GetAICoachAssessmentPointResponse> GetAICoachAssessmentPointAsync(GetAICoachAssessmentPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachAssessmentPointWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询作弊检测详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachCheatDetectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachCheatDetectionResponse
        /// </returns>
        public GetAICoachCheatDetectionResponse GetAICoachCheatDetectionWithOptions(GetAICoachCheatDetectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachCheatDetection",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getCheatDetection",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachCheatDetectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询作弊检测详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachCheatDetectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachCheatDetectionResponse
        /// </returns>
        public async Task<GetAICoachCheatDetectionResponse> GetAICoachCheatDetectionWithOptionsAsync(GetAICoachCheatDetectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachCheatDetection",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getCheatDetection",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachCheatDetectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询作弊检测详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachCheatDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachCheatDetectionResponse
        /// </returns>
        public GetAICoachCheatDetectionResponse GetAICoachCheatDetection(GetAICoachCheatDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachCheatDetectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询作弊检测详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachCheatDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachCheatDetectionResponse
        /// </returns>
        public async Task<GetAICoachCheatDetectionResponse> GetAICoachCheatDetectionAsync(GetAICoachCheatDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachCheatDetectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachScriptRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachScriptResponse
        /// </returns>
        public GetAICoachScriptResponse GetAICoachScriptWithOptions(GetAICoachScriptRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                query["scriptRecordId"] = request.ScriptRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachScript",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getScript",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachScriptRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachScriptResponse
        /// </returns>
        public async Task<GetAICoachScriptResponse> GetAICoachScriptWithOptionsAsync(GetAICoachScriptRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptRecordId))
            {
                query["scriptRecordId"] = request.ScriptRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachScript",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getScript",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachScriptResponse
        /// </returns>
        public GetAICoachScriptResponse GetAICoachScript(GetAICoachScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachScriptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachScriptResponse
        /// </returns>
        public async Task<GetAICoachScriptResponse> GetAICoachScriptAsync(GetAICoachScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachScriptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionHistoryResponse
        /// </returns>
        public GetAICoachTaskSessionHistoryResponse GetAICoachTaskSessionHistoryWithOptions(GetAICoachTaskSessionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionHistory",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/querySessionHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionHistoryResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionHistoryResponse> GetAICoachTaskSessionHistoryWithOptionsAsync(GetAICoachTaskSessionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionHistory",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/querySessionHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionHistoryResponse
        /// </returns>
        public GetAICoachTaskSessionHistoryResponse GetAICoachTaskSessionHistory(GetAICoachTaskSessionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachTaskSessionHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话历史</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionHistoryResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionHistoryResponse> GetAICoachTaskSessionHistoryAsync(GetAICoachTaskSessionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachTaskSessionHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话评测报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionReportResponse
        /// </returns>
        public GetAICoachTaskSessionReportResponse GetAICoachTaskSessionReportWithOptions(GetAICoachTaskSessionReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionReport",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/queryTaskSessionReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话评测报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionReportResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionReportResponse> GetAICoachTaskSessionReportWithOptionsAsync(GetAICoachTaskSessionReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionReport",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/queryTaskSessionReport",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话评测报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionReportResponse
        /// </returns>
        public GetAICoachTaskSessionReportResponse GetAICoachTaskSessionReport(GetAICoachTaskSessionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachTaskSessionReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>学员查询会话评测报告</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionReportResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionReportResponse> GetAICoachTaskSessionReportAsync(GetAICoachTaskSessionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachTaskSessionReportWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对练会话资源使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionResourceUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionResourceUsageResponse
        /// </returns>
        public GetAICoachTaskSessionResourceUsageResponse GetAICoachTaskSessionResourceUsageWithOptions(GetAICoachTaskSessionResourceUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionResourceUsage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getSessionResourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对练会话资源使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionResourceUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionResourceUsageResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionResourceUsageResponse> GetAICoachTaskSessionResourceUsageWithOptionsAsync(GetAICoachTaskSessionResourceUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAICoachTaskSessionResourceUsage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/getSessionResourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAICoachTaskSessionResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对练会话资源使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionResourceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionResourceUsageResponse
        /// </returns>
        public GetAICoachTaskSessionResourceUsageResponse GetAICoachTaskSessionResourceUsage(GetAICoachTaskSessionResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAICoachTaskSessionResourceUsageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取对练会话资源使用情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAICoachTaskSessionResourceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAICoachTaskSessionResourceUsageResponse
        /// </returns>
        public async Task<GetAICoachTaskSessionResourceUsageResponse> GetAICoachTaskSessionResourceUsageAsync(GetAICoachTaskSessionResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAICoachTaskSessionResourceUsageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图</para>
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
        /// GetIllustrationResponse
        /// </returns>
        public GetIllustrationResponse GetIllustrationWithOptions(string textId, string illustrationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustration",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图</para>
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
        /// GetIllustrationResponse
        /// </returns>
        public async Task<GetIllustrationResponse> GetIllustrationWithOptionsAsync(string textId, string illustrationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustration",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIllustrationResponse
        /// </returns>
        public GetIllustrationResponse GetIllustration(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationWithOptions(textId, illustrationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIllustrationResponse
        /// </returns>
        public async Task<GetIllustrationResponse> GetIllustrationAsync(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationWithOptionsAsync(textId, illustrationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图任务</para>
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
        /// GetIllustrationTaskResponse
        /// </returns>
        public GetIllustrationTaskResponse GetIllustrationTaskWithOptions(string textId, string illustrationTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图任务</para>
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
        /// GetIllustrationTaskResponse
        /// </returns>
        public async Task<GetIllustrationTaskResponse> GetIllustrationTaskWithOptionsAsync(string textId, string illustrationTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIllustrationTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId) + "/illustrationTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(illustrationTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIllustrationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIllustrationTaskResponse
        /// </returns>
        public GetIllustrationTaskResponse GetIllustrationTask(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationTaskWithOptions(textId, illustrationTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询配图任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIllustrationTaskResponse
        /// </returns>
        public async Task<GetIllustrationTaskResponse> GetIllustrationTaskAsync(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationTaskWithOptionsAsync(textId, illustrationTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片上传oss token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssUploadTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssUploadTokenResponse
        /// </returns>
        public GetOssUploadTokenResponse GetOssUploadTokenWithOptions(GetOssUploadTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["uploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssUploadToken",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/uploadToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssUploadTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片上传oss token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssUploadTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOssUploadTokenResponse
        /// </returns>
        public async Task<GetOssUploadTokenResponse> GetOssUploadTokenWithOptionsAsync(GetOssUploadTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["uploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssUploadToken",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/uploadToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssUploadTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片上传oss token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssUploadTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssUploadTokenResponse
        /// </returns>
        public GetOssUploadTokenResponse GetOssUploadToken(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOssUploadTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取图片上传oss token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOssUploadTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOssUploadTokenResponse
        /// </returns>
        public async Task<GetOssUploadTokenResponse> GetOssUploadTokenAsync(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOssUploadTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据人合成信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectTaskResponse
        /// </returns>
        public GetProjectTaskResponse GetProjectTaskWithOptions(GetProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
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
                Action = "GetProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/getProjectTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据人合成信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectTaskResponse
        /// </returns>
        public async Task<GetProjectTaskResponse> GetProjectTaskWithOptionsAsync(GetProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["IdempotentId"] = request.IdempotentId;
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
                Action = "GetProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/getProjectTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据人合成信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectTaskResponse
        /// </returns>
        public GetProjectTaskResponse GetProjectTask(GetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据人合成信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectTaskResponse
        /// </returns>
        public async Task<GetProjectTaskResponse> GetProjectTaskAsync(GetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案</para>
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
        /// GetTextResponse
        /// </returns>
        public GetTextResponse GetTextWithOptions(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案</para>
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
        /// GetTextResponse
        /// </returns>
        public async Task<GetTextResponse> GetTextWithOptionsAsync(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTextResponse
        /// </returns>
        public GetTextResponse GetText(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextWithOptions(textId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTextResponse
        /// </returns>
        public async Task<GetTextResponse> GetTextAsync(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextWithOptionsAsync(textId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案任务</para>
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
        /// GetTextTaskResponse
        /// </returns>
        public GetTextTaskResponse GetTextTaskWithOptions(string textTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案任务</para>
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
        /// GetTextTaskResponse
        /// </returns>
        public async Task<GetTextTaskResponse> GetTextTaskWithOptionsAsync(string textTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTextTaskResponse
        /// </returns>
        public GetTextTaskResponse GetTextTask(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextTaskWithOptions(textTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTextTaskResponse
        /// </returns>
        public async Task<GetTextTaskResponse> GetTextTaskAsync(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextTaskWithOptionsAsync(textTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextTemplateResponse
        /// </returns>
        public GetTextTemplateResponse GetTextTemplateWithOptions(GetTextTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTemplate",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/commands/getTextTemplate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextTemplateResponse
        /// </returns>
        public async Task<GetTextTemplateResponse> GetTextTemplateWithOptionsAsync(GetTextTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextTemplate",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts/commands/getTextTemplate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextTemplateResponse
        /// </returns>
        public GetTextTemplateResponse GetTextTemplate(GetTextTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询表单配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextTemplateResponse
        /// </returns>
        public async Task<GetTextTemplateResponse> GetTextTemplateAsync(GetTextTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案互动问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InteractTextResponse
        /// </returns>
        public InteractTextResponse InteractTextWithOptions(InteractTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InteractText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/stream/interactText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InteractTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案互动问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InteractTextResponse
        /// </returns>
        public async Task<InteractTextResponse> InteractTextWithOptionsAsync(InteractTextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InteractText",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/stream/interactText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InteractTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案互动问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractTextRequest
        /// </param>
        /// 
        /// <returns>
        /// InteractTextResponse
        /// </returns>
        public InteractTextResponse InteractText(InteractTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InteractTextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>营销文案互动问答</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractTextRequest
        /// </param>
        /// 
        /// <returns>
        /// InteractTextResponse
        /// </returns>
        public async Task<InteractTextResponse> InteractTextAsync(InteractTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InteractTextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachScriptPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachScriptPageResponse
        /// </returns>
        public ListAICoachScriptPageResponse ListAICoachScriptPageWithOptions(ListAICoachScriptPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAICoachScriptPage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/pageScript",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAICoachScriptPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachScriptPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachScriptPageResponse
        /// </returns>
        public async Task<ListAICoachScriptPageResponse> ListAICoachScriptPageWithOptionsAsync(ListAICoachScriptPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAICoachScriptPage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/pageScript",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAICoachScriptPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachScriptPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachScriptPageResponse
        /// </returns>
        public ListAICoachScriptPageResponse ListAICoachScriptPage(ListAICoachScriptPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAICoachScriptPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询剧本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachScriptPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachScriptPageResponse
        /// </returns>
        public async Task<ListAICoachScriptPageResponse> ListAICoachScriptPageAsync(ListAICoachScriptPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAICoachScriptPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachTaskPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachTaskPageResponse
        /// </returns>
        public ListAICoachTaskPageResponse ListAICoachTaskPageWithOptions(ListAICoachTaskPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "ListAICoachTaskPage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/listTaskPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAICoachTaskPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachTaskPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachTaskPageResponse
        /// </returns>
        public async Task<ListAICoachTaskPageResponse> ListAICoachTaskPageWithOptionsAsync(ListAICoachTaskPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "ListAICoachTaskPage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/aicoach/listTaskPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAICoachTaskPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachTaskPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachTaskPageResponse
        /// </returns>
        public ListAICoachTaskPageResponse ListAICoachTaskPage(ListAICoachTaskPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAICoachTaskPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAICoachTaskPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAICoachTaskPageResponse
        /// </returns>
        public async Task<ListAICoachTaskPageResponse> ListAICoachTaskPageAsync(ListAICoachTaskPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAICoachTaskPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgentsWithOptions(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentScene))
            {
                query["agentScene"] = request.AgentScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListAgents",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/agent/listAgents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsWithOptionsAsync(ListAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentScene))
            {
                query["agentScene"] = request.AgentScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListAgents",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/agent/listAgents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能体</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentsResponse
        /// </returns>
        public async Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字人模特列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnchorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnchorResponse
        /// </returns>
        public ListAnchorResponse ListAnchorWithOptions(ListAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorCategory))
            {
                query["anchorCategory"] = request.AnchorCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorId))
            {
                query["anchorId"] = request.AnchorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorType))
            {
                query["anchorType"] = request.AnchorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverRate))
            {
                query["coverRate"] = request.CoverRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalHumanType))
            {
                query["digitalHumanType"] = request.DigitalHumanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                query["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnchor",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/anchorOpen/listAnchor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnchorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字人模特列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnchorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAnchorResponse
        /// </returns>
        public async Task<ListAnchorResponse> ListAnchorWithOptionsAsync(ListAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorCategory))
            {
                query["anchorCategory"] = request.AnchorCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorId))
            {
                query["anchorId"] = request.AnchorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnchorType))
            {
                query["anchorType"] = request.AnchorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverRate))
            {
                query["coverRate"] = request.CoverRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalHumanType))
            {
                query["digitalHumanType"] = request.DigitalHumanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                query["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnchor",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/anchorOpen/listAnchor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnchorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字人模特列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnchorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnchorResponse
        /// </returns>
        public ListAnchorResponse ListAnchor(ListAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnchorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数字人模特列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAnchorRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAnchorResponse
        /// </returns>
        public async Task<ListAnchorResponse> ListAnchorAsync(ListAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnchorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询数字人项目启动结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvatarProjectResponse
        /// </returns>
        public ListAvatarProjectResponse ListAvatarProjectWithOptions(ListAvatarProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAvatarProjectShrinkRequest request = new ListAvatarProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProjectIdList))
            {
                request.ProjectIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProjectIdList, "projectIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdListShrink))
            {
                query["projectIdList"] = request.ProjectIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/listAvatarProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询数字人项目启动结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvatarProjectResponse
        /// </returns>
        public async Task<ListAvatarProjectResponse> ListAvatarProjectWithOptionsAsync(ListAvatarProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAvatarProjectShrinkRequest request = new ListAvatarProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProjectIdList))
            {
                request.ProjectIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProjectIdList, "projectIdList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdListShrink))
            {
                query["projectIdList"] = request.ProjectIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/listAvatarProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询数字人项目启动结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvatarProjectResponse
        /// </returns>
        public ListAvatarProjectResponse ListAvatarProject(ListAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAvatarProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询数字人项目启动结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvatarProjectResponse
        /// </returns>
        public async Task<ListAvatarProjectResponse> ListAvatarProjectAsync(ListAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAvatarProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseResponse
        /// </returns>
        public ListKnowledgeBaseResponse ListKnowledgeBaseWithOptions(ListKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["knowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListKnowledgeBase",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseResponse
        /// </returns>
        public async Task<ListKnowledgeBaseResponse> ListKnowledgeBaseWithOptionsAsync(ListKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["knowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListKnowledgeBase",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/knowledge-base",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseResponse
        /// </returns>
        public ListKnowledgeBaseResponse ListKnowledgeBase(ListKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKnowledgeBaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseResponse
        /// </returns>
        public async Task<ListKnowledgeBaseResponse> ListKnowledgeBaseAsync(ListKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKnowledgeBaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案主题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextThemesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextThemesResponse
        /// </returns>
        public ListTextThemesResponse ListTextThemesWithOptions(ListTextThemesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextThemes",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textThemes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextThemesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案主题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextThemesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextThemesResponse
        /// </returns>
        public async Task<ListTextThemesResponse> ListTextThemesWithOptionsAsync(ListTextThemesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextThemes",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/textThemes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextThemesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案主题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextThemesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextThemesResponse
        /// </returns>
        public ListTextThemesResponse ListTextThemes(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextThemesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文案主题列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextThemesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextThemesResponse
        /// </returns>
        public async Task<ListTextThemesResponse> ListTextThemesAsync(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextThemesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextsResponse
        /// </returns>
        public ListTextsResponse ListTextsWithOptions(ListTextsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextStyleType))
            {
                query["textStyleType"] = request.TextStyleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextTheme))
            {
                query["textTheme"] = request.TextTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTexts",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextsResponse
        /// </returns>
        public async Task<ListTextsResponse> ListTextsWithOptionsAsync(ListTextsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationSource))
            {
                query["generationSource"] = request.GenerationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishStatus))
            {
                query["publishStatus"] = request.PublishStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextStyleType))
            {
                query["textStyleType"] = request.TextStyleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextTheme))
            {
                query["textTheme"] = request.TextTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTexts",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/texts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextsResponse
        /// </returns>
        public ListTextsResponse ListTexts(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举文案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextsResponse
        /// </returns>
        public async Task<ListTextsResponse> ListTextsAsync(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取声音模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceModelsResponse
        /// </returns>
        public ListVoiceModelsResponse ListVoiceModelsWithOptions(ListVoiceModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                query["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceLanguage))
            {
                query["voiceLanguage"] = request.VoiceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceType))
            {
                query["voiceType"] = request.VoiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVoiceModels",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/voiceOpen/listVoiceModels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVoiceModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取声音模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceModelsResponse
        /// </returns>
        public async Task<ListVoiceModelsResponse> ListVoiceModelsWithOptionsAsync(ListVoiceModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                query["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceLanguage))
            {
                query["voiceLanguage"] = request.VoiceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceType))
            {
                query["voiceType"] = request.VoiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVoiceModels",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/voiceOpen/listVoiceModels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVoiceModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取声音模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceModelsResponse
        /// </returns>
        public ListVoiceModelsResponse ListVoiceModels(ListVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVoiceModelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取声音模版列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVoiceModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVoiceModelsResponse
        /// </returns>
        public async Task<ListVoiceModelsResponse> ListVoiceModelsAsync(ListVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVoiceModelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAvatarProjectResponse
        /// </returns>
        public OperateAvatarProjectResponse OperateAvatarProjectWithOptions(OperateAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResChannelNumber))
            {
                body["resChannelNumber"] = request.ResChannelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResType))
            {
                body["resType"] = request.ResType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/operateProjectAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAvatarProjectResponse
        /// </returns>
        public async Task<OperateAvatarProjectResponse> OperateAvatarProjectWithOptionsAsync(OperateAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResChannelNumber))
            {
                body["resChannelNumber"] = request.ResChannelNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResType))
            {
                body["resType"] = request.ResType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/operateProjectAvatar",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAvatarProjectResponse
        /// </returns>
        public OperateAvatarProjectResponse OperateAvatarProject(OperateAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OperateAvatarProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>操作实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAvatarProjectResponse
        /// </returns>
        public async Task<OperateAvatarProjectResponse> OperateAvatarProjectAsync(OperateAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OperateAvatarProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字人项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarProjectResponse
        /// </returns>
        public QueryAvatarProjectResponse QueryAvatarProjectWithOptions(QueryAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/queryAvatarProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字人项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarProjectResponse
        /// </returns>
        public async Task<QueryAvatarProjectResponse> QueryAvatarProjectWithOptionsAsync(QueryAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/queryAvatarProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字人项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarProjectResponse
        /// </returns>
        public QueryAvatarProjectResponse QueryAvatarProject(QueryAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAvatarProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数字人项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarProjectResponse
        /// </returns>
        public async Task<QueryAvatarProjectResponse> QueryAvatarProjectAsync(QueryAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAvatarProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarResourceResponse
        /// </returns>
        public QueryAvatarResourceResponse QueryAvatarResourceWithOptions(QueryAvatarResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["idempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvatarResource",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/queryResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvatarResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarResourceResponse
        /// </returns>
        public async Task<QueryAvatarResourceResponse> QueryAvatarResourceWithOptionsAsync(QueryAvatarResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["idempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvatarResource",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/queryResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvatarResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarResourceResponse
        /// </returns>
        public QueryAvatarResourceResponse QueryAvatarResource(QueryAvatarResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAvatarResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查找资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvatarResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvatarResourceResponse
        /// </returns>
        public async Task<QueryAvatarResourceResponse> QueryAvatarResourceAsync(QueryAvatarResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAvatarResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryImageToVideoTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryImageToVideoTaskResponse
        /// </returns>
        public QueryImageToVideoTaskResponse QueryImageToVideoTaskWithOptions(QueryImageToVideoTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryImageToVideoTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/imageToVideo/task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryImageToVideoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryImageToVideoTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryImageToVideoTaskResponse
        /// </returns>
        public async Task<QueryImageToVideoTaskResponse> QueryImageToVideoTaskWithOptionsAsync(QueryImageToVideoTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryImageToVideoTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/imageToVideo/task",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryImageToVideoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryImageToVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryImageToVideoTaskResponse
        /// </returns>
        public QueryImageToVideoTaskResponse QueryImageToVideoTask(QueryImageToVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryImageToVideoTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryImageToVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryImageToVideoTaskResponse
        /// </returns>
        public async Task<QueryImageToVideoTaskResponse> QueryImageToVideoTaskAsync(QueryImageToVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryImageToVideoTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIndividuationTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndividuationTextTaskResponse
        /// </returns>
        public QueryIndividuationTextTaskResponse QueryIndividuationTextTaskWithOptions(QueryIndividuationTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIndividuationTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/queryTextTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndividuationTextTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIndividuationTextTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIndividuationTextTaskResponse
        /// </returns>
        public async Task<QueryIndividuationTextTaskResponse> QueryIndividuationTextTaskWithOptionsAsync(QueryIndividuationTextTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIndividuationTextTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/individuationText/queryTextTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIndividuationTextTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIndividuationTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndividuationTextTaskResponse
        /// </returns>
        public QueryIndividuationTextTaskResponse QueryIndividuationTextTask(QueryIndividuationTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryIndividuationTextTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个性化文案任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIndividuationTextTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIndividuationTextTaskResponse
        /// </returns>
        public async Task<QueryIndividuationTextTaskResponse> QueryIndividuationTextTaskAsync(QueryIndividuationTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryIndividuationTextTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySessionInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionInfoResponse
        /// </returns>
        public QuerySessionInfoResponse QuerySessionInfoWithOptions(QuerySessionInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySessionInfoShrinkRequest request = new QuerySessionInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "statusList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["statusList"] = request.StatusListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionInfo",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/querySessionInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QuerySessionInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionInfoResponse
        /// </returns>
        public async Task<QuerySessionInfoResponse> QuerySessionInfoWithOptionsAsync(QuerySessionInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QuerySessionInfoShrinkRequest request = new QuerySessionInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "statusList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["statusList"] = request.StatusListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionInfo",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/querySessionInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySessionInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionInfoResponse
        /// </returns>
        public QuerySessionInfoResponse QuerySessionInfo(QuerySessionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySessionInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySessionInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionInfoResponse
        /// </returns>
        public async Task<QuerySessionInfoResponse> QuerySessionInfoAsync(QuerySessionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySessionInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式输出文案</para>
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
        /// QueryTextStreamResponse
        /// </returns>
        public QueryTextStreamResponse QueryTextStreamWithOptions(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTextStream",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/stream/queryTextStream/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTextStreamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式输出文案</para>
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
        /// QueryTextStreamResponse
        /// </returns>
        public async Task<QueryTextStreamResponse> QueryTextStreamWithOptionsAsync(string textId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTextStream",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/stream/queryTextStream/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(textId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTextStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式输出文案</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTextStreamResponse
        /// </returns>
        public QueryTextStreamResponse QueryTextStream(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryTextStreamWithOptions(textId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流式输出文案</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryTextStreamResponse
        /// </returns>
        public async Task<QueryTextStreamResponse> QueryTextStreamAsync(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryTextStreamWithOptionsAsync(textId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAvatarProjectResponse
        /// </returns>
        public SaveAvatarProjectResponse SaveAvatarProjectWithOptions(SaveAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BitRate))
            {
                body["bitRate"] = request.BitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                body["frameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frames))
            {
                body["frames"] = request.Frames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                body["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptModelTag))
            {
                body["scriptModelTag"] = request.ScriptModelTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizedDisplay))
            {
                body["synchronizedDisplay"] = request.SynchronizedDisplay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/saveAvatarProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAvatarProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAvatarProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveAvatarProjectResponse
        /// </returns>
        public async Task<SaveAvatarProjectResponse> SaveAvatarProjectWithOptionsAsync(SaveAvatarProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BitRate))
            {
                body["bitRate"] = request.BitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                body["frameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frames))
            {
                body["frames"] = request.Frames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                body["operateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResSpecType))
            {
                body["resSpecType"] = request.ResSpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                body["resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptModelTag))
            {
                body["scriptModelTag"] = request.ScriptModelTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynchronizedDisplay))
            {
                body["synchronizedDisplay"] = request.SynchronizedDisplay;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveAvatarProject",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/saveAvatarProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveAvatarProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAvatarProjectResponse
        /// </returns>
        public SaveAvatarProjectResponse SaveAvatarProject(SaveAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SaveAvatarProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存实时数字人项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveAvatarProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveAvatarProjectResponse
        /// </returns>
        public async Task<SaveAvatarProjectResponse> SaveAvatarProjectAsync(SaveAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SaveAvatarProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片任务</para>
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
        /// SelectImageTaskResponse
        /// </returns>
        public SelectImageTaskResponse SelectImageTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectImageTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/select/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectImageTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片任务</para>
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
        /// SelectImageTaskResponse
        /// </returns>
        public async Task<SelectImageTaskResponse> SelectImageTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectImageTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/select/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectImageTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// SelectImageTaskResponse
        /// </returns>
        public SelectImageTaskResponse SelectImageTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectImageTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询图片任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// SelectImageTaskResponse
        /// </returns>
        public async Task<SelectImageTaskResponse> SelectImageTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectImageTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离线数字人剩余资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectResourceResponse
        /// </returns>
        public SelectResourceResponse SelectResourceWithOptions(SelectResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["idempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectResource",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/commands/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离线数字人剩余资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectResourceResponse
        /// </returns>
        public async Task<SelectResourceResponse> SelectResourceWithOptionsAsync(SelectResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentId))
            {
                query["idempotentId"] = request.IdempotentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectResource",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/commands/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离线数字人剩余资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectResourceResponse
        /// </returns>
        public SelectResourceResponse SelectResource(SelectResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询离线数字人剩余资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectResourceResponse
        /// </returns>
        public async Task<SelectResourceResponse> SelectResourceAsync(SelectResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSdkMessageResponse
        /// </returns>
        public SendSdkMessageResponse SendSdkMessageWithOptions(SendSdkMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header))
            {
                body["header"] = request.Header;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                body["moduleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                body["operationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSdkMessage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/sdk/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSdkMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSdkMessageResponse
        /// </returns>
        public async Task<SendSdkMessageResponse> SendSdkMessageWithOptionsAsync(SendSdkMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header))
            {
                body["header"] = request.Header;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                body["moduleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                body["operationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSdkMessage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/sdk/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSdkMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSdkMessageResponse
        /// </returns>
        public SendSdkMessageResponse SendSdkMessage(SendSdkMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendSdkMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSdkMessageResponse
        /// </returns>
        public async Task<SendSdkMessageResponse> SendSdkMessageAsync(SendSdkMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendSdkMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk流式消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkStreamMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSdkStreamMessageResponse
        /// </returns>
        public SendSdkStreamMessageResponse SendSdkStreamMessageWithOptions(SendSdkStreamMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header))
            {
                body["header"] = request.Header;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                body["moduleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                body["operationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSdkStreamMessage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/sdk/stream/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSdkStreamMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk流式消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkStreamMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSdkStreamMessageResponse
        /// </returns>
        public async Task<SendSdkStreamMessageResponse> SendSdkStreamMessageWithOptionsAsync(SendSdkStreamMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Header))
            {
                body["header"] = request.Header;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                body["moduleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                body["operationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSdkStreamMessage",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/sdk/stream/sendMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSdkStreamMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk流式消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkStreamMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSdkStreamMessageResponse
        /// </returns>
        public SendSdkStreamMessageResponse SendSdkStreamMessage(SendSdkStreamMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendSdkStreamMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送sdk流式消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendSdkStreamMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendSdkStreamMessageResponse
        /// </returns>
        public async Task<SendSdkStreamMessageResponse> SendSdkStreamMessageAsync(SendSdkStreamMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendSdkStreamMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文本消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTextMsgRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTextMsgResponse
        /// </returns>
        public SendTextMsgResponse SendTextMsgWithOptions(SendTextMsgRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTextMsg",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/sendTextMsg",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTextMsgResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文本消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTextMsgRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTextMsgResponse
        /// </returns>
        public async Task<SendTextMsgResponse> SendTextMsgWithOptionsAsync(SendTextMsgRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTextMsg",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/sendTextMsg",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTextMsgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文本消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTextMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTextMsgResponse
        /// </returns>
        public SendTextMsgResponse SendTextMsg(SendTextMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendTextMsgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送文本消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTextMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTextMsgResponse
        /// </returns>
        public async Task<SendTextMsgResponse> SendTextMsgAsync(SendTextMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendTextMsgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAvatarSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAvatarSessionResponse
        /// </returns>
        public StartAvatarSessionResponse StartAvatarSessionWithOptions(StartAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelToken))
            {
                body["channelToken"] = request.ChannelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPushUrl))
            {
                body["customPushUrl"] = request.CustomPushUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                body["customUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAvatarSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/startAvatarSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAvatarSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAvatarSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartAvatarSessionResponse
        /// </returns>
        public async Task<StartAvatarSessionResponse> StartAvatarSessionWithOptionsAsync(StartAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelToken))
            {
                body["channelToken"] = request.ChannelToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPushUrl))
            {
                body["customPushUrl"] = request.CustomPushUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                body["customUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAvatarSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/startAvatarSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAvatarSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAvatarSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAvatarSessionResponse
        /// </returns>
        public StartAvatarSessionResponse StartAvatarSession(StartAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAvatarSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartAvatarSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartAvatarSessionResponse
        /// </returns>
        public async Task<StartAvatarSessionResponse> StartAvatarSessionAsync(StartAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAvatarSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAvatarSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAvatarSessionResponse
        /// </returns>
        public StopAvatarSessionResponse StopAvatarSessionWithOptions(StopAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAvatarSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/stopAvatarSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAvatarSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAvatarSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopAvatarSessionResponse
        /// </returns>
        public async Task<StopAvatarSessionResponse> StopAvatarSessionWithOptionsAsync(StopAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAvatarSession",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/avatar/project/stopAvatarSession",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAvatarSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAvatarSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAvatarSessionResponse
        /// </returns>
        public StopAvatarSessionResponse StopAvatarSession(StopAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAvatarSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopAvatarSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StopAvatarSessionResponse
        /// </returns>
        public async Task<StopAvatarSessionResponse> StopAvatarSessionAsync(StopAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAvatarSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频合成任务停止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopProjectTaskResponse
        /// </returns>
        public StopProjectTaskResponse StopProjectTaskWithOptions(StopProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频合成任务停止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopProjectTaskResponse
        /// </returns>
        public async Task<StopProjectTaskResponse> StopProjectTaskWithOptionsAsync(StopProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频合成任务停止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopProjectTaskResponse
        /// </returns>
        public StopProjectTaskResponse StopProjectTask(StopProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopProjectTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>视频合成任务停止</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopProjectTaskResponse
        /// </returns>
        public async Task<StopProjectTaskResponse> StopProjectTaskAsync(StopProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageToVideoTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageToVideoTaskResponse
        /// </returns>
        public SubmitImageToVideoTaskResponse SubmitImageToVideoTaskWithOptions(SubmitImageToVideoTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosPrompt))
            {
                body["posPrompt"] = request.PosPrompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageToVideoTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/imageToVideo/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageToVideoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageToVideoTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageToVideoTaskResponse
        /// </returns>
        public async Task<SubmitImageToVideoTaskResponse> SubmitImageToVideoTaskWithOptionsAsync(SubmitImageToVideoTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PosPrompt))
            {
                body["posPrompt"] = request.PosPrompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageToVideoTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/video/imageToVideo/task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageToVideoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageToVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageToVideoTaskResponse
        /// </returns>
        public SubmitImageToVideoTaskResponse SubmitImageToVideoTask(SubmitImageToVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitImageToVideoTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交图片转视频任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageToVideoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageToVideoTaskResponse
        /// </returns>
        public async Task<SubmitImageToVideoTaskResponse> SubmitImageToVideoTaskAsync(SubmitImageToVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitImageToVideoTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线数字人合成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitProjectTaskResponse
        /// </returns>
        public SubmitProjectTaskResponse SubmitProjectTaskWithOptions(SubmitProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frames))
            {
                body["frames"] = request.Frames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubtitleTag))
            {
                body["subtitleTag"] = request.SubtitleTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentBackground))
            {
                body["transparentBackground"] = request.TransparentBackground;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/submitProjectTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitProjectTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线数字人合成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitProjectTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitProjectTaskResponse
        /// </returns>
        public async Task<SubmitProjectTaskResponse> SubmitProjectTaskWithOptionsAsync(SubmitProjectTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frames))
            {
                body["frames"] = request.Frames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                body["scaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubtitleTag))
            {
                body["subtitleTag"] = request.SubtitleTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransparentBackground))
            {
                body["transparentBackground"] = request.TransparentBackground;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitProjectTask",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/digitalHuman/project/submitProjectTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitProjectTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线数字人合成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitProjectTaskResponse
        /// </returns>
        public SubmitProjectTaskResponse SubmitProjectTask(SubmitProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitProjectTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交离线数字人合成任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitProjectTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitProjectTaskResponse
        /// </returns>
        public async Task<SubmitProjectTaskResponse> SubmitProjectTaskAsync(SubmitProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人像风格变化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferPortraitStyleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferPortraitStyleResponse
        /// </returns>
        public TransferPortraitStyleResponse TransferPortraitStyleWithOptions(TransferPortraitStyleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                body["numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedrawAmplitude))
            {
                body["redrawAmplitude"] = request.RedrawAmplitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferPortraitStyle",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/transferPortraitStyle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferPortraitStyleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人像风格变化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferPortraitStyleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferPortraitStyleResponse
        /// </returns>
        public async Task<TransferPortraitStyleResponse> TransferPortraitStyleWithOptionsAsync(TransferPortraitStyleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Numbers))
            {
                body["numbers"] = request.Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedrawAmplitude))
            {
                body["redrawAmplitude"] = request.RedrawAmplitude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferPortraitStyle",
                Version = "2024-03-13",
                Protocol = "HTTPS",
                Pathname = "/yic/yic-console/openService/v1/images/portrait/transferPortraitStyle",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferPortraitStyleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人像风格变化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferPortraitStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferPortraitStyleResponse
        /// </returns>
        public TransferPortraitStyleResponse TransferPortraitStyle(TransferPortraitStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TransferPortraitStyleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人像风格变化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferPortraitStyleRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferPortraitStyleResponse
        /// </returns>
        public async Task<TransferPortraitStyleResponse> TransferPortraitStyleAsync(TransferPortraitStyleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TransferPortraitStyleWithOptionsAsync(request, headers, runtime);
        }

    }
}
