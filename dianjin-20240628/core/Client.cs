// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DianJin20240628.Models;

namespace AlibabaCloud.SDK.DianJin20240628
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dianjin", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建文档库
         *
         * @param request CreateLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLibraryResponse
         */
        public CreateLibraryResponse CreateLibraryWithOptions(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建文档库
         *
         * @param request CreateLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLibraryResponse
         */
        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(string workspaceId, CreateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建文档库
         *
         * @param request CreateLibraryRequest
         * @return CreateLibraryResponse
         */
        public CreateLibraryResponse CreateLibrary(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建文档库
         *
         * @param request CreateLibraryRequest
         * @return CreateLibraryResponse
         */
        public async Task<CreateLibraryResponse> CreateLibraryAsync(string workspaceId, CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建预定义文档
         *
         * @param request CreatePredefinedDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePredefinedDocumentResponse
         */
        public CreatePredefinedDocumentResponse CreatePredefinedDocumentWithOptions(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
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
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建预定义文档
         *
         * @param request CreatePredefinedDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePredefinedDocumentResponse
         */
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentWithOptionsAsync(string workspaceId, CreatePredefinedDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
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
                Action = "CreatePredefinedDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/createPredefinedDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePredefinedDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建预定义文档
         *
         * @param request CreatePredefinedDocumentRequest
         * @return CreatePredefinedDocumentResponse
         */
        public CreatePredefinedDocumentResponse CreatePredefinedDocument(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePredefinedDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建预定义文档
         *
         * @param request CreatePredefinedDocumentRequest
         * @return CreatePredefinedDocumentResponse
         */
        public async Task<CreatePredefinedDocumentResponse> CreatePredefinedDocumentAsync(string workspaceId, CreatePredefinedDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePredefinedDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除文档
         *
         * @param request DeleteDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDocumentResponse
         */
        public DeleteDocumentResponse DeleteDocumentWithOptions(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除文档
         *
         * @param request DeleteDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDocumentResponse
         */
        public async Task<DeleteDocumentResponse> DeleteDocumentWithOptionsAsync(string workspaceId, DeleteDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIds))
            {
                body["docIds"] = request.DocIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除文档
         *
         * @param request DeleteDocumentRequest
         * @return DeleteDocumentResponse
         */
        public DeleteDocumentResponse DeleteDocument(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除文档
         *
         * @param request DeleteDocumentRequest
         * @return DeleteDocumentResponse
         */
        public async Task<DeleteDocumentResponse> DeleteDocumentAsync(string workspaceId, DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除文档库
         *
         * @param request DeleteLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLibraryResponse
         */
        public DeleteLibraryResponse DeleteLibraryWithOptions(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除文档库
         *
         * @param request DeleteLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLibraryResponse
         */
        public async Task<DeleteLibraryResponse> DeleteLibraryWithOptionsAsync(string workspaceId, DeleteLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除文档库
         *
         * @param request DeleteLibraryRequest
         * @return DeleteLibraryResponse
         */
        public DeleteLibraryResponse DeleteLibrary(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除文档库
         *
         * @param request DeleteLibraryRequest
         * @return DeleteLibraryResponse
         */
        public async Task<DeleteLibraryResponse> DeleteLibraryAsync(string workspaceId, DeleteLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取app配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppConfigResponse
         */
        public GetAppConfigResponse GetAppConfigWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取app配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppConfigResponse
         */
        public async Task<GetAppConfigResponse> GetAppConfigWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppConfig",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/app/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取app配置
         *
         * @return GetAppConfigResponse
         */
        public GetAppConfigResponse GetAppConfig(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppConfigWithOptions(workspaceId, headers, runtime);
        }

        /**
         * @summary 获取app配置
         *
         * @return GetAppConfigResponse
         */
        public async Task<GetAppConfigResponse> GetAppConfigAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppConfigWithOptionsAsync(workspaceId, headers, runtime);
        }

        /**
         * @summary 获取文档的chunk列表
         *
         * @param request GetDocumentChunkListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentChunkListResponse
         */
        public GetDocumentChunkListResponse GetDocumentChunkListWithOptions(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档的chunk列表
         *
         * @param request GetDocumentChunkListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentChunkListResponse
         */
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListWithOptionsAsync(string workspaceId, GetDocumentChunkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdList))
            {
                body["chunkIdList"] = request.ChunkIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentChunkList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/getDocumentChunk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentChunkListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档的chunk列表
         *
         * @param request GetDocumentChunkListRequest
         * @return GetDocumentChunkListResponse
         */
        public GetDocumentChunkListResponse GetDocumentChunkList(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentChunkListWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档的chunk列表
         *
         * @param request GetDocumentChunkListRequest
         * @return GetDocumentChunkListResponse
         */
        public async Task<GetDocumentChunkListResponse> GetDocumentChunkListAsync(string workspaceId, GetDocumentChunkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentChunkListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库的文档列表
         *
         * @param request GetDocumentListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentListResponse
         */
        public GetDocumentListResponse GetDocumentListWithOptions(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库的文档列表
         *
         * @param request GetDocumentListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentListResponse
         */
        public async Task<GetDocumentListResponse> GetDocumentListWithOptionsAsync(string workspaceId, GetDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
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
                Action = "GetDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/listDocument",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库的文档列表
         *
         * @param request GetDocumentListRequest
         * @return GetDocumentListResponse
         */
        public GetDocumentListResponse GetDocumentList(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库的文档列表
         *
         * @param request GetDocumentListRequest
         * @return GetDocumentListResponse
         */
        public async Task<GetDocumentListResponse> GetDocumentListAsync(string workspaceId, GetDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档URL
         *
         * @param request GetDocumentUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentUrlResponse
         */
        public GetDocumentUrlResponse GetDocumentUrlWithOptions(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档URL
         *
         * @param request GetDocumentUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentUrlResponse
         */
        public async Task<GetDocumentUrlResponse> GetDocumentUrlWithOptionsAsync(string workspaceId, GetDocumentUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentUrl",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档URL
         *
         * @param request GetDocumentUrlRequest
         * @return GetDocumentUrlResponse
         */
        public GetDocumentUrlResponse GetDocumentUrl(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentUrlWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档URL
         *
         * @param request GetDocumentUrlRequest
         * @return GetDocumentUrlResponse
         */
        public async Task<GetDocumentUrlResponse> GetDocumentUrlAsync(string workspaceId, GetDocumentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentUrlWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 带条件的分页查询文档库的文档列表
         *
         * @param request GetFilterDocumentListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFilterDocumentListResponse
         */
        public GetFilterDocumentListResponse GetFilterDocumentListWithOptions(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 带条件的分页查询文档库的文档列表
         *
         * @param request GetFilterDocumentListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFilterDocumentListResponse
         */
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListWithOptionsAsync(string workspaceId, GetFilterDocumentListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.And))
            {
                body["and"] = request.And;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Or))
            {
                body["or"] = request.Or;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "GetFilterDocumentList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/filterDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFilterDocumentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 带条件的分页查询文档库的文档列表
         *
         * @param request GetFilterDocumentListRequest
         * @return GetFilterDocumentListResponse
         */
        public GetFilterDocumentListResponse GetFilterDocumentList(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFilterDocumentListWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 带条件的分页查询文档库的文档列表
         *
         * @param request GetFilterDocumentListRequest
         * @return GetFilterDocumentListResponse
         */
        public async Task<GetFilterDocumentListResponse> GetFilterDocumentListAsync(string workspaceId, GetFilterDocumentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFilterDocumentListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetHistoryListByBizTypeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHistoryListByBizTypeResponse
         */
        public GetHistoryListByBizTypeResponse GetHistoryListByBizTypeWithOptions(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetHistoryListByBizTypeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetHistoryListByBizTypeResponse
         */
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeWithOptionsAsync(string workspaceId, GetHistoryListByBizTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
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
                Action = "GetHistoryListByBizType",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/history/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoryListByBizTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetHistoryListByBizTypeRequest
         * @return GetHistoryListByBizTypeResponse
         */
        public GetHistoryListByBizTypeResponse GetHistoryListByBizType(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHistoryListByBizTypeWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetHistoryListByBizTypeRequest
         * @return GetHistoryListByBizTypeResponse
         */
        public async Task<GetHistoryListByBizTypeResponse> GetHistoryListByBizTypeAsync(string workspaceId, GetHistoryListByBizTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHistoryListByBizTypeWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档库配置详情
         *
         * @param request GetLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLibraryResponse
         */
        public GetLibraryResponse GetLibraryWithOptions(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档库配置详情
         *
         * @param request GetLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLibraryResponse
         */
        public async Task<GetLibraryResponse> GetLibraryWithOptionsAsync(string workspaceId, GetLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                query["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档库配置详情
         *
         * @param request GetLibraryRequest
         * @return GetLibraryResponse
         */
        public GetLibraryResponse GetLibrary(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档库配置详情
         *
         * @param request GetLibraryRequest
         * @return GetLibraryResponse
         */
        public async Task<GetLibraryResponse> GetLibraryAsync(string workspaceId, GetLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetLibraryListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLibraryListResponse
         */
        public GetLibraryListResponse GetLibraryListWithOptions(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetLibraryListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLibraryListResponse
         */
        public async Task<GetLibraryListResponse> GetLibraryListWithOptionsAsync(string workspaceId, GetLibraryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLibraryList",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLibraryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetLibraryListRequest
         * @return GetLibraryListResponse
         */
        public GetLibraryListResponse GetLibraryList(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLibraryListWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 分页查询文档库列表
         *
         * @param request GetLibraryListRequest
         * @return GetLibraryListResponse
         */
        public async Task<GetLibraryListResponse> GetLibraryListAsync(string workspaceId, GetLibraryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLibraryListWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取解析结果
         *
         * @param request GetParseResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetParseResultResponse
         */
        public GetParseResultResponse GetParseResultWithOptions(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取解析结果
         *
         * @param request GetParseResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetParseResultResponse
         */
        public async Task<GetParseResultResponse> GetParseResultWithOptionsAsync(string workspaceId, GetParseResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParseResult",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/getParseResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParseResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取解析结果
         *
         * @param request GetParseResultRequest
         * @return GetParseResultResponse
         */
        public GetParseResultResponse GetParseResult(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetParseResultWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取解析结果
         *
         * @param request GetParseResultRequest
         * @return GetParseResultResponse
         */
        public async Task<GetParseResultResponse> GetParseResultAsync(string workspaceId, GetParseResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetParseResultWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 插件调试接口
         *
         * @param request InvokePluginRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokePluginResponse
         */
        public InvokePluginResponse InvokePluginWithOptions(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 插件调试接口
         *
         * @param request InvokePluginRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvokePluginResponse
         */
        public async Task<InvokePluginResponse> InvokePluginWithOptionsAsync(string workspaceId, InvokePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                body["pluginId"] = request.PluginId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokePlugin",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/plugin/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvokePluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 插件调试接口
         *
         * @param request InvokePluginRequest
         * @return InvokePluginResponse
         */
        public InvokePluginResponse InvokePlugin(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InvokePluginWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 插件调试接口
         *
         * @param request InvokePluginRequest
         * @return InvokePluginResponse
         */
        public async Task<InvokePluginResponse> InvokePluginAsync(string workspaceId, InvokePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InvokePluginWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档预览
         *
         * @param request PreviewDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreviewDocumentResponse
         */
        public PreviewDocumentResponse PreviewDocumentWithOptions(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档预览
         *
         * @param request PreviewDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreviewDocumentResponse
         */
        public async Task<PreviewDocumentResponse> PreviewDocumentWithOptionsAsync(string workspaceId, PreviewDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档预览
         *
         * @param request PreviewDocumentRequest
         * @return PreviewDocumentResponse
         */
        public PreviewDocumentResponse PreviewDocument(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档预览
         *
         * @param request PreviewDocumentRequest
         * @return PreviewDocumentResponse
         */
        public async Task<PreviewDocumentResponse> PreviewDocumentAsync(string workspaceId, PreviewDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 重新索引
         *
         * @param request ReIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReIndexResponse
         */
        public ReIndexResponse ReIndexWithOptions(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重新索引
         *
         * @param request ReIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReIndexResponse
         */
        public async Task<ReIndexResponse> ReIndexWithOptionsAsync(string workspaceId, ReIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["documentId"] = request.DocumentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReIndex",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/reIndex",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重新索引
         *
         * @param request ReIndexRequest
         * @return ReIndexResponse
         */
        public ReIndexResponse ReIndex(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReIndexWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 重新索引
         *
         * @param request ReIndexRequest
         * @return ReIndexResponse
         */
        public async Task<ReIndexResponse> ReIndexAsync(string workspaceId, ReIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReIndexWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 文档召回
         *
         * @param request RecallDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecallDocumentResponse
         */
        public RecallDocumentResponse RecallDocumentWithOptions(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档召回
         *
         * @param request RecallDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecallDocumentResponse
         */
        public async Task<RecallDocumentResponse> RecallDocumentWithOptionsAsync(string workspaceId, RecallDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rearrangement))
            {
                body["rearrangement"] = request.Rearrangement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecallDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/recallDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecallDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档召回
         *
         * @param request RecallDocumentRequest
         * @return RecallDocumentResponse
         */
        public RecallDocumentResponse RecallDocument(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecallDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 文档召回
         *
         * @param request RecallDocumentRequest
         * @return RecallDocumentResponse
         */
        public async Task<RecallDocumentResponse> RecallDocumentAsync(string workspaceId, RecallDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecallDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunChatResultGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunChatResultGenerationResponse
         */
        public RunChatResultGenerationResponse RunChatResultGenerationWithOptions(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunChatResultGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunChatResultGenerationResponse
         */
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationWithOptionsAsync(string workspaceId, RunChatResultGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceParameters))
            {
                body["inferenceParameters"] = request.InferenceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tools))
            {
                body["tools"] = request.Tools;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunChatResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunChatResultGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunChatResultGenerationRequest
         * @return RunChatResultGenerationResponse
         */
        public RunChatResultGenerationResponse RunChatResultGeneration(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunChatResultGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunChatResultGenerationRequest
         * @return RunChatResultGenerationResponse
         */
        public async Task<RunChatResultGenerationResponse> RunChatResultGenerationAsync(string workspaceId, RunChatResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunChatResultGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunLibraryChatGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunLibraryChatGenerationResponse
         */
        public RunLibraryChatGenerationResponse RunLibraryChatGenerationWithOptions(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunLibraryChatGenerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunLibraryChatGenerationResponse
         */
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationWithOptionsAsync(string workspaceId, RunLibraryChatGenerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocIdList))
            {
                body["docIdList"] = request.DocIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFollowUp))
            {
                body["enableFollowUp"] = request.EnableFollowUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMultiQuery))
            {
                body["enableMultiQuery"] = request.EnableMultiQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableOpenQa))
            {
                body["enableOpenQa"] = request.EnableOpenQa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FollowUpLlm))
            {
                body["followUpLlm"] = request.FollowUpLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmType))
            {
                body["llmType"] = request.LlmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiQueryLlm))
            {
                body["multiQueryLlm"] = request.MultiQueryLlm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCriteria))
            {
                body["queryCriteria"] = request.QueryCriteria;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankType))
            {
                body["rerankType"] = request.RerankType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQueryList))
            {
                body["subQueryList"] = request.SubQueryList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSearchParameter))
            {
                body["textSearchParameter"] = request.TextSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["topK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorSearchParameter))
            {
                body["vectorSearchParameter"] = request.VectorSearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentReference))
            {
                body["withDocumentReference"] = request.WithDocumentReference;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLibraryChatGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/run/library/chat/generation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLibraryChatGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunLibraryChatGenerationRequest
         * @return RunLibraryChatGenerationResponse
         */
        public RunLibraryChatGenerationResponse RunLibraryChatGeneration(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunLibraryChatGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取生成式对话结果
         *
         * @param request RunLibraryChatGenerationRequest
         * @return RunLibraryChatGenerationResponse
         */
        public async Task<RunLibraryChatGenerationResponse> RunLibraryChatGenerationAsync(string workspaceId, RunLibraryChatGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunLibraryChatGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 更新文档
         *
         * @param request UpdateDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDocumentResponse
         */
        public UpdateDocumentResponse UpdateDocumentWithOptions(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
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
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新文档
         *
         * @param request UpdateDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDocumentResponse
         */
        public async Task<UpdateDocumentResponse> UpdateDocumentWithOptionsAsync(string workspaceId, UpdateDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocId))
            {
                body["docId"] = request.DocId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Meta))
            {
                body["meta"] = request.Meta;
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
                Action = "UpdateDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/updateDocument",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新文档
         *
         * @param request UpdateDocumentRequest
         * @return UpdateDocumentResponse
         */
        public UpdateDocumentResponse UpdateDocument(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 更新文档
         *
         * @param request UpdateDocumentRequest
         * @return UpdateDocumentResponse
         */
        public async Task<UpdateDocumentResponse> UpdateDocumentAsync(string workspaceId, UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 更新文档库配置
         *
         * @param request UpdateLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLibraryResponse
         */
        public UpdateLibraryResponse UpdateLibraryWithOptions(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新文档库配置
         *
         * @param request UpdateLibraryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLibraryResponse
         */
        public async Task<UpdateLibraryResponse> UpdateLibraryWithOptionsAsync(string workspaceId, UpdateLibraryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexSetting))
            {
                body["indexSetting"] = request.IndexSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryName))
            {
                body["libraryName"] = request.LibraryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLibrary",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLibraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新文档库配置
         *
         * @param request UpdateLibraryRequest
         * @return UpdateLibraryResponse
         */
        public UpdateLibraryResponse UpdateLibrary(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLibraryWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 更新文档库配置
         *
         * @param request UpdateLibraryRequest
         * @return UpdateLibraryResponse
         */
        public async Task<UpdateLibraryResponse> UpdateLibraryAsync(string workspaceId, UpdateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLibraryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 上传文档到文档库
         *
         * @param request UploadDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDocumentResponse
         */
        public UploadDocumentResponse UploadDocumentWithOptions(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 上传文档到文档库
         *
         * @param request UploadDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDocumentResponse
         */
        public async Task<UploadDocumentResponse> UploadDocumentWithOptionsAsync(string workspaceId, UploadDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/api/library/document/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 上传文档到文档库
         *
         * @param request UploadDocumentRequest
         * @return UploadDocumentResponse
         */
        public UploadDocumentResponse UploadDocument(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadDocumentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 上传文档到文档库
         *
         * @param request UploadDocumentRequest
         * @return UploadDocumentResponse
         */
        public async Task<UploadDocumentResponse> UploadDocumentAsync(string workspaceId, UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadDocumentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        public UploadDocumentResponse UploadDocumentAdvance(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "DianJin",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                uploadDocumentReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadDocumentResponse uploadDocumentResp = UploadDocumentWithOptions(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

        public async Task<UploadDocumentResponse> UploadDocumentAdvanceAsync(string workspaceId, UploadDocumentAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "DianJin",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            UploadDocumentRequest uploadDocumentReq = new UploadDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, uploadDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                uploadDocumentReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            UploadDocumentResponse uploadDocumentResp = await UploadDocumentWithOptionsAsync(workspaceId, uploadDocumentReq, headers, runtime);
            return uploadDocumentResp;
        }

    }
}
