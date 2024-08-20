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

        /**
         * @summary 添加文案反馈
         *
         * @param request AddTextFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTextFeedbackResponse
         */
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

        /**
         * @summary 添加文案反馈
         *
         * @param request AddTextFeedbackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTextFeedbackResponse
         */
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

        /**
         * @summary 添加文案反馈
         *
         * @param request AddTextFeedbackRequest
         * @return AddTextFeedbackResponse
         */
        public AddTextFeedbackResponse AddTextFeedback(AddTextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddTextFeedbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加文案反馈
         *
         * @param request AddTextFeedbackRequest
         * @return AddTextFeedbackResponse
         */
        public async Task<AddTextFeedbackResponse> AddTextFeedbackAsync(AddTextFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddTextFeedbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询项目信息
         *
         * @param tmpReq BatchGetProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetProjectTaskResponse
         */
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

        /**
         * @summary 批量查询项目信息
         *
         * @param tmpReq BatchGetProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetProjectTaskResponse
         */
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

        /**
         * @summary 批量查询项目信息
         *
         * @param request BatchGetProjectTaskRequest
         * @return BatchGetProjectTaskResponse
         */
        public BatchGetProjectTaskResponse BatchGetProjectTask(BatchGetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetProjectTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询项目信息
         *
         * @param request BatchGetProjectTaskRequest
         * @return BatchGetProjectTaskResponse
         */
        public async Task<BatchGetProjectTaskResponse> BatchGetProjectTaskAsync(BatchGetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 检查会话状态
         *
         * @param request CheckSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSessionResponse
         */
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

        /**
         * @summary 检查会话状态
         *
         * @param request CheckSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSessionResponse
         */
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

        /**
         * @summary 检查会话状态
         *
         * @param request CheckSessionRequest
         * @return CheckSessionResponse
         */
        public CheckSessionResponse CheckSession(CheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckSessionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 检查会话状态
         *
         * @param request CheckSessionRequest
         * @return CheckSessionResponse
         */
        public async Task<CheckSessionResponse> CheckSessionAsync(CheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckSessionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 文本数量统计
         *
         * @param request CountTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CountTextResponse
         */
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

        /**
         * @summary 文本数量统计
         *
         * @param request CountTextRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CountTextResponse
         */
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

        /**
         * @summary 文本数量统计
         *
         * @param request CountTextRequest
         * @return CountTextResponse
         */
        public CountTextResponse CountText(CountTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CountTextWithOptions(request, headers, runtime);
        }

        /**
         * @summary 文本数量统计
         *
         * @param request CountTextRequest
         * @return CountTextResponse
         */
        public async Task<CountTextResponse> CountTextAsync(CountTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CountTextWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIllustrationTaskResponse
         */
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

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIllustrationTaskResponse
         */
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

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @return CreateIllustrationTaskResponse
         */
        public CreateIllustrationTaskResponse CreateIllustrationTask(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIllustrationTaskWithOptions(textId, request, headers, runtime);
        }

        /**
         * @summary 创建配图生成任务
         *
         * @param request CreateIllustrationTaskRequest
         * @return CreateIllustrationTaskResponse
         */
        public async Task<CreateIllustrationTaskResponse> CreateIllustrationTaskAsync(string textId, CreateIllustrationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIllustrationTaskWithOptionsAsync(textId, request, headers, runtime);
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTextTaskResponse
         */
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

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTextTaskResponse
         */
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

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @return CreateTextTaskResponse
         */
        public CreateTextTaskResponse CreateTextTask(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTextTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建文案生成任务
         *
         * @param request CreateTextTaskRequest
         * @return CreateTextTaskResponse
         */
        public async Task<CreateTextTaskResponse> CreateTextTaskAsync(CreateTextTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTextTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询配图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationResponse
         */
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

        /**
         * @summary 查询配图
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationResponse
         */
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

        /**
         * @summary 查询配图
         *
         * @return GetIllustrationResponse
         */
        public GetIllustrationResponse GetIllustration(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationWithOptions(textId, illustrationId, headers, runtime);
        }

        /**
         * @summary 查询配图
         *
         * @return GetIllustrationResponse
         */
        public async Task<GetIllustrationResponse> GetIllustrationAsync(string textId, string illustrationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationWithOptionsAsync(textId, illustrationId, headers, runtime);
        }

        /**
         * @summary 查询配图任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationTaskResponse
         */
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

        /**
         * @summary 查询配图任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIllustrationTaskResponse
         */
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

        /**
         * @summary 查询配图任务
         *
         * @return GetIllustrationTaskResponse
         */
        public GetIllustrationTaskResponse GetIllustrationTask(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIllustrationTaskWithOptions(textId, illustrationTaskId, headers, runtime);
        }

        /**
         * @summary 查询配图任务
         *
         * @return GetIllustrationTaskResponse
         */
        public async Task<GetIllustrationTaskResponse> GetIllustrationTaskAsync(string textId, string illustrationTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIllustrationTaskWithOptionsAsync(textId, illustrationTaskId, headers, runtime);
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssUploadTokenResponse
         */
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

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssUploadTokenResponse
         */
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

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @return GetOssUploadTokenResponse
         */
        public GetOssUploadTokenResponse GetOssUploadToken(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOssUploadTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取图片上传oss token
         *
         * @param request GetOssUploadTokenRequest
         * @return GetOssUploadTokenResponse
         */
        public async Task<GetOssUploadTokenResponse> GetOssUploadTokenAsync(GetOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOssUploadTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取数据人合成信息
         *
         * @param request GetProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectTaskResponse
         */
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

        /**
         * @summary 获取数据人合成信息
         *
         * @param request GetProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectTaskResponse
         */
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

        /**
         * @summary 获取数据人合成信息
         *
         * @param request GetProjectTaskRequest
         * @return GetProjectTaskResponse
         */
        public GetProjectTaskResponse GetProjectTask(GetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取数据人合成信息
         *
         * @param request GetProjectTaskRequest
         * @return GetProjectTaskResponse
         */
        public async Task<GetProjectTaskResponse> GetProjectTaskAsync(GetProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询文案
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextResponse
         */
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

        /**
         * @summary 查询文案
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextResponse
         */
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

        /**
         * @summary 查询文案
         *
         * @return GetTextResponse
         */
        public GetTextResponse GetText(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextWithOptions(textId, headers, runtime);
        }

        /**
         * @summary 查询文案
         *
         * @return GetTextResponse
         */
        public async Task<GetTextResponse> GetTextAsync(string textId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextWithOptionsAsync(textId, headers, runtime);
        }

        /**
         * @summary 查询文案任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTaskResponse
         */
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

        /**
         * @summary 查询文案任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTaskResponse
         */
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

        /**
         * @summary 查询文案任务
         *
         * @return GetTextTaskResponse
         */
        public GetTextTaskResponse GetTextTask(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextTaskWithOptions(textTaskId, headers, runtime);
        }

        /**
         * @summary 查询文案任务
         *
         * @return GetTextTaskResponse
         */
        public async Task<GetTextTaskResponse> GetTextTaskAsync(string textTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextTaskWithOptionsAsync(textTaskId, headers, runtime);
        }

        /**
         * @summary 查询表单配置
         *
         * @param request GetTextTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTemplateResponse
         */
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

        /**
         * @summary 查询表单配置
         *
         * @param request GetTextTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextTemplateResponse
         */
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

        /**
         * @summary 查询表单配置
         *
         * @param request GetTextTemplateRequest
         * @return GetTextTemplateResponse
         */
        public GetTextTemplateResponse GetTextTemplate(GetTextTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询表单配置
         *
         * @param request GetTextTemplateRequest
         * @return GetTextTemplateResponse
         */
        public async Task<GetTextTemplateResponse> GetTextTemplateAsync(GetTextTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取数字人模特列表
         *
         * @param request ListAnchorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnchorResponse
         */
        public ListAnchorResponse ListAnchorWithOptions(ListAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取数字人模特列表
         *
         * @param request ListAnchorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnchorResponse
         */
        public async Task<ListAnchorResponse> ListAnchorWithOptionsAsync(ListAnchorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取数字人模特列表
         *
         * @param request ListAnchorRequest
         * @return ListAnchorResponse
         */
        public ListAnchorResponse ListAnchor(ListAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnchorWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取数字人模特列表
         *
         * @param request ListAnchorRequest
         * @return ListAnchorResponse
         */
        public async Task<ListAnchorResponse> ListAnchorAsync(ListAnchorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnchorWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextThemesResponse
         */
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

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextThemesResponse
         */
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

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @return ListTextThemesResponse
         */
        public ListTextThemesResponse ListTextThemes(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextThemesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询文案主题列表
         *
         * @param request ListTextThemesRequest
         * @return ListTextThemesResponse
         */
        public async Task<ListTextThemesResponse> ListTextThemesAsync(ListTextThemesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextThemesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextsResponse
         */
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

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTextsResponse
         */
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

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @return ListTextsResponse
         */
        public ListTextsResponse ListTexts(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举文案
         *
         * @param request ListTextsRequest
         * @return ListTextsResponse
         */
        public async Task<ListTextsResponse> ListTextsAsync(ListTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取声音模版列表
         *
         * @param request ListVoiceModelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVoiceModelsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
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

        /**
         * @summary 获取声音模版列表
         *
         * @param request ListVoiceModelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVoiceModelsResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseScene))
            {
                query["useScene"] = request.UseScene;
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

        /**
         * @summary 获取声音模版列表
         *
         * @param request ListVoiceModelsRequest
         * @return ListVoiceModelsResponse
         */
        public ListVoiceModelsResponse ListVoiceModels(ListVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVoiceModelsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取声音模版列表
         *
         * @param request ListVoiceModelsRequest
         * @return ListVoiceModelsResponse
         */
        public async Task<ListVoiceModelsResponse> ListVoiceModelsAsync(ListVoiceModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVoiceModelsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询数字人项目信息
         *
         * @param request QueryAvatarProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvatarProjectResponse
         */
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

        /**
         * @summary 查询数字人项目信息
         *
         * @param request QueryAvatarProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvatarProjectResponse
         */
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

        /**
         * @summary 查询数字人项目信息
         *
         * @param request QueryAvatarProjectRequest
         * @return QueryAvatarProjectResponse
         */
        public QueryAvatarProjectResponse QueryAvatarProject(QueryAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAvatarProjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询数字人项目信息
         *
         * @param request QueryAvatarProjectRequest
         * @return QueryAvatarProjectResponse
         */
        public async Task<QueryAvatarProjectResponse> QueryAvatarProjectAsync(QueryAvatarProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAvatarProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查找资源
         *
         * @param request QueryAvatarResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvatarResourceResponse
         */
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

        /**
         * @summary 查找资源
         *
         * @param request QueryAvatarResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAvatarResourceResponse
         */
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

        /**
         * @summary 查找资源
         *
         * @param request QueryAvatarResourceRequest
         * @return QueryAvatarResourceResponse
         */
        public QueryAvatarResourceResponse QueryAvatarResource(QueryAvatarResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryAvatarResourceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查找资源
         *
         * @param request QueryAvatarResourceRequest
         * @return QueryAvatarResourceResponse
         */
        public async Task<QueryAvatarResourceResponse> QueryAvatarResourceAsync(QueryAvatarResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryAvatarResourceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询离线数字人剩余资源
         *
         * @param request SelectResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SelectResourceResponse
         */
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

        /**
         * @summary 查询离线数字人剩余资源
         *
         * @param request SelectResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SelectResourceResponse
         */
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

        /**
         * @summary 查询离线数字人剩余资源
         *
         * @param request SelectResourceRequest
         * @return SelectResourceResponse
         */
        public SelectResourceResponse SelectResource(SelectResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SelectResourceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询离线数字人剩余资源
         *
         * @param request SelectResourceRequest
         * @return SelectResourceResponse
         */
        public async Task<SelectResourceResponse> SelectResourceAsync(SelectResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SelectResourceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送文本消息
         *
         * @param request SendTextMsgRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTextMsgResponse
         */
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

        /**
         * @summary 发送文本消息
         *
         * @param request SendTextMsgRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTextMsgResponse
         */
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

        /**
         * @summary 发送文本消息
         *
         * @param request SendTextMsgRequest
         * @return SendTextMsgResponse
         */
        public SendTextMsgResponse SendTextMsg(SendTextMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendTextMsgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送文本消息
         *
         * @param request SendTextMsgRequest
         * @return SendTextMsgResponse
         */
        public async Task<SendTextMsgResponse> SendTextMsgAsync(SendTextMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendTextMsgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启动会话
         *
         * @param request StartAvatarSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAvatarSessionResponse
         */
        public StartAvatarSessionResponse StartAvatarSessionWithOptions(StartAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 启动会话
         *
         * @param request StartAvatarSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAvatarSessionResponse
         */
        public async Task<StartAvatarSessionResponse> StartAvatarSessionWithOptionsAsync(StartAvatarSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 启动会话
         *
         * @param request StartAvatarSessionRequest
         * @return StartAvatarSessionResponse
         */
        public StartAvatarSessionResponse StartAvatarSession(StartAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAvatarSessionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 启动会话
         *
         * @param request StartAvatarSessionRequest
         * @return StartAvatarSessionResponse
         */
        public async Task<StartAvatarSessionResponse> StartAvatarSessionAsync(StartAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAvatarSessionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 停止会话
         *
         * @param request StopAvatarSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAvatarSessionResponse
         */
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

        /**
         * @summary 停止会话
         *
         * @param request StopAvatarSessionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAvatarSessionResponse
         */
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

        /**
         * @summary 停止会话
         *
         * @param request StopAvatarSessionRequest
         * @return StopAvatarSessionResponse
         */
        public StopAvatarSessionResponse StopAvatarSession(StopAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAvatarSessionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 停止会话
         *
         * @param request StopAvatarSessionRequest
         * @return StopAvatarSessionResponse
         */
        public async Task<StopAvatarSessionResponse> StopAvatarSessionAsync(StopAvatarSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAvatarSessionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 视频合成任务停止
         *
         * @param request StopProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectTaskResponse
         */
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

        /**
         * @summary 视频合成任务停止
         *
         * @param request StopProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectTaskResponse
         */
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

        /**
         * @summary 视频合成任务停止
         *
         * @param request StopProjectTaskRequest
         * @return StopProjectTaskResponse
         */
        public StopProjectTaskResponse StopProjectTask(StopProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopProjectTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 视频合成任务停止
         *
         * @param request StopProjectTaskRequest
         * @return StopProjectTaskResponse
         */
        public async Task<StopProjectTaskResponse> StopProjectTaskAsync(StopProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopProjectTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 提交离线数字人合成任务
         *
         * @param request SubmitProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitProjectTaskResponse
         */
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

        /**
         * @summary 提交离线数字人合成任务
         *
         * @param request SubmitProjectTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitProjectTaskResponse
         */
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

        /**
         * @summary 提交离线数字人合成任务
         *
         * @param request SubmitProjectTaskRequest
         * @return SubmitProjectTaskResponse
         */
        public SubmitProjectTaskResponse SubmitProjectTask(SubmitProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitProjectTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提交离线数字人合成任务
         *
         * @param request SubmitProjectTaskRequest
         * @return SubmitProjectTaskResponse
         */
        public async Task<SubmitProjectTaskResponse> SubmitProjectTaskAsync(SubmitProjectTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitProjectTaskWithOptionsAsync(request, headers, runtime);
        }

    }
}
