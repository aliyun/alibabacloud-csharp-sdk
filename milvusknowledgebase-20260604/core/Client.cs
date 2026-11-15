// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "MilvusKnowledgeBase";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("milvusknowledgebase", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Registers files that have been uploaded to the knowledge base storage as knowledge base documents and <b>automatically triggers parsing</b> (chunking and embedding). Supports two types of import:</para>
        /// <list type="bullet">
        /// <item><description><c>LOCAL_UPLOAD</c>: Used with the <c>GetKnowledgeBasePreSignedUrl</c> direct upload process. This operation only registers the files and does not verify whether the files have been actually uploaded. Therefore, you must complete the PUT upload first.</description></item>
        /// <item><description><c>OSS_IMPORT</c>: Imports files from an external OSS bucket. This operation creates an asynchronous import task and returns the <c>knowledge_import_task_id</c>. The system downloads and registers the files in the background.
        /// A maximum of 100 files can be processed at a time.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDocumentsResponse
        /// </returns>
        public AddDocumentsResponse AddDocumentsWithOptions(string datasetId, AddDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dedup))
            {
                body["Dedup"] = request.Dedup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documents))
            {
                body["Documents"] = request.Documents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                body["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                body["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaFields))
            {
                body["MetaFields"] = request.MetaFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                body["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkConfiguration))
            {
                body["dingTalkConfiguration"] = request.DingTalkConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDocuments",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetId) + "/documents/addDocuments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers files that have been uploaded to the knowledge base storage as knowledge base documents and <b>automatically triggers parsing</b> (chunking and embedding). Supports two types of import:</para>
        /// <list type="bullet">
        /// <item><description><c>LOCAL_UPLOAD</c>: Used with the <c>GetKnowledgeBasePreSignedUrl</c> direct upload process. This operation only registers the files and does not verify whether the files have been actually uploaded. Therefore, you must complete the PUT upload first.</description></item>
        /// <item><description><c>OSS_IMPORT</c>: Imports files from an external OSS bucket. This operation creates an asynchronous import task and returns the <c>knowledge_import_task_id</c>. The system downloads and registers the files in the background.
        /// A maximum of 100 files can be processed at a time.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDocumentsResponse
        /// </returns>
        public async Task<AddDocumentsResponse> AddDocumentsWithOptionsAsync(string datasetId, AddDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dedup))
            {
                body["Dedup"] = request.Dedup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documents))
            {
                body["Documents"] = request.Documents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                body["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                body["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaFields))
            {
                body["MetaFields"] = request.MetaFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                body["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkConfiguration))
            {
                body["dingTalkConfiguration"] = request.DingTalkConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDocuments",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetId) + "/documents/addDocuments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers files that have been uploaded to the knowledge base storage as knowledge base documents and <b>automatically triggers parsing</b> (chunking and embedding). Supports two types of import:</para>
        /// <list type="bullet">
        /// <item><description><c>LOCAL_UPLOAD</c>: Used with the <c>GetKnowledgeBasePreSignedUrl</c> direct upload process. This operation only registers the files and does not verify whether the files have been actually uploaded. Therefore, you must complete the PUT upload first.</description></item>
        /// <item><description><c>OSS_IMPORT</c>: Imports files from an external OSS bucket. This operation creates an asynchronous import task and returns the <c>knowledge_import_task_id</c>. The system downloads and registers the files in the background.
        /// A maximum of 100 files can be processed at a time.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDocumentsResponse
        /// </returns>
        public AddDocumentsResponse AddDocuments(string datasetId, AddDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddDocumentsWithOptions(datasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers files that have been uploaded to the knowledge base storage as knowledge base documents and <b>automatically triggers parsing</b> (chunking and embedding). Supports two types of import:</para>
        /// <list type="bullet">
        /// <item><description><c>LOCAL_UPLOAD</c>: Used with the <c>GetKnowledgeBasePreSignedUrl</c> direct upload process. This operation only registers the files and does not verify whether the files have been actually uploaded. Therefore, you must complete the PUT upload first.</description></item>
        /// <item><description><c>OSS_IMPORT</c>: Imports files from an external OSS bucket. This operation creates an asynchronous import task and returns the <c>knowledge_import_task_id</c>. The system downloads and registers the files in the background.
        /// A maximum of 100 files can be processed at a time.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDocumentsResponse
        /// </returns>
        public async Task<AddDocumentsResponse> AddDocumentsAsync(string datasetId, AddDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddDocumentsWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an <b>Object Storage Service (OSS) pre-signed PUT URL</b> pointing to the dedicated storage of the knowledge base for each file in <c>Documents</c>. Callers use the URL to upload file content directly to OSS and then call <c>AddDocuments</c> to complete the registration. A maximum of 100 files can be processed at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBasePreSignedUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBasePreSignedUrlResponse
        /// </returns>
        public GetKnowledgeBasePreSignedUrlResponse GetKnowledgeBasePreSignedUrlWithOptions(string datasetId, GetKnowledgeBasePreSignedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documents))
            {
                body["Documents"] = request.Documents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiresIn))
            {
                body["ExpiresIn"] = request.ExpiresIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                body["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBasePreSignedUrl",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetId) + "/getKnowledgeBasePreSignedUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBasePreSignedUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an <b>Object Storage Service (OSS) pre-signed PUT URL</b> pointing to the dedicated storage of the knowledge base for each file in <c>Documents</c>. Callers use the URL to upload file content directly to OSS and then call <c>AddDocuments</c> to complete the registration. A maximum of 100 files can be processed at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBasePreSignedUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBasePreSignedUrlResponse
        /// </returns>
        public async Task<GetKnowledgeBasePreSignedUrlResponse> GetKnowledgeBasePreSignedUrlWithOptionsAsync(string datasetId, GetKnowledgeBasePreSignedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documents))
            {
                body["Documents"] = request.Documents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiresIn))
            {
                body["ExpiresIn"] = request.ExpiresIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                body["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBasePreSignedUrl",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetId) + "/getKnowledgeBasePreSignedUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBasePreSignedUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an <b>Object Storage Service (OSS) pre-signed PUT URL</b> pointing to the dedicated storage of the knowledge base for each file in <c>Documents</c>. Callers use the URL to upload file content directly to OSS and then call <c>AddDocuments</c> to complete the registration. A maximum of 100 files can be processed at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBasePreSignedUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBasePreSignedUrlResponse
        /// </returns>
        public GetKnowledgeBasePreSignedUrlResponse GetKnowledgeBasePreSignedUrl(string datasetId, GetKnowledgeBasePreSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKnowledgeBasePreSignedUrlWithOptions(datasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an <b>Object Storage Service (OSS) pre-signed PUT URL</b> pointing to the dedicated storage of the knowledge base for each file in <c>Documents</c>. Callers use the URL to upload file content directly to OSS and then call <c>AddDocuments</c> to complete the registration. A maximum of 100 files can be processed at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBasePreSignedUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBasePreSignedUrlResponse
        /// </returns>
        public async Task<GetKnowledgeBasePreSignedUrlResponse> GetKnowledgeBasePreSignedUrlAsync(string datasetId, GetKnowledgeBasePreSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKnowledgeBasePreSignedUrlWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches a knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Searches a specified knowledge base by using a text query or an image. For the version parameter, use the display name DRAFT, LATEST_PUBLISHED, or vN. Pass tag filter conditions based on the actual operators used by the backend.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public SearchKnowledgeBaseResponse SearchKnowledgeBaseWithOptions(string knowledgeBaseId, SearchKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIds))
            {
                body["documentIds"] = request.DocumentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableKnowledgeGraph))
            {
                body["enableKnowledgeGraph"] = request.EnableKnowledgeGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvidencePageToken))
            {
                body["evidencePageToken"] = request.EvidencePageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeWiki))
            {
                body["includeWiki"] = request.IncludeWiki;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelId))
            {
                body["rerankModelId"] = request.RerankModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                body["rerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalConfig))
            {
                body["retrievalConfig"] = request.RetrievalConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                body["tagFilter"] = request.TagFilter;
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
                Action = "SearchKnowledgeBase",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/knowledge-bases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches a knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Searches a specified knowledge base by using a text query or an image. For the version parameter, use the display name DRAFT, LATEST_PUBLISHED, or vN. Pass tag filter conditions based on the actual operators used by the backend.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchKnowledgeBaseResponse> SearchKnowledgeBaseWithOptionsAsync(string knowledgeBaseId, SearchKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIds))
            {
                body["documentIds"] = request.DocumentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableKnowledgeGraph))
            {
                body["enableKnowledgeGraph"] = request.EnableKnowledgeGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvidencePageToken))
            {
                body["evidencePageToken"] = request.EvidencePageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                body["image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeWiki))
            {
                body["includeWiki"] = request.IncludeWiki;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelId))
            {
                body["rerankModelId"] = request.RerankModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                body["rerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalConfig))
            {
                body["retrievalConfig"] = request.RetrievalConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                body["tagFilter"] = request.TagFilter;
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
                Action = "SearchKnowledgeBase",
                Version = "2026-06-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/knowledge-bases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(knowledgeBaseId) + "/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches a knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Searches a specified knowledge base by using a text query or an image. For the version parameter, use the display name DRAFT, LATEST_PUBLISHED, or vN. Pass tag filter conditions based on the actual operators used by the backend.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public SearchKnowledgeBaseResponse SearchKnowledgeBase(string knowledgeBaseId, SearchKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchKnowledgeBaseWithOptions(knowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches a knowledge base.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Searches a specified knowledge base by using a text query or an image. For the version parameter, use the display name DRAFT, LATEST_PUBLISHED, or vN. Pass tag filter conditions based on the actual operators used by the backend.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchKnowledgeBaseResponse
        /// </returns>
        public async Task<SearchKnowledgeBaseResponse> SearchKnowledgeBaseAsync(string knowledgeBaseId, SearchKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchKnowledgeBaseWithOptionsAsync(knowledgeBaseId, request, headers, runtime);
        }

    }
}
