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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "aicontent.cn-beijing.aliyuncs.com"},
                {"cn-hangzhou", "aicontent.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "aicontent.aliyuncs.com"},
                {"public", "aicontent.aliyuncs.com"},
            };
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
        /// <para>Generate Q&amp;A pairs to expand data.</para>
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
        /// <para>Generate Q&amp;A pairs to expand data.</para>
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
        /// <para>Generate Q&amp;A pairs to expand data.</para>
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
        /// <para>Generate Q&amp;A pairs to expand data.</para>
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
        /// <para>Synchronous basic practice is primarily for dialogue tasks with a ground truth. Although this mode allows some deviation from the ground truth, the AI strictly requires users to follow it.</para>
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
        /// <para>Synchronous basic practice is primarily for dialogue tasks with a ground truth. Although this mode allows some deviation from the ground truth, the AI strictly requires users to follow it.</para>
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
        /// <para>Synchronous basic practice is primarily for dialogue tasks with a ground truth. Although this mode allows some deviation from the ground truth, the AI strictly requires users to follow it.</para>
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
        /// <para>Synchronous basic practice is primarily for dialogue tasks with a ground truth. Although this mode allows some deviation from the ground truth, the AI strictly requires users to follow it.</para>
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
        /// <para>Lists the services available on the Alibaba Cloud Console.</para>
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
        /// <para>Lists the services available on the Alibaba Cloud Console.</para>
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
        /// <para>Lists the services available on the Alibaba Cloud Console.</para>
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
        /// <para>Lists the services available on the Alibaba Cloud Console.</para>
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
        /// <para>Lists the services available in the Alibaba Cloud console.</para>
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
        /// <para>Lists the services available in the Alibaba Cloud console.</para>
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
        /// <para>Lists the services available in the Alibaba Cloud console.</para>
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
        /// <para>Lists the services available in the Alibaba Cloud console.</para>
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
        /// <para>Alibaba Cloud Management Console / List purchased resources</para>
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
        /// <para>Alibaba Cloud Management Console / List purchased resources</para>
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
        /// <para>Alibaba Cloud Management Console / List purchased resources</para>
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
        /// <para>Alibaba Cloud Management Console / List purchased resources</para>
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
        /// <para>Intelligent Correction / Oral Evaluation / Statistics / call volume</para>
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
        /// <para>Intelligent Correction / Oral Evaluation / Statistics / call volume</para>
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
        /// <para>Intelligent Correction / Oral Evaluation / Statistics / call volume</para>
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
        /// <para>Intelligent Correction / Oral Evaluation / Statistics / call volume</para>
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
        /// <para>Intelligent grading / oral evaluation / statistics / concurrency</para>
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
        /// <para>Intelligent grading / oral evaluation / statistics / concurrency</para>
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
        /// <para>Intelligent grading / oral evaluation / statistics / concurrency</para>
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
        /// <para>Intelligent grading / oral evaluation / statistics / concurrency</para>
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
        /// <para>Retrieves statistics about API call errors for the oral evaluation service.</para>
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
        /// <para>Retrieves statistics about API call errors for the oral evaluation service.</para>
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
        /// <para>Retrieves statistics about API call errors for the oral evaluation service.</para>
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
        /// <para>Retrieves statistics about API call errors for the oral evaluation service.</para>
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
        /// <para>Creates an access warrant.</para>
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
        /// <para>Creates an access warrant.</para>
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
        /// <para>Creates an access warrant.</para>
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
        /// <para>Creates an access warrant.</para>
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
        /// <para>Alibaba Cloud console &gt; Create Project</para>
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
        /// <para>Alibaba Cloud console &gt; Create Project</para>
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
        /// <para>Alibaba Cloud console &gt; Create Project</para>
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
        /// <para>Alibaba Cloud console &gt; Create Project</para>
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
        /// <para>Executes a workflow for Chinese composition tutoring.</para>
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
        /// <para>Executes a workflow for Chinese composition tutoring.</para>
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
        /// <para>Executes a workflow for Chinese composition tutoring.</para>
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
        /// <para>Executes a workflow for Chinese composition tutoring.</para>
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
        /// <para>English Composition Tutoring</para>
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
        /// <para>English Composition Tutoring</para>
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
        /// <para>English Composition Tutoring</para>
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
        /// <para>English Composition Tutoring</para>
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
        /// <para>Answers English-related questions.</para>
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
        /// <para>Answers English-related questions.</para>
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
        /// <para>Answers English-related questions.</para>
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
        /// <para>Answers English-related questions.</para>
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
        /// <para>Expansion dialogues are for open-ended conversations. In these conversations, the AI poses open-ended questions, but the user must stay on topic. If a user\&quot;s response is off-topic, the AI steers the conversation back on topic. If the user gives two consecutive off-topic responses, the AI moves on to the next topic.</para>
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
        /// <para>Expansion dialogues are for open-ended conversations. In these conversations, the AI poses open-ended questions, but the user must stay on topic. If a user\&quot;s response is off-topic, the AI steers the conversation back on topic. If the user gives two consecutive off-topic responses, the AI moves on to the next topic.</para>
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
        /// <para>Expansion dialogues are for open-ended conversations. In these conversations, the AI poses open-ended questions, but the user must stay on topic. If a user\&quot;s response is off-topic, the AI steers the conversation back on topic. If the user gives two consecutive off-topic responses, the AI moves on to the next topic.</para>
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
        /// <para>Expansion dialogues are for open-ended conversations. In these conversations, the AI poses open-ended questions, but the user must stay on topic. If a user\&quot;s response is off-topic, the AI steers the conversation back on topic. If the user gives two consecutive off-topic responses, the AI moves on to the next topic.</para>
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
        /// <para>Uses context to polish the expanded text.</para>
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
        /// <para>Uses context to polish the expanded text.</para>
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
        /// <para>Uses context to polish the expanded text.</para>
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
        /// <para>Uses context to polish the expanded text.</para>
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
        /// <para>Further Contextual Translation Practice.</para>
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
        /// <para>Further Contextual Translation Practice.</para>
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
        /// <para>Further Contextual Translation Practice.</para>
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
        /// <para>Further Contextual Translation Practice.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Practice synchronous dialogue.</para>
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
        /// <para>Practice synchronous dialogue.</para>
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
        /// <para>Practice synchronous dialogue.</para>
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
        /// <para>Practice synchronous dialogue.</para>
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
        /// <para>You can practice contextual translation in real-time.</para>
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
        /// <para>You can practice contextual translation in real-time.</para>
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
        /// <para>You can practice contextual translation in real-time.</para>
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
        /// <para>You can practice contextual translation in real-time.</para>
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
        /// <para>Executes a dialogue turn with the Textbook Assistant.</para>
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
        /// <para>Executes a dialogue turn with the Textbook Assistant.</para>
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
        /// <para>Executes a dialogue turn with the Textbook Assistant.</para>
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
        /// <para>Executes a dialogue turn with the Textbook Assistant.</para>
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
        /// <para>Adjusts the difficulty of the textbook assistant\&quot;s dialogue.</para>
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
        /// <para>Adjusts the difficulty of the textbook assistant\&quot;s dialogue.</para>
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
        /// <para>Adjusts the difficulty of the textbook assistant\&quot;s dialogue.</para>
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
        /// <para>Adjusts the difficulty of the textbook assistant\&quot;s dialogue.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Performs a grammar check.</para>
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
        /// <para>Refines a sentence based on the conversational context.</para>
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
        /// <para>Refines a sentence based on the conversational context.</para>
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
        /// <para>Refines a sentence based on the conversational context.</para>
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
        /// <para>Refines a sentence based on the conversational context.</para>
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
        /// <para>This operation retries a conversation.</para>
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
        /// <para>This operation retries a conversation.</para>
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
        /// <para>This operation retries a conversation.</para>
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
        /// <para>This operation retries a conversation.</para>
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
        /// <para>Starts a conversation and returns a streaming output.</para>
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
        /// <para>Starts a conversation and returns a streaming output.</para>
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
        /// <para>Starts a conversation and returns a streaming output.</para>
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
        /// <para>Starts a conversation and returns a streaming output.</para>
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
        /// <para>Starts a conversation with the AI teacher. The teacher then sends the initial message.</para>
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
        /// <para>Starts a conversation with the AI teacher. The teacher then sends the initial message.</para>
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
        /// <para>Starts a conversation with the AI teacher. The teacher then sends the initial message.</para>
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
        /// <para>Starts a conversation with the AI teacher. The teacher then sends the initial message.</para>
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
        /// <para>Generates a suggested response from the textbook-based AI teacher.</para>
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
        /// <para>Generates a suggested response from the textbook-based AI teacher.</para>
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
        /// <para>Generates a suggested response from the textbook-based AI teacher.</para>
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
        /// <para>Generates a suggested response from the textbook-based AI teacher.</para>
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
        /// <para>Translates the content of a message.</para>
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
        /// <para>Translates the content of a message.</para>
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
        /// <para>Translates the content of a message.</para>
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
        /// <para>Translates the content of a message.</para>
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
        /// <para>Supplemental Practice Assistant</para>
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
        /// <para>Supplemental Practice Assistant</para>
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
        /// <para>Supplemental Practice Assistant</para>
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
        /// <para>Supplemental Practice Assistant</para>
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
        /// <para>Sync Practice Assistant</para>
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
        /// <para>Sync Practice Assistant</para>
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
        /// <para>Sync Practice Assistant</para>
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
        /// <para>Sync Practice Assistant</para>
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
        /// <para>Obtains an authorization token to make API calls.</para>
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
        /// <para>Obtains an authorization token to make API calls.</para>
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
        /// <para>Obtains an authorization token to make API calls.</para>
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
        /// <para>Obtains an authorization token to make API calls.</para>
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
        /// <para>Batch get article details</para>
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
        /// <para>Batch get article details</para>
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
        /// <para>Batch get article details</para>
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
        /// <para>Batch get article details</para>
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
        /// <para>Returns a list of articles.</para>
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
        /// <para>Returns a list of articles.</para>
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
        /// <para>Returns a list of articles.</para>
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
        /// <para>Returns a list of articles.</para>
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
        /// <para>Gets the table of contents of a book.</para>
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
        /// <para>Gets the table of contents of a book.</para>
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
        /// <para>Gets the table of contents of a book.</para>
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
        /// <para>Gets the table of contents of a book.</para>
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
        /// <para>Retrieves a list of books for a specified grade.</para>
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
        /// <para>Retrieves a list of books for a specified grade.</para>
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
        /// <para>Retrieves a list of books for a specified grade.</para>
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
        /// <para>Retrieves a list of books for a specified grade.</para>
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
        /// <para>Retrieves the available grades and volumes for the Textbook Assistant.</para>
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
        /// <para>Retrieves the available grades and volumes for the Textbook Assistant.</para>
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
        /// <para>Retrieves the available grades and volumes for the Textbook Assistant.</para>
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
        /// <para>Retrieves the available grades and volumes for the Textbook Assistant.</para>
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
        /// <para>Get Article Details</para>
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
        /// <para>Get Article Details</para>
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
        /// <para>Get Article Details</para>
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
        /// <para>Get Article Details</para>
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
        /// <para>Binds model groups to departments in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Binds model groups to departments in batches.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterBatchBindModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchBindModelGroupResponse
        /// </returns>
        public ModelRouterBatchBindModelGroupResponse ModelRouterBatchBindModelGroupWithOptions(ModelRouterBatchBindModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                body["clientIdList"] = request.ClientIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchBindModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/batch-bind-model-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchBindModelGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds model groups to departments in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Binds model groups to departments in batches.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterBatchBindModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchBindModelGroupResponse
        /// </returns>
        public async Task<ModelRouterBatchBindModelGroupResponse> ModelRouterBatchBindModelGroupWithOptionsAsync(ModelRouterBatchBindModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                body["clientIdList"] = request.ClientIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchBindModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/batch-bind-model-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchBindModelGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds model groups to departments in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Binds model groups to departments in batches.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterBatchBindModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchBindModelGroupResponse
        /// </returns>
        public ModelRouterBatchBindModelGroupResponse ModelRouterBatchBindModelGroup(ModelRouterBatchBindModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchBindModelGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds model groups to departments in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Binds model groups to departments in batches.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterBatchBindModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchBindModelGroupResponse
        /// </returns>
        public async Task<ModelRouterBatchBindModelGroupResponse> ModelRouterBatchBindModelGroupAsync(ModelRouterBatchBindModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchBindModelGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateMemberApiKeysResponse
        /// </returns>
        public ModelRouterBatchCreateMemberApiKeysResponse ModelRouterBatchCreateMemberApiKeysWithOptions(string id, ModelRouterBatchCreateMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchCreateMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchCreateMemberApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterBatchCreateMemberApiKeysResponse> ModelRouterBatchCreateMemberApiKeysWithOptionsAsync(string id, ModelRouterBatchCreateMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchCreateMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchCreateMemberApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateMemberApiKeysResponse
        /// </returns>
        public ModelRouterBatchCreateMemberApiKeysResponse ModelRouterBatchCreateMemberApiKeys(string id, ModelRouterBatchCreateMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchCreateMemberApiKeysWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterBatchCreateMemberApiKeysResponse> ModelRouterBatchCreateMemberApiKeysAsync(string id, ModelRouterBatchCreateMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchCreateMemberApiKeysWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manages models by performing batch model creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateModelResponse
        /// </returns>
        public ModelRouterBatchCreateModelResponse ModelRouterBatchCreateModelWithOptions(ModelRouterBatchCreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchCreateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchCreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manages models by performing batch model creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateModelResponse
        /// </returns>
        public async Task<ModelRouterBatchCreateModelResponse> ModelRouterBatchCreateModelWithOptionsAsync(ModelRouterBatchCreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symbol))
            {
                body["symbol"] = request.Symbol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchCreateModel",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/models/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchCreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manages models by performing batch model creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateModelResponse
        /// </returns>
        public ModelRouterBatchCreateModelResponse ModelRouterBatchCreateModel(ModelRouterBatchCreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchCreateModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manages models by performing batch model creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchCreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchCreateModelResponse
        /// </returns>
        public async Task<ModelRouterBatchCreateModelResponse> ModelRouterBatchCreateModelAsync(ModelRouterBatchCreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchCreateModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchDisableMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchDisableMemberApiKeysResponse
        /// </returns>
        public ModelRouterBatchDisableMemberApiKeysResponse ModelRouterBatchDisableMemberApiKeysWithOptions(string id, ModelRouterBatchDisableMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchDisableMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-apikeys/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchDisableMemberApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchDisableMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchDisableMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterBatchDisableMemberApiKeysResponse> ModelRouterBatchDisableMemberApiKeysWithOptionsAsync(string id, ModelRouterBatchDisableMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchDisableMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-apikeys/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchDisableMemberApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchDisableMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchDisableMemberApiKeysResponse
        /// </returns>
        public ModelRouterBatchDisableMemberApiKeysResponse ModelRouterBatchDisableMemberApiKeys(string id, ModelRouterBatchDisableMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchDisableMemberApiKeysWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables API keys in batches for members under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchDisableMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchDisableMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterBatchDisableMemberApiKeysResponse> ModelRouterBatchDisableMemberApiKeysAsync(string id, ModelRouterBatchDisableMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchDisableMemberApiKeysWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch resets member authorizations to inherit under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchResetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchResetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterBatchResetMemberAuthorizationResponse ModelRouterBatchResetMemberAuthorizationWithOptions(string id, ModelRouterBatchResetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchResetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-authorizations/reset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchResetMemberAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch resets member authorizations to inherit under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchResetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchResetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterBatchResetMemberAuthorizationResponse> ModelRouterBatchResetMemberAuthorizationWithOptionsAsync(string id, ModelRouterBatchResetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchResetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-authorizations/reset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchResetMemberAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch resets member authorizations to inherit under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchResetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchResetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterBatchResetMemberAuthorizationResponse ModelRouterBatchResetMemberAuthorization(string id, ModelRouterBatchResetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchResetMemberAuthorizationWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch resets member authorizations to inherit under a department in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchResetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchResetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterBatchResetMemberAuthorizationResponse> ModelRouterBatchResetMemberAuthorizationAsync(string id, ModelRouterBatchResetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchResetMemberAuthorizationWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch sets member authorization under a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchSetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchSetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterBatchSetMemberAuthorizationResponse ModelRouterBatchSetMemberAuthorizationWithOptions(string id, ModelRouterBatchSetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchSetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-authorizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchSetMemberAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch sets member authorization under a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchSetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchSetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterBatchSetMemberAuthorizationResponse> ModelRouterBatchSetMemberAuthorizationWithOptionsAsync(string id, ModelRouterBatchSetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBatchSetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/member-authorizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBatchSetMemberAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch sets member authorization under a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchSetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchSetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterBatchSetMemberAuthorizationResponse ModelRouterBatchSetMemberAuthorization(string id, ModelRouterBatchSetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBatchSetMemberAuthorizationWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch sets member authorization under a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBatchSetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBatchSetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterBatchSetMemberAuthorizationResponse> ModelRouterBatchSetMemberAuthorizationAsync(string id, ModelRouterBatchSetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBatchSetMemberAuthorizationWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage monitoring tab configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBillingCostTabsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBillingCostTabsResponse
        /// </returns>
        public ModelRouterBillingCostTabsResponse ModelRouterBillingCostTabsWithOptions(ModelRouterBillingCostTabsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBillingCostTabs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/tabs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBillingCostTabsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage monitoring tab configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBillingCostTabsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBillingCostTabsResponse
        /// </returns>
        public async Task<ModelRouterBillingCostTabsResponse> ModelRouterBillingCostTabsWithOptionsAsync(ModelRouterBillingCostTabsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterBillingCostTabs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/tabs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterBillingCostTabsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage monitoring tab configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBillingCostTabsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBillingCostTabsResponse
        /// </returns>
        public ModelRouterBillingCostTabsResponse ModelRouterBillingCostTabs(ModelRouterBillingCostTabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterBillingCostTabsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage monitoring tab configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterBillingCostTabsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterBillingCostTabsResponse
        /// </returns>
        public async Task<ModelRouterBillingCostTabsResponse> ModelRouterBillingCostTabsAsync(ModelRouterBillingCostTabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterBillingCostTabsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a chat conversation.</para>
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
        /// <para>Initiates a chat conversation.</para>
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
        /// <para>Initiates a chat conversation.</para>
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
        /// <para>Initiates a chat conversation.</para>
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
        /// <para>Enables balance-based throttling for a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureClientBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureClientBalanceResponse
        /// </returns>
        public ModelRouterConfigureClientBalanceResponse ModelRouterConfigureClientBalanceWithOptions(string id, ModelRouterConfigureClientBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBalance))
            {
                body["enableBalance"] = request.EnableBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialBalance))
            {
                body["initialBalance"] = request.InitialBalance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterConfigureClientBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterConfigureClientBalanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables balance-based throttling for a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureClientBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureClientBalanceResponse
        /// </returns>
        public async Task<ModelRouterConfigureClientBalanceResponse> ModelRouterConfigureClientBalanceWithOptionsAsync(string id, ModelRouterConfigureClientBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBalance))
            {
                body["enableBalance"] = request.EnableBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialBalance))
            {
                body["initialBalance"] = request.InitialBalance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterConfigureClientBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterConfigureClientBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables balance-based throttling for a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureClientBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureClientBalanceResponse
        /// </returns>
        public ModelRouterConfigureClientBalanceResponse ModelRouterConfigureClientBalance(string id, ModelRouterConfigureClientBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterConfigureClientBalanceWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables balance-based throttling for a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureClientBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureClientBalanceResponse
        /// </returns>
        public async Task<ModelRouterConfigureClientBalanceResponse> ModelRouterConfigureClientBalanceAsync(string id, ModelRouterConfigureClientBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterConfigureClientBalanceWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureMemberBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureMemberBalanceResponse
        /// </returns>
        public ModelRouterConfigureMemberBalanceResponse ModelRouterConfigureMemberBalanceWithOptions(string clientId, string id, ModelRouterConfigureMemberBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBalance))
            {
                body["enableBalance"] = request.EnableBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialBalance))
            {
                body["initialBalance"] = request.InitialBalance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterConfigureMemberBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterConfigureMemberBalanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureMemberBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureMemberBalanceResponse
        /// </returns>
        public async Task<ModelRouterConfigureMemberBalanceResponse> ModelRouterConfigureMemberBalanceWithOptionsAsync(string clientId, string id, ModelRouterConfigureMemberBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBalance))
            {
                body["enableBalance"] = request.EnableBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialBalance))
            {
                body["initialBalance"] = request.InitialBalance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterConfigureMemberBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterConfigureMemberBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureMemberBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureMemberBalanceResponse
        /// </returns>
        public ModelRouterConfigureMemberBalanceResponse ModelRouterConfigureMemberBalance(string clientId, string id, ModelRouterConfigureMemberBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterConfigureMemberBalanceWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterConfigureMemberBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterConfigureMemberBalanceResponse
        /// </returns>
        public async Task<ModelRouterConfigureMemberBalanceResponse> ModelRouterConfigureMemberBalanceAsync(string clientId, string id, ModelRouterConfigureMemberBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterConfigureMemberBalanceWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies an API key.</para>
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
        /// <para>Copies an API key.</para>
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
        /// <para>Copies an API key.</para>
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
        /// <para>Copies an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates a balance transaction for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBalanceTransactionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBalanceTransactionResponse
        /// </returns>
        public ModelRouterCreateBalanceTransactionResponse ModelRouterCreateBalanceTransactionWithOptions(string id, ModelRouterCreateBalanceTransactionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterCreateBalanceTransaction",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/transactions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateBalanceTransactionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance transaction for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBalanceTransactionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBalanceTransactionResponse
        /// </returns>
        public async Task<ModelRouterCreateBalanceTransactionResponse> ModelRouterCreateBalanceTransactionWithOptionsAsync(string id, ModelRouterCreateBalanceTransactionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterCreateBalanceTransaction",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/transactions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateBalanceTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance transaction for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBalanceTransactionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBalanceTransactionResponse
        /// </returns>
        public ModelRouterCreateBalanceTransactionResponse ModelRouterCreateBalanceTransaction(string id, ModelRouterCreateBalanceTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateBalanceTransactionWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance transaction for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBalanceTransactionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBalanceTransactionResponse
        /// </returns>
        public async Task<ModelRouterCreateBalanceTransactionResponse> ModelRouterCreateBalanceTransactionAsync(string id, ModelRouterCreateBalanceTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateBalanceTransactionWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a billing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBillingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBillingRuleResponse
        /// </returns>
        public ModelRouterCreateBillingRuleResponse ModelRouterCreateBillingRuleWithOptions(ModelRouterCreateBillingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                body["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingConfig))
            {
                body["pricingConfig"] = request.PricingConfig;
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
                Action = "ModelRouterCreateBillingRule",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateBillingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a billing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBillingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBillingRuleResponse
        /// </returns>
        public async Task<ModelRouterCreateBillingRuleResponse> ModelRouterCreateBillingRuleWithOptionsAsync(ModelRouterCreateBillingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                body["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingConfig))
            {
                body["pricingConfig"] = request.PricingConfig;
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
                Action = "ModelRouterCreateBillingRule",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateBillingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a billing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBillingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBillingRuleResponse
        /// </returns>
        public ModelRouterCreateBillingRuleResponse ModelRouterCreateBillingRule(ModelRouterCreateBillingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateBillingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a billing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateBillingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateBillingRuleResponse
        /// </returns>
        public async Task<ModelRouterCreateBillingRuleResponse> ModelRouterCreateBillingRuleAsync(ModelRouterCreateBillingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateBillingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a customer.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
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
        /// <para>Creates a customer.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
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
        /// <para>Creates a customer.</para>
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
        /// <para>Creates a customer.</para>
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
        /// <para>Creates a conversation.</para>
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
        /// <para>Creates a conversation.</para>
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
        /// <para>Creates a conversation.</para>
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
        /// <para>Creates a conversation.</para>
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
        /// <para>Creates an API key for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberApiKeyResponse
        /// </returns>
        public ModelRouterCreateMemberApiKeyResponse ModelRouterCreateMemberApiKeyWithOptions(string clientId, string id, ModelRouterCreateMemberApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateMemberApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API key for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberApiKeyResponse> ModelRouterCreateMemberApiKeyWithOptionsAsync(string clientId, string id, ModelRouterCreateMemberApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateMemberApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/apikeys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API key for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberApiKeyResponse
        /// </returns>
        public ModelRouterCreateMemberApiKeyResponse ModelRouterCreateMemberApiKey(string clientId, string id, ModelRouterCreateMemberApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateMemberApiKeyWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an API key for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberApiKeyResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberApiKeyResponse> ModelRouterCreateMemberApiKeyAsync(string clientId, string id, ModelRouterCreateMemberApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateMemberApiKeyWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a balance transaction on a member sub-wallet in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberBalanceTransactionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberBalanceTransactionResponse
        /// </returns>
        public ModelRouterCreateMemberBalanceTransactionResponse ModelRouterCreateMemberBalanceTransactionWithOptions(string clientId, string id, ModelRouterCreateMemberBalanceTransactionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterCreateMemberBalanceTransaction",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/transactions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberBalanceTransactionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a balance transaction on a member sub-wallet in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberBalanceTransactionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberBalanceTransactionResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberBalanceTransactionResponse> ModelRouterCreateMemberBalanceTransactionWithOptionsAsync(string clientId, string id, ModelRouterCreateMemberBalanceTransactionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
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
                Action = "ModelRouterCreateMemberBalanceTransaction",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/transactions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberBalanceTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a balance transaction on a member sub-wallet in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberBalanceTransactionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberBalanceTransactionResponse
        /// </returns>
        public ModelRouterCreateMemberBalanceTransactionResponse ModelRouterCreateMemberBalanceTransaction(string clientId, string id, ModelRouterCreateMemberBalanceTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateMemberBalanceTransactionWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a balance transaction on a member sub-wallet in organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberBalanceTransactionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberBalanceTransactionResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberBalanceTransactionResponse> ModelRouterCreateMemberBalanceTransactionAsync(string clientId, string id, ModelRouterCreateMemberBalanceTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateMemberBalanceTransactionWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance subscription for a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberSubscriptionResponse
        /// </returns>
        public ModelRouterCreateMemberSubscriptionResponse ModelRouterCreateMemberSubscriptionWithOptions(string clientId, string id, ModelRouterCreateMemberSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateMemberSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance subscription for a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberSubscriptionResponse> ModelRouterCreateMemberSubscriptionWithOptionsAsync(string clientId, string id, ModelRouterCreateMemberSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateMemberSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateMemberSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance subscription for a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberSubscriptionResponse
        /// </returns>
        public ModelRouterCreateMemberSubscriptionResponse ModelRouterCreateMemberSubscription(string clientId, string id, ModelRouterCreateMemberSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateMemberSubscriptionWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a balance subscription for a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateMemberSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateMemberSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterCreateMemberSubscriptionResponse> ModelRouterCreateMemberSubscriptionAsync(string clientId, string id, ModelRouterCreateMemberSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateMemberSubscriptionWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs model creation.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extensions))
            {
                body["extensions"] = request.Extensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InOut))
            {
                body["inOut"] = request.InOut;
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
        /// <para>Performs model creation.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extensions))
            {
                body["extensions"] = request.Extensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InOut))
            {
                body["inOut"] = request.InOut;
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
        /// <para>Performs model creation.</para>
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
        /// <para>Performs model creation.</para>
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
        /// <para>Creates a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a manual model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelGroupResponse
        /// </returns>
        public ModelRouterCreateModelGroupResponse ModelRouterCreateModelGroupWithOptions(ModelRouterCreateModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelList))
            {
                body["modelList"] = request.ModelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateModelGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a manual model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelGroupResponse
        /// </returns>
        public async Task<ModelRouterCreateModelGroupResponse> ModelRouterCreateModelGroupWithOptionsAsync(ModelRouterCreateModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelList))
            {
                body["modelList"] = request.ModelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateModelGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a manual model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelGroupResponse
        /// </returns>
        public ModelRouterCreateModelGroupResponse ModelRouterCreateModelGroup(ModelRouterCreateModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateModelGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a manual model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateModelGroupResponse
        /// </returns>
        public async Task<ModelRouterCreateModelGroupResponse> ModelRouterCreateModelGroupAsync(ModelRouterCreateModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateModelGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateSubscriptionResponse
        /// </returns>
        public ModelRouterCreateSubscriptionResponse ModelRouterCreateSubscriptionWithOptions(string id, ModelRouterCreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionAmount))
            {
                body["subscriptionAmount"] = request.SubscriptionAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterCreateSubscriptionResponse> ModelRouterCreateSubscriptionWithOptionsAsync(string id, ModelRouterCreateSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionAmount))
            {
                body["subscriptionAmount"] = request.SubscriptionAmount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateSubscriptionResponse
        /// </returns>
        public ModelRouterCreateSubscriptionResponse ModelRouterCreateSubscription(string id, ModelRouterCreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateSubscriptionWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterCreateSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterCreateSubscriptionResponse> ModelRouterCreateSubscriptionAsync(string id, ModelRouterCreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateSubscriptionWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateUserResponse
        /// </returns>
        public ModelRouterCreateUserResponse ModelRouterCreateUserWithOptions(ModelRouterCreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentRoles))
            {
                body["departmentRoles"] = request.DepartmentRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginName))
            {
                body["loginName"] = request.LoginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateUserResponse
        /// </returns>
        public async Task<ModelRouterCreateUserResponse> ModelRouterCreateUserWithOptionsAsync(ModelRouterCreateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentRoles))
            {
                body["departmentRoles"] = request.DepartmentRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginName))
            {
                body["loginName"] = request.LoginName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterCreateUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterCreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateUserResponse
        /// </returns>
        public ModelRouterCreateUserResponse ModelRouterCreateUser(ModelRouterCreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterCreateUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterCreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterCreateUserResponse
        /// </returns>
        public async Task<ModelRouterCreateUserResponse> ModelRouterCreateUserAsync(ModelRouterCreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterCreateUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes a customer.</para>
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
        /// <para>Deletes a customer.</para>
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
        /// <para>Deletes a customer.</para>
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
        /// <para>Deletes a customer.</para>
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
        /// <para>Deletes a conversation.</para>
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
        /// <para>Deletes a conversation.</para>
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
        /// <para>Deletes a conversation.</para>
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
        /// <para>Deletes a conversation.</para>
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
        /// <para>Deletes a model.</para>
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
        /// <para>Deletes a model.</para>
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
        /// <para>Deletes a model.</para>
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
        /// <para>Deletes a model.</para>
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
        /// <para>Deletes a manual group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelGroupResponse
        /// </returns>
        public ModelRouterDeleteModelGroupResponse ModelRouterDeleteModelGroupWithOptions(string groupId, ModelRouterDeleteModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteModelGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a manual group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelGroupResponse
        /// </returns>
        public async Task<ModelRouterDeleteModelGroupResponse> ModelRouterDeleteModelGroupWithOptionsAsync(string groupId, ModelRouterDeleteModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteModelGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a manual group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelGroupResponse
        /// </returns>
        public ModelRouterDeleteModelGroupResponse ModelRouterDeleteModelGroup(string groupId, ModelRouterDeleteModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteModelGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a manual group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteModelGroupResponse
        /// </returns>
        public async Task<ModelRouterDeleteModelGroupResponse> ModelRouterDeleteModelGroupAsync(string groupId, ModelRouterDeleteModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteModelGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteUserResponse
        /// </returns>
        public ModelRouterDeleteUserResponse ModelRouterDeleteUserWithOptions(string id, ModelRouterDeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteUserResponse
        /// </returns>
        public async Task<ModelRouterDeleteUserResponse> ModelRouterDeleteUserWithOptionsAsync(string id, ModelRouterDeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterDeleteUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterDeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteUserResponse
        /// </returns>
        public ModelRouterDeleteUserResponse ModelRouterDeleteUser(string id, ModelRouterDeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterDeleteUserWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterDeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterDeleteUserResponse
        /// </returns>
        public async Task<ModelRouterDeleteUserResponse> ModelRouterDeleteUserAsync(string id, ModelRouterDeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterDeleteUserWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterExportMemberBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterExportMemberBalanceOrdersResponse
        /// </returns>
        public ModelRouterExportMemberBalanceOrdersResponse ModelRouterExportMemberBalanceOrdersWithOptions(string clientId, string id, ModelRouterExportMemberBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterExportMemberBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterExportMemberBalanceOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterExportMemberBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterExportMemberBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterExportMemberBalanceOrdersResponse> ModelRouterExportMemberBalanceOrdersWithOptionsAsync(string clientId, string id, ModelRouterExportMemberBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterExportMemberBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterExportMemberBalanceOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterExportMemberBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterExportMemberBalanceOrdersResponse
        /// </returns>
        public ModelRouterExportMemberBalanceOrdersResponse ModelRouterExportMemberBalanceOrders(string clientId, string id, ModelRouterExportMemberBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterExportMemberBalanceOrdersWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterExportMemberBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterExportMemberBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterExportMemberBalanceOrdersResponse> ModelRouterExportMemberBalanceOrdersAsync(string clientId, string id, ModelRouterExportMemberBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterExportMemberBalanceOrdersWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Client Management/Get department balance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceResponse
        /// </returns>
        public ModelRouterGetClientBalanceResponse ModelRouterGetClientBalanceWithOptions(string id, ModelRouterGetClientBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetClientBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetClientBalanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Client Management/Get department balance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceResponse
        /// </returns>
        public async Task<ModelRouterGetClientBalanceResponse> ModelRouterGetClientBalanceWithOptionsAsync(string id, ModelRouterGetClientBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetClientBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetClientBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Client Management/Get department balance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceResponse
        /// </returns>
        public ModelRouterGetClientBalanceResponse ModelRouterGetClientBalance(string id, ModelRouterGetClientBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetClientBalanceWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Client Management/Get department balance</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceResponse
        /// </returns>
        public async Task<ModelRouterGetClientBalanceResponse> ModelRouterGetClientBalanceAsync(string id, ModelRouterGetClientBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetClientBalanceWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceLogsResponse
        /// </returns>
        public ModelRouterGetClientBalanceLogsResponse ModelRouterGetClientBalanceLogsWithOptions(string id, ModelRouterGetClientBalanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["changeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetClientBalanceLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetClientBalanceLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceLogsResponse
        /// </returns>
        public async Task<ModelRouterGetClientBalanceLogsResponse> ModelRouterGetClientBalanceLogsWithOptionsAsync(string id, ModelRouterGetClientBalanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["changeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetClientBalanceLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetClientBalanceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceLogsResponse
        /// </returns>
        public ModelRouterGetClientBalanceLogsResponse ModelRouterGetClientBalanceLogs(string id, ModelRouterGetClientBalanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetClientBalanceLogsWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetClientBalanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetClientBalanceLogsResponse
        /// </returns>
        public async Task<ModelRouterGetClientBalanceLogsResponse> ModelRouterGetClientBalanceLogsAsync(string id, ModelRouterGetClientBalanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetClientBalanceLogsWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance overview of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetDeptBalanceSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetDeptBalanceSummaryResponse
        /// </returns>
        public ModelRouterGetDeptBalanceSummaryResponse ModelRouterGetDeptBalanceSummaryWithOptions(string id, ModelRouterGetDeptBalanceSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetDeptBalanceSummary",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetDeptBalanceSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance overview of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetDeptBalanceSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetDeptBalanceSummaryResponse
        /// </returns>
        public async Task<ModelRouterGetDeptBalanceSummaryResponse> ModelRouterGetDeptBalanceSummaryWithOptionsAsync(string id, ModelRouterGetDeptBalanceSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetDeptBalanceSummary",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetDeptBalanceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance overview of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetDeptBalanceSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetDeptBalanceSummaryResponse
        /// </returns>
        public ModelRouterGetDeptBalanceSummaryResponse ModelRouterGetDeptBalanceSummary(string id, ModelRouterGetDeptBalanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetDeptBalanceSummaryWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance overview of a department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetDeptBalanceSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetDeptBalanceSummaryResponse
        /// </returns>
        public async Task<ModelRouterGetDeptBalanceSummaryResponse> ModelRouterGetDeptBalanceSummaryAsync(string id, ModelRouterGetDeptBalanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetDeptBalanceSummaryWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of API keys for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberApiKeysResponse
        /// </returns>
        public ModelRouterGetMemberApiKeysResponse ModelRouterGetMemberApiKeysWithOptions(string clientId, string id, ModelRouterGetMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "ModelRouterGetMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of API keys for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberApiKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterGetMemberApiKeysResponse> ModelRouterGetMemberApiKeysWithOptionsAsync(string clientId, string id, ModelRouterGetMemberApiKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "ModelRouterGetMemberApiKeys",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/apikeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of API keys for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberApiKeysResponse
        /// </returns>
        public ModelRouterGetMemberApiKeysResponse ModelRouterGetMemberApiKeys(string clientId, string id, ModelRouterGetMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetMemberApiKeysWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of API keys for a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberApiKeysResponse
        /// </returns>
        public async Task<ModelRouterGetMemberApiKeysResponse> ModelRouterGetMemberApiKeysAsync(string clientId, string id, ModelRouterGetMemberApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetMemberApiKeysWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceResponse
        /// </returns>
        public ModelRouterGetMemberBalanceResponse ModelRouterGetMemberBalanceWithOptions(string clientId, string id, ModelRouterGetMemberBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetMemberBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberBalanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceResponse
        /// </returns>
        public async Task<ModelRouterGetMemberBalanceResponse> ModelRouterGetMemberBalanceWithOptionsAsync(string clientId, string id, ModelRouterGetMemberBalanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetMemberBalance",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberBalanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceResponse
        /// </returns>
        public ModelRouterGetMemberBalanceResponse ModelRouterGetMemberBalance(string clientId, string id, ModelRouterGetMemberBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetMemberBalanceWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the sub-wallet balance of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceResponse
        /// </returns>
        public async Task<ModelRouterGetMemberBalanceResponse> ModelRouterGetMemberBalanceAsync(string clientId, string id, ModelRouterGetMemberBalanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetMemberBalanceWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceLogsResponse
        /// </returns>
        public ModelRouterGetMemberBalanceLogsResponse ModelRouterGetMemberBalanceLogsWithOptions(string clientId, string id, ModelRouterGetMemberBalanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["changeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipTotal))
            {
                query["skipTotal"] = request.SkipTotal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetMemberBalanceLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberBalanceLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceLogsResponse
        /// </returns>
        public async Task<ModelRouterGetMemberBalanceLogsResponse> ModelRouterGetMemberBalanceLogsWithOptionsAsync(string clientId, string id, ModelRouterGetMemberBalanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeType))
            {
                query["changeType"] = request.ChangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipTotal))
            {
                query["skipTotal"] = request.SkipTotal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetMemberBalanceLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetMemberBalanceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceLogsResponse
        /// </returns>
        public ModelRouterGetMemberBalanceLogsResponse ModelRouterGetMemberBalanceLogs(string clientId, string id, ModelRouterGetMemberBalanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetMemberBalanceLogsWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change logs of a member in an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterGetMemberBalanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetMemberBalanceLogsResponse
        /// </returns>
        public async Task<ModelRouterGetMemberBalanceLogsResponse> ModelRouterGetMemberBalanceLogsAsync(string clientId, string id, ModelRouterGetMemberBalanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetMemberBalanceLogsWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-department role assignments of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the role assignments of a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterGetUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetUserRolesResponse
        /// </returns>
        public ModelRouterGetUserRolesResponse ModelRouterGetUserRolesWithOptions(string id, ModelRouterGetUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetUserRoles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-department role assignments of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the role assignments of a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterGetUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetUserRolesResponse
        /// </returns>
        public async Task<ModelRouterGetUserRolesResponse> ModelRouterGetUserRolesWithOptionsAsync(string id, ModelRouterGetUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterGetUserRoles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterGetUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-department role assignments of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the role assignments of a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterGetUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetUserRolesResponse
        /// </returns>
        public ModelRouterGetUserRolesResponse ModelRouterGetUserRoles(string id, ModelRouterGetUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterGetUserRolesWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-department role assignments of a user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the role assignments of a user.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterGetUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterGetUserRolesResponse
        /// </returns>
        public async Task<ModelRouterGetUserRolesResponse> ModelRouterGetUserRolesAsync(string id, ModelRouterGetUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterGetUserRolesWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries balance change records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListBalanceOrdersResponse
        /// </returns>
        public ModelRouterListBalanceOrdersResponse ModelRouterListBalanceOrdersWithOptions(string id, ModelRouterListBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
                Action = "ModelRouterListBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListBalanceOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries balance change records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterListBalanceOrdersResponse> ModelRouterListBalanceOrdersWithOptionsAsync(string id, ModelRouterListBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
                Action = "ModelRouterListBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListBalanceOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries balance change records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListBalanceOrdersResponse
        /// </returns>
        public ModelRouterListBalanceOrdersResponse ModelRouterListBalanceOrders(string id, ModelRouterListBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterListBalanceOrdersWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries balance change records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterListBalanceOrdersResponse> ModelRouterListBalanceOrdersAsync(string id, ModelRouterListBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterListBalanceOrdersWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of members in a specified department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListDeptMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListDeptMembersResponse
        /// </returns>
        public ModelRouterListDeptMembersResponse ModelRouterListDeptMembersWithOptions(string id, ModelRouterListDeptMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAuthorization))
            {
                query["includeAuthorization"] = request.IncludeAuthorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeBalance))
            {
                query["includeBalance"] = request.IncludeBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["model"] = request.Model;
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
                Action = "ModelRouterListDeptMembers",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListDeptMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of members in a specified department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListDeptMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListDeptMembersResponse
        /// </returns>
        public async Task<ModelRouterListDeptMembersResponse> ModelRouterListDeptMembersWithOptionsAsync(string id, ModelRouterListDeptMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthConfig))
            {
                query["authConfig"] = request.AuthConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeAuthorization))
            {
                query["includeAuthorization"] = request.IncludeAuthorization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeBalance))
            {
                query["includeBalance"] = request.IncludeBalance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["model"] = request.Model;
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
                Action = "ModelRouterListDeptMembers",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListDeptMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of members in a specified department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListDeptMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListDeptMembersResponse
        /// </returns>
        public ModelRouterListDeptMembersResponse ModelRouterListDeptMembers(string id, ModelRouterListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterListDeptMembersWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of members in a specified department.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListDeptMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListDeptMembersResponse
        /// </returns>
        public async Task<ModelRouterListDeptMembersResponse> ModelRouterListDeptMembersAsync(string id, ModelRouterListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterListDeptMembersWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberBalanceOrdersResponse
        /// </returns>
        public ModelRouterListMemberBalanceOrdersResponse ModelRouterListMemberBalanceOrdersWithOptions(string clientId, string id, ModelRouterListMemberBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
                Action = "ModelRouterListMemberBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListMemberBalanceOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberBalanceOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterListMemberBalanceOrdersResponse> ModelRouterListMemberBalanceOrdersWithOptionsAsync(string clientId, string id, ModelRouterListMemberBalanceOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
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
                Action = "ModelRouterListMemberBalanceOrders",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListMemberBalanceOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberBalanceOrdersResponse
        /// </returns>
        public ModelRouterListMemberBalanceOrdersResponse ModelRouterListMemberBalanceOrders(string clientId, string id, ModelRouterListMemberBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterListMemberBalanceOrdersWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the balance change records of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberBalanceOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberBalanceOrdersResponse
        /// </returns>
        public async Task<ModelRouterListMemberBalanceOrdersResponse> ModelRouterListMemberBalanceOrdersAsync(string clientId, string id, ModelRouterListMemberBalanceOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterListMemberBalanceOrdersWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription list of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberSubscriptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberSubscriptionsResponse
        /// </returns>
        public ModelRouterListMemberSubscriptionsResponse ModelRouterListMemberSubscriptionsWithOptions(string clientId, string id, ModelRouterListMemberSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterListMemberSubscriptions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListMemberSubscriptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription list of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberSubscriptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberSubscriptionsResponse
        /// </returns>
        public async Task<ModelRouterListMemberSubscriptionsResponse> ModelRouterListMemberSubscriptionsWithOptionsAsync(string clientId, string id, ModelRouterListMemberSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterListMemberSubscriptions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListMemberSubscriptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription list of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberSubscriptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberSubscriptionsResponse
        /// </returns>
        public ModelRouterListMemberSubscriptionsResponse ModelRouterListMemberSubscriptions(string clientId, string id, ModelRouterListMemberSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterListMemberSubscriptionsWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the subscription list of a member in the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterListMemberSubscriptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListMemberSubscriptionsResponse
        /// </returns>
        public async Task<ModelRouterListMemberSubscriptionsResponse> ModelRouterListMemberSubscriptionsAsync(string clientId, string id, ModelRouterListMemberSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterListMemberSubscriptionsWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of periodic recharge subscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListSubscriptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListSubscriptionsResponse
        /// </returns>
        public ModelRouterListSubscriptionsResponse ModelRouterListSubscriptionsWithOptions(string id, ModelRouterListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ModelRouterListSubscriptions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListSubscriptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of periodic recharge subscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListSubscriptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListSubscriptionsResponse
        /// </returns>
        public async Task<ModelRouterListSubscriptionsResponse> ModelRouterListSubscriptionsWithOptionsAsync(string id, ModelRouterListSubscriptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                query["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ModelRouterListSubscriptions",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterListSubscriptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of periodic recharge subscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListSubscriptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListSubscriptionsResponse
        /// </returns>
        public ModelRouterListSubscriptionsResponse ModelRouterListSubscriptions(string id, ModelRouterListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterListSubscriptionsWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of periodic recharge subscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is deprecated. Do not use it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterListSubscriptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterListSubscriptionsResponse
        /// </returns>
        public async Task<ModelRouterListSubscriptionsResponse> ModelRouterListSubscriptionsAsync(string id, ModelRouterListSubscriptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterListSubscriptionsWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an API key.</para>
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
        /// <para>Retrieves the details of an API key.</para>
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
        /// <para>Retrieves the details of an API key.</para>
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
        /// <para>Retrieves the details of an API key.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMemberKeys))
            {
                query["includeMemberKeys"] = request.IncludeMemberKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves a list of API keys.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMemberKeys))
            {
                query["includeMemberKeys"] = request.IncludeMemberKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Queries billing details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingCostBreakdownRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingCostBreakdownResponse
        /// </returns>
        public ModelRouterQueryBillingCostBreakdownResponse ModelRouterQueryBillingCostBreakdownWithOptions(ModelRouterQueryBillingCostBreakdownRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryBillingCostBreakdown",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/breakdown",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryBillingCostBreakdownResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries billing details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingCostBreakdownRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingCostBreakdownResponse
        /// </returns>
        public async Task<ModelRouterQueryBillingCostBreakdownResponse> ModelRouterQueryBillingCostBreakdownWithOptionsAsync(ModelRouterQueryBillingCostBreakdownRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryBillingCostBreakdown",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/breakdown",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryBillingCostBreakdownResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries billing details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingCostBreakdownRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingCostBreakdownResponse
        /// </returns>
        public ModelRouterQueryBillingCostBreakdownResponse ModelRouterQueryBillingCostBreakdown(ModelRouterQueryBillingCostBreakdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryBillingCostBreakdownWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries billing details in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingCostBreakdownRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingCostBreakdownResponse
        /// </returns>
        public async Task<ModelRouterQueryBillingCostBreakdownResponse> ModelRouterQueryBillingCostBreakdownAsync(ModelRouterQueryBillingCostBreakdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryBillingCostBreakdownWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management / Query billing rule list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingRuleListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingRuleListResponse
        /// </returns>
        public ModelRouterQueryBillingRuleListResponse ModelRouterQueryBillingRuleListWithOptions(ModelRouterQueryBillingRuleListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveOnly))
            {
                query["activeOnly"] = request.ActiveOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                query["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "ModelRouterQueryBillingRuleList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryBillingRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management / Query billing rule list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingRuleListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingRuleListResponse
        /// </returns>
        public async Task<ModelRouterQueryBillingRuleListResponse> ModelRouterQueryBillingRuleListWithOptionsAsync(ModelRouterQueryBillingRuleListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveOnly))
            {
                query["activeOnly"] = request.ActiveOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                query["modelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "ModelRouterQueryBillingRuleList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryBillingRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management / Query billing rule list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingRuleListResponse
        /// </returns>
        public ModelRouterQueryBillingRuleListResponse ModelRouterQueryBillingRuleList(ModelRouterQueryBillingRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryBillingRuleListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management / Query billing rule list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryBillingRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryBillingRuleListResponse
        /// </returns>
        public async Task<ModelRouterQueryBillingRuleListResponse> ModelRouterQueryBillingRuleListAsync(ModelRouterQueryBillingRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryBillingRuleListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the discount modification history for a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientDiscountLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientDiscountLogsResponse
        /// </returns>
        public ModelRouterQueryClientDiscountLogsResponse ModelRouterQueryClientDiscountLogsWithOptions(string id, ModelRouterQueryClientDiscountLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryClientDiscountLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/discount-logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientDiscountLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the discount modification history for a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientDiscountLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientDiscountLogsResponse
        /// </returns>
        public async Task<ModelRouterQueryClientDiscountLogsResponse> ModelRouterQueryClientDiscountLogsWithOptionsAsync(string id, ModelRouterQueryClientDiscountLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryClientDiscountLogs",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/discount-logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientDiscountLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the discount modification history for a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientDiscountLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientDiscountLogsResponse
        /// </returns>
        public ModelRouterQueryClientDiscountLogsResponse ModelRouterQueryClientDiscountLogs(string id, ModelRouterQueryClientDiscountLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryClientDiscountLogsWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the discount modification history for a client.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientDiscountLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientDiscountLogsResponse
        /// </returns>
        public async Task<ModelRouterQueryClientDiscountLogsResponse> ModelRouterQueryClientDiscountLogsAsync(string id, ModelRouterQueryClientDiscountLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryClientDiscountLogsWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of clients.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
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
        /// <para>Retrieves a list of clients.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
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
        /// <para>Retrieves a list of clients.</para>
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
        /// <para>Retrieves a list of clients.</para>
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
        /// <para>Retrieves the customer tree structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientTreeResponse
        /// </returns>
        public ModelRouterQueryClientTreeResponse ModelRouterQueryClientTreeWithOptions(ModelRouterQueryClientTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryClientTree",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the customer tree structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientTreeResponse
        /// </returns>
        public async Task<ModelRouterQueryClientTreeResponse> ModelRouterQueryClientTreeWithOptionsAsync(ModelRouterQueryClientTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryClientTree",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryClientTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the customer tree structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientTreeResponse
        /// </returns>
        public ModelRouterQueryClientTreeResponse ModelRouterQueryClientTree(ModelRouterQueryClientTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryClientTreeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the customer tree structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryClientTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryClientTreeResponse
        /// </returns>
        public async Task<ModelRouterQueryClientTreeResponse> ModelRouterQueryClientTreeAsync(ModelRouterQueryClientTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryClientTreeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a conversation.</para>
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
        /// <para>Retrieves the details of a conversation.</para>
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
        /// <para>Retrieves the details of a conversation.</para>
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
        /// <para>Retrieves the details of a conversation.</para>
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
        /// <para>Conversation management/Conversation list</para>
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
        /// <para>Conversation management/Conversation list</para>
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
        /// <para>Conversation management/Conversation list</para>
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
        /// <para>Conversation management/Conversation list</para>
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
        /// <para>Retrieves the usage details of a model for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelDetailResponse
        /// </returns>
        public ModelRouterQueryCostModelDetailResponse ModelRouterQueryCostModelDetailWithOptions(ModelRouterQueryCostModelDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostModelDetail",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/model-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostModelDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage details of a model for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelDetailResponse
        /// </returns>
        public async Task<ModelRouterQueryCostModelDetailResponse> ModelRouterQueryCostModelDetailWithOptionsAsync(ModelRouterQueryCostModelDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostModelDetail",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/model-detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostModelDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage details of a model for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelDetailResponse
        /// </returns>
        public ModelRouterQueryCostModelDetailResponse ModelRouterQueryCostModelDetail(ModelRouterQueryCostModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryCostModelDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the usage details of a model for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelDetailResponse
        /// </returns>
        public async Task<ModelRouterQueryCostModelDetailResponse> ModelRouterQueryCostModelDetailAsync(ModelRouterQueryCostModelDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryCostModelDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models called for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelListResponse
        /// </returns>
        public ModelRouterQueryCostModelListResponse ModelRouterQueryCostModelListWithOptions(ModelRouterQueryCostModelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostModelList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostModelListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models called for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelListResponse
        /// </returns>
        public async Task<ModelRouterQueryCostModelListResponse> ModelRouterQueryCostModelListWithOptionsAsync(ModelRouterQueryCostModelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostModelList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostModelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models called for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelListResponse
        /// </returns>
        public ModelRouterQueryCostModelListResponse ModelRouterQueryCostModelList(ModelRouterQueryCostModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryCostModelListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of models called for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostModelListResponse
        /// </returns>
        public async Task<ModelRouterQueryCostModelListResponse> ModelRouterQueryCostModelListAsync(ModelRouterQueryCostModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryCostModelListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves cost overview metrics for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostOverviewMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostOverviewMetricsResponse
        /// </returns>
        public ModelRouterQueryCostOverviewMetricsResponse ModelRouterQueryCostOverviewMetricsWithOptions(ModelRouterQueryCostOverviewMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostOverviewMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostOverviewMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves cost overview metrics for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostOverviewMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostOverviewMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryCostOverviewMetricsResponse> ModelRouterQueryCostOverviewMetricsWithOptionsAsync(ModelRouterQueryCostOverviewMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostOverviewMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/overview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostOverviewMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves cost overview metrics for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostOverviewMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostOverviewMetricsResponse
        /// </returns>
        public ModelRouterQueryCostOverviewMetricsResponse ModelRouterQueryCostOverviewMetrics(ModelRouterQueryCostOverviewMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryCostOverviewMetricsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves cost overview metrics for billing management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostOverviewMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostOverviewMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryCostOverviewMetricsResponse> ModelRouterQueryCostOverviewMetricsAsync(ModelRouterQueryCostOverviewMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryCostOverviewMetricsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves usage cost trends.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostTrendMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostTrendMetricsResponse
        /// </returns>
        public ModelRouterQueryCostTrendMetricsResponse ModelRouterQueryCostTrendMetricsWithOptions(ModelRouterQueryCostTrendMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostTrendMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/trend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostTrendMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves usage cost trends.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostTrendMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostTrendMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryCostTrendMetricsResponse> ModelRouterQueryCostTrendMetricsWithOptionsAsync(ModelRouterQueryCostTrendMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypes))
            {
                query["modelTypes"] = request.ModelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryCostTrendMetrics",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/cost/trend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryCostTrendMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves usage cost trends.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostTrendMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostTrendMetricsResponse
        /// </returns>
        public ModelRouterQueryCostTrendMetricsResponse ModelRouterQueryCostTrendMetrics(ModelRouterQueryCostTrendMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryCostTrendMetricsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves usage cost trends.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryCostTrendMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryCostTrendMetricsResponse
        /// </returns>
        public async Task<ModelRouterQueryCostTrendMetricsResponse> ModelRouterQueryCostTrendMetricsAsync(ModelRouterQueryCostTrendMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryCostTrendMetricsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specific model.</para>
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
        /// <para>Retrieves details for a specific model.</para>
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
        /// <para>Retrieves details for a specific model.</para>
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
        /// <para>Retrieves details for a specific model.</para>
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
        /// <para>Queries the details of a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupResponse
        /// </returns>
        public ModelRouterQueryModelGroupResponse ModelRouterQueryModelGroupWithOptions(string groupId, ModelRouterQueryModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupResponse> ModelRouterQueryModelGroupWithOptionsAsync(string groupId, ModelRouterQueryModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupResponse
        /// </returns>
        public ModelRouterQueryModelGroupResponse ModelRouterQueryModelGroup(string groupId, ModelRouterQueryModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a model group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupResponse> ModelRouterQueryModelGroupAsync(string groupId, ModelRouterQueryModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupClientsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupClientsResponse
        /// </returns>
        public ModelRouterQueryModelGroupClientsResponse ModelRouterQueryModelGroupClientsWithOptions(string groupId, ModelRouterQueryModelGroupClientsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModelRouterQueryModelGroupClients",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/clients",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupClientsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupClientsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupClientsResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupClientsResponse> ModelRouterQueryModelGroupClientsWithOptionsAsync(string groupId, ModelRouterQueryModelGroupClientsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModelRouterQueryModelGroupClients",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/clients",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupClientsResponse
        /// </returns>
        public ModelRouterQueryModelGroupClientsResponse ModelRouterQueryModelGroupClients(string groupId, ModelRouterQueryModelGroupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupClientsWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the departments bound to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupClientsResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupClientsResponse> ModelRouterQueryModelGroupClientsAsync(string groupId, ModelRouterQueryModelGroupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupClientsWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model groups by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of model groups by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupListResponse
        /// </returns>
        public ModelRouterQueryModelGroupListResponse ModelRouterQueryModelGroupListWithOptions(ModelRouterQueryModelGroupListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ModelRouterQueryModelGroupList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model groups by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of model groups by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupListResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupListResponse> ModelRouterQueryModelGroupListWithOptionsAsync(ModelRouterQueryModelGroupListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ModelRouterQueryModelGroupList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model groups by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of model groups by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupListResponse
        /// </returns>
        public ModelRouterQueryModelGroupListResponse ModelRouterQueryModelGroupList(ModelRouterQueryModelGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of model groups by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of model groups by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupListResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupListResponse> ModelRouterQueryModelGroupListAsync(ModelRouterQueryModelGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for models within a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries models within a group with pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupModelsResponse
        /// </returns>
        public ModelRouterQueryModelGroupModelsResponse ModelRouterQueryModelGroupModelsWithOptions(string groupId, ModelRouterQueryModelGroupModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ModelRouterQueryModelGroupModels",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for models within a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries models within a group with pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupModelsResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupModelsResponse> ModelRouterQueryModelGroupModelsWithOptionsAsync(string groupId, ModelRouterQueryModelGroupModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ModelRouterQueryModelGroupModels",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for models within a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries models within a group with pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupModelsResponse
        /// </returns>
        public ModelRouterQueryModelGroupModelsResponse ModelRouterQueryModelGroupModels(string groupId, ModelRouterQueryModelGroupModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupModelsWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for models within a model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries models within a group with pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupModelsResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupModelsResponse> ModelRouterQueryModelGroupModelsAsync(string groupId, ModelRouterQueryModelGroupModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupModelsWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupUsersResponse
        /// </returns>
        public ModelRouterQueryModelGroupUsersResponse ModelRouterQueryModelGroupUsersWithOptions(string groupId, ModelRouterQueryModelGroupUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModelRouterQueryModelGroupUsers",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupUsersResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupUsersResponse> ModelRouterQueryModelGroupUsersWithOptionsAsync(string groupId, ModelRouterQueryModelGroupUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModelRouterQueryModelGroupUsers",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupUsersResponse
        /// </returns>
        public ModelRouterQueryModelGroupUsersResponse ModelRouterQueryModelGroupUsers(string groupId, ModelRouterQueryModelGroupUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupUsersWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the users attached to a model group by paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupUsersResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupUsersResponse> ModelRouterQueryModelGroupUsersAsync(string groupId, ModelRouterQueryModelGroupUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupUsersWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupsByApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupsByApiKeyResponse
        /// </returns>
        public ModelRouterQueryModelGroupsByApiKeyResponse ModelRouterQueryModelGroupsByApiKeyWithOptions(string id, ModelRouterQueryModelGroupsByApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModelGroupsByApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/model-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupsByApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupsByApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupsByApiKeyResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupsByApiKeyResponse> ModelRouterQueryModelGroupsByApiKeyWithOptionsAsync(string id, ModelRouterQueryModelGroupsByApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryModelGroupsByApiKey",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/apikeys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/model-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryModelGroupsByApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupsByApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupsByApiKeyResponse
        /// </returns>
        public ModelRouterQueryModelGroupsByApiKeyResponse ModelRouterQueryModelGroupsByApiKey(string id, ModelRouterQueryModelGroupsByApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryModelGroupsByApiKeyWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the bound groups and models by API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryModelGroupsByApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryModelGroupsByApiKeyResponse
        /// </returns>
        public async Task<ModelRouterQueryModelGroupsByApiKeyResponse> ModelRouterQueryModelGroupsByApiKeyAsync(string id, ModelRouterQueryModelGroupsByApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryModelGroupsByApiKeyWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Model management/Get model list</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
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
        /// <para>Model management/Get model list</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
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
        /// <para>Model management/Get model list</para>
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
        /// <para>Model management/Get model list</para>
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
        /// <para>Queries the list of Nacos service providers through Nacos configuration.</para>
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
        /// <para>Queries the list of Nacos service providers through Nacos configuration.</para>
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
        /// <para>Queries the list of Nacos service providers through Nacos configuration.</para>
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
        /// <para>Queries the list of Nacos service providers through Nacos configuration.</para>
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
        /// <para>Retrieves a list of tags from Nacos.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
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
        /// <para>Retrieves a list of tags from Nacos.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
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
        /// <para>Retrieves a list of tags from Nacos.</para>
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
        /// <para>Retrieves a list of tags from Nacos.</para>
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
        /// <para>Retrieves observation chart data for model monitoring.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves observation chart data for model monitoring.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves observation chart data for model monitoring.</para>
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
        /// <para>Retrieves observation chart data for model monitoring.</para>
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
        /// <para>Retrieves a list of model observation logs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves a list of model observation logs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves a list of model observation logs.</para>
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
        /// <para>Retrieves a list of model observation logs.</para>
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
        /// <para>Retrieves observability metric data for models.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves observability metric data for models.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
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
        /// <para>Retrieves observability metric data for models.</para>
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
        /// <para>Retrieves observability metric data for models.</para>
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
        /// <para>Queries usage details in batches for usage management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUsageBreakdownRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUsageBreakdownResponse
        /// </returns>
        public ModelRouterQueryUsageBreakdownResponse ModelRouterQueryUsageBreakdownWithOptions(ModelRouterQueryUsageBreakdownRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryUsageBreakdown",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/usage/breakdown",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryUsageBreakdownResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage details in batches for usage management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUsageBreakdownRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUsageBreakdownResponse
        /// </returns>
        public async Task<ModelRouterQueryUsageBreakdownResponse> ModelRouterQueryUsageBreakdownWithOptionsAsync(ModelRouterQueryUsageBreakdownRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserIds))
            {
                query["memberUserIds"] = request.MemberUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryUsageBreakdown",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/usage/breakdown",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryUsageBreakdownResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage details in batches for usage management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUsageBreakdownRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUsageBreakdownResponse
        /// </returns>
        public ModelRouterQueryUsageBreakdownResponse ModelRouterQueryUsageBreakdown(ModelRouterQueryUsageBreakdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryUsageBreakdownWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries usage details in batches for usage management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUsageBreakdownRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUsageBreakdownResponse
        /// </returns>
        public async Task<ModelRouterQueryUsageBreakdownResponse> ModelRouterQueryUsageBreakdownAsync(ModelRouterQueryUsageBreakdownRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryUsageBreakdownWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUserListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUserListResponse
        /// </returns>
        public ModelRouterQueryUserListResponse ModelRouterQueryUserListWithOptions(ModelRouterQueryUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryUserList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryUserListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUserListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUserListResponse
        /// </returns>
        public async Task<ModelRouterQueryUserListResponse> ModelRouterQueryUserListWithOptionsAsync(ModelRouterQueryUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["pageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterQueryUserList",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterQueryUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUserListResponse
        /// </returns>
        public ModelRouterQueryUserListResponse ModelRouterQueryUserList(ModelRouterQueryUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterQueryUserListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of users.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterQueryUserListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterQueryUserListResponse
        /// </returns>
        public async Task<ModelRouterQueryUserListResponse> ModelRouterQueryUserListAsync(ModelRouterQueryUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterQueryUserListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the authorization of a member to inherit from the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterResetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterResetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterResetMemberAuthorizationResponse ModelRouterResetMemberAuthorizationWithOptions(string clientId, string id, ModelRouterResetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterResetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/authorization",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterResetMemberAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the authorization of a member to inherit from the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterResetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterResetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterResetMemberAuthorizationResponse> ModelRouterResetMemberAuthorizationWithOptionsAsync(string clientId, string id, ModelRouterResetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterResetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/authorization",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterResetMemberAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the authorization of a member to inherit from the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterResetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterResetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterResetMemberAuthorizationResponse ModelRouterResetMemberAuthorization(string clientId, string id, ModelRouterResetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterResetMemberAuthorizationWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the authorization of a member to inherit from the organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterResetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterResetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterResetMemberAuthorizationResponse> ModelRouterResetMemberAuthorizationAsync(string clientId, string id, ModelRouterResetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterResetMemberAuthorizationWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Flow control management / Save flow control configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSaveFlowConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSaveFlowConfigResponse
        /// </returns>
        public ModelRouterSaveFlowConfigResponse ModelRouterSaveFlowConfigWithOptions(ModelRouterSaveFlowConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rpm))
            {
                body["rpm"] = request.Rpm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmoothFlowEnabled))
            {
                body["smoothFlowEnabled"] = request.SmoothFlowEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tpm))
            {
                body["tpm"] = request.Tpm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSaveFlowConfig",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/flow-config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSaveFlowConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Flow control management / Save flow control configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSaveFlowConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSaveFlowConfigResponse
        /// </returns>
        public async Task<ModelRouterSaveFlowConfigResponse> ModelRouterSaveFlowConfigWithOptionsAsync(ModelRouterSaveFlowConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rpm))
            {
                body["rpm"] = request.Rpm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmoothFlowEnabled))
            {
                body["smoothFlowEnabled"] = request.SmoothFlowEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tpm))
            {
                body["tpm"] = request.Tpm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSaveFlowConfig",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/flow-config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSaveFlowConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Flow control management / Save flow control configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSaveFlowConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSaveFlowConfigResponse
        /// </returns>
        public ModelRouterSaveFlowConfigResponse ModelRouterSaveFlowConfig(ModelRouterSaveFlowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterSaveFlowConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Flow control management / Save flow control configuration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSaveFlowConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSaveFlowConfigResponse
        /// </returns>
        public async Task<ModelRouterSaveFlowConfigResponse> ModelRouterSaveFlowConfigAsync(ModelRouterSaveFlowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterSaveFlowConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches and locates nodes in the department tree for organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSearchClientTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSearchClientTreeResponse
        /// </returns>
        public ModelRouterSearchClientTreeResponse ModelRouterSearchClientTreeWithOptions(ModelRouterSearchClientTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSearchClientTree",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/tree/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSearchClientTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches and locates nodes in the department tree for organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSearchClientTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSearchClientTreeResponse
        /// </returns>
        public async Task<ModelRouterSearchClientTreeResponse> ModelRouterSearchClientTreeWithOptionsAsync(ModelRouterSearchClientTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSearchClientTree",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/tree/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSearchClientTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches and locates nodes in the department tree for organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSearchClientTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSearchClientTreeResponse
        /// </returns>
        public ModelRouterSearchClientTreeResponse ModelRouterSearchClientTree(ModelRouterSearchClientTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterSearchClientTreeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches and locates nodes in the department tree for organization management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSearchClientTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSearchClientTreeResponse
        /// </returns>
        public async Task<ModelRouterSearchClientTreeResponse> ModelRouterSearchClientTreeAsync(ModelRouterSearchClientTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterSearchClientTreeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the member authorization model for an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterSetMemberAuthorizationResponse ModelRouterSetMemberAuthorizationWithOptions(string clientId, string id, ModelRouterSetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/authorization",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSetMemberAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the member authorization model for an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSetMemberAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterSetMemberAuthorizationResponse> ModelRouterSetMemberAuthorizationWithOptionsAsync(string clientId, string id, ModelRouterSetMemberAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSetMemberAuthorization",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/authorization",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSetMemberAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the member authorization model for an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetMemberAuthorizationResponse
        /// </returns>
        public ModelRouterSetMemberAuthorizationResponse ModelRouterSetMemberAuthorization(string clientId, string id, ModelRouterSetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterSetMemberAuthorizationWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the member authorization model for an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterSetMemberAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetMemberAuthorizationResponse
        /// </returns>
        public async Task<ModelRouterSetMemberAuthorizationResponse> ModelRouterSetMemberAuthorizationAsync(string clientId, string id, ModelRouterSetMemberAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterSetMemberAuthorizationWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterSetUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetUserRolesResponse
        /// </returns>
        public ModelRouterSetUserRolesResponse ModelRouterSetUserRolesWithOptions(string id, ModelRouterSetUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentRoles))
            {
                body["departmentRoles"] = request.DepartmentRoles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSetUserRoles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSetUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterSetUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetUserRolesResponse
        /// </returns>
        public async Task<ModelRouterSetUserRolesResponse> ModelRouterSetUserRolesWithOptionsAsync(string id, ModelRouterSetUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentRoles))
            {
                body["departmentRoles"] = request.DepartmentRoles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterSetUserRoles",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterSetUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterSetUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetUserRolesResponse
        /// </returns>
        public ModelRouterSetUserRolesResponse ModelRouterSetUserRoles(string id, ModelRouterSetUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterSetUserRolesWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets user roles or changes the department to which a user belongs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterSetUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterSetUserRolesResponse
        /// </returns>
        public async Task<ModelRouterSetUserRolesResponse> ModelRouterSetUserRolesAsync(string id, ModelRouterSetUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterSetUserRolesWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织管理/停止成员订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopMemberSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopMemberSubscriptionResponse
        /// </returns>
        public ModelRouterStopMemberSubscriptionResponse ModelRouterStopMemberSubscriptionWithOptions(string clientId, string id, ModelRouterStopMemberSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterStopMemberSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterStopMemberSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织管理/停止成员订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopMemberSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopMemberSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterStopMemberSubscriptionResponse> ModelRouterStopMemberSubscriptionWithOptionsAsync(string clientId, string id, ModelRouterStopMemberSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterStopMemberSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterStopMemberSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织管理/停止成员订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopMemberSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopMemberSubscriptionResponse
        /// </returns>
        public ModelRouterStopMemberSubscriptionResponse ModelRouterStopMemberSubscription(string clientId, string id, ModelRouterStopMemberSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterStopMemberSubscriptionWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>组织管理/停止成员订阅</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopMemberSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopMemberSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterStopMemberSubscriptionResponse> ModelRouterStopMemberSubscriptionAsync(string clientId, string id, ModelRouterStopMemberSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterStopMemberSubscriptionWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopSubscriptionResponse
        /// </returns>
        public ModelRouterStopSubscriptionResponse ModelRouterStopSubscriptionWithOptions(string id, ModelRouterStopSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterStopSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterStopSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopSubscriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterStopSubscriptionResponse> ModelRouterStopSubscriptionWithOptionsAsync(string id, ModelRouterStopSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterStopSubscription",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/balance/subscription/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterStopSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopSubscriptionResponse
        /// </returns>
        public ModelRouterStopSubscriptionResponse ModelRouterStopSubscription(string id, ModelRouterStopSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterStopSubscriptionWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a periodic recharge subscription for customer management.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterStopSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterStopSubscriptionResponse
        /// </returns>
        public async Task<ModelRouterStopSubscriptionResponse> ModelRouterStopSubscriptionAsync(string id, ModelRouterStopSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterStopSubscriptionWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers funds from a department to a member within an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterTransferToMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterTransferToMemberResponse
        /// </returns>
        public ModelRouterTransferToMemberResponse ModelRouterTransferToMemberWithOptions(string clientId, string id, ModelRouterTransferToMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthlyQuota))
            {
                body["monthlyQuota"] = request.MonthlyQuota;
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
                Action = "ModelRouterTransferToMember",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterTransferToMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers funds from a department to a member within an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterTransferToMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterTransferToMemberResponse
        /// </returns>
        public async Task<ModelRouterTransferToMemberResponse> ModelRouterTransferToMemberWithOptionsAsync(string clientId, string id, ModelRouterTransferToMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BalanceType))
            {
                body["balanceType"] = request.BalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotencyKey))
            {
                body["idempotencyKey"] = request.IdempotencyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthlyQuota))
            {
                body["monthlyQuota"] = request.MonthlyQuota;
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
                Action = "ModelRouterTransferToMember",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/clients/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clientId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id) + "/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterTransferToMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers funds from a department to a member within an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterTransferToMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterTransferToMemberResponse
        /// </returns>
        public ModelRouterTransferToMemberResponse ModelRouterTransferToMember(string clientId, string id, ModelRouterTransferToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterTransferToMemberWithOptions(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers funds from a department to a member within an organization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterTransferToMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterTransferToMemberResponse
        /// </returns>
        public async Task<ModelRouterTransferToMemberResponse> ModelRouterTransferToMemberAsync(string clientId, string id, ModelRouterTransferToMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterTransferToMemberWithOptionsAsync(clientId, id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management/Update billing rules</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateBillingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateBillingRuleResponse
        /// </returns>
        public ModelRouterUpdateBillingRuleResponse ModelRouterUpdateBillingRuleWithOptions(string id, ModelRouterUpdateBillingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                body["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingConfig))
            {
                body["pricingConfig"] = request.PricingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "ModelRouterUpdateBillingRule",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateBillingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management/Update billing rules</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateBillingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateBillingRuleResponse
        /// </returns>
        public async Task<ModelRouterUpdateBillingRuleResponse> ModelRouterUpdateBillingRuleWithOptionsAsync(string id, ModelRouterUpdateBillingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                body["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingConfig))
            {
                body["pricingConfig"] = request.PricingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "ModelRouterUpdateBillingRule",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/billing/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateBillingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management/Update billing rules</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateBillingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateBillingRuleResponse
        /// </returns>
        public ModelRouterUpdateBillingRuleResponse ModelRouterUpdateBillingRule(string id, ModelRouterUpdateBillingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateBillingRuleWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Billing management/Update billing rules</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateBillingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateBillingRuleResponse
        /// </returns>
        public async Task<ModelRouterUpdateBillingRuleResponse> ModelRouterUpdateBillingRuleAsync(string id, ModelRouterUpdateBillingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateBillingRuleWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates customer information.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
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
        /// <para>Updates customer information.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModelGroupConfig))
            {
                body["allowedModelGroupConfig"] = request.AllowedModelGroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedModels))
            {
                body["allowedModels"] = request.AllowedModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
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
        /// <para>Updates customer information.</para>
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
        /// <para>Updates customer information.</para>
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
        /// <para>Conversation management / Update conversation</para>
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
        /// <para>Conversation management / Update conversation</para>
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
        /// <para>Conversation management / Update conversation</para>
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
        /// <para>Conversation management / Update conversation</para>
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
        /// <para>Model Management / Update Model</para>
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
        /// <para>Model Management / Update Model</para>
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
        /// <para>Model Management / Update Model</para>
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
        /// <para>Model Management / Update Model</para>
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
        /// <para>Edits a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Edits a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelGroupResponse
        /// </returns>
        public ModelRouterUpdateModelGroupResponse ModelRouterUpdateModelGroupWithOptions(string groupId, ModelRouterUpdateModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelList))
            {
                body["modelList"] = request.ModelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateModelGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Edits a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelGroupResponse
        /// </returns>
        public async Task<ModelRouterUpdateModelGroupResponse> ModelRouterUpdateModelGroupWithOptionsAsync(string groupId, ModelRouterUpdateModelGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelList))
            {
                body["modelList"] = request.ModelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateModelGroup",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/model-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateModelGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Edits a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelGroupResponse
        /// </returns>
        public ModelRouterUpdateModelGroupResponse ModelRouterUpdateModelGroup(string groupId, ModelRouterUpdateModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateModelGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Edits a manual model group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Edits a manual group.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateModelGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateModelGroupResponse
        /// </returns>
        public async Task<ModelRouterUpdateModelGroupResponse> ModelRouterUpdateModelGroupAsync(string groupId, ModelRouterUpdateModelGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateModelGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates user information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates user information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateUserResponse
        /// </returns>
        public ModelRouterUpdateUserResponse ModelRouterUpdateUserWithOptions(string id, ModelRouterUpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates user information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates user information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateUserResponse
        /// </returns>
        public async Task<ModelRouterUpdateUserResponse> ModelRouterUpdateUserWithOptionsAsync(string id, ModelRouterUpdateUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModelRouterUpdateUser",
                Version = "20240611",
                Protocol = "HTTPS",
                Pathname = "/api/v1/modelRouter/open/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModelRouterUpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates user information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates user information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateUserResponse
        /// </returns>
        public ModelRouterUpdateUserResponse ModelRouterUpdateUser(string id, ModelRouterUpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModelRouterUpdateUserWithOptions(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates user information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates user information.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModelRouterUpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ModelRouterUpdateUserResponse
        /// </returns>
        public async Task<ModelRouterUpdateUserResponse> ModelRouterUpdateUserAsync(string id, ModelRouterUpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModelRouterUpdateUserWithOptionsAsync(id, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Personalized text-to-image: Create image inference tasks using a pre-trained model.</para>
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
        /// <para>Personalized text-to-image: Create image inference tasks using a pre-trained model.</para>
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
        /// <para>Personalized text-to-image: Create image inference tasks using a pre-trained model.</para>
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
        /// <para>Personalized text-to-image: Create image inference tasks using a pre-trained model.</para>
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
        /// <para>Retrieves the content of an image from the personalized text-to-image service using its unique image ID.</para>
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
        /// <para>Retrieves the content of an image from the personalized text-to-image service using its unique image ID.</para>
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
        /// <para>Retrieves the content of an image from the personalized text-to-image service using its unique image ID.</para>
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
        /// <para>Retrieves the content of an image from the personalized text-to-image service using its unique image ID.</para>
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
        /// <para>Queries the status of a personalized text-to-image inference job.</para>
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
        /// <para>Queries the status of a personalized text-to-image inference job.</para>
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
        /// <para>Queries the status of a personalized text-to-image inference job.</para>
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
        /// <para>Queries the status of a personalized text-to-image inference job.</para>
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
        /// <para>Creates an inference job to generate images based on a personalized text-to-image model.</para>
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
        /// <para>Creates an inference job to generate images based on a personalized text-to-image model.</para>
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
        /// <para>Creates an inference job to generate images based on a personalized text-to-image model.</para>
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
        /// <para>Creates an inference job to generate images based on a personalized text-to-image model.</para>
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
        /// <para>Personalized text-to-image: Create a model training task.</para>
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
        /// <para>Personalized text-to-image: Create a model training task.</para>
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
        /// <para>Personalized text-to-image: Create a model training task.</para>
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
        /// <para>Personalized text-to-image: Create a model training task.</para>
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
        /// <para>Retrieves the binary data of an image generated by the personalized text-to-image service.</para>
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
        /// <para>Retrieves the binary data of an image generated by the personalized text-to-image service.</para>
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
        /// <para>Retrieves the binary data of an image generated by the personalized text-to-image service.</para>
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
        /// <para>Retrieves the binary data of an image generated by the personalized text-to-image service.</para>
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
        /// <para>Retrieves the status and results of a Personalizedtxt2img inference job.</para>
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
        /// <para>Retrieves the status and results of a Personalizedtxt2img inference job.</para>
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
        /// <para>Retrieves the status and results of a Personalizedtxt2img inference job.</para>
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
        /// <para>Retrieves the status and results of a Personalizedtxt2img inference job.</para>
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
        /// <para>Your personalized model training tasks: image generation and query models.</para>
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
        /// <para>Your personalized model training tasks: image generation and query models.</para>
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
        /// <para>Your personalized model training tasks: image generation and query models.</para>
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
        /// <para>Your personalized model training tasks: image generation and query models.</para>
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
        /// <para>Queries the training status of a personalized text-to-image model.</para>
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
        /// <para>Queries the training status of a personalized text-to-image model.</para>
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
        /// <para>Queries the training status of a personalized text-to-image model.</para>
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
        /// <para>Queries the training status of a personalized text-to-image model.</para>
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
        /// <para>Queries information about an application access ID (appkey).</para>
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
        /// <para>Queries information about an application access ID (appkey).</para>
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
        /// <para>Queries information about an application access ID (appkey).</para>
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
        /// <para>Queries information about an application access ID (appkey).</para>
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
        /// <para>Alibaba Cloud console / Project list</para>
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
        /// <para>Alibaba Cloud console / Project list</para>
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
        /// <para>Alibaba Cloud console / Project list</para>
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
        /// <para>Alibaba Cloud console / Project list</para>
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
        /// <para>Alibaba Cloud console / Project List</para>
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
        /// <para>Alibaba Cloud console / Project List</para>
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
        /// <para>Alibaba Cloud console / Project List</para>
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
        /// <para>Alibaba Cloud console / Project List</para>
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
        /// <para>Alibaba Cloud Console / Purchased Services</para>
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
        /// <para>Alibaba Cloud Console / Purchased Services</para>
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
        /// <para>Alibaba Cloud Console / Purchased Services</para>
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
        /// <para>Alibaba Cloud Console / Purchased Services</para>
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
        /// <para>Alibaba Cloud Console / Update project information</para>
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
        /// <para>Alibaba Cloud Console / Update project information</para>
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
        /// <para>Alibaba Cloud Console / Update project information</para>
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
        /// <para>Alibaba Cloud Console / Update project information</para>
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
