// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AiContent20240611.Models;

namespace AlibabaCloud.SDK.AiContent20240611
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aicontent", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>拓展练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherExpansionPracticeTaskGenerateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AITeacherExpansionPracticeTaskGenerateResponse
        /// </returns>
        public AITeacherExpansionPracticeTaskGenerateResponse AITeacherExpansionPracticeTaskGenerateWithOptions(AITeacherExpansionPracticeTaskGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySentences))
            {
                body["keySentences"] = request.KeySentences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningObject))
            {
                body["learningObject"] = request.LearningObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Textbook))
            {
                body["textbook"] = request.Textbook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "AITeacherExpansionPracticeTaskGenerate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/generateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherExpansionPracticeTaskGenerateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AITeacherExpansionPracticeTaskGenerateResponse
        /// </returns>
        public async Task<AITeacherExpansionPracticeTaskGenerateResponse> AITeacherExpansionPracticeTaskGenerateWithOptionsAsync(AITeacherExpansionPracticeTaskGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySentences))
            {
                body["keySentences"] = request.KeySentences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningObject))
            {
                body["learningObject"] = request.LearningObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Textbook))
            {
                body["textbook"] = request.Textbook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "AITeacherExpansionPracticeTaskGenerate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/generateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherExpansionPracticeTaskGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// AITeacherExpansionPracticeTaskGenerateResponse
        /// </returns>
        public AITeacherExpansionPracticeTaskGenerateResponse AITeacherExpansionPracticeTaskGenerate(AITeacherExpansionPracticeTaskGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AITeacherExpansionPracticeTaskGenerateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherExpansionPracticeTaskGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// AITeacherExpansionPracticeTaskGenerateResponse
        /// </returns>
        public async Task<AITeacherExpansionPracticeTaskGenerateResponse> AITeacherExpansionPracticeTaskGenerateAsync(AITeacherExpansionPracticeTaskGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AITeacherExpansionPracticeTaskGenerateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步基础练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherSyncPracticeTaskGenerateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AITeacherSyncPracticeTaskGenerateResponse
        /// </returns>
        public AITeacherSyncPracticeTaskGenerateResponse AITeacherSyncPracticeTaskGenerateWithOptions(AITeacherSyncPracticeTaskGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySentences))
            {
                body["keySentences"] = request.KeySentences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningObject))
            {
                body["learningObject"] = request.LearningObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Textbook))
            {
                body["textbook"] = request.Textbook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "AITeacherSyncPracticeTaskGenerate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/generateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步基础练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherSyncPracticeTaskGenerateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AITeacherSyncPracticeTaskGenerateResponse
        /// </returns>
        public async Task<AITeacherSyncPracticeTaskGenerateResponse> AITeacherSyncPracticeTaskGenerateWithOptionsAsync(AITeacherSyncPracticeTaskGenerateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySentences))
            {
                body["keySentences"] = request.KeySentences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWords))
            {
                body["keyWords"] = request.KeyWords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningObject))
            {
                body["learningObject"] = request.LearningObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Textbook))
            {
                body["textbook"] = request.Textbook;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "AITeacherSyncPracticeTaskGenerate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/generateTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步基础练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherSyncPracticeTaskGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// AITeacherSyncPracticeTaskGenerateResponse
        /// </returns>
        public AITeacherSyncPracticeTaskGenerateResponse AITeacherSyncPracticeTaskGenerate(AITeacherSyncPracticeTaskGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AITeacherSyncPracticeTaskGenerateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步基础练问答对生成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AITeacherSyncPracticeTaskGenerateRequest
        /// </param>
        /// 
        /// <returns>
        /// AITeacherSyncPracticeTaskGenerateResponse
        /// </returns>
        public async Task<AITeacherSyncPracticeTaskGenerateResponse> AITeacherSyncPracticeTaskGenerateAsync(AITeacherSyncPracticeTaskGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AITeacherSyncPracticeTaskGenerateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
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
        /// AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServcieList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunconsole/queryAliyunConsoleServcieList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
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
        /// AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServcieList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunconsole/queryAliyunConsoleServcieList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse AliyunConsoleOpenApiQueryAliyunConsoleServcieList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServcieListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AliyunConsoleOpenApiQueryAliyunConsoleServcieListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
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
        /// AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse AliyunConsoleOpenApiQueryAliyunConsoleServiceListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServiceList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryAliyunConsoleServiceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
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
        /// AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServiceListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryAliyunConsoleServiceList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryAliyunConsoleServiceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse AliyunConsoleOpenApiQueryAliyunConsoleServiceList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AliyunConsoleOpenApiQueryAliyunConsoleServiceListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出阿里云控制台上可使用的服务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse> AliyunConsoleOpenApiQueryAliyunConsoleServiceListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AliyunConsoleOpenApiQueryAliyunConsoleServiceListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出购买过的资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AliyunConsoleOpenApiQueryPaidResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryPaidResourceResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryPaidResourceResponse AliyunConsoleOpenApiQueryPaidResourceWithOptions(AliyunConsoleOpenApiQueryPaidResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryPaidResource",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryPaidResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryPaidResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出购买过的资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AliyunConsoleOpenApiQueryPaidResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryPaidResourceResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryPaidResourceResponse> AliyunConsoleOpenApiQueryPaidResourceWithOptionsAsync(AliyunConsoleOpenApiQueryPaidResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AliyunConsoleOpenApiQueryPaidResource",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryPaidResource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AliyunConsoleOpenApiQueryPaidResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出购买过的资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AliyunConsoleOpenApiQueryPaidResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryPaidResourceResponse
        /// </returns>
        public AliyunConsoleOpenApiQueryPaidResourceResponse AliyunConsoleOpenApiQueryPaidResource(AliyunConsoleOpenApiQueryPaidResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AliyunConsoleOpenApiQueryPaidResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/列出购买过的资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AliyunConsoleOpenApiQueryPaidResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// AliyunConsoleOpenApiQueryPaidResourceResponse
        /// </returns>
        public async Task<AliyunConsoleOpenApiQueryPaidResourceResponse> AliyunConsoleOpenApiQueryPaidResourceAsync(AliyunConsoleOpenApiQueryPaidResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AliyunConsoleOpenApiQueryPaidResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsCallsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsCallsResponse
        /// </returns>
        public CountOralEvaluationStatisticsCallsResponse CountOralEvaluationStatisticsCallsWithOptions(CountOralEvaluationStatisticsCallsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsCalls",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsCalls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsCallsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsCallsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsCallsResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsCallsResponse> CountOralEvaluationStatisticsCallsWithOptionsAsync(CountOralEvaluationStatisticsCallsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsCalls",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsCalls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsCallsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsCallsRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsCallsResponse
        /// </returns>
        public CountOralEvaluationStatisticsCallsResponse CountOralEvaluationStatisticsCalls(CountOralEvaluationStatisticsCallsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CountOralEvaluationStatisticsCallsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsCallsRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsCallsResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsCallsResponse> CountOralEvaluationStatisticsCallsAsync(CountOralEvaluationStatisticsCallsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CountOralEvaluationStatisticsCallsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/并发数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsConcurrentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsConcurrentResponse
        /// </returns>
        public CountOralEvaluationStatisticsConcurrentResponse CountOralEvaluationStatisticsConcurrentWithOptions(CountOralEvaluationStatisticsConcurrentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsConcurrent",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsConcurrent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsConcurrentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/并发数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsConcurrentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsConcurrentResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsConcurrentResponse> CountOralEvaluationStatisticsConcurrentWithOptionsAsync(CountOralEvaluationStatisticsConcurrentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsConcurrent",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsConcurrent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsConcurrentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/并发数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsConcurrentRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsConcurrentResponse
        /// </returns>
        public CountOralEvaluationStatisticsConcurrentResponse CountOralEvaluationStatisticsConcurrent(CountOralEvaluationStatisticsConcurrentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CountOralEvaluationStatisticsConcurrentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/并发数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsConcurrentRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsConcurrentResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsConcurrentResponse> CountOralEvaluationStatisticsConcurrentAsync(CountOralEvaluationStatisticsConcurrentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CountOralEvaluationStatisticsConcurrentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用错误</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsErrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsErrorResponse
        /// </returns>
        public CountOralEvaluationStatisticsErrorResponse CountOralEvaluationStatisticsErrorWithOptions(CountOralEvaluationStatisticsErrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsError",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsError",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsErrorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用错误</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsErrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsErrorResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsErrorResponse> CountOralEvaluationStatisticsErrorWithOptionsAsync(CountOralEvaluationStatisticsErrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CountOralEvaluationStatisticsError",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/countOralEvaluationStatisticsError",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOralEvaluationStatisticsErrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用错误</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsErrorRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsErrorResponse
        /// </returns>
        public CountOralEvaluationStatisticsErrorResponse CountOralEvaluationStatisticsError(CountOralEvaluationStatisticsErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CountOralEvaluationStatisticsErrorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能批改/口语评测/统计/调用错误</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOralEvaluationStatisticsErrorRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOralEvaluationStatisticsErrorResponse
        /// </returns>
        public async Task<CountOralEvaluationStatisticsErrorResponse> CountOralEvaluationStatisticsErrorAsync(CountOralEvaluationStatisticsErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CountOralEvaluationStatisticsErrorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/授权凭证创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessWarrantRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessWarrantResponse
        /// </returns>
        public CreateAccessWarrantResponse CreateAccessWarrantWithOptions(CreateAccessWarrantRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestSign))
            {
                body["requestSign"] = request.RequestSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                body["userClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarrantAvailable))
            {
                body["warrantAvailable"] = request.WarrantAvailable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessWarrant",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/createAccessWarrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessWarrantResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/授权凭证创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessWarrantRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessWarrantResponse
        /// </returns>
        public async Task<CreateAccessWarrantResponse> CreateAccessWarrantWithOptionsAsync(CreateAccessWarrantRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestSign))
            {
                body["requestSign"] = request.RequestSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                body["userClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarrantAvailable))
            {
                body["warrantAvailable"] = request.WarrantAvailable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessWarrant",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/createAccessWarrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessWarrantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/授权凭证创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessWarrantRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessWarrantResponse
        /// </returns>
        public CreateAccessWarrantResponse CreateAccessWarrant(CreateAccessWarrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAccessWarrantWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/授权凭证创建</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessWarrantRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessWarrantResponse
        /// </returns>
        public async Task<CreateAccessWarrantResponse> CreateAccessWarrantAsync(CreateAccessWarrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAccessWarrantWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                body["projectType"] = request.ProjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                body["projectType"] = request.ProjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中文作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptions(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayOutline))
            {
                body["essayOutline"] = request.EssayOutline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayRequirements))
            {
                body["essayRequirements"] = request.EssayRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayTopic))
            {
                body["essayTopic"] = request.EssayTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayType))
            {
                body["essayType"] = request.EssayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayWordCount))
            {
                body["essayWordCount"] = request.EssayWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
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
                Action = "ExecuteAITeacherChineseCompositionTutoringWorkflowRun",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/chineseCompositionTutoring/workflowRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中文作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public async Task<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse> ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptionsAsync(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayOutline))
            {
                body["essayOutline"] = request.EssayOutline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayRequirements))
            {
                body["essayRequirements"] = request.EssayRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayTopic))
            {
                body["essayTopic"] = request.EssayTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayType))
            {
                body["essayType"] = request.EssayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayWordCount))
            {
                body["essayWordCount"] = request.EssayWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
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
                Action = "ExecuteAITeacherChineseCompositionTutoringWorkflowRun",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/chineseCompositionTutoring/workflowRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中文作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse ExecuteAITeacherChineseCompositionTutoringWorkflowRun(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中文作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public async Task<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse> ExecuteAITeacherChineseCompositionTutoringWorkflowRunAsync(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse
        /// </returns>
        public ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse ExecuteAITeacherEnglishCompositionTutoringWorkflowRunWithOptions(ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayOutline))
            {
                body["essayOutline"] = request.EssayOutline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayRequirements))
            {
                body["essayRequirements"] = request.EssayRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayTopic))
            {
                body["essayTopic"] = request.EssayTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayType))
            {
                body["essayType"] = request.EssayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayWordCount))
            {
                body["essayWordCount"] = request.EssayWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
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
                Action = "ExecuteAITeacherEnglishCompositionTutoringWorkflowRun",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/englishCompositionTutoring/workflowRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse
        /// </returns>
        public async Task<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse> ExecuteAITeacherEnglishCompositionTutoringWorkflowRunWithOptionsAsync(ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayOutline))
            {
                body["essayOutline"] = request.EssayOutline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayRequirements))
            {
                body["essayRequirements"] = request.EssayRequirements;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayTopic))
            {
                body["essayTopic"] = request.EssayTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayType))
            {
                body["essayType"] = request.EssayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EssayWordCount))
            {
                body["essayWordCount"] = request.EssayWordCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
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
                Action = "ExecuteAITeacherEnglishCompositionTutoringWorkflowRun",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/englishCompositionTutoring/workflowRun",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse
        /// </returns>
        public ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse ExecuteAITeacherEnglishCompositionTutoringWorkflowRun(ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherEnglishCompositionTutoringWorkflowRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英语作文辅导</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse
        /// </returns>
        public async Task<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse> ExecuteAITeacherEnglishCompositionTutoringWorkflowRunAsync(ExecuteAITeacherEnglishCompositionTutoringWorkflowRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherEnglishCompositionTutoringWorkflowRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英文释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishParaphraseChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishParaphraseChatMessageResponse
        /// </returns>
        public ExecuteAITeacherEnglishParaphraseChatMessageResponse ExecuteAITeacherEnglishParaphraseChatMessageWithOptions(ExecuteAITeacherEnglishParaphraseChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionId))
            {
                body["questionId"] = request.QuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionInfo))
            {
                body["questionInfo"] = request.QuestionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAnswer))
            {
                body["userAnswer"] = request.UserAnswer;
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
                Action = "ExecuteAITeacherEnglishParaphraseChatMessage",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/englishParaphrase/chatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英文释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishParaphraseChatMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishParaphraseChatMessageResponse
        /// </returns>
        public async Task<ExecuteAITeacherEnglishParaphraseChatMessageResponse> ExecuteAITeacherEnglishParaphraseChatMessageWithOptionsAsync(ExecuteAITeacherEnglishParaphraseChatMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionId))
            {
                body["questionId"] = request.QuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionInfo))
            {
                body["questionInfo"] = request.QuestionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseMode))
            {
                body["responseMode"] = request.ResponseMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAnswer))
            {
                body["userAnswer"] = request.UserAnswer;
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
                Action = "ExecuteAITeacherEnglishParaphraseChatMessage",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/pop/api/v1/intelligentAgent/englishParaphrase/chatMessage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英文释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishParaphraseChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishParaphraseChatMessageResponse
        /// </returns>
        public ExecuteAITeacherEnglishParaphraseChatMessageResponse ExecuteAITeacherEnglishParaphraseChatMessage(ExecuteAITeacherEnglishParaphraseChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherEnglishParaphraseChatMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>英文释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherEnglishParaphraseChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherEnglishParaphraseChatMessageResponse
        /// </returns>
        public async Task<ExecuteAITeacherEnglishParaphraseChatMessageResponse> ExecuteAITeacherEnglishParaphraseChatMessageAsync(ExecuteAITeacherEnglishParaphraseChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherEnglishParaphraseChatMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行拓展练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueResponse ExecuteAITeacherExpansionDialogueWithOptions(ExecuteAITeacherExpansionDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/executeExpansionTraining",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行拓展练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueResponse> ExecuteAITeacherExpansionDialogueWithOptionsAsync(ExecuteAITeacherExpansionDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/executeExpansionTraining",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行拓展练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueResponse ExecuteAITeacherExpansionDialogue(ExecuteAITeacherExpansionDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherExpansionDialogueWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行拓展练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueResponse> ExecuteAITeacherExpansionDialogueAsync(ExecuteAITeacherExpansionDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherExpansionDialogueWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练根据上下文进行润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRefineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueRefineResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueRefineResponse ExecuteAITeacherExpansionDialogueRefineWithOptions(ExecuteAITeacherExpansionDialogueRefineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogueRefine",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/refineByContext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练根据上下文进行润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRefineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueRefineResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueRefineResponse> ExecuteAITeacherExpansionDialogueRefineWithOptionsAsync(ExecuteAITeacherExpansionDialogueRefineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogueRefine",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/refineByContext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练根据上下文进行润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRefineRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueRefineResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueRefineResponse ExecuteAITeacherExpansionDialogueRefine(ExecuteAITeacherExpansionDialogueRefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherExpansionDialogueRefineWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练根据上下文进行润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueRefineRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueRefineResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueRefineResponse> ExecuteAITeacherExpansionDialogueRefineAsync(ExecuteAITeacherExpansionDialogueRefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherExpansionDialogueRefineWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueTranslateResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueTranslateResponse ExecuteAITeacherExpansionDialogueTranslateWithOptions(ExecuteAITeacherExpansionDialogueTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogueTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueTranslateResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueTranslateResponse> ExecuteAITeacherExpansionDialogueTranslateWithOptionsAsync(ExecuteAITeacherExpansionDialogueTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "ExecuteAITeacherExpansionDialogueTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueTranslateResponse
        /// </returns>
        public ExecuteAITeacherExpansionDialogueTranslateResponse ExecuteAITeacherExpansionDialogueTranslate(ExecuteAITeacherExpansionDialogueTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherExpansionDialogueTranslateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherExpansionDialogueTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherExpansionDialogueTranslateResponse
        /// </returns>
        public async Task<ExecuteAITeacherExpansionDialogueTranslateResponse> ExecuteAITeacherExpansionDialogueTranslateAsync(ExecuteAITeacherExpansionDialogueTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherExpansionDialogueTranslateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherGrammarCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherGrammarCheckResponse
        /// </returns>
        public ExecuteAITeacherGrammarCheckResponse ExecuteAITeacherGrammarCheckWithOptions(ExecuteAITeacherGrammarCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
                Action = "ExecuteAITeacherGrammarCheck",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/common/grammarChecking",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherGrammarCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherGrammarCheckResponse
        /// </returns>
        public async Task<ExecuteAITeacherGrammarCheckResponse> ExecuteAITeacherGrammarCheckWithOptionsAsync(ExecuteAITeacherGrammarCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
                Action = "ExecuteAITeacherGrammarCheck",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/common/grammarChecking",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherGrammarCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherGrammarCheckResponse
        /// </returns>
        public ExecuteAITeacherGrammarCheckResponse ExecuteAITeacherGrammarCheck(ExecuteAITeacherGrammarCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherGrammarCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherGrammarCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherGrammarCheckResponse
        /// </returns>
        public async Task<ExecuteAITeacherGrammarCheckResponse> ExecuteAITeacherGrammarCheckAsync(ExecuteAITeacherGrammarCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherGrammarCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行同步练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueResponse
        /// </returns>
        public ExecuteAITeacherSyncDialogueResponse ExecuteAITeacherSyncDialogueWithOptions(ExecuteAITeacherSyncDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "ExecuteAITeacherSyncDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/executeSyncTraining",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行同步练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueResponse
        /// </returns>
        public async Task<ExecuteAITeacherSyncDialogueResponse> ExecuteAITeacherSyncDialogueWithOptionsAsync(ExecuteAITeacherSyncDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "ExecuteAITeacherSyncDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/executeSyncTraining",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行同步练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueResponse
        /// </returns>
        public ExecuteAITeacherSyncDialogueResponse ExecuteAITeacherSyncDialogue(ExecuteAITeacherSyncDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherSyncDialogueWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行同步练对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueResponse
        /// </returns>
        public async Task<ExecuteAITeacherSyncDialogueResponse> ExecuteAITeacherSyncDialogueAsync(ExecuteAITeacherSyncDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherSyncDialogueWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueTranslateResponse
        /// </returns>
        public ExecuteAITeacherSyncDialogueTranslateResponse ExecuteAITeacherSyncDialogueTranslateWithOptions(ExecuteAITeacherSyncDialogueTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "ExecuteAITeacherSyncDialogueTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueTranslateResponse
        /// </returns>
        public async Task<ExecuteAITeacherSyncDialogueTranslateResponse> ExecuteAITeacherSyncDialogueTranslateWithOptionsAsync(ExecuteAITeacherSyncDialogueTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "ExecuteAITeacherSyncDialogueTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/translate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueTranslateResponse
        /// </returns>
        public ExecuteAITeacherSyncDialogueTranslateResponse ExecuteAITeacherSyncDialogueTranslate(ExecuteAITeacherSyncDialogueTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteAITeacherSyncDialogueTranslateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练语境翻译</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAITeacherSyncDialogueTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherSyncDialogueTranslateResponse
        /// </returns>
        public async Task<ExecuteAITeacherSyncDialogueTranslateResponse> ExecuteAITeacherSyncDialogueTranslateAsync(ExecuteAITeacherSyncDialogueTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteAITeacherSyncDialogueTranslateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行AI对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDialogueResponse
        /// </returns>
        public ExecuteTextbookAssistantDialogueResponse ExecuteTextbookAssistantDialogueWithOptions(ExecuteTextbookAssistantDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMessage))
            {
                body["userMessage"] = request.UserMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteDialogue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行AI对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDialogueResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantDialogueResponse> ExecuteTextbookAssistantDialogueWithOptionsAsync(ExecuteTextbookAssistantDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMessage))
            {
                body["userMessage"] = request.UserMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteDialogue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行AI对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDialogueResponse
        /// </returns>
        public ExecuteTextbookAssistantDialogueResponse ExecuteTextbookAssistantDialogue(ExecuteTextbookAssistantDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantDialogueWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行AI对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDialogueResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantDialogueResponse> ExecuteTextbookAssistantDialogueAsync(ExecuteTextbookAssistantDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantDialogueWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调整难度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDifficultyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDifficultyResponse
        /// </returns>
        public ExecuteTextbookAssistantDifficultyResponse ExecuteTextbookAssistantDifficultyWithOptions(ExecuteTextbookAssistantDifficultyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantDifficulty",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteDifficulty",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调整难度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDifficultyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDifficultyResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantDifficultyResponse> ExecuteTextbookAssistantDifficultyWithOptionsAsync(ExecuteTextbookAssistantDifficultyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantDifficulty",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteDifficulty",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调整难度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDifficultyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDifficultyResponse
        /// </returns>
        public ExecuteTextbookAssistantDifficultyResponse ExecuteTextbookAssistantDifficulty(ExecuteTextbookAssistantDifficultyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantDifficultyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调整难度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantDifficultyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantDifficultyResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantDifficultyResponse> ExecuteTextbookAssistantDifficultyAsync(ExecuteTextbookAssistantDifficultyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantDifficultyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantGrammarCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantGrammarCheckResponse
        /// </returns>
        public ExecuteTextbookAssistantGrammarCheckResponse ExecuteTextbookAssistantGrammarCheckWithOptions(ExecuteTextbookAssistantGrammarCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantGrammarCheck",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteGrammarCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantGrammarCheckRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantGrammarCheckResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantGrammarCheckResponse> ExecuteTextbookAssistantGrammarCheckWithOptionsAsync(ExecuteTextbookAssistantGrammarCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantGrammarCheck",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteGrammarCheck",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantGrammarCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantGrammarCheckResponse
        /// </returns>
        public ExecuteTextbookAssistantGrammarCheckResponse ExecuteTextbookAssistantGrammarCheck(ExecuteTextbookAssistantGrammarCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantGrammarCheckWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>语法检测</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantGrammarCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantGrammarCheckResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantGrammarCheckResponse> ExecuteTextbookAssistantGrammarCheckAsync(ExecuteTextbookAssistantGrammarCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantGrammarCheckWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>句子润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRefineByContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRefineByContextResponse
        /// </returns>
        public ExecuteTextbookAssistantRefineByContextResponse ExecuteTextbookAssistantRefineByContextWithOptions(ExecuteTextbookAssistantRefineByContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantRefineByContext",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/RefineByContext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>句子润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRefineByContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRefineByContextResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantRefineByContextResponse> ExecuteTextbookAssistantRefineByContextWithOptionsAsync(ExecuteTextbookAssistantRefineByContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantRefineByContext",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/RefineByContext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>句子润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRefineByContextRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRefineByContextResponse
        /// </returns>
        public ExecuteTextbookAssistantRefineByContextResponse ExecuteTextbookAssistantRefineByContext(ExecuteTextbookAssistantRefineByContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantRefineByContextWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>句子润色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRefineByContextRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRefineByContextResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantRefineByContextResponse> ExecuteTextbookAssistantRefineByContextAsync(ExecuteTextbookAssistantRefineByContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantRefineByContextWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话重试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRetryConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRetryConversationResponse
        /// </returns>
        public ExecuteTextbookAssistantRetryConversationResponse ExecuteTextbookAssistantRetryConversationWithOptions(ExecuteTextbookAssistantRetryConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantRetryConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/RetryConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话重试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRetryConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRetryConversationResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantRetryConversationResponse> ExecuteTextbookAssistantRetryConversationWithOptionsAsync(ExecuteTextbookAssistantRetryConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantRetryConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/RetryConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话重试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRetryConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRetryConversationResponse
        /// </returns>
        public ExecuteTextbookAssistantRetryConversationResponse ExecuteTextbookAssistantRetryConversation(ExecuteTextbookAssistantRetryConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantRetryConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话重试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantRetryConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantRetryConversationResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantRetryConversationResponse> ExecuteTextbookAssistantRetryConversationAsync(ExecuteTextbookAssistantRetryConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantRetryConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行对话-流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSseDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSseDialogueResponse
        /// </returns>
        public ExecuteTextbookAssistantSseDialogueResponse ExecuteTextbookAssistantSseDialogueWithOptions(ExecuteTextbookAssistantSseDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMessage))
            {
                body["userMessage"] = request.UserMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantSseDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteSseDialogue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantSseDialogueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行对话-流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSseDialogueRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSseDialogueResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantSseDialogueResponse> ExecuteTextbookAssistantSseDialogueWithOptionsAsync(ExecuteTextbookAssistantSseDialogueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMessage))
            {
                body["userMessage"] = request.UserMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantSseDialogue",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteSseDialogue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantSseDialogueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行对话-流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSseDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSseDialogueResponse
        /// </returns>
        public ExecuteTextbookAssistantSseDialogueResponse ExecuteTextbookAssistantSseDialogue(ExecuteTextbookAssistantSseDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantSseDialogueWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>进行对话-流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSseDialogueRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSseDialogueResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantSseDialogueResponse> ExecuteTextbookAssistantSseDialogueAsync(ExecuteTextbookAssistantSseDialogueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantSseDialogueWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启自由对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantStartConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantStartConversationResponse
        /// </returns>
        public ExecuteTextbookAssistantStartConversationResponse ExecuteTextbookAssistantStartConversationWithOptions(ExecuteTextbookAssistantStartConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["articleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantStartConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/StartConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启自由对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantStartConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantStartConversationResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantStartConversationResponse> ExecuteTextbookAssistantStartConversationWithOptionsAsync(ExecuteTextbookAssistantStartConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleId))
            {
                body["articleId"] = request.ArticleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantStartConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/StartConversation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启自由对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantStartConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantStartConversationResponse
        /// </returns>
        public ExecuteTextbookAssistantStartConversationResponse ExecuteTextbookAssistantStartConversation(ExecuteTextbookAssistantStartConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantStartConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启自由对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantStartConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantStartConversationResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantStartConversationResponse> ExecuteTextbookAssistantStartConversationAsync(ExecuteTextbookAssistantStartConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantStartConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSuggestionResponse
        /// </returns>
        public ExecuteTextbookAssistantSuggestionResponse ExecuteTextbookAssistantSuggestionWithOptions(ExecuteTextbookAssistantSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/Suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSuggestionResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantSuggestionResponse> ExecuteTextbookAssistantSuggestionWithOptionsAsync(ExecuteTextbookAssistantSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/Suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSuggestionResponse
        /// </returns>
        public ExecuteTextbookAssistantSuggestionResponse ExecuteTextbookAssistantSuggestion(ExecuteTextbookAssistantSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantSuggestionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantSuggestionResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantSuggestionResponse> ExecuteTextbookAssistantSuggestionAsync(ExecuteTextbookAssistantSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantSuggestionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>翻译消息内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantTranslateResponse
        /// </returns>
        public ExecuteTextbookAssistantTranslateResponse ExecuteTextbookAssistantTranslateWithOptions(ExecuteTextbookAssistantTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>翻译消息内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantTranslateResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantTranslateResponse> ExecuteTextbookAssistantTranslateWithOptionsAsync(ExecuteTextbookAssistantTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Assistant))
            {
                body["assistant"] = request.Assistant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatId))
            {
                body["chatId"] = request.ChatId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteTextbookAssistantTranslate",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/dialogue/ExecuteTranslate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>翻译消息内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantTranslateResponse
        /// </returns>
        public ExecuteTextbookAssistantTranslateResponse ExecuteTextbookAssistantTranslate(ExecuteTextbookAssistantTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteTextbookAssistantTranslateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>翻译消息内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteTextbookAssistantTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteTextbookAssistantTranslateResponse
        /// </returns>
        public async Task<ExecuteTextbookAssistantTranslateResponse> ExecuteTextbookAssistantTranslateAsync(ExecuteTextbookAssistantTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteTextbookAssistantTranslateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherExpansionDialogueSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherExpansionDialogueSuggestionResponse
        /// </returns>
        public GetAITeacherExpansionDialogueSuggestionResponse GetAITeacherExpansionDialogueSuggestionWithOptions(GetAITeacherExpansionDialogueSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "GetAITeacherExpansionDialogueSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherExpansionDialogueSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherExpansionDialogueSuggestionResponse
        /// </returns>
        public async Task<GetAITeacherExpansionDialogueSuggestionResponse> GetAITeacherExpansionDialogueSuggestionWithOptionsAsync(GetAITeacherExpansionDialogueSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                body["background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInfo))
            {
                body["roleInfo"] = request.RoleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartSentence))
            {
                body["startSentence"] = request.StartSentence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
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
                Action = "GetAITeacherExpansionDialogueSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/expansionPractice/suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherExpansionDialogueSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherExpansionDialogueSuggestionResponse
        /// </returns>
        public GetAITeacherExpansionDialogueSuggestionResponse GetAITeacherExpansionDialogueSuggestion(GetAITeacherExpansionDialogueSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAITeacherExpansionDialogueSuggestionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拓展练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherExpansionDialogueSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherExpansionDialogueSuggestionResponse
        /// </returns>
        public async Task<GetAITeacherExpansionDialogueSuggestionResponse> GetAITeacherExpansionDialogueSuggestionAsync(GetAITeacherExpansionDialogueSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAITeacherExpansionDialogueSuggestionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherSyncDialogueSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherSyncDialogueSuggestionResponse
        /// </returns>
        public GetAITeacherSyncDialogueSuggestionResponse GetAITeacherSyncDialogueSuggestionWithOptions(GetAITeacherSyncDialogueSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "GetAITeacherSyncDialogueSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherSyncDialogueSuggestionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherSyncDialogueSuggestionResponse
        /// </returns>
        public async Task<GetAITeacherSyncDialogueSuggestionResponse> GetAITeacherSyncDialogueSuggestionWithOptionsAsync(GetAITeacherSyncDialogueSuggestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueTasks))
            {
                body["dialogueTasks"] = request.DialogueTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageCode))
            {
                body["languageCode"] = request.LanguageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Action = "GetAITeacherSyncDialogueSuggestion",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aiteacher/syncPractice/suggestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherSyncDialogueSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherSyncDialogueSuggestionResponse
        /// </returns>
        public GetAITeacherSyncDialogueSuggestionResponse GetAITeacherSyncDialogueSuggestion(GetAITeacherSyncDialogueSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAITeacherSyncDialogueSuggestionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步练小助手</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITeacherSyncDialogueSuggestionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITeacherSyncDialogueSuggestionResponse
        /// </returns>
        public async Task<GetAITeacherSyncDialogueSuggestionResponse> GetAITeacherSyncDialogueSuggestionAsync(GetAITeacherSyncDialogueSuggestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAITeacherSyncDialogueSuggestionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取请求鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextbookAssistantTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextbookAssistantTokenResponse
        /// </returns>
        public GetTextbookAssistantTokenResponse GetTextbookAssistantTokenWithOptions(GetTextbookAssistantTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextbookAssistantToken",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/GetToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取请求鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextbookAssistantTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTextbookAssistantTokenResponse
        /// </returns>
        public async Task<GetTextbookAssistantTokenResponse> GetTextbookAssistantTokenWithOptionsAsync(GetTextbookAssistantTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextbookAssistantToken",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/GetToken",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取请求鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextbookAssistantTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextbookAssistantTokenResponse
        /// </returns>
        public GetTextbookAssistantTokenResponse GetTextbookAssistantToken(GetTextbookAssistantTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTextbookAssistantTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取请求鉴权参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTextbookAssistantTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTextbookAssistantTokenResponse
        /// </returns>
        public async Task<GetTextbookAssistantTokenResponse> GetTextbookAssistantTokenAsync(GetTextbookAssistantTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTextbookAssistantTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文章详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticleDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticleDetailsResponse
        /// </returns>
        public ListTextbookAssistantArticleDetailsResponse ListTextbookAssistantArticleDetailsWithOptions(ListTextbookAssistantArticleDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleIdList))
            {
                body["articleIdList"] = request.ArticleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantArticleDetails",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListArticleDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantArticleDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文章详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticleDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticleDetailsResponse
        /// </returns>
        public async Task<ListTextbookAssistantArticleDetailsResponse> ListTextbookAssistantArticleDetailsWithOptionsAsync(ListTextbookAssistantArticleDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArticleIdList))
            {
                body["articleIdList"] = request.ArticleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantArticleDetails",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListArticleDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantArticleDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文章详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticleDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticleDetailsResponse
        /// </returns>
        public ListTextbookAssistantArticleDetailsResponse ListTextbookAssistantArticleDetails(ListTextbookAssistantArticleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantArticleDetailsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取文章详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticleDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticleDetailsResponse
        /// </returns>
        public async Task<ListTextbookAssistantArticleDetailsResponse> ListTextbookAssistantArticleDetailsAsync(ListTextbookAssistantArticleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantArticleDetailsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticlesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticlesResponse
        /// </returns>
        public ListTextbookAssistantArticlesResponse ListTextbookAssistantArticlesWithOptions(ListTextbookAssistantArticlesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantArticles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListArticles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticlesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticlesResponse
        /// </returns>
        public async Task<ListTextbookAssistantArticlesResponse> ListTextbookAssistantArticlesWithOptionsAsync(ListTextbookAssistantArticlesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirectoryId))
            {
                body["directoryId"] = request.DirectoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantArticles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListArticles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticlesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticlesResponse
        /// </returns>
        public ListTextbookAssistantArticlesResponse ListTextbookAssistantArticles(ListTextbookAssistantArticlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantArticlesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantArticlesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantArticlesResponse
        /// </returns>
        public async Task<ListTextbookAssistantArticlesResponse> ListTextbookAssistantArticlesAsync(ListTextbookAssistantArticlesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantArticlesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取书本下的目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBookDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBookDirectoriesResponse
        /// </returns>
        public ListTextbookAssistantBookDirectoriesResponse ListTextbookAssistantBookDirectoriesWithOptions(ListTextbookAssistantBookDirectoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookId))
            {
                body["bookId"] = request.BookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantBookDirectories",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListBookDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取书本下的目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBookDirectoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBookDirectoriesResponse
        /// </returns>
        public async Task<ListTextbookAssistantBookDirectoriesResponse> ListTextbookAssistantBookDirectoriesWithOptionsAsync(ListTextbookAssistantBookDirectoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookId))
            {
                body["bookId"] = request.BookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantBookDirectories",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListBookDirectories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取书本下的目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBookDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBookDirectoriesResponse
        /// </returns>
        public ListTextbookAssistantBookDirectoriesResponse ListTextbookAssistantBookDirectories(ListTextbookAssistantBookDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantBookDirectoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取书本下的目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBookDirectoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBookDirectoriesResponse
        /// </returns>
        public async Task<ListTextbookAssistantBookDirectoriesResponse> ListTextbookAssistantBookDirectoriesAsync(ListTextbookAssistantBookDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantBookDirectoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取包含年级下的书本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBooksResponse
        /// </returns>
        public ListTextbookAssistantBooksResponse ListTextbookAssistantBooksWithOptions(ListTextbookAssistantBooksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookId))
            {
                body["bookId"] = request.BookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                body["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantBooks",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListBooks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取包含年级下的书本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBooksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBooksResponse
        /// </returns>
        public async Task<ListTextbookAssistantBooksResponse> ListTextbookAssistantBooksWithOptionsAsync(ListTextbookAssistantBooksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BookId))
            {
                body["bookId"] = request.BookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                body["grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                body["volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantBooks",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListBooks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取包含年级下的书本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBooksResponse
        /// </returns>
        public ListTextbookAssistantBooksResponse ListTextbookAssistantBooks(ListTextbookAssistantBooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantBooksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取包含年级下的书本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantBooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantBooksResponse
        /// </returns>
        public async Task<ListTextbookAssistantBooksResponse> ListTextbookAssistantBooksAsync(ListTextbookAssistantBooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantBooksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取有资源的年级信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantGradeVolumesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantGradeVolumesResponse
        /// </returns>
        public ListTextbookAssistantGradeVolumesResponse ListTextbookAssistantGradeVolumesWithOptions(ListTextbookAssistantGradeVolumesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantGradeVolumes",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListGradeVolumes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取有资源的年级信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantGradeVolumesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantGradeVolumesResponse
        /// </returns>
        public async Task<ListTextbookAssistantGradeVolumesResponse> ListTextbookAssistantGradeVolumesWithOptionsAsync(ListTextbookAssistantGradeVolumesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantGradeVolumes",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListGradeVolumes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取有资源的年级信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantGradeVolumesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantGradeVolumesResponse
        /// </returns>
        public ListTextbookAssistantGradeVolumesResponse ListTextbookAssistantGradeVolumes(ListTextbookAssistantGradeVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantGradeVolumesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取有资源的年级信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantGradeVolumesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantGradeVolumesResponse
        /// </returns>
        public async Task<ListTextbookAssistantGradeVolumesResponse> ListTextbookAssistantGradeVolumesAsync(ListTextbookAssistantGradeVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantGradeVolumesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章内容详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantSceneDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantSceneDetailsResponse
        /// </returns>
        public ListTextbookAssistantSceneDetailsResponse ListTextbookAssistantSceneDetailsWithOptions(ListTextbookAssistantSceneDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIdList))
            {
                body["sceneIdList"] = request.SceneIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantSceneDetails",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListSceneDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantSceneDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章内容详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantSceneDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantSceneDetailsResponse
        /// </returns>
        public async Task<ListTextbookAssistantSceneDetailsResponse> ListTextbookAssistantSceneDetailsWithOptionsAsync(ListTextbookAssistantSceneDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthToken))
            {
                body["authToken"] = request.AuthToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIdList))
            {
                body["sceneIdList"] = request.SceneIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTextbookAssistantSceneDetails",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/textbookAssistant/teachingResource/ListSceneDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTextbookAssistantSceneDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章内容详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantSceneDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantSceneDetailsResponse
        /// </returns>
        public ListTextbookAssistantSceneDetailsResponse ListTextbookAssistantSceneDetails(ListTextbookAssistantSceneDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTextbookAssistantSceneDetailsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文章内容详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTextbookAssistantSceneDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTextbookAssistantSceneDetailsResponse
        /// </returns>
        public async Task<ListTextbookAssistantSceneDetailsResponse> ListTextbookAssistantSceneDetailsAsync(ListTextbookAssistantSceneDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTextbookAssistantSceneDetailsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>聊天/聊天接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterChatCompletionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterChatCompletionsResponse
        /// </returns>
        public ModelRouterChatCompletionsResponse ModelRouterChatCompletionsWithOptions(ModelRouterChatCompletionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterChatCompletions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterChatCompletionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>聊天/聊天接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterChatCompletionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterChatCompletionsResponse
        /// </returns>
        public async Task<ModelRouterChatCompletionsResponse> ModelRouterChatCompletionsWithOptionsAsync(ModelRouterChatCompletionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterChatCompletions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/chat/completions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterChatCompletionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>聊天/聊天接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterChatCompletionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterChatCompletionsResponse
        /// </returns>
        public ModelRouterChatCompletionsResponse ModelRouterChatCompletions(ModelRouterChatCompletionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterChatCompletionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>聊天/聊天接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterChatCompletionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterChatCompletionsResponse
        /// </returns>
        public async Task<ModelRouterChatCompletionsResponse> ModelRouterChatCompletionsAsync(ModelRouterChatCompletionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterChatCompletionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/复制API密钥</para>
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
        /// ModelRouterCopyApiKeyResponse
        /// </returns>
        public ModelRouterCopyApiKeyResponse ModelRouterCopyApiKeyWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCopyApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/copy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCopyApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/复制API密钥</para>
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
        /// ModelRouterCopyApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCopyApiKeyResponse> ModelRouterCopyApiKeyWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCopyApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/copy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCopyApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/复制API密钥</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterCopyApiKeyResponse
        /// </returns>
        public ModelRouterCopyApiKeyResponse ModelRouterCopyApiKey(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCopyApiKeyWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/复制API密钥</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterCopyApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCopyApiKeyResponse> ModelRouterCopyApiKeyAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCopyApiKeyWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/创建API密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateApiKeyResponse
        /// </returns>
        public ModelRouterCreateApiKeyResponse ModelRouterCreateApiKeyWithOptions(ModelRouterCreateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/创建API密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCreateApiKeyResponse> ModelRouterCreateApiKeyWithOptionsAsync(ModelRouterCreateApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/创建API密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateApiKeyResponse
        /// </returns>
        public ModelRouterCreateApiKeyResponse ModelRouterCreateApiKey(ModelRouterCreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateApiKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/创建API密钥</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCreateApiKeyResponse> ModelRouterCreateApiKeyAsync(ModelRouterCreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateApiKeyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/创建客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateClientRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateClientResponse
        /// </returns>
        public ModelRouterCreateClientResponse ModelRouterCreateClientWithOptions(ModelRouterCreateClientRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/创建客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateClientRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateClientResponse
        /// </returns>
        public async Task<ModelRouterCreateClientResponse> ModelRouterCreateClientWithOptionsAsync(ModelRouterCreateClientRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/创建客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateClientRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateClientResponse
        /// </returns>
        public ModelRouterCreateClientResponse ModelRouterCreateClient(ModelRouterCreateClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateClientWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/创建客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateClientRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateClientResponse
        /// </returns>
        public async Task<ModelRouterCreateClientResponse> ModelRouterCreateClientAsync(ModelRouterCreateClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateClientWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/新建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateConversationResponse
        /// </returns>
        public ModelRouterCreateConversationResponse ModelRouterCreateConversationWithOptions(ModelRouterCreateConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatData))
            {
                body["chatData"] = request.ChatData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                body["modelIds"] = request.ModelIds;
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
                Action = "ModelRouterCreateConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/新建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateConversationResponse
        /// </returns>
        public async Task<ModelRouterCreateConversationResponse> ModelRouterCreateConversationWithOptionsAsync(ModelRouterCreateConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatData))
            {
                body["chatData"] = request.ChatData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                body["modelIds"] = request.ModelIds;
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
                Action = "ModelRouterCreateConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/新建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateConversationResponse
        /// </returns>
        public ModelRouterCreateConversationResponse ModelRouterCreateConversation(ModelRouterCreateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/新建对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateConversationResponse
        /// </returns>
        public async Task<ModelRouterCreateConversationResponse> ModelRouterCreateConversationAsync(ModelRouterCreateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/创建模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelResponse
        /// </returns>
        public ModelRouterCreateModelResponse ModelRouterCreateModelWithOptions(ModelRouterCreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseUrl))
            {
                body["baseUrl"] = request.BaseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInputLength))
            {
                body["maxInputLength"] = request.MaxInputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/创建模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelResponse
        /// </returns>
        public async Task<ModelRouterCreateModelResponse> ModelRouterCreateModelWithOptionsAsync(ModelRouterCreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseUrl))
            {
                body["baseUrl"] = request.BaseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInputLength))
            {
                body["maxInputLength"] = request.MaxInputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/创建模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelResponse
        /// </returns>
        public ModelRouterCreateModelResponse ModelRouterCreateModel(ModelRouterCreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/创建模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelResponse
        /// </returns>
        public async Task<ModelRouterCreateModelResponse> ModelRouterCreateModelAsync(ModelRouterCreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/删除API密钥</para>
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
        /// ModelRouterDeleteApiKeyResponse
        /// </returns>
        public ModelRouterDeleteApiKeyResponse ModelRouterDeleteApiKeyWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/删除API密钥</para>
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
        /// ModelRouterDeleteApiKeyResponse
        /// </returns>
        public async Task<ModelRouterDeleteApiKeyResponse> ModelRouterDeleteApiKeyWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/删除API密钥</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteApiKeyResponse
        /// </returns>
        public ModelRouterDeleteApiKeyResponse ModelRouterDeleteApiKey(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteApiKeyWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/删除API密钥</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteApiKeyResponse
        /// </returns>
        public async Task<ModelRouterDeleteApiKeyResponse> ModelRouterDeleteApiKeyAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteApiKeyWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/删除客户</para>
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
        /// ModelRouterDeleteClientResponse
        /// </returns>
        public ModelRouterDeleteClientResponse ModelRouterDeleteClientWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/删除客户</para>
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
        /// ModelRouterDeleteClientResponse
        /// </returns>
        public async Task<ModelRouterDeleteClientResponse> ModelRouterDeleteClientWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/删除客户</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteClientResponse
        /// </returns>
        public ModelRouterDeleteClientResponse ModelRouterDeleteClient(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteClientWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/删除客户</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteClientResponse
        /// </returns>
        public async Task<ModelRouterDeleteClientResponse> ModelRouterDeleteClientAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteClientWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/删除对话</para>
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
        /// ModelRouterDeleteConversationResponse
        /// </returns>
        public ModelRouterDeleteConversationResponse ModelRouterDeleteConversationWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/删除对话</para>
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
        /// ModelRouterDeleteConversationResponse
        /// </returns>
        public async Task<ModelRouterDeleteConversationResponse> ModelRouterDeleteConversationWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/删除对话</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteConversationResponse
        /// </returns>
        public ModelRouterDeleteConversationResponse ModelRouterDeleteConversation(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteConversationWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/删除对话</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteConversationResponse
        /// </returns>
        public async Task<ModelRouterDeleteConversationResponse> ModelRouterDeleteConversationAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteConversationWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/删除模型</para>
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
        /// ModelRouterDeleteModelResponse
        /// </returns>
        public ModelRouterDeleteModelResponse ModelRouterDeleteModelWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/删除模型</para>
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
        /// ModelRouterDeleteModelResponse
        /// </returns>
        public async Task<ModelRouterDeleteModelResponse> ModelRouterDeleteModelWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/删除模型</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelResponse
        /// </returns>
        public ModelRouterDeleteModelResponse ModelRouterDeleteModel(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteModelWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/删除模型</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelResponse
        /// </returns>
        public async Task<ModelRouterDeleteModelResponse> ModelRouterDeleteModelAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteModelWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥详情</para>
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
        /// ModelRouterQueryApiKeyResponse
        /// </returns>
        public ModelRouterQueryApiKeyResponse ModelRouterQueryApiKeyWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥详情</para>
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
        /// ModelRouterQueryApiKeyResponse
        /// </returns>
        public async Task<ModelRouterQueryApiKeyResponse> ModelRouterQueryApiKeyWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyResponse
        /// </returns>
        public ModelRouterQueryApiKeyResponse ModelRouterQueryApiKey(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryApiKeyWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyResponse
        /// </returns>
        public async Task<ModelRouterQueryApiKeyResponse> ModelRouterQueryApiKeyAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryApiKeyWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryApiKeyListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyListResponse
        /// </returns>
        public ModelRouterQueryApiKeyListResponse ModelRouterQueryApiKeyListWithOptions(ModelRouterQueryApiKeyListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryApiKeyList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryApiKeyListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryApiKeyListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyListResponse
        /// </returns>
        public async Task<ModelRouterQueryApiKeyListResponse> ModelRouterQueryApiKeyListWithOptionsAsync(ModelRouterQueryApiKeyListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryApiKeyList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryApiKeyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryApiKeyListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyListResponse
        /// </returns>
        public ModelRouterQueryApiKeyListResponse ModelRouterQueryApiKeyList(ModelRouterQueryApiKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryApiKeyListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API密钥管理/获取API密钥列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryApiKeyListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryApiKeyListResponse
        /// </returns>
        public async Task<ModelRouterQueryApiKeyListResponse> ModelRouterQueryApiKeyListAsync(ModelRouterQueryApiKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryApiKeyListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/获取客户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientListResponse
        /// </returns>
        public ModelRouterQueryClientListResponse ModelRouterQueryClientListWithOptions(ModelRouterQueryClientListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryClientList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/获取客户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientListResponse
        /// </returns>
        public async Task<ModelRouterQueryClientListResponse> ModelRouterQueryClientListWithOptionsAsync(ModelRouterQueryClientListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryClientList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/获取客户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientListResponse
        /// </returns>
        public ModelRouterQueryClientListResponse ModelRouterQueryClientList(ModelRouterQueryClientListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryClientListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/获取客户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientListResponse
        /// </returns>
        public async Task<ModelRouterQueryClientListResponse> ModelRouterQueryClientListAsync(ModelRouterQueryClientListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryClientListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话详情</para>
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
        /// ModelRouterQueryConversationResponse
        /// </returns>
        public ModelRouterQueryConversationResponse ModelRouterQueryConversationWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话详情</para>
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
        /// ModelRouterQueryConversationResponse
        /// </returns>
        public async Task<ModelRouterQueryConversationResponse> ModelRouterQueryConversationWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationResponse
        /// </returns>
        public ModelRouterQueryConversationResponse ModelRouterQueryConversation(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryConversationWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationResponse
        /// </returns>
        public async Task<ModelRouterQueryConversationResponse> ModelRouterQueryConversationAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryConversationWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryConversationListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationListResponse
        /// </returns>
        public ModelRouterQueryConversationListResponse ModelRouterQueryConversationListWithOptions(ModelRouterQueryConversationListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryConversationList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryConversationListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryConversationListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationListResponse
        /// </returns>
        public async Task<ModelRouterQueryConversationListResponse> ModelRouterQueryConversationListWithOptionsAsync(ModelRouterQueryConversationListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryConversationList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryConversationListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryConversationListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationListResponse
        /// </returns>
        public ModelRouterQueryConversationListResponse ModelRouterQueryConversationList(ModelRouterQueryConversationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryConversationListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/获取对话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryConversationListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryConversationListResponse
        /// </returns>
        public async Task<ModelRouterQueryConversationListResponse> ModelRouterQueryConversationListAsync(ModelRouterQueryConversationListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryConversationListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型详情</para>
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
        /// ModelRouterQueryModelResponse
        /// </returns>
        public ModelRouterQueryModelResponse ModelRouterQueryModelWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型详情</para>
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
        /// ModelRouterQueryModelResponse
        /// </returns>
        public async Task<ModelRouterQueryModelResponse> ModelRouterQueryModelWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryModelResponse
        /// </returns>
        public ModelRouterQueryModelResponse ModelRouterQueryModel(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModelRouterQueryModelResponse
        /// </returns>
        public async Task<ModelRouterQueryModelResponse> ModelRouterQueryModelAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelListResponse
        /// </returns>
        public ModelRouterQueryModelListResponse ModelRouterQueryModelListWithOptions(ModelRouterQueryModelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryModelList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelListResponse
        /// </returns>
        public async Task<ModelRouterQueryModelListResponse> ModelRouterQueryModelListWithOptionsAsync(ModelRouterQueryModelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryModelList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelListResponse
        /// </returns>
        public ModelRouterQueryModelListResponse ModelRouterQueryModelList(ModelRouterQueryModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/获取模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelListResponse
        /// </returns>
        public async Task<ModelRouterQueryModelListResponse> ModelRouterQueryModelListAsync(ModelRouterQueryModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos服务提供者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosProvidersResponse
        /// </returns>
        public ModelRouterQueryNacosProvidersResponse ModelRouterQueryNacosProvidersWithOptions(ModelRouterQueryNacosProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryNacosProviders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/nacos/providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryNacosProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos服务提供者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosProvidersResponse
        /// </returns>
        public async Task<ModelRouterQueryNacosProvidersResponse> ModelRouterQueryNacosProvidersWithOptionsAsync(ModelRouterQueryNacosProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryNacosProviders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/nacos/providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryNacosProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos服务提供者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosProvidersResponse
        /// </returns>
        public ModelRouterQueryNacosProvidersResponse ModelRouterQueryNacosProviders(ModelRouterQueryNacosProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryNacosProvidersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos服务提供者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosProvidersResponse
        /// </returns>
        public async Task<ModelRouterQueryNacosProvidersResponse> ModelRouterQueryNacosProvidersAsync(ModelRouterQueryNacosProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryNacosProvidersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosTagsResponse
        /// </returns>
        public ModelRouterQueryNacosTagsResponse ModelRouterQueryNacosTagsWithOptions(ModelRouterQueryNacosTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryNacosTags",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/nacos/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryNacosTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosTagsResponse
        /// </returns>
        public async Task<ModelRouterQueryNacosTagsResponse> ModelRouterQueryNacosTagsWithOptionsAsync(ModelRouterQueryNacosTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
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
                Action = "ModelRouterQueryNacosTags",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/nacos/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryNacosTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosTagsResponse
        /// </returns>
        public ModelRouterQueryNacosTagsResponse ModelRouterQueryNacosTags(ModelRouterQueryNacosTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryNacosTagsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Nacos配置/获取Nacos标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryNacosTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryNacosTagsResponse
        /// </returns>
        public async Task<ModelRouterQueryNacosTagsResponse> ModelRouterQueryNacosTagsAsync(ModelRouterQueryNacosTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryNacosTagsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationChartsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationChartsResponse
        /// </returns>
        public ModelRouterQueryObservationChartsResponse ModelRouterQueryObservationChartsWithOptions(ModelRouterQueryObservationChartsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationCharts",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/charts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationChartsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationChartsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationChartsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationChartsResponse> ModelRouterQueryObservationChartsWithOptionsAsync(ModelRouterQueryObservationChartsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationCharts",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/charts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationChartsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationChartsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationChartsResponse
        /// </returns>
        public ModelRouterQueryObservationChartsResponse ModelRouterQueryObservationCharts(ModelRouterQueryObservationChartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryObservationChartsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测图表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationChartsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationChartsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationChartsResponse> ModelRouterQueryObservationChartsAsync(ModelRouterQueryObservationChartsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryObservationChartsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationLogsResponse
        /// </returns>
        public ModelRouterQueryObservationLogsResponse ModelRouterQueryObservationLogsWithOptions(ModelRouterQueryObservationLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationLogsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationLogsResponse> ModelRouterQueryObservationLogsWithOptionsAsync(ModelRouterQueryObservationLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationLogsResponse
        /// </returns>
        public ModelRouterQueryObservationLogsResponse ModelRouterQueryObservationLogs(ModelRouterQueryObservationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryObservationLogsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测日志列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationLogsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationLogsResponse> ModelRouterQueryObservationLogsAsync(ModelRouterQueryObservationLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryObservationLogsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测指标数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationMetricsResponse
        /// </returns>
        public ModelRouterQueryObservationMetricsResponse ModelRouterQueryObservationMetricsWithOptions(ModelRouterQueryObservationMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测指标数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationMetricsResponse> ModelRouterQueryObservationMetricsWithOptionsAsync(ModelRouterQueryObservationMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyId))
            {
                query["apiKeyId"] = request.ApiKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["groupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                query["needTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                query["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["timeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryObservationMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/observation/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryObservationMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测指标数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationMetricsResponse
        /// </returns>
        public ModelRouterQueryObservationMetricsResponse ModelRouterQueryObservationMetrics(ModelRouterQueryObservationMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryObservationMetricsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型观测/获取观测指标数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryObservationMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryObservationMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryObservationMetricsResponse> ModelRouterQueryObservationMetricsAsync(ModelRouterQueryObservationMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryObservationMetricsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/更新客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateClientRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateClientResponse
        /// </returns>
        public ModelRouterUpdateClientResponse ModelRouterUpdateClientWithOptions(string id, ModelRouterUpdateClientRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterUpdateClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateClientResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/更新客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateClientRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateClientResponse
        /// </returns>
        public async Task<ModelRouterUpdateClientResponse> ModelRouterUpdateClientWithOptionsAsync(string id, ModelRouterUpdateClientRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterUpdateClient",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/更新客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateClientRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateClientResponse
        /// </returns>
        public ModelRouterUpdateClientResponse ModelRouterUpdateClient(string id, ModelRouterUpdateClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateClientWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>客户管理/更新客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateClientRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateClientResponse
        /// </returns>
        public async Task<ModelRouterUpdateClientResponse> ModelRouterUpdateClientAsync(string id, ModelRouterUpdateClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateClientWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/更新对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateConversationResponse
        /// </returns>
        public ModelRouterUpdateConversationResponse ModelRouterUpdateConversationWithOptions(string id, ModelRouterUpdateConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatData))
            {
                body["chatData"] = request.ChatData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageCount))
            {
                body["messageCount"] = request.MessageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                body["modelIds"] = request.ModelIds;
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
                Action = "ModelRouterUpdateConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateConversationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/更新对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateConversationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateConversationResponse
        /// </returns>
        public async Task<ModelRouterUpdateConversationResponse> ModelRouterUpdateConversationWithOptionsAsync(string id, ModelRouterUpdateConversationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatData))
            {
                body["chatData"] = request.ChatData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageCount))
            {
                body["messageCount"] = request.MessageCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                body["modelIds"] = request.ModelIds;
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
                Action = "ModelRouterUpdateConversation",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/conversations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateConversationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/更新对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateConversationResponse
        /// </returns>
        public ModelRouterUpdateConversationResponse ModelRouterUpdateConversation(string id, ModelRouterUpdateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateConversationWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对话管理/更新对话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateConversationResponse
        /// </returns>
        public async Task<ModelRouterUpdateConversationResponse> ModelRouterUpdateConversationAsync(string id, ModelRouterUpdateConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateConversationWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/更新模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelResponse
        /// </returns>
        public ModelRouterUpdateModelResponse ModelRouterUpdateModelWithOptions(string id, ModelRouterUpdateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseUrl))
            {
                body["baseUrl"] = request.BaseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInputLength))
            {
                body["maxInputLength"] = request.MaxInputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/更新模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelResponse
        /// </returns>
        public async Task<ModelRouterUpdateModelResponse> ModelRouterUpdateModelWithOptionsAsync(string id, ModelRouterUpdateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                body["apiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseUrl))
            {
                body["baseUrl"] = request.BaseUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxInputLength))
            {
                body["maxInputLength"] = request.MaxInputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/更新模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelResponse
        /// </returns>
        public ModelRouterUpdateModelResponse ModelRouterUpdateModel(string id, ModelRouterUpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateModelWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模型管理/更新模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelResponse
        /// </returns>
        public async Task<ModelRouterUpdateModelResponse> ModelRouterUpdateModelAsync(string id, ModelRouterUpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateModelWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个预训练模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageAddInferenceJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageAddInferenceJobResponse
        /// </returns>
        public PersonalizedTextToImageAddInferenceJobResponse PersonalizedTextToImageAddInferenceJobWithOptions(PersonalizedTextToImageAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strength))
            {
                body["strength"] = request.Strength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addPreModelInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个预训练模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageAddInferenceJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageAddInferenceJobResponse
        /// </returns>
        public async Task<PersonalizedTextToImageAddInferenceJobResponse> PersonalizedTextToImageAddInferenceJobWithOptionsAsync(PersonalizedTextToImageAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strength))
            {
                body["strength"] = request.Strength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addPreModelInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个预训练模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageAddInferenceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageAddInferenceJobResponse
        /// </returns>
        public PersonalizedTextToImageAddInferenceJobResponse PersonalizedTextToImageAddInferenceJob(PersonalizedTextToImageAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PersonalizedTextToImageAddInferenceJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个预训练模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageAddInferenceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageAddInferenceJobResponse
        /// </returns>
        public async Task<PersonalizedTextToImageAddInferenceJobResponse> PersonalizedTextToImageAddInferenceJobAsync(PersonalizedTextToImageAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PersonalizedTextToImageAddInferenceJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/通过唯一的图片编号获取图片内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryImageAssetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryImageAssetResponse
        /// </returns>
        public PersonalizedTextToImageQueryImageAssetResponse PersonalizedTextToImageQueryImageAssetWithOptions(PersonalizedTextToImageQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAssetFromImageId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/通过唯一的图片编号获取图片内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryImageAssetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryImageAssetResponse
        /// </returns>
        public async Task<PersonalizedTextToImageQueryImageAssetResponse> PersonalizedTextToImageQueryImageAssetWithOptionsAsync(PersonalizedTextToImageQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAssetFromImageId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/通过唯一的图片编号获取图片内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryImageAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryImageAssetResponse
        /// </returns>
        public PersonalizedTextToImageQueryImageAssetResponse PersonalizedTextToImageQueryImageAsset(PersonalizedTextToImageQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PersonalizedTextToImageQueryImageAssetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/通过唯一的图片编号获取图片内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryImageAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryImageAssetResponse
        /// </returns>
        public async Task<PersonalizedTextToImageQueryImageAssetResponse> PersonalizedTextToImageQueryImageAssetAsync(PersonalizedTextToImageQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PersonalizedTextToImageQueryImageAssetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询预制模型推理任务的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse
        /// </returns>
        public PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse PersonalizedTextToImageQueryPreModelInferenceJobInfoWithOptions(PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageQueryPreModelInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryPreModelInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询预制模型推理任务的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse
        /// </returns>
        public async Task<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse> PersonalizedTextToImageQueryPreModelInferenceJobInfoWithOptionsAsync(PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PersonalizedTextToImageQueryPreModelInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryPreModelInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询预制模型推理任务的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse
        /// </returns>
        public PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse PersonalizedTextToImageQueryPreModelInferenceJobInfo(PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PersonalizedTextToImageQueryPreModelInferenceJobInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询预制模型推理任务的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse
        /// </returns>
        public async Task<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse> PersonalizedTextToImageQueryPreModelInferenceJobInfoAsync(PersonalizedTextToImageQueryPreModelInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PersonalizedTextToImageQueryPreModelInferenceJobInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddInferenceJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddInferenceJobResponse
        /// </returns>
        public Personalizedtxt2imgAddInferenceJobResponse Personalizedtxt2imgAddInferenceJobWithOptions(Personalizedtxt2imgAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddInferenceJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddInferenceJobResponse
        /// </returns>
        public async Task<Personalizedtxt2imgAddInferenceJobResponse> Personalizedtxt2imgAddInferenceJobWithOptionsAsync(Personalizedtxt2imgAddInferenceJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNumber))
            {
                body["imageNumber"] = request.ImageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Seed))
            {
                body["seed"] = request.Seed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddInferenceJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addInferenceJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddInferenceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddInferenceJobResponse
        /// </returns>
        public Personalizedtxt2imgAddInferenceJobResponse Personalizedtxt2imgAddInferenceJob(Personalizedtxt2imgAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgAddInferenceJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/基于一个模型创建图片推理任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddInferenceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddInferenceJobResponse
        /// </returns>
        public async Task<Personalizedtxt2imgAddInferenceJobResponse> Personalizedtxt2imgAddInferenceJobAsync(Personalizedtxt2imgAddInferenceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgAddInferenceJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/创建一个模型训练任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddModelTrainJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddModelTrainJobResponse
        /// </returns>
        public Personalizedtxt2imgAddModelTrainJobResponse Personalizedtxt2imgAddModelTrainJobWithOptions(Personalizedtxt2imgAddModelTrainJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddModelTrainJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addModelTrainJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/创建一个模型训练任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddModelTrainJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddModelTrainJobResponse
        /// </returns>
        public async Task<Personalizedtxt2imgAddModelTrainJobResponse> Personalizedtxt2imgAddModelTrainJobWithOptionsAsync(Personalizedtxt2imgAddModelTrainJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainSteps))
            {
                body["trainSteps"] = request.TrainSteps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgAddModelTrainJob",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/addModelTrainJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/创建一个模型训练任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddModelTrainJobRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddModelTrainJobResponse
        /// </returns>
        public Personalizedtxt2imgAddModelTrainJobResponse Personalizedtxt2imgAddModelTrainJob(Personalizedtxt2imgAddModelTrainJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgAddModelTrainJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/创建一个模型训练任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgAddModelTrainJobRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgAddModelTrainJobResponse
        /// </returns>
        public async Task<Personalizedtxt2imgAddModelTrainJobResponse> Personalizedtxt2imgAddModelTrainJobAsync(Personalizedtxt2imgAddModelTrainJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgAddModelTrainJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/图片二进制内容获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryImageAssetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryImageAssetResponse
        /// </returns>
        public Personalizedtxt2imgQueryImageAssetResponse Personalizedtxt2imgQueryImageAssetWithOptions(Personalizedtxt2imgQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptId))
            {
                query["promptId"] = request.PromptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAsset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/图片二进制内容获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryImageAssetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryImageAssetResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryImageAssetResponse> Personalizedtxt2imgQueryImageAssetWithOptionsAsync(Personalizedtxt2imgQueryImageAssetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodeFormat))
            {
                query["encodeFormat"] = request.EncodeFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["imageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromptId))
            {
                query["promptId"] = request.PromptId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryImageAsset",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryImageAsset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "any",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/图片二进制内容获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryImageAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryImageAssetResponse
        /// </returns>
        public Personalizedtxt2imgQueryImageAssetResponse Personalizedtxt2imgQueryImageAsset(Personalizedtxt2imgQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryImageAssetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/图片二进制内容获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryImageAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryImageAssetResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryImageAssetResponse> Personalizedtxt2imgQueryImageAssetAsync(Personalizedtxt2imgQueryImageAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryImageAssetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型推理任务的状态和结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryInferenceJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryInferenceJobInfoResponse
        /// </returns>
        public Personalizedtxt2imgQueryInferenceJobInfoResponse Personalizedtxt2imgQueryInferenceJobInfoWithOptions(Personalizedtxt2imgQueryInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型推理任务的状态和结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryInferenceJobInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryInferenceJobInfoResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryInferenceJobInfoResponse> Personalizedtxt2imgQueryInferenceJobInfoWithOptionsAsync(Personalizedtxt2imgQueryInferenceJobInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceJobId))
            {
                query["inferenceJobId"] = request.InferenceJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryInferenceJobInfo",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryInferenceJobInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型推理任务的状态和结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryInferenceJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryInferenceJobInfoResponse
        /// </returns>
        public Personalizedtxt2imgQueryInferenceJobInfoResponse Personalizedtxt2imgQueryInferenceJobInfo(Personalizedtxt2imgQueryInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryInferenceJobInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型推理任务的状态和结果信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryInferenceJobInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryInferenceJobInfoResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryInferenceJobInfoResponse> Personalizedtxt2imgQueryInferenceJobInfoAsync(Personalizedtxt2imgQueryInferenceJobInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryInferenceJobInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型训练任务列表</para>
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
        /// Personalizedtxt2imgQueryModelTrainJobListResponse
        /// </returns>
        public Personalizedtxt2imgQueryModelTrainJobListResponse Personalizedtxt2imgQueryModelTrainJobListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainJobList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainJobList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型训练任务列表</para>
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
        /// Personalizedtxt2imgQueryModelTrainJobListResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryModelTrainJobListResponse> Personalizedtxt2imgQueryModelTrainJobListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainJobList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainJobList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型训练任务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainJobListResponse
        /// </returns>
        public Personalizedtxt2imgQueryModelTrainJobListResponse Personalizedtxt2imgQueryModelTrainJobList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryModelTrainJobListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/查询模型训练任务列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainJobListResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryModelTrainJobListResponse> Personalizedtxt2imgQueryModelTrainJobListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryModelTrainJobListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/模型训练状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryModelTrainStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainStatusResponse
        /// </returns>
        public Personalizedtxt2imgQueryModelTrainStatusResponse Personalizedtxt2imgQueryModelTrainStatusWithOptions(Personalizedtxt2imgQueryModelTrainStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainStatus",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/模型训练状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryModelTrainStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainStatusResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryModelTrainStatusResponse> Personalizedtxt2imgQueryModelTrainStatusWithOptionsAsync(Personalizedtxt2imgQueryModelTrainStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Personalizedtxt2imgQueryModelTrainStatus",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/personalizedtxt2img/queryModelTrainStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/模型训练状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryModelTrainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainStatusResponse
        /// </returns>
        public Personalizedtxt2imgQueryModelTrainStatusResponse Personalizedtxt2imgQueryModelTrainStatus(Personalizedtxt2imgQueryModelTrainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return Personalizedtxt2imgQueryModelTrainStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>个性化文生图/模型训练状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// Personalizedtxt2imgQueryModelTrainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// Personalizedtxt2imgQueryModelTrainStatusResponse
        /// </returns>
        public async Task<Personalizedtxt2imgQueryModelTrainStatusResponse> Personalizedtxt2imgQueryModelTrainStatusAsync(Personalizedtxt2imgQueryModelTrainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await Personalizedtxt2imgQueryModelTrainStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取应用访问识别码(appkey)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApplicationAccessIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApplicationAccessIdResponse
        /// </returns>
        public QueryApplicationAccessIdResponse QueryApplicationAccessIdWithOptions(QueryApplicationAccessIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationAccessId))
            {
                query["applicationAccessId"] = request.ApplicationAccessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApplicationAccessId",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryApplicationAccessId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApplicationAccessIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取应用访问识别码(appkey)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApplicationAccessIdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApplicationAccessIdResponse
        /// </returns>
        public async Task<QueryApplicationAccessIdResponse> QueryApplicationAccessIdWithOptionsAsync(QueryApplicationAccessIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationAccessId))
            {
                query["applicationAccessId"] = request.ApplicationAccessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApplicationAccessId",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryApplicationAccessId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApplicationAccessIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取应用访问识别码(appkey)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApplicationAccessIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApplicationAccessIdResponse
        /// </returns>
        public QueryApplicationAccessIdResponse QueryApplicationAccessId(QueryApplicationAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryApplicationAccessIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取应用访问识别码(appkey)信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApplicationAccessIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApplicationAccessIdResponse
        /// </returns>
        public async Task<QueryApplicationAccessIdResponse> QueryApplicationAccessIdAsync(QueryApplicationAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryApplicationAccessIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectResponse
        /// </returns>
        public QueryProjectResponse QueryProjectWithOptions(QueryProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectResponse
        /// </returns>
        public async Task<QueryProjectResponse> QueryProjectWithOptionsAsync(QueryProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryProject",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectResponse
        /// </returns>
        public QueryProjectResponse QueryProject(QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectResponse
        /// </returns>
        public async Task<QueryProjectResponse> QueryProjectAsync(QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
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
        /// QueryProjectListResponse
        /// </returns>
        public QueryProjectListResponse QueryProjectListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProjectList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryProjectList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
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
        /// QueryProjectListResponse
        /// </returns>
        public async Task<QueryProjectListResponse> QueryProjectListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryProjectList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryProjectList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryProjectListResponse
        /// </returns>
        public QueryProjectListResponse QueryProjectList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryProjectListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/获取项目列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryProjectListResponse
        /// </returns>
        public async Task<QueryProjectListResponse> QueryProjectListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryProjectListWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/已经购买过的服务项目</para>
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
        /// QueryPurchasedServiceResponse
        /// </returns>
        public QueryPurchasedServiceResponse QueryPurchasedServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedService",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryPurchasedService",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/已经购买过的服务项目</para>
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
        /// QueryPurchasedServiceResponse
        /// </returns>
        public async Task<QueryPurchasedServiceResponse> QueryPurchasedServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedService",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/queryPurchasedService",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/已经购买过的服务项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPurchasedServiceResponse
        /// </returns>
        public QueryPurchasedServiceResponse QueryPurchasedService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryPurchasedServiceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/已经购买过的服务项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPurchasedServiceResponse
        /// </returns>
        public async Task<QueryPurchasedServiceResponse> QueryPurchasedServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryPurchasedServiceWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/更新项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/updateProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/更新项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aliyunConsole/updateProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/更新项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>阿里云控制台/更新项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(request, headers, runtime);
        }

    }
}
