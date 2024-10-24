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
        /// <para>评论生成服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public RunCommentGenerationResponse RunCommentGenerationWithOptions(string workspaceId, RunCommentGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumComments))
            {
                body["numComments"] = request.NumComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommentGeneration",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runCommentGeneration",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommentGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>评论生成服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public async Task<RunCommentGenerationResponse> RunCommentGenerationWithOptionsAsync(string workspaceId, RunCommentGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumComments))
            {
                body["numComments"] = request.NumComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Style))
            {
                body["style"] = request.Style;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommentGeneration",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runCommentGeneration",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommentGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>评论生成服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public RunCommentGenerationResponse RunCommentGeneration(string workspaceId, RunCommentGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunCommentGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>评论生成服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCommentGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommentGenerationResponse
        /// </returns>
        public async Task<RunCommentGenerationResponse> RunCommentGenerationAsync(string workspaceId, RunCommentGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunCommentGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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

    }
}
