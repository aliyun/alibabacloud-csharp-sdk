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

        /**
         * @summary 取消异步任务
         *
         * @param request CancelAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAsyncTaskResponse
         */
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

        /**
         * @summary 取消异步任务
         *
         * @param request CancelAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelAsyncTaskResponse
         */
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

        /**
         * @summary 取消异步任务
         *
         * @param request CancelAsyncTaskRequest
         * @return CancelAsyncTaskResponse
         */
        public CancelAsyncTaskResponse CancelAsyncTask(CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAsyncTaskWithOptions(request, runtime);
        }

        /**
         * @summary 取消异步任务
         *
         * @param request CancelAsyncTaskRequest
         * @return CancelAsyncTaskResponse
         */
        public async Task<CancelAsyncTaskResponse> CancelAsyncTaskAsync(CancelAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAsyncTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 清除所有干预内容
         *
         * @param request ClearIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearIntervenesResponse
         */
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

        /**
         * @summary 清除所有干预内容
         *
         * @param request ClearIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearIntervenesResponse
         */
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

        /**
         * @summary 清除所有干预内容
         *
         * @param request ClearIntervenesRequest
         * @return ClearIntervenesResponse
         */
        public ClearIntervenesResponse ClearIntervenes(ClearIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearIntervenesWithOptions(request, runtime);
        }

        /**
         * @summary 清除所有干预内容
         *
         * @param request ClearIntervenesRequest
         * @return ClearIntervenesResponse
         */
        public async Task<ClearIntervenesResponse> ClearIntervenesAsync(ClearIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearIntervenesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-创建
         *
         * @param tmpReq CreateGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-创建
         *
         * @param tmpReq CreateGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-创建
         *
         * @param request CreateGeneratedContentRequest
         * @return CreateGeneratedContentResponse
         */
        public CreateGeneratedContentResponse CreateGeneratedContent(CreateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGeneratedContentWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-创建
         *
         * @param request CreateGeneratedContentRequest
         * @return CreateGeneratedContentResponse
         */
        public async Task<CreateGeneratedContentResponse> CreateGeneratedContentAsync(CreateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGeneratedContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取授权token
         *
         * @param request CreateTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTokenResponse
         */
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

        /**
         * @summary 获取授权token
         *
         * @param request CreateTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTokenResponse
         */
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

        /**
         * @summary 获取授权token
         *
         * @param request CreateTokenRequest
         * @return CreateTokenResponse
         */
        public CreateTokenResponse CreateToken(CreateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTokenWithOptions(request, runtime);
        }

        /**
         * @summary 获取授权token
         *
         * @param request CreateTokenRequest
         * @return CreateTokenResponse
         */
        public async Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除自定义文本
         *
         * @param request DeleteCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTextResponse
         */
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

        /**
         * @summary 删除自定义文本
         *
         * @param request DeleteCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTextResponse
         */
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

        /**
         * @summary 删除自定义文本
         *
         * @param request DeleteCustomTextRequest
         * @return DeleteCustomTextResponse
         */
        public DeleteCustomTextResponse DeleteCustomText(DeleteCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTextWithOptions(request, runtime);
        }

        /**
         * @summary 删除自定义文本
         *
         * @param request DeleteCustomTextRequest
         * @return DeleteCustomTextResponse
         */
        public async Task<DeleteCustomTextResponse> DeleteCustomTextAsync(DeleteCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据主题删除自定义主题事件
         *
         * @param request DeleteCustomTopicByTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTopicByTopicResponse
         */
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

        /**
         * @summary 根据主题删除自定义主题事件
         *
         * @param request DeleteCustomTopicByTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTopicByTopicResponse
         */
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

        /**
         * @summary 根据主题删除自定义主题事件
         *
         * @param request DeleteCustomTopicByTopicRequest
         * @return DeleteCustomTopicByTopicResponse
         */
        public DeleteCustomTopicByTopicResponse DeleteCustomTopicByTopic(DeleteCustomTopicByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTopicByTopicWithOptions(request, runtime);
        }

        /**
         * @summary 根据主题删除自定义主题事件
         *
         * @param request DeleteCustomTopicByTopicRequest
         * @return DeleteCustomTopicByTopicResponse
         */
        public async Task<DeleteCustomTopicByTopicResponse> DeleteCustomTopicByTopicAsync(DeleteCustomTopicByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTopicByTopicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据自定义观点ID删除自定义观点
         *
         * @param request DeleteCustomTopicViewPointByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTopicViewPointByIdResponse
         */
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

        /**
         * @summary 根据自定义观点ID删除自定义观点
         *
         * @param request DeleteCustomTopicViewPointByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTopicViewPointByIdResponse
         */
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

        /**
         * @summary 根据自定义观点ID删除自定义观点
         *
         * @param request DeleteCustomTopicViewPointByIdRequest
         * @return DeleteCustomTopicViewPointByIdResponse
         */
        public DeleteCustomTopicViewPointByIdResponse DeleteCustomTopicViewPointById(DeleteCustomTopicViewPointByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTopicViewPointByIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据自定义观点ID删除自定义观点
         *
         * @param request DeleteCustomTopicViewPointByIdRequest
         * @return DeleteCustomTopicViewPointByIdResponse
         */
        public async Task<DeleteCustomTopicViewPointByIdResponse> DeleteCustomTopicViewPointByIdAsync(DeleteCustomTopicViewPointByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTopicViewPointByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-删除。
         *
         * @param request DeleteGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-删除。
         *
         * @param request DeleteGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-删除。
         *
         * @param request DeleteGeneratedContentRequest
         * @return DeleteGeneratedContentResponse
         */
        public DeleteGeneratedContentResponse DeleteGeneratedContent(DeleteGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGeneratedContentWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-删除。
         *
         * @param request DeleteGeneratedContentRequest
         * @return DeleteGeneratedContentResponse
         */
        public async Task<DeleteGeneratedContentResponse> DeleteGeneratedContentAsync(DeleteGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGeneratedContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除干预规则
         *
         * @param request DeleteInterveneRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInterveneRuleResponse
         */
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

        /**
         * @summary 删除干预规则
         *
         * @param request DeleteInterveneRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInterveneRuleResponse
         */
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

        /**
         * @summary 删除干预规则
         *
         * @param request DeleteInterveneRuleRequest
         * @return DeleteInterveneRuleResponse
         */
        public DeleteInterveneRuleResponse DeleteInterveneRule(DeleteInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInterveneRuleWithOptions(request, runtime);
        }

        /**
         * @summary 删除干预规则
         *
         * @param request DeleteInterveneRuleRequest
         * @return DeleteInterveneRuleResponse
         */
        public async Task<DeleteInterveneRuleResponse> DeleteInterveneRuleAsync(DeleteInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInterveneRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据ID删除素材
         *
         * @param request DeleteMaterialByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMaterialByIdResponse
         */
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

        /**
         * @summary 根据ID删除素材
         *
         * @param request DeleteMaterialByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMaterialByIdResponse
         */
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

        /**
         * @summary 根据ID删除素材
         *
         * @param request DeleteMaterialByIdRequest
         * @return DeleteMaterialByIdResponse
         */
        public DeleteMaterialByIdResponse DeleteMaterialById(DeleteMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMaterialByIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据ID删除素材
         *
         * @param request DeleteMaterialByIdRequest
         * @return DeleteMaterialByIdResponse
         */
        public async Task<DeleteMaterialByIdResponse> DeleteMaterialByIdAsync(DeleteMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMaterialByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 从链接中提取文档内容
         *
         * @param tmpReq DocumentExtractionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocumentExtractionResponse
         */
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

        /**
         * @summary 从链接中提取文档内容
         *
         * @param tmpReq DocumentExtractionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DocumentExtractionResponse
         */
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

        /**
         * @summary 从链接中提取文档内容
         *
         * @param request DocumentExtractionRequest
         * @return DocumentExtractionResponse
         */
        public DocumentExtractionResponse DocumentExtraction(DocumentExtractionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocumentExtractionWithOptions(request, runtime);
        }

        /**
         * @summary 从链接中提取文档内容
         *
         * @param request DocumentExtractionRequest
         * @return DocumentExtractionResponse
         */
        public async Task<DocumentExtractionResponse> DocumentExtractionAsync(DocumentExtractionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocumentExtractionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-导出。
         *
         * @param request ExportGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-导出。
         *
         * @param request ExportGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-导出。
         *
         * @param request ExportGeneratedContentRequest
         * @return ExportGeneratedContentResponse
         */
        public ExportGeneratedContentResponse ExportGeneratedContent(ExportGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportGeneratedContentWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-导出。
         *
         * @param request ExportGeneratedContentRequest
         * @return ExportGeneratedContentResponse
         */
        public async Task<ExportGeneratedContentResponse> ExportGeneratedContentAsync(ExportGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportGeneratedContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出选题策划文档，响应为一个可公开访问的URL。一小时后失效
         *
         * @param tmpReq ExportHotTopicPlanningProposalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportHotTopicPlanningProposalsResponse
         */
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

        /**
         * @summary 导出选题策划文档，响应为一个可公开访问的URL。一小时后失效
         *
         * @param tmpReq ExportHotTopicPlanningProposalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportHotTopicPlanningProposalsResponse
         */
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

        /**
         * @summary 导出选题策划文档，响应为一个可公开访问的URL。一小时后失效
         *
         * @param request ExportHotTopicPlanningProposalsRequest
         * @return ExportHotTopicPlanningProposalsResponse
         */
        public ExportHotTopicPlanningProposalsResponse ExportHotTopicPlanningProposals(ExportHotTopicPlanningProposalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportHotTopicPlanningProposalsWithOptions(request, runtime);
        }

        /**
         * @summary 导出选题策划文档，响应为一个可公开访问的URL。一小时后失效
         *
         * @param request ExportHotTopicPlanningProposalsRequest
         * @return ExportHotTopicPlanningProposalsResponse
         */
        public async Task<ExportHotTopicPlanningProposalsResponse> ExportHotTopicPlanningProposalsAsync(ExportHotTopicPlanningProposalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportHotTopicPlanningProposalsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出所有干预内容
         *
         * @param request ExportIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportIntervenesResponse
         */
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

        /**
         * @summary 导出所有干预内容
         *
         * @param request ExportIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportIntervenesResponse
         */
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

        /**
         * @summary 导出所有干预内容
         *
         * @param request ExportIntervenesRequest
         * @return ExportIntervenesResponse
         */
        public ExportIntervenesResponse ExportIntervenes(ExportIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportIntervenesWithOptions(request, runtime);
        }

        /**
         * @summary 导出所有干预内容
         *
         * @param request ExportIntervenesRequest
         * @return ExportIntervenesResponse
         */
        public async Task<ExportIntervenesResponse> ExportIntervenesAsync(ExportIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportIntervenesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 反馈某次生成的结果
         *
         * @param tmpReq FeedbackDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FeedbackDialogueResponse
         */
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

        /**
         * @summary 反馈某次生成的结果
         *
         * @param tmpReq FeedbackDialogueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FeedbackDialogueResponse
         */
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

        /**
         * @summary 反馈某次生成的结果
         *
         * @param request FeedbackDialogueRequest
         * @return FeedbackDialogueResponse
         */
        public FeedbackDialogueResponse FeedbackDialogue(FeedbackDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FeedbackDialogueWithOptions(request, runtime);
        }

        /**
         * @summary 反馈某次生成的结果
         *
         * @param request FeedbackDialogueRequest
         * @return FeedbackDialogueResponse
         */
        public async Task<FeedbackDialogueResponse> FeedbackDialogueAsync(FeedbackDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FeedbackDialogueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片任务执行结果
         *
         * @param tmpReq FetchImageTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchImageTaskResponse
         */
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

        /**
         * @summary 获取图片任务执行结果
         *
         * @param tmpReq FetchImageTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchImageTaskResponse
         */
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

        /**
         * @summary 获取图片任务执行结果
         *
         * @param request FetchImageTaskRequest
         * @return FetchImageTaskResponse
         */
        public FetchImageTaskResponse FetchImageTask(FetchImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchImageTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片任务执行结果
         *
         * @param request FetchImageTaskRequest
         * @return FetchImageTaskResponse
         */
        public async Task<FetchImageTaskResponse> FetchImageTaskAsync(FetchImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchImageTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成临时可访问的公开url
         *
         * @param request GenerateFileUrlByKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateFileUrlByKeyResponse
         */
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

        /**
         * @summary 生成临时可访问的公开url
         *
         * @param request GenerateFileUrlByKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateFileUrlByKeyResponse
         */
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

        /**
         * @summary 生成临时可访问的公开url
         *
         * @param request GenerateFileUrlByKeyRequest
         * @return GenerateFileUrlByKeyResponse
         */
        public GenerateFileUrlByKeyResponse GenerateFileUrlByKey(GenerateFileUrlByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateFileUrlByKeyWithOptions(request, runtime);
        }

        /**
         * @summary 生成临时可访问的公开url
         *
         * @param request GenerateFileUrlByKeyRequest
         * @return GenerateFileUrlByKeyResponse
         */
        public async Task<GenerateFileUrlByKeyResponse> GenerateFileUrlByKeyAsync(GenerateFileUrlByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateFileUrlByKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 智能配图，图片生成任务
         *
         * @param tmpReq GenerateImageTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateImageTaskResponse
         */
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

        /**
         * @summary 智能配图，图片生成任务
         *
         * @param tmpReq GenerateImageTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateImageTaskResponse
         */
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

        /**
         * @summary 智能配图，图片生成任务
         *
         * @param request GenerateImageTaskRequest
         * @return GenerateImageTaskResponse
         */
        public GenerateImageTaskResponse GenerateImageTask(GenerateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateImageTaskWithOptions(request, runtime);
        }

        /**
         * @summary 智能配图，图片生成任务
         *
         * @param request GenerateImageTaskRequest
         * @return GenerateImageTaskResponse
         */
        public async Task<GenerateImageTaskResponse> GenerateImageTaskAsync(GenerateImageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateImageTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成上传配置
         *
         * @param request GenerateUploadConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateUploadConfigResponse
         */
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

        /**
         * @summary 生成上传配置
         *
         * @param request GenerateUploadConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateUploadConfigResponse
         */
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

        /**
         * @summary 生成上传配置
         *
         * @param request GenerateUploadConfigRequest
         * @return GenerateUploadConfigResponse
         */
        public GenerateUploadConfigResponse GenerateUploadConfig(GenerateUploadConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadConfigWithOptions(request, runtime);
        }

        /**
         * @summary 生成上传配置
         *
         * @param request GenerateUploadConfigRequest
         * @return GenerateUploadConfigResponse
         */
        public async Task<GenerateUploadConfigResponse> GenerateUploadConfigAsync(GenerateUploadConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 视角生成
         *
         * @param tmpReq GenerateViewPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateViewPointResponse
         */
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

        /**
         * @summary 视角生成
         *
         * @param tmpReq GenerateViewPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateViewPointResponse
         */
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

        /**
         * @summary 视角生成
         *
         * @param request GenerateViewPointRequest
         * @return GenerateViewPointResponse
         */
        public GenerateViewPointResponse GenerateViewPoint(GenerateViewPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateViewPointWithOptions(request, runtime);
        }

        /**
         * @summary 视角生成
         *
         * @param request GenerateViewPointRequest
         * @return GenerateViewPointResponse
         */
        public async Task<GenerateViewPointResponse> GenerateViewPointAsync(GenerateViewPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateViewPointWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取自定义文本
         *
         * @param request GetCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTextResponse
         */
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

        /**
         * @summary 获取自定义文本
         *
         * @param request GetCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTextResponse
         */
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

        /**
         * @summary 获取自定义文本
         *
         * @param request GetCustomTextRequest
         * @return GetCustomTextResponse
         */
        public GetCustomTextResponse GetCustomText(GetCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTextWithOptions(request, runtime);
        }

        /**
         * @summary 获取自定义文本
         *
         * @param request GetCustomTextRequest
         * @return GetCustomTextResponse
         */
        public async Task<GetCustomTextResponse> GetCustomTextAsync(GetCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取自定义选题视角分析任务结果
         *
         * @param request GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 获取自定义选题视角分析任务结果
         *
         * @param request GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 获取自定义选题视角分析任务结果
         *
         * @param request GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @return GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public GetCustomTopicSelectionPerspectiveAnalysisTaskResponse GetCustomTopicSelectionPerspectiveAnalysisTask(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取自定义选题视角分析任务结果
         *
         * @param request GetCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @return GetCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public async Task<GetCustomTopicSelectionPerspectiveAnalysisTaskResponse> GetCustomTopicSelectionPerspectiveAnalysisTaskAsync(GetCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取系统数据源配置和个人配置
         *
         * @param request GetDataSourceOrderConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataSourceOrderConfigResponse
         */
        public GetDataSourceOrderConfigResponse GetDataSourceOrderConfigWithOptions(GetDataSourceOrderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取系统数据源配置和个人配置
         *
         * @param request GetDataSourceOrderConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataSourceOrderConfigResponse
         */
        public async Task<GetDataSourceOrderConfigResponse> GetDataSourceOrderConfigWithOptionsAsync(GetDataSourceOrderConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentKey))
            {
                query["AgentKey"] = request.AgentKey;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取系统数据源配置和个人配置
         *
         * @param request GetDataSourceOrderConfigRequest
         * @return GetDataSourceOrderConfigResponse
         */
        public GetDataSourceOrderConfigResponse GetDataSourceOrderConfig(GetDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataSourceOrderConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取系统数据源配置和个人配置
         *
         * @param request GetDataSourceOrderConfigRequest
         * @return GetDataSourceOrderConfigResponse
         */
        public async Task<GetDataSourceOrderConfigResponse> GetDataSourceOrderConfigAsync(GetDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataSourceOrderConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取文档聚合任务结果
         *
         * @param request GetDocClusterTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocClusterTaskResponse
         */
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

        /**
         * @summary 获取文档聚合任务结果
         *
         * @param request GetDocClusterTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocClusterTaskResponse
         */
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

        /**
         * @summary 获取文档聚合任务结果
         *
         * @param request GetDocClusterTaskRequest
         * @return GetDocClusterTaskResponse
         */
        public GetDocClusterTaskResponse GetDocClusterTask(GetDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocClusterTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取文档聚合任务结果
         *
         * @param request GetDocClusterTaskRequest
         * @return GetDocClusterTaskResponse
         */
        public async Task<GetDocClusterTaskResponse> GetDocClusterTaskAsync(GetDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocClusterTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-查询详情。
         *
         * @param request GetGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-查询详情。
         *
         * @param request GetGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-查询详情。
         *
         * @param request GetGeneratedContentRequest
         * @return GetGeneratedContentResponse
         */
        public GetGeneratedContentResponse GetGeneratedContent(GetGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGeneratedContentWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-查询详情。
         *
         * @param request GetGeneratedContentRequest
         * @return GetGeneratedContentResponse
         */
        public async Task<GetGeneratedContentResponse> GetGeneratedContentAsync(GetGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGeneratedContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预全局回复
         *
         * @param request GetInterveneGlobalReplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneGlobalReplyResponse
         */
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

        /**
         * @summary 获得干预全局回复
         *
         * @param request GetInterveneGlobalReplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneGlobalReplyResponse
         */
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

        /**
         * @summary 获得干预全局回复
         *
         * @param request GetInterveneGlobalReplyRequest
         * @return GetInterveneGlobalReplyResponse
         */
        public GetInterveneGlobalReplyResponse GetInterveneGlobalReply(GetInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneGlobalReplyWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预全局回复
         *
         * @param request GetInterveneGlobalReplyRequest
         * @return GetInterveneGlobalReplyResponse
         */
        public async Task<GetInterveneGlobalReplyResponse> GetInterveneGlobalReplyAsync(GetInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneGlobalReplyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得导入任务信息
         *
         * @param request GetInterveneImportTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneImportTaskInfoResponse
         */
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

        /**
         * @summary 获得导入任务信息
         *
         * @param request GetInterveneImportTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneImportTaskInfoResponse
         */
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

        /**
         * @summary 获得导入任务信息
         *
         * @param request GetInterveneImportTaskInfoRequest
         * @return GetInterveneImportTaskInfoResponse
         */
        public GetInterveneImportTaskInfoResponse GetInterveneImportTaskInfo(GetInterveneImportTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneImportTaskInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获得导入任务信息
         *
         * @param request GetInterveneImportTaskInfoRequest
         * @return GetInterveneImportTaskInfoResponse
         */
        public async Task<GetInterveneImportTaskInfoResponse> GetInterveneImportTaskInfoAsync(GetInterveneImportTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneImportTaskInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预项规则详情
         *
         * @param request GetInterveneRuleDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneRuleDetailResponse
         */
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

        /**
         * @summary 获得干预项规则详情
         *
         * @param request GetInterveneRuleDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneRuleDetailResponse
         */
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

        /**
         * @summary 获得干预项规则详情
         *
         * @param request GetInterveneRuleDetailRequest
         * @return GetInterveneRuleDetailResponse
         */
        public GetInterveneRuleDetailResponse GetInterveneRuleDetail(GetInterveneRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneRuleDetailWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预项规则详情
         *
         * @param request GetInterveneRuleDetailRequest
         * @return GetInterveneRuleDetailResponse
         */
        public async Task<GetInterveneRuleDetailResponse> GetInterveneRuleDetailAsync(GetInterveneRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneRuleDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预导入模版文件下载地址
         *
         * @param request GetInterveneTemplateFileUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneTemplateFileUrlResponse
         */
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

        /**
         * @summary 获得干预导入模版文件下载地址
         *
         * @param request GetInterveneTemplateFileUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterveneTemplateFileUrlResponse
         */
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

        /**
         * @summary 获得干预导入模版文件下载地址
         *
         * @param request GetInterveneTemplateFileUrlRequest
         * @return GetInterveneTemplateFileUrlResponse
         */
        public GetInterveneTemplateFileUrlResponse GetInterveneTemplateFileUrl(GetInterveneTemplateFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInterveneTemplateFileUrlWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预导入模版文件下载地址
         *
         * @param request GetInterveneTemplateFileUrlRequest
         * @return GetInterveneTemplateFileUrlResponse
         */
        public async Task<GetInterveneTemplateFileUrlResponse> GetInterveneTemplateFileUrlAsync(GetInterveneTemplateFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInterveneTemplateFileUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据ID获取素材内容
         *
         * @param request GetMaterialByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMaterialByIdResponse
         */
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

        /**
         * @summary 根据ID获取素材内容
         *
         * @param request GetMaterialByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMaterialByIdResponse
         */
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

        /**
         * @summary 根据ID获取素材内容
         *
         * @param request GetMaterialByIdRequest
         * @return GetMaterialByIdResponse
         */
        public GetMaterialByIdResponse GetMaterialById(GetMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMaterialByIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据ID获取素材内容
         *
         * @param request GetMaterialByIdRequest
         * @return GetMaterialByIdResponse
         */
        public async Task<GetMaterialByIdResponse> GetMaterialByIdAsync(GetMaterialByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMaterialByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取当前用户的配置
         *
         * @param request GetPropertiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPropertiesResponse
         */
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

        /**
         * @summary 获取当前用户的配置
         *
         * @param request GetPropertiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPropertiesResponse
         */
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

        /**
         * @summary 获取当前用户的配置
         *
         * @param request GetPropertiesRequest
         * @return GetPropertiesResponse
         */
        public GetPropertiesResponse GetProperties(GetPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPropertiesWithOptions(request, runtime);
        }

        /**
         * @summary 获取当前用户的配置
         *
         * @param request GetPropertiesRequest
         * @return GetPropertiesResponse
         */
        public async Task<GetPropertiesResponse> GetPropertiesAsync(GetPropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPropertiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据ID获取热点事件信息
         *
         * @param request GetTopicByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicByIdResponse
         */
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

        /**
         * @summary 根据ID获取热点事件信息
         *
         * @param request GetTopicByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicByIdResponse
         */
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

        /**
         * @summary 根据ID获取热点事件信息
         *
         * @param request GetTopicByIdRequest
         * @return GetTopicByIdResponse
         */
        public GetTopicByIdResponse GetTopicById(GetTopicByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicByIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据ID获取热点事件信息
         *
         * @param request GetTopicByIdRequest
         * @return GetTopicByIdResponse
         */
        public async Task<GetTopicByIdResponse> GetTopicByIdAsync(GetTopicByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取选题视角分析任务结果
         *
         * @param request GetTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 获取选题视角分析任务结果
         *
         * @param request GetTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 获取选题视角分析任务结果
         *
         * @param request GetTopicSelectionPerspectiveAnalysisTaskRequest
         * @return GetTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public GetTopicSelectionPerspectiveAnalysisTaskResponse GetTopicSelectionPerspectiveAnalysisTask(GetTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取选题视角分析任务结果
         *
         * @param request GetTopicSelectionPerspectiveAnalysisTaskRequest
         * @return GetTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public async Task<GetTopicSelectionPerspectiveAnalysisTaskResponse> GetTopicSelectionPerspectiveAnalysisTaskAsync(GetTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入干预文件
         *
         * @param request ImportInterveneFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportInterveneFileResponse
         */
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

        /**
         * @summary 导入干预文件
         *
         * @param request ImportInterveneFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportInterveneFileResponse
         */
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

        /**
         * @summary 导入干预文件
         *
         * @param request ImportInterveneFileRequest
         * @return ImportInterveneFileResponse
         */
        public ImportInterveneFileResponse ImportInterveneFile(ImportInterveneFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportInterveneFileWithOptions(request, runtime);
        }

        /**
         * @summary 导入干预文件
         *
         * @param request ImportInterveneFileRequest
         * @return ImportInterveneFileResponse
         */
        public async Task<ImportInterveneFileResponse> ImportInterveneFileAsync(ImportInterveneFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportInterveneFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 异步导入干预文件
         *
         * @param request ImportInterveneFileAsyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportInterveneFileAsyncResponse
         */
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

        /**
         * @summary 异步导入干预文件
         *
         * @param request ImportInterveneFileAsyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportInterveneFileAsyncResponse
         */
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

        /**
         * @summary 异步导入干预文件
         *
         * @param request ImportInterveneFileAsyncRequest
         * @return ImportInterveneFileAsyncResponse
         */
        public ImportInterveneFileAsyncResponse ImportInterveneFileAsync(ImportInterveneFileAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportInterveneFileAsyncWithOptions(request, runtime);
        }

        /**
         * @summary 异步导入干预文件
         *
         * @param request ImportInterveneFileAsyncRequest
         * @return ImportInterveneFileAsyncResponse
         */
        public async Task<ImportInterveneFileAsyncResponse> ImportInterveneFileAsyncAsync(ImportInterveneFileAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportInterveneFileAsyncWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置干预全局回复
         *
         * @param tmpReq InsertInterveneGlobalReplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertInterveneGlobalReplyResponse
         */
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

        /**
         * @summary 设置干预全局回复
         *
         * @param tmpReq InsertInterveneGlobalReplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertInterveneGlobalReplyResponse
         */
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

        /**
         * @summary 设置干预全局回复
         *
         * @param request InsertInterveneGlobalReplyRequest
         * @return InsertInterveneGlobalReplyResponse
         */
        public InsertInterveneGlobalReplyResponse InsertInterveneGlobalReply(InsertInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertInterveneGlobalReplyWithOptions(request, runtime);
        }

        /**
         * @summary 设置干预全局回复
         *
         * @param request InsertInterveneGlobalReplyRequest
         * @return InsertInterveneGlobalReplyResponse
         */
        public async Task<InsertInterveneGlobalReplyResponse> InsertInterveneGlobalReplyAsync(InsertInterveneGlobalReplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertInterveneGlobalReplyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 插入干预规则
         *
         * @param tmpReq InsertInterveneRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertInterveneRuleResponse
         */
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

        /**
         * @summary 插入干预规则
         *
         * @param tmpReq InsertInterveneRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertInterveneRuleResponse
         */
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

        /**
         * @summary 插入干预规则
         *
         * @param request InsertInterveneRuleRequest
         * @return InsertInterveneRuleResponse
         */
        public InsertInterveneRuleResponse InsertInterveneRule(InsertInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertInterveneRuleWithOptions(request, runtime);
        }

        /**
         * @summary 插入干预规则
         *
         * @param request InsertInterveneRuleRequest
         * @return InsertInterveneRuleResponse
         */
        public async Task<InsertInterveneRuleResponse> InsertInterveneRuleAsync(InsertInterveneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertInterveneRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询任务列表
         *
         * @param tmpReq ListAsyncTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncTasksResponse
         */
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

        /**
         * @summary 查询任务列表
         *
         * @param tmpReq ListAsyncTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsyncTasksResponse
         */
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

        /**
         * @summary 查询任务列表
         *
         * @param request ListAsyncTasksRequest
         * @return ListAsyncTasksResponse
         */
        public ListAsyncTasksResponse ListAsyncTasks(ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsyncTasksWithOptions(request, runtime);
        }

        /**
         * @summary 查询任务列表
         *
         * @param request ListAsyncTasksRequest
         * @return ListAsyncTasksResponse
         */
        public async Task<ListAsyncTasksResponse> ListAsyncTasksAsync(ListAsyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsyncTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取系统自定义预设
         *
         * @param request ListBuildConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBuildConfigsResponse
         */
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

        /**
         * @summary 获取系统自定义预设
         *
         * @param request ListBuildConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBuildConfigsResponse
         */
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

        /**
         * @summary 获取系统自定义预设
         *
         * @param request ListBuildConfigsRequest
         * @return ListBuildConfigsResponse
         */
        public ListBuildConfigsResponse ListBuildConfigs(ListBuildConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBuildConfigsWithOptions(request, runtime);
        }

        /**
         * @summary 获取系统自定义预设
         *
         * @param request ListBuildConfigsRequest
         * @return ListBuildConfigsResponse
         */
        public async Task<ListBuildConfigsResponse> ListBuildConfigsAsync(ListBuildConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBuildConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 自定义文本列表
         *
         * @param request ListCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomTextResponse
         */
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

        /**
         * @summary 自定义文本列表
         *
         * @param request ListCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomTextResponse
         */
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

        /**
         * @summary 自定义文本列表
         *
         * @param request ListCustomTextRequest
         * @return ListCustomTextResponse
         */
        public ListCustomTextResponse ListCustomText(ListCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomTextWithOptions(request, runtime);
        }

        /**
         * @summary 自定义文本列表
         *
         * @param request ListCustomTextRequest
         * @return ListCustomTextResponse
         */
        public async Task<ListCustomTextResponse> ListCustomTextAsync(ListCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 自定义视角列表
         *
         * @param tmpReq ListCustomViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomViewPointsResponse
         */
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

        /**
         * @summary 自定义视角列表
         *
         * @param tmpReq ListCustomViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomViewPointsResponse
         */
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

        /**
         * @summary 自定义视角列表
         *
         * @param request ListCustomViewPointsRequest
         * @return ListCustomViewPointsResponse
         */
        public ListCustomViewPointsResponse ListCustomViewPoints(ListCustomViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomViewPointsWithOptions(request, runtime);
        }

        /**
         * @summary 自定义视角列表
         *
         * @param request ListCustomViewPointsRequest
         * @return ListCustomViewPointsResponse
         */
        public async Task<ListCustomViewPointsResponse> ListCustomViewPointsAsync(ListCustomViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomViewPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成历史列表
         *
         * @param request ListDialoguesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDialoguesResponse
         */
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

        /**
         * @summary 生成历史列表
         *
         * @param request ListDialoguesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDialoguesResponse
         */
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

        /**
         * @summary 生成历史列表
         *
         * @param request ListDialoguesRequest
         * @return ListDialoguesResponse
         */
        public ListDialoguesResponse ListDialogues(ListDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDialoguesWithOptions(request, runtime);
        }

        /**
         * @summary 生成历史列表
         *
         * @param request ListDialoguesRequest
         * @return ListDialoguesResponse
         */
        public async Task<ListDialoguesResponse> ListDialoguesAsync(ListDialoguesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDialoguesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新颖视角列表
         *
         * @param request ListFreshViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFreshViewPointsResponse
         */
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

        /**
         * @summary 新颖视角列表
         *
         * @param request ListFreshViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFreshViewPointsResponse
         */
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

        /**
         * @summary 新颖视角列表
         *
         * @param request ListFreshViewPointsRequest
         * @return ListFreshViewPointsResponse
         */
        public ListFreshViewPointsResponse ListFreshViewPoints(ListFreshViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFreshViewPointsWithOptions(request, runtime);
        }

        /**
         * @summary 新颖视角列表
         *
         * @param request ListFreshViewPointsRequest
         * @return ListFreshViewPointsResponse
         */
        public async Task<ListFreshViewPointsResponse> ListFreshViewPointsAsync(ListFreshViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFreshViewPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-列表。
         *
         * @param request ListGeneratedContentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGeneratedContentsResponse
         */
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

        /**
         * @summary 文档管理-列表。
         *
         * @param request ListGeneratedContentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGeneratedContentsResponse
         */
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

        /**
         * @summary 文档管理-列表。
         *
         * @param request ListGeneratedContentsRequest
         * @return ListGeneratedContentsResponse
         */
        public ListGeneratedContentsResponse ListGeneratedContents(ListGeneratedContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGeneratedContentsWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-列表。
         *
         * @param request ListGeneratedContentsRequest
         * @return ListGeneratedContentsResponse
         */
        public async Task<ListGeneratedContentsResponse> ListGeneratedContentsAsync(ListGeneratedContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGeneratedContentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取分类的热点新闻
         *
         * @param tmpReq ListHotNewsWithTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotNewsWithTypeResponse
         */
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

        /**
         * @summary 获取分类的热点新闻
         *
         * @param tmpReq ListHotNewsWithTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotNewsWithTypeResponse
         */
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

        /**
         * @summary 获取分类的热点新闻
         *
         * @param request ListHotNewsWithTypeRequest
         * @return ListHotNewsWithTypeResponse
         */
        public ListHotNewsWithTypeResponse ListHotNewsWithType(ListHotNewsWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotNewsWithTypeWithOptions(request, runtime);
        }

        /**
         * @summary 获取分类的热点新闻
         *
         * @param request ListHotNewsWithTypeRequest
         * @return ListHotNewsWithTypeResponse
         */
        public async Task<ListHotNewsWithTypeResponse> ListHotNewsWithTypeAsync(ListHotNewsWithTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotNewsWithTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取所有平台热榜源列表
         *
         * @param request ListHotSourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotSourcesResponse
         */
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

        /**
         * @summary 获取所有平台热榜源列表
         *
         * @param request ListHotSourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotSourcesResponse
         */
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

        /**
         * @summary 获取所有平台热榜源列表
         *
         * @param request ListHotSourcesRequest
         * @return ListHotSourcesResponse
         */
        public ListHotSourcesResponse ListHotSources(ListHotSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotSourcesWithOptions(request, runtime);
        }

        /**
         * @summary 获取所有平台热榜源列表
         *
         * @param request ListHotSourcesRequest
         * @return ListHotSourcesResponse
         */
        public async Task<ListHotSourcesResponse> ListHotSourcesAsync(ListHotSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotSourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取热点事件列表
         *
         * @param tmpReq ListHotTopicsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotTopicsResponse
         */
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

        /**
         * @summary 获取热点事件列表
         *
         * @param tmpReq ListHotTopicsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotTopicsResponse
         */
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

        /**
         * @summary 获取热点事件列表
         *
         * @param request ListHotTopicsRequest
         * @return ListHotTopicsResponse
         */
        public ListHotTopicsResponse ListHotTopics(ListHotTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotTopicsWithOptions(request, runtime);
        }

        /**
         * @summary 获取热点事件列表
         *
         * @param request ListHotTopicsRequest
         * @return ListHotTopicsResponse
         */
        public async Task<ListHotTopicsResponse> ListHotTopicsAsync(ListHotTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotTopicsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 热门视角列表
         *
         * @param request ListHotViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotViewPointsResponse
         */
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

        /**
         * @summary 热门视角列表
         *
         * @param request ListHotViewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHotViewPointsResponse
         */
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

        /**
         * @summary 热门视角列表
         *
         * @param request ListHotViewPointsRequest
         * @return ListHotViewPointsResponse
         */
        public ListHotViewPointsResponse ListHotViewPoints(ListHotViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotViewPointsWithOptions(request, runtime);
        }

        /**
         * @summary 热门视角列表
         *
         * @param request ListHotViewPointsRequest
         * @return ListHotViewPointsResponse
         */
        public async Task<ListHotViewPointsResponse> ListHotViewPointsAsync(ListHotViewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotViewPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预项目数量列表
         *
         * @param request ListInterveneCntRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneCntResponse
         */
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

        /**
         * @summary 获得干预项目数量列表
         *
         * @param request ListInterveneCntRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneCntResponse
         */
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

        /**
         * @summary 获得干预项目数量列表
         *
         * @param request ListInterveneCntRequest
         * @return ListInterveneCntResponse
         */
        public ListInterveneCntResponse ListInterveneCnt(ListInterveneCntRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneCntWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预项目数量列表
         *
         * @param request ListInterveneCntRequest
         * @return ListInterveneCntResponse
         */
        public async Task<ListInterveneCntResponse> ListInterveneCntAsync(ListInterveneCntRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneCntWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得导入任务列表
         *
         * @param request ListInterveneImportTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneImportTasksResponse
         */
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

        /**
         * @summary 获得导入任务列表
         *
         * @param request ListInterveneImportTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneImportTasksResponse
         */
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

        /**
         * @summary 获得导入任务列表
         *
         * @param request ListInterveneImportTasksRequest
         * @return ListInterveneImportTasksResponse
         */
        public ListInterveneImportTasksResponse ListInterveneImportTasks(ListInterveneImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneImportTasksWithOptions(request, runtime);
        }

        /**
         * @summary 获得导入任务列表
         *
         * @param request ListInterveneImportTasksRequest
         * @return ListInterveneImportTasksResponse
         */
        public async Task<ListInterveneImportTasksResponse> ListInterveneImportTasksAsync(ListInterveneImportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneImportTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预规则列表
         *
         * @param request ListInterveneRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneRulesResponse
         */
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

        /**
         * @summary 获得干预规则列表
         *
         * @param request ListInterveneRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInterveneRulesResponse
         */
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

        /**
         * @summary 获得干预规则列表
         *
         * @param request ListInterveneRulesRequest
         * @return ListInterveneRulesResponse
         */
        public ListInterveneRulesResponse ListInterveneRules(ListInterveneRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInterveneRulesWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预规则列表
         *
         * @param request ListInterveneRulesRequest
         * @return ListInterveneRulesResponse
         */
        public async Task<ListInterveneRulesResponse> ListInterveneRulesAsync(ListInterveneRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInterveneRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得干预项列表
         *
         * @param request ListIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntervenesResponse
         */
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

        /**
         * @summary 获得干预项列表
         *
         * @param request ListIntervenesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIntervenesResponse
         */
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

        /**
         * @summary 获得干预项列表
         *
         * @param request ListIntervenesRequest
         * @return ListIntervenesResponse
         */
        public ListIntervenesResponse ListIntervenes(ListIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervenesWithOptions(request, runtime);
        }

        /**
         * @summary 获得干预项列表
         *
         * @param request ListIntervenesRequest
         * @return ListIntervenesResponse
         */
        public async Task<ListIntervenesResponse> ListIntervenesAsync(ListIntervenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervenesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询素材列表
         *
         * @param tmpReq ListMaterialDocumentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMaterialDocumentsResponse
         */
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

        /**
         * @summary 查询素材列表
         *
         * @param tmpReq ListMaterialDocumentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMaterialDocumentsResponse
         */
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

        /**
         * @summary 查询素材列表
         *
         * @param request ListMaterialDocumentsRequest
         * @return ListMaterialDocumentsResponse
         */
        public ListMaterialDocumentsResponse ListMaterialDocuments(ListMaterialDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMaterialDocumentsWithOptions(request, runtime);
        }

        /**
         * @summary 查询素材列表
         *
         * @param request ListMaterialDocumentsRequest
         * @return ListMaterialDocumentsResponse
         */
        public async Task<ListMaterialDocumentsResponse> ListMaterialDocumentsAsync(ListMaterialDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMaterialDocumentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取选题策划列表
         *
         * @param tmpReq ListPlanningProposalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPlanningProposalResponse
         */
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

        /**
         * @summary 获取选题策划列表
         *
         * @param tmpReq ListPlanningProposalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPlanningProposalResponse
         */
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

        /**
         * @summary 获取选题策划列表
         *
         * @param request ListPlanningProposalRequest
         * @return ListPlanningProposalResponse
         */
        public ListPlanningProposalResponse ListPlanningProposal(ListPlanningProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlanningProposalWithOptions(request, runtime);
        }

        /**
         * @summary 获取选题策划列表
         *
         * @param request ListPlanningProposalRequest
         * @return ListPlanningProposalResponse
         */
        public async Task<ListPlanningProposalResponse> ListPlanningProposalAsync(ListPlanningProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlanningProposalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 时效性视角列表
         *
         * @param request ListTimedViewAttitudeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTimedViewAttitudeResponse
         */
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

        /**
         * @summary 时效性视角列表
         *
         * @param request ListTimedViewAttitudeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTimedViewAttitudeResponse
         */
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

        /**
         * @summary 时效性视角列表
         *
         * @param request ListTimedViewAttitudeRequest
         * @return ListTimedViewAttitudeResponse
         */
        public ListTimedViewAttitudeResponse ListTimedViewAttitude(ListTimedViewAttitudeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTimedViewAttitudeWithOptions(request, runtime);
        }

        /**
         * @summary 时效性视角列表
         *
         * @param request ListTimedViewAttitudeRequest
         * @return ListTimedViewAttitudeResponse
         */
        public async Task<ListTimedViewAttitudeResponse> ListTimedViewAttitudeAsync(ListTimedViewAttitudeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTimedViewAttitudeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取热点推荐事件
         *
         * @param request ListTopicRecommendEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicRecommendEventListResponse
         */
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

        /**
         * @summary 获取热点推荐事件
         *
         * @param request ListTopicRecommendEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicRecommendEventListResponse
         */
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

        /**
         * @summary 获取热点推荐事件
         *
         * @param request ListTopicRecommendEventListRequest
         * @return ListTopicRecommendEventListResponse
         */
        public ListTopicRecommendEventListResponse ListTopicRecommendEventList(ListTopicRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicRecommendEventListWithOptions(request, runtime);
        }

        /**
         * @summary 获取热点推荐事件
         *
         * @param request ListTopicRecommendEventListRequest
         * @return ListTopicRecommendEventListResponse
         */
        public async Task<ListTopicRecommendEventListResponse> ListTopicRecommendEventListAsync(ListTopicRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicRecommendEventListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取主题事件推荐观点列表
         *
         * @param request ListTopicViewPointRecommendEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicViewPointRecommendEventListResponse
         */
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

        /**
         * @summary 获取主题事件推荐观点列表
         *
         * @param request ListTopicViewPointRecommendEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicViewPointRecommendEventListResponse
         */
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

        /**
         * @summary 获取主题事件推荐观点列表
         *
         * @param request ListTopicViewPointRecommendEventListRequest
         * @return ListTopicViewPointRecommendEventListResponse
         */
        public ListTopicViewPointRecommendEventListResponse ListTopicViewPointRecommendEventList(ListTopicViewPointRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicViewPointRecommendEventListWithOptions(request, runtime);
        }

        /**
         * @summary 获取主题事件推荐观点列表
         *
         * @param request ListTopicViewPointRecommendEventListRequest
         * @return ListTopicViewPointRecommendEventListResponse
         */
        public async Task<ListTopicViewPointRecommendEventListResponse> ListTopicViewPointRecommendEventListAsync(ListTopicViewPointRecommendEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicViewPointRecommendEventListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取系统所有实例信息
         *
         * @param request ListVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVersionsResponse
         */
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

        /**
         * @summary 获取系统所有实例信息
         *
         * @param request ListVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVersionsResponse
         */
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

        /**
         * @summary 获取系统所有实例信息
         *
         * @param request ListVersionsRequest
         * @return ListVersionsResponse
         */
        public ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVersionsWithOptions(request, runtime);
        }

        /**
         * @summary 获取系统所有实例信息
         *
         * @param request ListVersionsRequest
         * @return ListVersionsResponse
         */
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 网友视角列表
         *
         * @param request ListWebReviewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebReviewPointsResponse
         */
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

        /**
         * @summary 网友视角列表
         *
         * @param request ListWebReviewPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebReviewPointsResponse
         */
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

        /**
         * @summary 网友视角列表
         *
         * @param request ListWebReviewPointsRequest
         * @return ListWebReviewPointsResponse
         */
        public ListWebReviewPointsResponse ListWebReviewPoints(ListWebReviewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWebReviewPointsWithOptions(request, runtime);
        }

        /**
         * @summary 网友视角列表
         *
         * @param request ListWebReviewPointsRequest
         * @return ListWebReviewPointsResponse
         */
        public async Task<ListWebReviewPointsResponse> ListWebReviewPointsAsync(ListWebReviewPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWebReviewPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据taskId查询异步任务状态
         *
         * @param request QueryAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAsyncTaskResponse
         */
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

        /**
         * @summary 根据taskId查询异步任务状态
         *
         * @param request QueryAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAsyncTaskResponse
         */
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

        /**
         * @summary 根据taskId查询异步任务状态
         *
         * @param request QueryAsyncTaskRequest
         * @return QueryAsyncTaskResponse
         */
        public QueryAsyncTaskResponse QueryAsyncTask(QueryAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAsyncTaskWithOptions(request, runtime);
        }

        /**
         * @summary 根据taskId查询异步任务状态
         *
         * @param request QueryAsyncTaskRequest
         * @return QueryAsyncTaskResponse
         */
        public async Task<QueryAsyncTaskResponse> QueryAsyncTaskAsync(QueryAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAsyncTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 内容缩写
         *
         * @param request RunAbbreviationContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunAbbreviationContentResponse
         */
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

        /**
         * @summary 内容缩写
         *
         * @param request RunAbbreviationContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunAbbreviationContentResponse
         */
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

        /**
         * @summary 内容缩写
         *
         * @param request RunAbbreviationContentRequest
         * @return RunAbbreviationContentResponse
         */
        public RunAbbreviationContentResponse RunAbbreviationContent(RunAbbreviationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunAbbreviationContentWithOptions(request, runtime);
        }

        /**
         * @summary 内容缩写
         *
         * @param request RunAbbreviationContentRequest
         * @return RunAbbreviationContentResponse
         */
        public async Task<RunAbbreviationContentResponse> RunAbbreviationContentAsync(RunAbbreviationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunAbbreviationContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 内容续写
         *
         * @param request RunContinueContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunContinueContentResponse
         */
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

        /**
         * @summary 内容续写
         *
         * @param request RunContinueContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunContinueContentResponse
         */
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

        /**
         * @summary 内容续写
         *
         * @param request RunContinueContentRequest
         * @return RunContinueContentResponse
         */
        public RunContinueContentResponse RunContinueContent(RunContinueContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunContinueContentWithOptions(request, runtime);
        }

        /**
         * @summary 内容续写
         *
         * @param request RunContinueContentRequest
         * @return RunContinueContentResponse
         */
        public async Task<RunContinueContentResponse> RunContinueContentAsync(RunContinueContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunContinueContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 自定义热点话题分析
         *
         * @param request RunCustomHotTopicAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCustomHotTopicAnalysisResponse
         */
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

        /**
         * @summary 自定义热点话题分析
         *
         * @param request RunCustomHotTopicAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCustomHotTopicAnalysisResponse
         */
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

        /**
         * @summary 自定义热点话题分析
         *
         * @param request RunCustomHotTopicAnalysisRequest
         * @return RunCustomHotTopicAnalysisResponse
         */
        public RunCustomHotTopicAnalysisResponse RunCustomHotTopicAnalysis(RunCustomHotTopicAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCustomHotTopicAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary 自定义热点话题分析
         *
         * @param request RunCustomHotTopicAnalysisRequest
         * @return RunCustomHotTopicAnalysisResponse
         */
        public async Task<RunCustomHotTopicAnalysisResponse> RunCustomHotTopicAnalysisAsync(RunCustomHotTopicAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCustomHotTopicAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 自定义选题视角分析
         *
         * @param request RunCustomHotTopicViewPointAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCustomHotTopicViewPointAnalysisResponse
         */
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

        /**
         * @summary 自定义选题视角分析
         *
         * @param request RunCustomHotTopicViewPointAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCustomHotTopicViewPointAnalysisResponse
         */
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

        /**
         * @summary 自定义选题视角分析
         *
         * @param request RunCustomHotTopicViewPointAnalysisRequest
         * @return RunCustomHotTopicViewPointAnalysisResponse
         */
        public RunCustomHotTopicViewPointAnalysisResponse RunCustomHotTopicViewPointAnalysis(RunCustomHotTopicViewPointAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCustomHotTopicViewPointAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary 自定义选题视角分析
         *
         * @param request RunCustomHotTopicViewPointAnalysisRequest
         * @return RunCustomHotTopicViewPointAnalysisResponse
         */
        public async Task<RunCustomHotTopicViewPointAnalysisResponse> RunCustomHotTopicViewPointAnalysisAsync(RunCustomHotTopicViewPointAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCustomHotTopicViewPointAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 内容扩写
         *
         * @param request RunExpandContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunExpandContentResponse
         */
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

        /**
         * @summary 内容扩写
         *
         * @param request RunExpandContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunExpandContentResponse
         */
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

        /**
         * @summary 内容扩写
         *
         * @param request RunExpandContentRequest
         * @return RunExpandContentResponse
         */
        public RunExpandContentResponse RunExpandContent(RunExpandContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunExpandContentWithOptions(request, runtime);
        }

        /**
         * @summary 内容扩写
         *
         * @param request RunExpandContentRequest
         * @return RunExpandContentResponse
         */
        public async Task<RunExpandContentResponse> RunExpandContentAsync(RunExpandContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunExpandContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-抽取关键词
         *
         * @param tmpReq RunKeywordsExtractionGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunKeywordsExtractionGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-抽取关键词
         *
         * @param tmpReq RunKeywordsExtractionGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunKeywordsExtractionGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-抽取关键词
         *
         * @param request RunKeywordsExtractionGenerationRequest
         * @return RunKeywordsExtractionGenerationResponse
         */
        public RunKeywordsExtractionGenerationResponse RunKeywordsExtractionGeneration(RunKeywordsExtractionGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunKeywordsExtractionGenerationWithOptions(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-抽取关键词
         *
         * @param request RunKeywordsExtractionGenerationRequest
         * @return RunKeywordsExtractionGenerationResponse
         */
        public async Task<RunKeywordsExtractionGenerationResponse> RunKeywordsExtractionGenerationAsync(RunKeywordsExtractionGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunKeywordsExtractionGenerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创作-分步骤写作
         *
         * @param tmpReq RunStepByStepWritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStepByStepWritingResponse
         */
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

        /**
         * @summary 创作-分步骤写作
         *
         * @param tmpReq RunStepByStepWritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStepByStepWritingResponse
         */
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

        /**
         * @summary 创作-分步骤写作
         *
         * @param request RunStepByStepWritingRequest
         * @return RunStepByStepWritingResponse
         */
        public RunStepByStepWritingResponse RunStepByStepWriting(RunStepByStepWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunStepByStepWritingWithOptions(request, runtime);
        }

        /**
         * @summary 创作-分步骤写作
         *
         * @param request RunStepByStepWritingRequest
         * @return RunStepByStepWritingResponse
         */
        public async Task<RunStepByStepWritingResponse> RunStepByStepWritingAsync(RunStepByStepWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunStepByStepWritingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 内容特点分析
         *
         * @param tmpReq RunStyleFeatureAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStyleFeatureAnalysisResponse
         */
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

        /**
         * @summary 内容特点分析
         *
         * @param tmpReq RunStyleFeatureAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStyleFeatureAnalysisResponse
         */
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

        /**
         * @summary 内容特点分析
         *
         * @param request RunStyleFeatureAnalysisRequest
         * @return RunStyleFeatureAnalysisResponse
         */
        public RunStyleFeatureAnalysisResponse RunStyleFeatureAnalysis(RunStyleFeatureAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunStyleFeatureAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary 内容特点分析
         *
         * @param request RunStyleFeatureAnalysisRequest
         * @return RunStyleFeatureAnalysisResponse
         */
        public async Task<RunStyleFeatureAnalysisResponse> RunStyleFeatureAnalysisAsync(RunStyleFeatureAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunStyleFeatureAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 内容摘要生成
         *
         * @param request RunSummaryGenerateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunSummaryGenerateResponse
         */
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

        /**
         * @summary 内容摘要生成
         *
         * @param request RunSummaryGenerateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunSummaryGenerateResponse
         */
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

        /**
         * @summary 内容摘要生成
         *
         * @param request RunSummaryGenerateRequest
         * @return RunSummaryGenerateResponse
         */
        public RunSummaryGenerateResponse RunSummaryGenerate(RunSummaryGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSummaryGenerateWithOptions(request, runtime);
        }

        /**
         * @summary 内容摘要生成
         *
         * @param request RunSummaryGenerateRequest
         * @return RunSummaryGenerateResponse
         */
        public async Task<RunSummaryGenerateResponse> RunSummaryGenerateAsync(RunSummaryGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSummaryGenerateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创作-文本润色
         *
         * @param request RunTextPolishingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTextPolishingResponse
         */
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

        /**
         * @summary 创作-文本润色
         *
         * @param request RunTextPolishingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTextPolishingResponse
         */
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

        /**
         * @summary 创作-文本润色
         *
         * @param request RunTextPolishingRequest
         * @return RunTextPolishingResponse
         */
        public RunTextPolishingResponse RunTextPolishing(RunTextPolishingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTextPolishingWithOptions(request, runtime);
        }

        /**
         * @summary 创作-文本润色
         *
         * @param request RunTextPolishingRequest
         * @return RunTextPolishingResponse
         */
        public async Task<RunTextPolishingResponse> RunTextPolishingAsync(RunTextPolishingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTextPolishingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 妙笔：标题生成
         *
         * @param tmpReq RunTitleGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTitleGenerationResponse
         */
        public RunTitleGenerationResponse RunTitleGenerationWithOptions(RunTitleGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTitleGenerationShrinkRequest request = new RunTitleGenerationShrinkRequest();
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

        /**
         * @summary 妙笔：标题生成
         *
         * @param tmpReq RunTitleGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTitleGenerationResponse
         */
        public async Task<RunTitleGenerationResponse> RunTitleGenerationWithOptionsAsync(RunTitleGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunTitleGenerationShrinkRequest request = new RunTitleGenerationShrinkRequest();
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

        /**
         * @summary 妙笔：标题生成
         *
         * @param request RunTitleGenerationRequest
         * @return RunTitleGenerationResponse
         */
        public RunTitleGenerationResponse RunTitleGeneration(RunTitleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTitleGenerationWithOptions(request, runtime);
        }

        /**
         * @summary 妙笔：标题生成
         *
         * @param request RunTitleGenerationRequest
         * @return RunTitleGenerationResponse
         */
        public async Task<RunTitleGenerationResponse> RunTitleGenerationAsync(RunTitleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTitleGenerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-中英文翻译
         *
         * @param tmpReq RunTranslateGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTranslateGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-中英文翻译
         *
         * @param tmpReq RunTranslateGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunTranslateGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-中英文翻译
         *
         * @param request RunTranslateGenerationRequest
         * @return RunTranslateGenerationResponse
         */
        public RunTranslateGenerationResponse RunTranslateGeneration(RunTranslateGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTranslateGenerationWithOptions(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-中英文翻译
         *
         * @param request RunTranslateGenerationRequest
         * @return RunTranslateGenerationResponse
         */
        public async Task<RunTranslateGenerationResponse> RunTranslateGenerationAsync(RunTranslateGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTranslateGenerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-文风改写
         *
         * @param tmpReq RunWriteToneGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunWriteToneGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-文风改写
         *
         * @param tmpReq RunWriteToneGenerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunWriteToneGenerationResponse
         */
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

        /**
         * @summary AI妙笔-创作-文风改写
         *
         * @param request RunWriteToneGenerationRequest
         * @return RunWriteToneGenerationResponse
         */
        public RunWriteToneGenerationResponse RunWriteToneGeneration(RunWriteToneGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunWriteToneGenerationWithOptions(request, runtime);
        }

        /**
         * @summary AI妙笔-创作-文风改写
         *
         * @param request RunWriteToneGenerationRequest
         * @return RunWriteToneGenerationResponse
         */
        public async Task<RunWriteToneGenerationResponse> RunWriteToneGenerationAsync(RunWriteToneGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunWriteToneGenerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 直接写作
         *
         * @param tmpReq RunWritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunWritingResponse
         */
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

        /**
         * @summary 直接写作
         *
         * @param tmpReq RunWritingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunWritingResponse
         */
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

        /**
         * @summary 直接写作
         *
         * @param request RunWritingRequest
         * @return RunWritingResponse
         */
        public RunWritingResponse RunWriting(RunWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunWritingWithOptions(request, runtime);
        }

        /**
         * @summary 直接写作
         *
         * @param request RunWritingRequest
         * @return RunWritingResponse
         */
        public async Task<RunWritingResponse> RunWritingAsync(RunWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunWritingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存自定义文本
         *
         * @param request SaveCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCustomTextResponse
         */
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

        /**
         * @summary 保存自定义文本
         *
         * @param request SaveCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCustomTextResponse
         */
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

        /**
         * @summary 保存自定义文本
         *
         * @param request SaveCustomTextRequest
         * @return SaveCustomTextResponse
         */
        public SaveCustomTextResponse SaveCustomText(SaveCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveCustomTextWithOptions(request, runtime);
        }

        /**
         * @summary 保存自定义文本
         *
         * @param request SaveCustomTextRequest
         * @return SaveCustomTextResponse
         */
        public async Task<SaveCustomTextResponse> SaveCustomTextAsync(SaveCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveCustomTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存用户的信源配置
         *
         * @param tmpReq SaveDataSourceOrderConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveDataSourceOrderConfigResponse
         */
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

        /**
         * @summary 保存用户的信源配置
         *
         * @param tmpReq SaveDataSourceOrderConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveDataSourceOrderConfigResponse
         */
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

        /**
         * @summary 保存用户的信源配置
         *
         * @param request SaveDataSourceOrderConfigRequest
         * @return SaveDataSourceOrderConfigResponse
         */
        public SaveDataSourceOrderConfigResponse SaveDataSourceOrderConfig(SaveDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDataSourceOrderConfigWithOptions(request, runtime);
        }

        /**
         * @summary 保存用户的信源配置
         *
         * @param request SaveDataSourceOrderConfigRequest
         * @return SaveDataSourceOrderConfigResponse
         */
        public async Task<SaveDataSourceOrderConfigResponse> SaveDataSourceOrderConfigAsync(SaveDataSourceOrderConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDataSourceOrderConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存素材
         *
         * @param tmpReq SaveMaterialDocumentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveMaterialDocumentResponse
         */
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

        /**
         * @summary 保存素材
         *
         * @param tmpReq SaveMaterialDocumentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveMaterialDocumentResponse
         */
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

        /**
         * @summary 保存素材
         *
         * @param request SaveMaterialDocumentRequest
         * @return SaveMaterialDocumentResponse
         */
        public SaveMaterialDocumentResponse SaveMaterialDocument(SaveMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveMaterialDocumentWithOptions(request, runtime);
        }

        /**
         * @summary 保存素材
         *
         * @param request SaveMaterialDocumentRequest
         * @return SaveMaterialDocumentResponse
         */
        public async Task<SaveMaterialDocumentResponse> SaveMaterialDocumentAsync(SaveMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveMaterialDocumentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新闻检索
         *
         * @param tmpReq SearchNewsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchNewsResponse
         */
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

        /**
         * @summary 新闻检索
         *
         * @param tmpReq SearchNewsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchNewsResponse
         */
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

        /**
         * @summary 新闻检索
         *
         * @param request SearchNewsRequest
         * @return SearchNewsResponse
         */
        public SearchNewsResponse SearchNews(SearchNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchNewsWithOptions(request, runtime);
        }

        /**
         * @summary 新闻检索
         *
         * @param request SearchNewsRequest
         * @return SearchNewsResponse
         */
        public async Task<SearchNewsResponse> SearchNewsAsync(SearchNewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchNewsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交异步任务
         *
         * @param request SubmitAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAsyncTaskResponse
         */
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

        /**
         * @summary 提交异步任务
         *
         * @param request SubmitAsyncTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAsyncTaskResponse
         */
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

        /**
         * @summary 提交异步任务
         *
         * @param request SubmitAsyncTaskRequest
         * @return SubmitAsyncTaskResponse
         */
        public SubmitAsyncTaskResponse SubmitAsyncTask(SubmitAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAsyncTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提交异步任务
         *
         * @param request SubmitAsyncTaskRequest
         * @return SubmitAsyncTaskResponse
         */
        public async Task<SubmitAsyncTaskResponse> SubmitAsyncTaskAsync(SubmitAsyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAsyncTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交自定义热点选题视角分析任务
         *
         * @param tmpReq SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 提交自定义热点选题视角分析任务
         *
         * @param tmpReq SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 提交自定义热点选题视角分析任务
         *
         * @param request SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @return SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse SubmitCustomTopicSelectionPerspectiveAnalysisTask(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提交自定义热点选题视角分析任务
         *
         * @param request SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest
         * @return SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public async Task<SubmitCustomTopicSelectionPerspectiveAnalysisTaskResponse> SubmitCustomTopicSelectionPerspectiveAnalysisTaskAsync(SubmitCustomTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCustomTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交文档聚合任务
         *
         * @param tmpReq SubmitDocClusterTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocClusterTaskResponse
         */
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

        /**
         * @summary 提交文档聚合任务
         *
         * @param tmpReq SubmitDocClusterTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocClusterTaskResponse
         */
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

        /**
         * @summary 提交文档聚合任务
         *
         * @param request SubmitDocClusterTaskRequest
         * @return SubmitDocClusterTaskResponse
         */
        public SubmitDocClusterTaskResponse SubmitDocClusterTask(SubmitDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocClusterTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提交文档聚合任务
         *
         * @param request SubmitDocClusterTaskRequest
         * @return SubmitDocClusterTaskResponse
         */
        public async Task<SubmitDocClusterTaskResponse> SubmitDocClusterTaskAsync(SubmitDocClusterTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDocClusterTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交选题热点分析任务
         *
         * @param tmpReq SubmitTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 提交选题热点分析任务
         *
         * @param tmpReq SubmitTopicSelectionPerspectiveAnalysisTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTopicSelectionPerspectiveAnalysisTaskResponse
         */
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

        /**
         * @summary 提交选题热点分析任务
         *
         * @param request SubmitTopicSelectionPerspectiveAnalysisTaskRequest
         * @return SubmitTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public SubmitTopicSelectionPerspectiveAnalysisTaskResponse SubmitTopicSelectionPerspectiveAnalysisTask(SubmitTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTopicSelectionPerspectiveAnalysisTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提交选题热点分析任务
         *
         * @param request SubmitTopicSelectionPerspectiveAnalysisTaskRequest
         * @return SubmitTopicSelectionPerspectiveAnalysisTaskResponse
         */
        public async Task<SubmitTopicSelectionPerspectiveAnalysisTaskResponse> SubmitTopicSelectionPerspectiveAnalysisTaskAsync(SubmitTopicSelectionPerspectiveAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTopicSelectionPerspectiveAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新自定义文本
         *
         * @param request UpdateCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomTextResponse
         */
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

        /**
         * @summary 更新自定义文本
         *
         * @param request UpdateCustomTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomTextResponse
         */
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

        /**
         * @summary 更新自定义文本
         *
         * @param request UpdateCustomTextRequest
         * @return UpdateCustomTextResponse
         */
        public UpdateCustomTextResponse UpdateCustomText(UpdateCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomTextWithOptions(request, runtime);
        }

        /**
         * @summary 更新自定义文本
         *
         * @param request UpdateCustomTextRequest
         * @return UpdateCustomTextResponse
         */
        public async Task<UpdateCustomTextResponse> UpdateCustomTextAsync(UpdateCustomTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档管理-更新。
         *
         * @param tmpReq UpdateGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-更新。
         *
         * @param tmpReq UpdateGeneratedContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGeneratedContentResponse
         */
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

        /**
         * @summary 文档管理-更新。
         *
         * @param request UpdateGeneratedContentRequest
         * @return UpdateGeneratedContentResponse
         */
        public UpdateGeneratedContentResponse UpdateGeneratedContent(UpdateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGeneratedContentWithOptions(request, runtime);
        }

        /**
         * @summary 文档管理-更新。
         *
         * @param request UpdateGeneratedContentRequest
         * @return UpdateGeneratedContentResponse
         */
        public async Task<UpdateGeneratedContentResponse> UpdateGeneratedContentAsync(UpdateGeneratedContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGeneratedContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据ID更新素材
         *
         * @param tmpReq UpdateMaterialDocumentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMaterialDocumentResponse
         */
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

        /**
         * @summary 根据ID更新素材
         *
         * @param tmpReq UpdateMaterialDocumentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMaterialDocumentResponse
         */
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

        /**
         * @summary 根据ID更新素材
         *
         * @param request UpdateMaterialDocumentRequest
         * @return UpdateMaterialDocumentResponse
         */
        public UpdateMaterialDocumentResponse UpdateMaterialDocument(UpdateMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMaterialDocumentWithOptions(request, runtime);
        }

        /**
         * @summary 根据ID更新素材
         *
         * @param request UpdateMaterialDocumentRequest
         * @return UpdateMaterialDocumentResponse
         */
        public async Task<UpdateMaterialDocumentResponse> UpdateMaterialDocumentAsync(UpdateMaterialDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMaterialDocumentWithOptionsAsync(request, runtime);
        }

    }
}
