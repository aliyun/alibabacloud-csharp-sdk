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
            this._endpointRule = "";
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
        /// <para>AI搜索流式接口</para>
        /// </summary>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AiSearchResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AiSearchResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI搜索流式接口</para>
        /// </summary>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AiSearchResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AiSearchResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI搜索流式接口</para>
        /// </summary>
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
        /// <para>AI搜索流式接口</para>
        /// </summary>
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
        /// <para>增强版通用搜索</para>
        /// </summary>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenericAdvancedSearchResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenericAdvancedSearchResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增强版通用搜索</para>
        /// </summary>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenericAdvancedSearchResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenericAdvancedSearchResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>增强版通用搜索</para>
        /// </summary>
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
        /// <para>增强版通用搜索</para>
        /// </summary>
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
        /// <para>通用搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public GenericSearchResponse GenericSearchWithOptions(GenericSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenericSearchResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenericSearchResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<GenericSearchResponse> GenericSearchWithOptionsAsync(GenericSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenericSearchResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenericSearchResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通用搜索</para>
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
        /// <para>通用搜索</para>
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

    }
}
