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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AITeacherExpansionPracticeTaskGenerateResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AITeacherSyncPracticeTaskGenerateResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AliyunConsoleOpenApiQueryAliyunConsoleServiceListResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAccessWarrantResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAccessWarrantResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAccessWarrantResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAccessWarrantResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateProjectResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptions(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request, ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerParentId))
            {
                realHeaders["callerParentId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerParentId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerType))
            {
                realHeaders["callerType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerUid))
            {
                realHeaders["callerUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerUid);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StsTokenCallerUid))
            {
                realHeaders["stsTokenCallerUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StsTokenCallerUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(Execute(params_, req, runtime));
            }
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
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse
        /// </returns>
        public async Task<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse> ExecuteAITeacherChineseCompositionTutoringWorkflowRunWithOptionsAsync(ExecuteAITeacherChineseCompositionTutoringWorkflowRunRequest request, ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerParentId))
            {
                realHeaders["callerParentId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerParentId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerType))
            {
                realHeaders["callerType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CallerUid))
            {
                realHeaders["callerUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.CallerUid);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.StsTokenCallerUid))
            {
                realHeaders["stsTokenCallerUid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.StsTokenCallerUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherChineseCompositionTutoringWorkflowRunResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders headers = new ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders();
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
            ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders headers = new ExecuteAITeacherChineseCompositionTutoringWorkflowRunHeaders();
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishCompositionTutoringWorkflowRunResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherEnglishParaphraseChatMessageResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueRefineResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherExpansionDialogueTranslateResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherGrammarCheckResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteAITeacherSyncDialogueTranslateResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDialogueResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantDifficultyResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantGrammarCheckResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRefineByContextResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantRetryConversationResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantStartConversationResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantSuggestionResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteTextbookAssistantTranslateResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAITeacherExpansionDialogueSuggestionResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAITeacherSyncDialogueSuggestionResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTextbookAssistantTokenResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantArticlesResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantBookDirectoriesResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantBooksResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTextbookAssistantGradeVolumesResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageAddInferenceJobResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryImageAssetResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PersonalizedTextToImageQueryPreModelInferenceJobInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddInferenceJobResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgAddModelTrainJobResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryImageAssetResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryInferenceJobInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainJobListResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<Personalizedtxt2imgQueryModelTrainStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryApplicationAccessIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryApplicationAccessIdResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryApplicationAccessIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryApplicationAccessIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryProjectResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryProjectListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryProjectListResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryProjectListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryProjectListResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryPurchasedServiceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryPurchasedServiceResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<QueryPurchasedServiceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<QueryPurchasedServiceResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateProjectResponse>(Execute(params_, req, runtime));
            }
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
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
