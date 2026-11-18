// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IQS20241111.Models;

namespace AlibabaCloud.SDK.IQS20241111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "IQS";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iqs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Describes how to invoke the multi-stage streaming API V3 for general search by using the Alibaba Cloud OpenAPI SDK and provides parameter descriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides streaming results in two stages, common_search and post_retrieval, for customers to use on demand. General search results (common_search): the original search results. Covers key fields such as web page title, dynamic summary, body text, source website, and publish time. Post-retrieval processing (post_retrieval): reranks and filters the common_search results from the previous stage by using a rerank model. The mean average precision (mAP) metric for context relevancy of search results is improved by about 5%, and the latency is increased by about 110 ms.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AiSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiSearchResponse
        /// </returns>
        public AiSearchResponse AiSearchWithOptions(AiSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "AiSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v3/linkedRetrieval/commands/aiSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes how to invoke the multi-stage streaming API V3 for general search by using the Alibaba Cloud OpenAPI SDK and provides parameter descriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides streaming results in two stages, common_search and post_retrieval, for customers to use on demand. General search results (common_search): the original search results. Covers key fields such as web page title, dynamic summary, body text, source website, and publish time. Post-retrieval processing (post_retrieval): reranks and filters the common_search results from the previous stage by using a rerank model. The mean average precision (mAP) metric for context relevancy of search results is improved by about 5%, and the latency is increased by about 110 ms.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AiSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AiSearchResponse
        /// </returns>
        public async Task<AiSearchResponse> AiSearchWithOptionsAsync(AiSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "AiSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v3/linkedRetrieval/commands/aiSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AiSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes how to invoke the multi-stage streaming API V3 for general search by using the Alibaba Cloud OpenAPI SDK and provides parameter descriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides streaming results in two stages, common_search and post_retrieval, for customers to use on demand. General search results (common_search): the original search results. Covers key fields such as web page title, dynamic summary, body text, source website, and publish time. Post-retrieval processing (post_retrieval): reranks and filters the common_search results from the previous stage by using a rerank model. The mean average precision (mAP) metric for context relevancy of search results is improved by about 5%, and the latency is increased by about 110 ms.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AiSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// AiSearchResponse
        /// </returns>
        public AiSearchResponse AiSearch(AiSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AiSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes how to invoke the multi-stage streaming API V3 for general search by using the Alibaba Cloud OpenAPI SDK and provides parameter descriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provides streaming results in two stages, common_search and post_retrieval, for customers to use on demand. General search results (common_search): the original search results. Covers key fields such as web page title, dynamic summary, body text, source website, and publish time. Post-retrieval processing (post_retrieval): reranks and filters the common_search results from the previous stage by using a rerank model. The mean average precision (mAP) metric for context relevancy of search results is improved by about 5%, and the latency is increased by about 110 ms.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AiSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// AiSearchResponse
        /// </returns>
        public async Task<AiSearchResponse> AiSearchAsync(AiSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AiSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs general natural language queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The general API for natural language search.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public CommonQueryBySceneResponse CommonQueryBySceneWithOptions(CommonQueryBySceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonQueryByScene",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v2/nl/common",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonQueryBySceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs general natural language queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The general API for natural language search.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public async Task<CommonQueryBySceneResponse> CommonQueryBySceneWithOptionsAsync(CommonQueryBySceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommonQueryByScene",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/amap-function-call-agent/iqs-agent-service/v2/nl/common",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommonQueryBySceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs general natural language queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The general API for natural language search.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public CommonQueryBySceneResponse CommonQueryByScene(CommonQueryBySceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommonQueryBySceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs general natural language queries.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The general API for natural language search.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommonQueryBySceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CommonQueryBySceneResponse
        /// </returns>
        public async Task<CommonQueryBySceneResponse> CommonQueryBySceneAsync(CommonQueryBySceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommonQueryBySceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the GenericAdvancedSearch operation by using Alibaba Cloud OpenAPI SDKs and provides parameter descriptions. Compared with GenericSearch, GenericAdvancedSearch provides better recall from authoritative websites and returns up to 40 results, delivering more authoritative and diverse data. The response parameters and format of the enhanced operation are the same as those of GenericAdvancedSearch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GenericAdvancedSearch is currently in the testing phase. New specifications will be available for purchase in the future.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenericAdvancedSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenericAdvancedSearchResponse
        /// </returns>
        public GenericAdvancedSearchResponse GenericAdvancedSearchWithOptions(GenericAdvancedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GenericAdvancedSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v2/linkedRetrieval/commands/genericAdvancedSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenericAdvancedSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the GenericAdvancedSearch operation by using Alibaba Cloud OpenAPI SDKs and provides parameter descriptions. Compared with GenericSearch, GenericAdvancedSearch provides better recall from authoritative websites and returns up to 40 results, delivering more authoritative and diverse data. The response parameters and format of the enhanced operation are the same as those of GenericAdvancedSearch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GenericAdvancedSearch is currently in the testing phase. New specifications will be available for purchase in the future.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenericAdvancedSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenericAdvancedSearchResponse
        /// </returns>
        public async Task<GenericAdvancedSearchResponse> GenericAdvancedSearchWithOptionsAsync(GenericAdvancedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GenericAdvancedSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v2/linkedRetrieval/commands/genericAdvancedSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenericAdvancedSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the GenericAdvancedSearch operation by using Alibaba Cloud OpenAPI SDKs and provides parameter descriptions. Compared with GenericSearch, GenericAdvancedSearch provides better recall from authoritative websites and returns up to 40 results, delivering more authoritative and diverse data. The response parameters and format of the enhanced operation are the same as those of GenericAdvancedSearch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GenericAdvancedSearch is currently in the testing phase. New specifications will be available for purchase in the future.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenericAdvancedSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenericAdvancedSearchResponse
        /// </returns>
        public GenericAdvancedSearchResponse GenericAdvancedSearch(GenericAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenericAdvancedSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes how to call the GenericAdvancedSearch operation by using Alibaba Cloud OpenAPI SDKs and provides parameter descriptions. Compared with GenericSearch, GenericAdvancedSearch provides better recall from authoritative websites and returns up to 40 results, delivering more authoritative and diverse data. The response parameters and format of the enhanced operation are the same as those of GenericAdvancedSearch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GenericAdvancedSearch is currently in the testing phase. New specifications will be available for purchase in the future.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenericAdvancedSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenericAdvancedSearchResponse
        /// </returns>
        public async Task<GenericAdvancedSearchResponse> GenericAdvancedSearchAsync(GenericAdvancedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenericAdvancedSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a general search.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenericSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenericSearchResponse
        /// </returns>
        public GenericSearchResponse GenericSearchWithOptions(GenericSearchRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenericSearchShrinkRequest request = new GenericSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedParams))
            {
                request.AdvancedParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedParams, "advancedParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedParamsShrink))
            {
                query["advancedParams"] = request.AdvancedParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRerank))
            {
                query["enableRerank"] = request.EnableRerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnMainText))
            {
                query["returnMainText"] = request.ReturnMainText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnMarkdownText))
            {
                query["returnMarkdownText"] = request.ReturnMarkdownText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnRichMainBody))
            {
                query["returnRichMainBody"] = request.ReturnRichMainBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSummary))
            {
                query["returnSummary"] = request.ReturnSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GenericSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v2/linkedRetrieval/commands/genericSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenericSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a general search.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GenericSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenericSearchResponse
        /// </returns>
        public async Task<GenericSearchResponse> GenericSearchWithOptionsAsync(GenericSearchRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenericSearchShrinkRequest request = new GenericSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedParams))
            {
                request.AdvancedParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedParams, "advancedParams", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedParamsShrink))
            {
                query["advancedParams"] = request.AdvancedParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRerank))
            {
                query["enableRerank"] = request.EnableRerank;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Industry))
            {
                query["industry"] = request.Industry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnMainText))
            {
                query["returnMainText"] = request.ReturnMainText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnMarkdownText))
            {
                query["returnMarkdownText"] = request.ReturnMarkdownText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnRichMainBody))
            {
                query["returnRichMainBody"] = request.ReturnRichMainBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSummary))
            {
                query["returnSummary"] = request.ReturnSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["sessionId"] = request.SessionId;
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
                Action = "GenericSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v2/linkedRetrieval/commands/genericSearch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenericSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a general search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenericSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenericSearchResponse
        /// </returns>
        public GenericSearchResponse GenericSearch(GenericSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenericSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a general search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenericSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenericSearchResponse
        /// </returns>
        public async Task<GenericSearchResponse> GenericSearchAsync(GenericSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenericSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the daily usage of the information query service API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIqsUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIqsUsageResponse
        /// </returns>
        public GetIqsUsageResponse GetIqsUsageWithOptions(GetIqsUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerId))
            {
                query["callerId"] = request.CallerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIqsUsage",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-admin/v1/iqs/usage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIqsUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the daily usage of the information query service API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIqsUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIqsUsageResponse
        /// </returns>
        public async Task<GetIqsUsageResponse> GetIqsUsageWithOptionsAsync(GetIqsUsageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerId))
            {
                query["callerId"] = request.CallerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIqsUsage",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-admin/v1/iqs/usage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIqsUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the daily usage of the information query service API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIqsUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIqsUsageResponse
        /// </returns>
        public GetIqsUsageResponse GetIqsUsage(GetIqsUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIqsUsageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the daily usage of the information query service API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIqsUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIqsUsageResponse
        /// </returns>
        public async Task<GetIqsUsageResponse> GetIqsUsageAsync(GetIqsUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIqsUsageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for global information by using the Global Edition search.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use the Global Edition search (GlobalSearch) and provides parameter descriptions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GlobalSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalSearchResponse
        /// </returns>
        public GlobalSearchResponse GlobalSearchWithOptions(GlobalSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GlobalSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/search/global",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for global information by using the Global Edition search.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use the Global Edition search (GlobalSearch) and provides parameter descriptions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GlobalSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GlobalSearchResponse
        /// </returns>
        public async Task<GlobalSearchResponse> GlobalSearchWithOptionsAsync(GlobalSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GlobalSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/search/global",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GlobalSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for global information by using the Global Edition search.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use the Global Edition search (GlobalSearch) and provides parameter descriptions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GlobalSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalSearchResponse
        /// </returns>
        public GlobalSearchResponse GlobalSearch(GlobalSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GlobalSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for global information by using the Global Edition search.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic describes how to use the Global Edition search (GlobalSearch) and provides parameter descriptions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GlobalSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// GlobalSearchResponse
        /// </returns>
        public async Task<GlobalSearchResponse> GlobalSearchAsync(GlobalSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GlobalSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides medical Q&amp;A.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAnswerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalAnswerResponse
        /// </returns>
        public MedicalAnswerResponse MedicalAnswerWithOptions(MedicalAnswerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalAnswer",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/domain/medical/answer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalAnswerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides medical Q&amp;A.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAnswerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalAnswerResponse
        /// </returns>
        public async Task<MedicalAnswerResponse> MedicalAnswerWithOptionsAsync(MedicalAnswerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalAnswer",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/domain/medical/answer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalAnswerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides medical Q&amp;A.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAnswerRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalAnswerResponse
        /// </returns>
        public MedicalAnswerResponse MedicalAnswer(MedicalAnswerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MedicalAnswerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides medical Q&amp;A.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalAnswerRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalAnswerResponse
        /// </returns>
        public async Task<MedicalAnswerResponse> MedicalAnswerAsync(MedicalAnswerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MedicalAnswerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health graph.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalKnowledgeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalKnowledgeResponse
        /// </returns>
        public MedicalKnowledgeResponse MedicalKnowledgeWithOptions(MedicalKnowledgeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalKnowledge",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/domain/medical/know",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalKnowledgeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health graph.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalKnowledgeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MedicalKnowledgeResponse
        /// </returns>
        public async Task<MedicalKnowledgeResponse> MedicalKnowledgeWithOptionsAsync(MedicalKnowledgeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MedicalKnowledge",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/domain/medical/know",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MedicalKnowledgeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health graph.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalKnowledgeRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalKnowledgeResponse
        /// </returns>
        public MedicalKnowledgeResponse MedicalKnowledge(MedicalKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MedicalKnowledgeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the health graph.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MedicalKnowledgeRequest
        /// </param>
        /// 
        /// <returns>
        /// MedicalKnowledgeResponse
        /// </returns>
        public async Task<MedicalKnowledgeResponse> MedicalKnowledgeAsync(MedicalKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MedicalKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a multimodal search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultimodalSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultimodalSearchResponse
        /// </returns>
        public MultimodalSearchResponse MultimodalSearchWithOptions(MultimodalSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultimodalSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/multimodal/unified",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultimodalSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a multimodal search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultimodalSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultimodalSearchResponse
        /// </returns>
        public async Task<MultimodalSearchResponse> MultimodalSearchWithOptionsAsync(MultimodalSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultimodalSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/multimodal/unified",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultimodalSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a multimodal search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultimodalSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// MultimodalSearchResponse
        /// </returns>
        public MultimodalSearchResponse MultimodalSearch(MultimodalSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MultimodalSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a multimodal search.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultimodalSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// MultimodalSearchResponse
        /// </returns>
        public async Task<MultimodalSearchResponse> MultimodalSearchAsync(MultimodalSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MultimodalSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the SearchStream streaming API for intelligent search and AI chat. Based on retrieval augmented generation (RAG) and large language models, this API accepts natural language questions from users and can automatically execute intent recognition, query rewrite, and content generation, and retrieve data from multiple sources. The API uses the Server-Sent Events (SSE) streaming protocol to return data, supporting real-time output of the infer status, reference sources, and token-by-token generated answers. This API is suitable for AI chat and search scenarios that require low latency and high interpretability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OmniAnswerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OmniAnswerResponse
        /// </returns>
        public OmniAnswerResponse OmniAnswerWithOptions(OmniAnswerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OmniAnswer",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/answer/omni/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<OmniAnswerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the SearchStream streaming API for intelligent search and AI chat. Based on retrieval augmented generation (RAG) and large language models, this API accepts natural language questions from users and can automatically execute intent recognition, query rewrite, and content generation, and retrieve data from multiple sources. The API uses the Server-Sent Events (SSE) streaming protocol to return data, supporting real-time output of the infer status, reference sources, and token-by-token generated answers. This API is suitable for AI chat and search scenarios that require low latency and high interpretability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OmniAnswerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OmniAnswerResponse
        /// </returns>
        public async Task<OmniAnswerResponse> OmniAnswerWithOptionsAsync(OmniAnswerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OmniAnswer",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/answer/omni/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<OmniAnswerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the SearchStream streaming API for intelligent search and AI chat. Based on retrieval augmented generation (RAG) and large language models, this API accepts natural language questions from users and can automatically execute intent recognition, query rewrite, and content generation, and retrieve data from multiple sources. The API uses the Server-Sent Events (SSE) streaming protocol to return data, supporting real-time output of the infer status, reference sources, and token-by-token generated answers. This API is suitable for AI chat and search scenarios that require low latency and high interpretability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OmniAnswerRequest
        /// </param>
        /// 
        /// <returns>
        /// OmniAnswerResponse
        /// </returns>
        public OmniAnswerResponse OmniAnswer(OmniAnswerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OmniAnswerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This topic describes the SearchStream streaming API for intelligent search and AI chat. Based on retrieval augmented generation (RAG) and large language models, this API accepts natural language questions from users and can automatically execute intent recognition, query rewrite, and content generation, and retrieve data from multiple sources. The API uses the Server-Sent Events (SSE) streaming protocol to return data, supporting real-time output of the infer status, reference sources, and token-by-token generated answers. This API is suitable for AI chat and search scenarios that require low latency and high interpretability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OmniAnswerRequest
        /// </param>
        /// 
        /// <returns>
        /// OmniAnswerResponse
        /// </returns>
        public async Task<OmniAnswerResponse> OmniAnswerAsync(OmniAnswerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OmniAnswerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves HTML and parses static web page content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as valid when the HTTP response code of the destination URL is less than 500.</description></item>
        /// <item><description>If the content type in the response header of the destination URL is application/pdf, the system automatically triggers PDF parsing (the maximum PDF size is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial instructions: During the trial period, the API rate limit is 5 QPS, and the trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageBasicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadPageBasicResponse
        /// </returns>
        public ReadPageBasicResponse ReadPageBasicWithOptions(ReadPageBasicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadPageBasic",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/readpage/basic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadPageBasicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves HTML and parses static web page content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as valid when the HTTP response code of the destination URL is less than 500.</description></item>
        /// <item><description>If the content type in the response header of the destination URL is application/pdf, the system automatically triggers PDF parsing (the maximum PDF size is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial instructions: During the trial period, the API rate limit is 5 QPS, and the trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageBasicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadPageBasicResponse
        /// </returns>
        public async Task<ReadPageBasicResponse> ReadPageBasicWithOptionsAsync(ReadPageBasicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadPageBasic",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/readpage/basic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadPageBasicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves HTML and parses static web page content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as valid when the HTTP response code of the destination URL is less than 500.</description></item>
        /// <item><description>If the content type in the response header of the destination URL is application/pdf, the system automatically triggers PDF parsing (the maximum PDF size is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial instructions: During the trial period, the API rate limit is 5 QPS, and the trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageBasicRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadPageBasicResponse
        /// </returns>
        public ReadPageBasicResponse ReadPageBasic(ReadPageBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReadPageBasicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves HTML and parses static web page content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as valid when the HTTP response code of the destination URL is less than 500.</description></item>
        /// <item><description>If the content type in the response header of the destination URL is application/pdf, the system automatically triggers PDF parsing (the maximum PDF size is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial instructions: During the trial period, the API rate limit is 5 QPS, and the trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageBasicRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadPageBasicResponse
        /// </returns>
        public async Task<ReadPageBasicResponse> ReadPageBasicAsync(ReadPageBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReadPageBasicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reads HTML and parses web page content in a browser sandbox environment. The operation starts parsing after the resources on the target page are fully loaded. You can adjust the maximum wait time by using the pageTimeout parameter. The overall execution duration is significantly affected by the resource loading status of the target site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as a valid request when the HTTP status code of the target URL is less than 500.</description></item>
        /// <item><description>If the Content-Type in the response header of the target URL is application/pdf, the system automatically triggers PDF parsing (the maximum size of a PDF file that can be processed is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial description: During the trial period, the API operation is limited to 5 QPS. The trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageScrapeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadPageScrapeResponse
        /// </returns>
        public ReadPageScrapeResponse ReadPageScrapeWithOptions(ReadPageScrapeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadPageScrape",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/readpage/scrape",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadPageScrapeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reads HTML and parses web page content in a browser sandbox environment. The operation starts parsing after the resources on the target page are fully loaded. You can adjust the maximum wait time by using the pageTimeout parameter. The overall execution duration is significantly affected by the resource loading status of the target site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as a valid request when the HTTP status code of the target URL is less than 500.</description></item>
        /// <item><description>If the Content-Type in the response header of the target URL is application/pdf, the system automatically triggers PDF parsing (the maximum size of a PDF file that can be processed is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial description: During the trial period, the API operation is limited to 5 QPS. The trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageScrapeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReadPageScrapeResponse
        /// </returns>
        public async Task<ReadPageScrapeResponse> ReadPageScrapeWithOptionsAsync(ReadPageScrapeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReadPageScrape",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/readpage/scrape",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReadPageScrapeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reads HTML and parses web page content in a browser sandbox environment. The operation starts parsing after the resources on the target page are fully loaded. You can adjust the maximum wait time by using the pageTimeout parameter. The overall execution duration is significantly affected by the resource loading status of the target site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as a valid request when the HTTP status code of the target URL is less than 500.</description></item>
        /// <item><description>If the Content-Type in the response header of the target URL is application/pdf, the system automatically triggers PDF parsing (the maximum size of a PDF file that can be processed is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial description: During the trial period, the API operation is limited to 5 QPS. The trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageScrapeRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadPageScrapeResponse
        /// </returns>
        public ReadPageScrapeResponse ReadPageScrape(ReadPageScrapeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReadPageScrapeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reads HTML and parses web page content in a browser sandbox environment. The operation starts parsing after the resources on the target page are fully loaded. You can adjust the maximum wait time by using the pageTimeout parameter. The overall execution duration is significantly affected by the resource loading status of the target site.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>A request is counted as a valid request when the HTTP status code of the target URL is less than 500.</description></item>
        /// <item><description>If the Content-Type in the response header of the target URL is application/pdf, the system automatically triggers PDF parsing (the maximum size of a PDF file that can be processed is 20 MB). This operation is counted as an additional valid request.</description></item>
        /// <item><description>Trial description: During the trial period, the API operation is limited to 5 QPS. The trial quota is 1,000 requests per 30 days.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ReadPageScrapeRequest
        /// </param>
        /// 
        /// <returns>
        /// ReadPageScrapeResponse
        /// </returns>
        public async Task<ReadPageScrapeResponse> ReadPageScrapeAsync(ReadPageScrapeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReadPageScrapeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides the Tongxiao unified search API to quickly and easily integrate web-wide general search capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnifiedSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnifiedSearchResponse
        /// </returns>
        public UnifiedSearchResponse UnifiedSearchWithOptions(UnifiedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnifiedSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/search/unified",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnifiedSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides the Tongxiao unified search API to quickly and easily integrate web-wide general search capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnifiedSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnifiedSearchResponse
        /// </returns>
        public async Task<UnifiedSearchResponse> UnifiedSearchWithOptionsAsync(UnifiedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnifiedSearch",
                Version = "2024-11-11",
                Protocol = "HTTPS",
                Pathname = "/linked-retrieval/linked-retrieval-entry/v1/iqs/search/unified",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnifiedSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides the Tongxiao unified search API to quickly and easily integrate web-wide general search capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnifiedSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// UnifiedSearchResponse
        /// </returns>
        public UnifiedSearchResponse UnifiedSearch(UnifiedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnifiedSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides the Tongxiao unified search API to quickly and easily integrate web-wide general search capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnifiedSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// UnifiedSearchResponse
        /// </returns>
        public async Task<UnifiedSearchResponse> UnifiedSearchAsync(UnifiedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnifiedSearchWithOptionsAsync(request, headers, runtime);
        }

    }
}
