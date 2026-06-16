// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AiSearchEngine20260417.Models;

namespace AlibabaCloud.SDK.AiSearchEngine20260417
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aisearchengine", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Provides a search API operation for the CleverSee AI Search platform. After you create a search application on the platform, you can invoke this search API operation to retrieve images, documents, and audio/video content in datasets. The platform supports text (natural language), image, or combined text-and-image input, enabling fast adaptation to multi-modal large-scale data search scenarios and helping you efficiently locate target content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation supports calling two types of search applications on the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a>: <b>image search applications</b> (text-to-image, image-to-image, and combined text-and-image search) and <b>audio/video search applications</b> (text-to-audio/video, image-to-video, and combined text-and-image-to-video search).</para>
        /// <h3>Data sources</h3>
        /// <para>Audio and video data is supported. You can upload and update data through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a> UI or through the <a href="https://www.alibabacloud.com/help/en/document_detail/3038471.html">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Search service by using the Alibaba Cloud SDK. For more information, see <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/EngineSearch">AI search engine operation</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EngineSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EngineSearchResponse
        /// </returns>
        public EngineSearchResponse EngineSearchWithOptions(EngineSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grey))
            {
                body["grey"] = request.Grey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
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
                Action = "EngineSearch",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/platform/app/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EngineSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a search API operation for the CleverSee AI Search platform. After you create a search application on the platform, you can invoke this search API operation to retrieve images, documents, and audio/video content in datasets. The platform supports text (natural language), image, or combined text-and-image input, enabling fast adaptation to multi-modal large-scale data search scenarios and helping you efficiently locate target content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation supports calling two types of search applications on the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a>: <b>image search applications</b> (text-to-image, image-to-image, and combined text-and-image search) and <b>audio/video search applications</b> (text-to-audio/video, image-to-video, and combined text-and-image-to-video search).</para>
        /// <h3>Data sources</h3>
        /// <para>Audio and video data is supported. You can upload and update data through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a> UI or through the <a href="https://www.alibabacloud.com/help/en/document_detail/3038471.html">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Search service by using the Alibaba Cloud SDK. For more information, see <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/EngineSearch">AI search engine operation</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EngineSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EngineSearchResponse
        /// </returns>
        public async Task<EngineSearchResponse> EngineSearchWithOptionsAsync(EngineSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grey))
            {
                body["grey"] = request.Grey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
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
                Action = "EngineSearch",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/platform/app/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EngineSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a search API operation for the CleverSee AI Search platform. After you create a search application on the platform, you can invoke this search API operation to retrieve images, documents, and audio/video content in datasets. The platform supports text (natural language), image, or combined text-and-image input, enabling fast adaptation to multi-modal large-scale data search scenarios and helping you efficiently locate target content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation supports calling two types of search applications on the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a>: <b>image search applications</b> (text-to-image, image-to-image, and combined text-and-image search) and <b>audio/video search applications</b> (text-to-audio/video, image-to-video, and combined text-and-image-to-video search).</para>
        /// <h3>Data sources</h3>
        /// <para>Audio and video data is supported. You can upload and update data through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a> UI or through the <a href="https://www.alibabacloud.com/help/en/document_detail/3038471.html">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Search service by using the Alibaba Cloud SDK. For more information, see <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/EngineSearch">AI search engine operation</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EngineSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// EngineSearchResponse
        /// </returns>
        public EngineSearchResponse EngineSearch(EngineSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EngineSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a search API operation for the CleverSee AI Search platform. After you create a search application on the platform, you can invoke this search API operation to retrieve images, documents, and audio/video content in datasets. The platform supports text (natural language), image, or combined text-and-image input, enabling fast adaptation to multi-modal large-scale data search scenarios and helping you efficiently locate target content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This operation supports calling two types of search applications on the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a>: <b>image search applications</b> (text-to-image, image-to-image, and combined text-and-image search) and <b>audio/video search applications</b> (text-to-audio/video, image-to-video, and combined text-and-image-to-video search).</para>
        /// <h3>Data sources</h3>
        /// <para>Audio and video data is supported. You can upload and update data through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search platform</a> UI or through the <a href="https://www.alibabacloud.com/help/en/document_detail/3038471.html">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Search service by using the Alibaba Cloud SDK. For more information, see <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/EngineSearch">AI search engine operation</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EngineSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// EngineSearchResponse
        /// </returns>
        public async Task<EngineSearchResponse> EngineSearchAsync(EngineSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EngineSearchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary public network access URL for an image, audio, or video resource in your dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary secure access URL for an underlying media resource (such as audio, video, or image) stored in AI Search Platform, based on the dataset ID and data primary key. The URL can be used directly for frontend display or download.
        /// Key use case: When you make a Search API call for a search application created in AI Search Platform, the returned image, audio, and video result URLs are pre-signed links with a validity period of 24 hours. If your application persists these URLs in local storage, subsequent access may fail because the URLs have expired. In this case, invoke this operation with the corresponding dataset ID and data record primary key to retrieve the latest valid access URL for the resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDatasetResourceUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResourceUrlResponse
        /// </returns>
        public GetDatasetResourceUrlResponse GetDatasetResourceUrlWithOptions(GetDatasetResourceUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetResourceUrl",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResourceUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary public network access URL for an image, audio, or video resource in your dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary secure access URL for an underlying media resource (such as audio, video, or image) stored in AI Search Platform, based on the dataset ID and data primary key. The URL can be used directly for frontend display or download.
        /// Key use case: When you make a Search API call for a search application created in AI Search Platform, the returned image, audio, and video result URLs are pre-signed links with a validity period of 24 hours. If your application persists these URLs in local storage, subsequent access may fail because the URLs have expired. In this case, invoke this operation with the corresponding dataset ID and data record primary key to retrieve the latest valid access URL for the resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDatasetResourceUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResourceUrlResponse
        /// </returns>
        public async Task<GetDatasetResourceUrlResponse> GetDatasetResourceUrlWithOptionsAsync(GetDatasetResourceUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetResourceUrl",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResourceUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary public network access URL for an image, audio, or video resource in your dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary secure access URL for an underlying media resource (such as audio, video, or image) stored in AI Search Platform, based on the dataset ID and data primary key. The URL can be used directly for frontend display or download.
        /// Key use case: When you make a Search API call for a search application created in AI Search Platform, the returned image, audio, and video result URLs are pre-signed links with a validity period of 24 hours. If your application persists these URLs in local storage, subsequent access may fail because the URLs have expired. In this case, invoke this operation with the corresponding dataset ID and data record primary key to retrieve the latest valid access URL for the resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDatasetResourceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResourceUrlResponse
        /// </returns>
        public GetDatasetResourceUrlResponse GetDatasetResourceUrl(GetDatasetResourceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetResourceUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary public network access URL for an image, audio, or video resource in your dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary secure access URL for an underlying media resource (such as audio, video, or image) stored in AI Search Platform, based on the dataset ID and data primary key. The URL can be used directly for frontend display or download.
        /// Key use case: When you make a Search API call for a search application created in AI Search Platform, the returned image, audio, and video result URLs are pre-signed links with a validity period of 24 hours. If your application persists these URLs in local storage, subsequent access may fail because the URLs have expired. In this case, invoke this operation with the corresponding dataset ID and data record primary key to retrieve the latest valid access URL for the resource.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDatasetResourceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResourceUrlResponse
        /// </returns>
        public async Task<GetDatasetResourceUrlResponse> GetDatasetResourceUrlAsync(GetDatasetResourceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetResourceUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or updates data in a specific dataset in real time. The system matches records based on the primary key value of the target dataset and the primary key value of the new data record (such as &quot;pk_id&quot; = &quot;2026aa01&quot;). If a matching primary key value is found, the corresponding data record is updated. If no match is found, a new data record is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Common scenarios</em>*</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Real-time data addition</td>
        /// <td>Pushes new data to the AI search platform in real time when the business system generates new data.</td>
        /// </tr>
        /// <tr>
        /// <td>Status update</td>
        /// <td>Promptly updates data when changes occur on the business side, such as title modifications or delisting.</td>
        /// </tr>
        /// <tr>
        /// <td><b>Before you begin</b></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Primary key handling</b>: The system determines whether to add or update a record based on the primary key type (user-defined or system-generated) of the target dataset.</description></item>
        /// <item><description><b>Batch limit</b>: A maximum of 100 records can be processed per request.</description></item>
        /// <item><description><b>Schema matching</b>: The <c>records</c> field must strictly follow the schema configured for the target dataset in the console.</description></item>
        /// <item><description><b>Permission requirements</b>: Make sure you have sufficient permissions to write to or update the target dataset.</description></item>
        /// <item><description><b>Status check</b>: Before sending a request, confirm that the target dataset is in a writable state and not in read-only mode.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportDatasetDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportDatasetDataResponse
        /// </returns>
        public ImportDatasetDataResponse ImportDatasetDataWithOptions(ImportDatasetDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportDatasetData",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportDatasetDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or updates data in a specific dataset in real time. The system matches records based on the primary key value of the target dataset and the primary key value of the new data record (such as &quot;pk_id&quot; = &quot;2026aa01&quot;). If a matching primary key value is found, the corresponding data record is updated. If no match is found, a new data record is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Common scenarios</em>*</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Real-time data addition</td>
        /// <td>Pushes new data to the AI search platform in real time when the business system generates new data.</td>
        /// </tr>
        /// <tr>
        /// <td>Status update</td>
        /// <td>Promptly updates data when changes occur on the business side, such as title modifications or delisting.</td>
        /// </tr>
        /// <tr>
        /// <td><b>Before you begin</b></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Primary key handling</b>: The system determines whether to add or update a record based on the primary key type (user-defined or system-generated) of the target dataset.</description></item>
        /// <item><description><b>Batch limit</b>: A maximum of 100 records can be processed per request.</description></item>
        /// <item><description><b>Schema matching</b>: The <c>records</c> field must strictly follow the schema configured for the target dataset in the console.</description></item>
        /// <item><description><b>Permission requirements</b>: Make sure you have sufficient permissions to write to or update the target dataset.</description></item>
        /// <item><description><b>Status check</b>: Before sending a request, confirm that the target dataset is in a writable state and not in read-only mode.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportDatasetDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportDatasetDataResponse
        /// </returns>
        public async Task<ImportDatasetDataResponse> ImportDatasetDataWithOptionsAsync(ImportDatasetDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportDatasetData",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportDatasetDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or updates data in a specific dataset in real time. The system matches records based on the primary key value of the target dataset and the primary key value of the new data record (such as &quot;pk_id&quot; = &quot;2026aa01&quot;). If a matching primary key value is found, the corresponding data record is updated. If no match is found, a new data record is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Common scenarios</em>*</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Real-time data addition</td>
        /// <td>Pushes new data to the AI search platform in real time when the business system generates new data.</td>
        /// </tr>
        /// <tr>
        /// <td>Status update</td>
        /// <td>Promptly updates data when changes occur on the business side, such as title modifications or delisting.</td>
        /// </tr>
        /// <tr>
        /// <td><b>Before you begin</b></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Primary key handling</b>: The system determines whether to add or update a record based on the primary key type (user-defined or system-generated) of the target dataset.</description></item>
        /// <item><description><b>Batch limit</b>: A maximum of 100 records can be processed per request.</description></item>
        /// <item><description><b>Schema matching</b>: The <c>records</c> field must strictly follow the schema configured for the target dataset in the console.</description></item>
        /// <item><description><b>Permission requirements</b>: Make sure you have sufficient permissions to write to or update the target dataset.</description></item>
        /// <item><description><b>Status check</b>: Before sending a request, confirm that the target dataset is in a writable state and not in read-only mode.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportDatasetDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportDatasetDataResponse
        /// </returns>
        public ImportDatasetDataResponse ImportDatasetData(ImportDatasetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ImportDatasetDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds or updates data in a specific dataset in real time. The system matches records based on the primary key value of the target dataset and the primary key value of the new data record (such as &quot;pk_id&quot; = &quot;2026aa01&quot;). If a matching primary key value is found, the corresponding data record is updated. If no match is found, a new data record is added.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Common scenarios</em>*</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Real-time data addition</td>
        /// <td>Pushes new data to the AI search platform in real time when the business system generates new data.</td>
        /// </tr>
        /// <tr>
        /// <td>Status update</td>
        /// <td>Promptly updates data when changes occur on the business side, such as title modifications or delisting.</td>
        /// </tr>
        /// <tr>
        /// <td><b>Before you begin</b></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Primary key handling</b>: The system determines whether to add or update a record based on the primary key type (user-defined or system-generated) of the target dataset.</description></item>
        /// <item><description><b>Batch limit</b>: A maximum of 100 records can be processed per request.</description></item>
        /// <item><description><b>Schema matching</b>: The <c>records</c> field must strictly follow the schema configured for the target dataset in the console.</description></item>
        /// <item><description><b>Permission requirements</b>: Make sure you have sufficient permissions to write to or update the target dataset.</description></item>
        /// <item><description><b>Status check</b>: Before sending a request, confirm that the target dataset is in a writable state and not in read-only mode.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportDatasetDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportDatasetDataResponse
        /// </returns>
        public async Task<ImportDatasetDataResponse> ImportDatasetDataAsync(ImportDatasetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ImportDatasetDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Build Q&amp;A applications leveraging powerful omni-modal search and comprehension capabilities on the CleverSee AI Search Platform, enabling deep understanding and precise Q&amp;A over images, documents, and video content in datasets. The platform supports flexible customization of the Q&amp;A assistant\&quot;s response style and interaction mode, allowing rapid adaptation to diverse large-scale data Q&amp;A scenarios. Users can ask questions via text, images, or a combination of both, and the platform performs deep semantic understanding across the complete dataset, producing answers in multiple formats including text, images, and video. For video content, the platform also provides template-based output capabilities for generating customized content summaries, information extraction, and video scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Streaming API for <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> intelligent Q&amp;A applications, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Integration Guide:</h3>
        /// <para>Streaming API for intelligent Q&amp;A, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Data Sources:</h3>
        /// <para>Supports video Q&amp;A. Data can be uploaded and updated through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> product interface or via the <a href="https://help.aliyun.com/zh/document_detail/3038471.html?spm=a2c4g.11186623.help-menu-3037946.d_0_2_1_0.54ed1e97NGXVV1&scm=20140722.H_3038471._.OR_help-T_cn~zh-V_1">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Q&amp;A service through the Alibaba Cloud SDK. For the detailed calling guide, please refer to: <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/QaChat">AI Q&amp;A Engine API</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// QaChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QaChatResponse
        /// </returns>
        public QaChatResponse QaChatWithOptions(QaChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
                Action = "QaChat",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/platform/app/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QaChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Build Q&amp;A applications leveraging powerful omni-modal search and comprehension capabilities on the CleverSee AI Search Platform, enabling deep understanding and precise Q&amp;A over images, documents, and video content in datasets. The platform supports flexible customization of the Q&amp;A assistant\&quot;s response style and interaction mode, allowing rapid adaptation to diverse large-scale data Q&amp;A scenarios. Users can ask questions via text, images, or a combination of both, and the platform performs deep semantic understanding across the complete dataset, producing answers in multiple formats including text, images, and video. For video content, the platform also provides template-based output capabilities for generating customized content summaries, information extraction, and video scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Streaming API for <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> intelligent Q&amp;A applications, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Integration Guide:</h3>
        /// <para>Streaming API for intelligent Q&amp;A, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Data Sources:</h3>
        /// <para>Supports video Q&amp;A. Data can be uploaded and updated through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> product interface or via the <a href="https://help.aliyun.com/zh/document_detail/3038471.html?spm=a2c4g.11186623.help-menu-3037946.d_0_2_1_0.54ed1e97NGXVV1&scm=20140722.H_3038471._.OR_help-T_cn~zh-V_1">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Q&amp;A service through the Alibaba Cloud SDK. For the detailed calling guide, please refer to: <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/QaChat">AI Q&amp;A Engine API</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// QaChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QaChatResponse
        /// </returns>
        public async Task<QaChatResponse> QaChatWithOptionsAsync(QaChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
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
                Action = "QaChat",
                Version = "2026-04-17",
                Protocol = "HTTPS",
                Pathname = "/api/v1/platform/app/chat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QaChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Build Q&amp;A applications leveraging powerful omni-modal search and comprehension capabilities on the CleverSee AI Search Platform, enabling deep understanding and precise Q&amp;A over images, documents, and video content in datasets. The platform supports flexible customization of the Q&amp;A assistant\&quot;s response style and interaction mode, allowing rapid adaptation to diverse large-scale data Q&amp;A scenarios. Users can ask questions via text, images, or a combination of both, and the platform performs deep semantic understanding across the complete dataset, producing answers in multiple formats including text, images, and video. For video content, the platform also provides template-based output capabilities for generating customized content summaries, information extraction, and video scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Streaming API for <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> intelligent Q&amp;A applications, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Integration Guide:</h3>
        /// <para>Streaming API for intelligent Q&amp;A, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Data Sources:</h3>
        /// <para>Supports video Q&amp;A. Data can be uploaded and updated through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> product interface or via the <a href="https://help.aliyun.com/zh/document_detail/3038471.html?spm=a2c4g.11186623.help-menu-3037946.d_0_2_1_0.54ed1e97NGXVV1&scm=20140722.H_3038471._.OR_help-T_cn~zh-V_1">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Q&amp;A service through the Alibaba Cloud SDK. For the detailed calling guide, please refer to: <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/QaChat">AI Q&amp;A Engine API</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// QaChatRequest
        /// </param>
        /// 
        /// <returns>
        /// QaChatResponse
        /// </returns>
        public QaChatResponse QaChat(QaChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QaChatWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Build Q&amp;A applications leveraging powerful omni-modal search and comprehension capabilities on the CleverSee AI Search Platform, enabling deep understanding and precise Q&amp;A over images, documents, and video content in datasets. The platform supports flexible customization of the Q&amp;A assistant\&quot;s response style and interaction mode, allowing rapid adaptation to diverse large-scale data Q&amp;A scenarios. Users can ask questions via text, images, or a combination of both, and the platform performs deep semantic understanding across the complete dataset, producing answers in multiple formats including text, images, and video. For video content, the platform also provides template-based output capabilities for generating customized content summaries, information extraction, and video scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Streaming API for <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> intelligent Q&amp;A applications, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Integration Guide:</h3>
        /// <para>Streaming API for intelligent Q&amp;A, supporting multimodal input (text, images, structured data) and streaming output (text, images, video, sources, etc.). The API uses the SSE (Server-Sent Events) protocol to push response data, where each data stream is a JSON object with different data types identified by the <c>type</c> field.</para>
        /// <h3>Data Sources:</h3>
        /// <para>Supports video Q&amp;A. Data can be uploaded and updated through the <a href="https://aisearch.aliyun.com/web-search">CleverSee AI Search Platform</a> product interface or via the <a href="https://help.aliyun.com/zh/document_detail/3038471.html?spm=a2c4g.11186623.help-menu-3037946.d_0_2_1_0.54ed1e97NGXVV1&scm=20140722.H_3038471._.OR_help-T_cn~zh-V_1">Dataset Data Add/Update API</a>.</para>
        /// <h1>Authentication</h1>
        /// <para>Call the CleverSee - Intelligent Q&amp;A service through the Alibaba Cloud SDK. For the detailed calling guide, please refer to: <a href="https://api.aliyun.com/document/AiSearchEngine/2026-04-17/QaChat">AI Q&amp;A Engine API</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// QaChatRequest
        /// </param>
        /// 
        /// <returns>
        /// QaChatResponse
        /// </returns>
        public async Task<QaChatResponse> QaChatAsync(QaChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QaChatWithOptionsAsync(request, headers, runtime);
        }

    }
}
