// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Bailian20231229.Models;

namespace AlibabaCloud.SDK.Bailian20231229
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("bailian", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 将临时上传的文档导入百炼数据中心，导入成功之后会自动触发文档解析。
         *
         * @param request AddFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public AddFileResponse AddFileWithOptions(string WorkspaceId, AddFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaseId))
            {
                body["LeaseId"] = request.LeaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 将临时上传的文档导入百炼数据中心，导入成功之后会自动触发文档解析。
         *
         * @param request AddFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public async Task<AddFileResponse> AddFileWithOptionsAsync(string WorkspaceId, AddFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaseId))
            {
                body["LeaseId"] = request.LeaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parser))
            {
                body["Parser"] = request.Parser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 将临时上传的文档导入百炼数据中心，导入成功之后会自动触发文档解析。
         *
         * @param request AddFileRequest
         * @return AddFileResponse
         */
        public AddFileResponse AddFile(string WorkspaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 将临时上传的文档导入百炼数据中心，导入成功之后会自动触发文档解析。
         *
         * @param request AddFileRequest
         * @return AddFileResponse
         */
        public async Task<AddFileResponse> AddFileAsync(string WorkspaceId, AddFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 请求文档上传租约，进行文档上传。
         *
         * @param request ApplyFileUploadLeaseRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyFileUploadLeaseResponse
         */
        public ApplyFileUploadLeaseResponse ApplyFileUploadLeaseWithOptions(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                body["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyFileUploadLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFileUploadLeaseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 请求文档上传租约，进行文档上传。
         *
         * @param request ApplyFileUploadLeaseRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyFileUploadLeaseResponse
         */
        public async Task<ApplyFileUploadLeaseResponse> ApplyFileUploadLeaseWithOptionsAsync(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                body["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SizeInBytes))
            {
                body["SizeInBytes"] = request.SizeInBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyFileUploadLease",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyFileUploadLeaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 请求文档上传租约，进行文档上传。
         *
         * @param request ApplyFileUploadLeaseRequest
         * @return ApplyFileUploadLeaseResponse
         */
        public ApplyFileUploadLeaseResponse ApplyFileUploadLease(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyFileUploadLeaseWithOptions(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 请求文档上传租约，进行文档上传。
         *
         * @param request ApplyFileUploadLeaseRequest
         * @return ApplyFileUploadLeaseResponse
         */
        public async Task<ApplyFileUploadLeaseResponse> ApplyFileUploadLeaseAsync(string CategoryId, string WorkspaceId, ApplyFileUploadLeaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyFileUploadLeaseWithOptionsAsync(CategoryId, WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建并运行pipeline
         *
         * @param tmpReq CreateIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndexWithOptions(string WorkspaceId, CreateIndexRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIndexShrinkRequest request = new CreateIndexShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModelName))
            {
                query["EmbeddingModelName"] = request.EmbeddingModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                query["RerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkInstanceId))
            {
                query["SinkInstanceId"] = request.SinkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkRegion))
            {
                query["SinkRegion"] = request.SinkRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkType))
            {
                query["SinkType"] = request.SinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建并运行pipeline
         *
         * @param tmpReq CreateIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexWithOptionsAsync(string WorkspaceId, CreateIndexRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIndexShrinkRequest request = new CreateIndexShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Columns))
            {
                request.ColumnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Columns, "Columns", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                query["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnsShrink))
            {
                query["Columns"] = request.ColumnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingModelName))
            {
                query["EmbeddingModelName"] = request.EmbeddingModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverlapSize))
            {
                query["OverlapSize"] = request.OverlapSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankModelName))
            {
                query["RerankModelName"] = request.RerankModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separator))
            {
                query["Separator"] = request.Separator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkInstanceId))
            {
                query["SinkInstanceId"] = request.SinkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkRegion))
            {
                query["SinkRegion"] = request.SinkRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkType))
            {
                query["SinkType"] = request.SinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建并运行pipeline
         *
         * @param request CreateIndexRequest
         * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndex(string WorkspaceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建并运行pipeline
         *
         * @param request CreateIndexRequest
         * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexAsync(string WorkspaceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除文档
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFileWithOptions(string FileId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除文档
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string FileId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除文档
         *
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFile(string FileId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(FileId, WorkspaceId, headers, runtime);
        }

        /**
         * @summary 删除文档
         *
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileAsync(string FileId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(FileId, WorkspaceId, headers, runtime);
        }

        /**
         * @summary 删除Index
         *
         * @param request DeleteIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndexWithOptions(string WorkspaceId, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除Index
         *
         * @param request DeleteIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexWithOptionsAsync(string WorkspaceId, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除Index
         *
         * @param request DeleteIndexRequest
         * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndex(string WorkspaceId, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除Index
         *
         * @param request DeleteIndexRequest
         * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexAsync(string WorkspaceId, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除index doc
         *
         * @param tmpReq DeleteIndexDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIndexDocumentResponse
         */
        public DeleteIndexDocumentResponse DeleteIndexDocumentWithOptions(string WorkspaceId, DeleteIndexDocumentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteIndexDocumentShrinkRequest request = new DeleteIndexDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexDocument",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete_index_document",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexDocumentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除index doc
         *
         * @param tmpReq DeleteIndexDocumentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIndexDocumentResponse
         */
        public async Task<DeleteIndexDocumentResponse> DeleteIndexDocumentWithOptionsAsync(string WorkspaceId, DeleteIndexDocumentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteIndexDocumentShrinkRequest request = new DeleteIndexDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexDocument",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/delete_index_document",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除index doc
         *
         * @param request DeleteIndexDocumentRequest
         * @return DeleteIndexDocumentResponse
         */
        public DeleteIndexDocumentResponse DeleteIndexDocument(string WorkspaceId, DeleteIndexDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexDocumentWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 删除index doc
         *
         * @param request DeleteIndexDocumentRequest
         * @return DeleteIndexDocumentResponse
         */
        public async Task<DeleteIndexDocumentResponse> DeleteIndexDocumentAsync(string WorkspaceId, DeleteIndexDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexDocumentWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档基本信息，包括文档名称、类型、状态等。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileResponse
         */
        public DescribeFileResponse DescribeFileWithOptions(string WorkspaceId, string FileId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档基本信息，包括文档名称、类型、状态等。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileResponse
         */
        public async Task<DescribeFileResponse> DescribeFileWithOptionsAsync(string WorkspaceId, string FileId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/file/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FileId) + "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档基本信息，包括文档名称、类型、状态等。
         *
         * @return DescribeFileResponse
         */
        public DescribeFileResponse DescribeFile(string WorkspaceId, string FileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFileWithOptions(WorkspaceId, FileId, headers, runtime);
        }

        /**
         * @summary 获取文档基本信息，包括文档名称、类型、状态等。
         *
         * @return DescribeFileResponse
         */
        public async Task<DescribeFileResponse> DescribeFileAsync(string WorkspaceId, string FileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFileWithOptionsAsync(WorkspaceId, FileId, headers, runtime);
        }

        /**
         * @summary 获取Index运行状态
         *
         * @param request GetIndexJobStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexJobStatusResponse
         */
        public GetIndexJobStatusResponse GetIndexJobStatusWithOptions(string WorkspaceId, GetIndexJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexJobStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/job/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Index运行状态
         *
         * @param request GetIndexJobStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexJobStatusResponse
         */
        public async Task<GetIndexJobStatusResponse> GetIndexJobStatusWithOptionsAsync(string WorkspaceId, GetIndexJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexJobStatus",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/job/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Index运行状态
         *
         * @param request GetIndexJobStatusRequest
         * @return GetIndexJobStatusResponse
         */
        public GetIndexJobStatusResponse GetIndexJobStatus(string WorkspaceId, GetIndexJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexJobStatusWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取Index运行状态
         *
         * @param request GetIndexJobStatusRequest
         * @return GetIndexJobStatusResponse
         */
        public async Task<GetIndexJobStatusResponse> GetIndexJobStatusAsync(string WorkspaceId, GetIndexJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexJobStatusWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary Chunk
         *
         * @param request ListChunksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChunksResponse
         */
        public ListChunksResponse ListChunksWithOptions(string WorkspaceId, ListChunksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filed))
            {
                body["Filed"] = request.Filed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                body["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_chunks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Chunk
         *
         * @param request ListChunksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChunksResponse
         */
        public async Task<ListChunksResponse> ListChunksWithOptionsAsync(string WorkspaceId, ListChunksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filed))
            {
                body["Filed"] = request.Filed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                body["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChunks",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_chunks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Chunk
         *
         * @param request ListChunksRequest
         * @return ListChunksResponse
         */
        public ListChunksResponse ListChunks(string WorkspaceId, ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChunksWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary Chunk
         *
         * @param request ListChunksRequest
         * @return ListChunksResponse
         */
        public async Task<ListChunksResponse> ListChunksAsync(string WorkspaceId, ListChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChunksWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询Index文件
         *
         * @param request ListIndexDocumentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndexDocumentsResponse
         */
        public ListIndexDocumentsResponse ListIndexDocumentsWithOptions(string WorkspaceId, ListIndexDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexDocuments",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_documents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询Index文件
         *
         * @param request ListIndexDocumentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndexDocumentsResponse
         */
        public async Task<ListIndexDocumentsResponse> ListIndexDocumentsWithOptionsAsync(string WorkspaceId, ListIndexDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                query["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentStatus))
            {
                query["DocumentStatus"] = request.DocumentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexDocuments",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_index_documents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询Index文件
         *
         * @param request ListIndexDocumentsRequest
         * @return ListIndexDocumentsResponse
         */
        public ListIndexDocumentsResponse ListIndexDocuments(string WorkspaceId, ListIndexDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexDocumentsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询Index文件
         *
         * @param request ListIndexDocumentsRequest
         * @return ListIndexDocumentsResponse
         */
        public async Task<ListIndexDocumentsResponse> ListIndexDocumentsAsync(string WorkspaceId, ListIndexDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexDocumentsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询pipeline
         *
         * @param request ListIndicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndicesResponse
         */
        public ListIndicesResponse ListIndicesWithOptions(string WorkspaceId, ListIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["IndexName"] = request.IndexName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询pipeline
         *
         * @param request ListIndicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndicesResponse
         */
        public async Task<ListIndicesResponse> ListIndicesWithOptionsAsync(string WorkspaceId, ListIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["IndexName"] = request.IndexName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/list_indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询pipeline
         *
         * @param request ListIndicesRequest
         * @return ListIndicesResponse
         */
        public ListIndicesResponse ListIndices(string WorkspaceId, ListIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndicesWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询pipeline
         *
         * @param request ListIndicesRequest
         * @return ListIndicesResponse
         */
        public async Task<ListIndicesResponse> ListIndicesAsync(string WorkspaceId, ListIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndicesWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 召回测试
         *
         * @param tmpReq RetrieveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveResponse
         */
        public RetrieveResponse RetrieveWithOptions(string WorkspaceId, RetrieveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RetrieveShrinkRequest request = new RetrieveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReranking))
            {
                query["EnableReranking"] = request.EnableReranking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankShrink))
            {
                query["Rerank"] = request.RerankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankTopN))
            {
                query["RerankTopN"] = request.RerankTopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteShrink))
            {
                query["Rewrite"] = request.RewriteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveRetrieverHistory))
            {
                query["SaveRetrieverHistory"] = request.SaveRetrieverHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Retrieve",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 召回测试
         *
         * @param tmpReq RetrieveRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveResponse
         */
        public async Task<RetrieveResponse> RetrieveWithOptionsAsync(string WorkspaceId, RetrieveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RetrieveShrinkRequest request = new RetrieveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DenseSimilarityTopK))
            {
                query["DenseSimilarityTopK"] = request.DenseSimilarityTopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReranking))
            {
                query["EnableReranking"] = request.EnableReranking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRewrite))
            {
                query["EnableRewrite"] = request.EnableRewrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankShrink))
            {
                query["Rerank"] = request.RerankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankMinScore))
            {
                query["RerankMinScore"] = request.RerankMinScore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankTopN))
            {
                query["RerankTopN"] = request.RerankTopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteShrink))
            {
                query["Rewrite"] = request.RewriteShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveRetrieverHistory))
            {
                query["SaveRetrieverHistory"] = request.SaveRetrieverHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SparseSimilarityTopK))
            {
                query["SparseSimilarityTopK"] = request.SparseSimilarityTopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Retrieve",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 召回测试
         *
         * @param request RetrieveRequest
         * @return RetrieveResponse
         */
        public RetrieveResponse Retrieve(string WorkspaceId, RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetrieveWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 召回测试
         *
         * @param request RetrieveRequest
         * @return RetrieveResponse
         */
        public async Task<RetrieveResponse> RetrieveAsync(string WorkspaceId, RetrieveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetrieveWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 知识索引
         *
         * @param tmpReq SubmitIndexAddDocumentsJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIndexAddDocumentsJobResponse
         */
        public SubmitIndexAddDocumentsJobResponse SubmitIndexAddDocumentsJobWithOptions(string WorkspaceId, SubmitIndexAddDocumentsJobRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIndexAddDocumentsJobShrinkRequest request = new SubmitIndexAddDocumentsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexAddDocumentsJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/add_documents_to_index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexAddDocumentsJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 知识索引
         *
         * @param tmpReq SubmitIndexAddDocumentsJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIndexAddDocumentsJobResponse
         */
        public async Task<SubmitIndexAddDocumentsJobResponse> SubmitIndexAddDocumentsJobWithOptionsAsync(string WorkspaceId, SubmitIndexAddDocumentsJobRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIndexAddDocumentsJobShrinkRequest request = new SubmitIndexAddDocumentsJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CategoryIds))
            {
                request.CategoryIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CategoryIds, "CategoryIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentIds))
            {
                request.DocumentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentIds, "DocumentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryIdsShrink))
            {
                query["CategoryIds"] = request.CategoryIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIdsShrink))
            {
                query["DocumentIds"] = request.DocumentIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexAddDocumentsJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/add_documents_to_index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexAddDocumentsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 知识索引
         *
         * @param request SubmitIndexAddDocumentsJobRequest
         * @return SubmitIndexAddDocumentsJobResponse
         */
        public SubmitIndexAddDocumentsJobResponse SubmitIndexAddDocumentsJob(string WorkspaceId, SubmitIndexAddDocumentsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitIndexAddDocumentsJobWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 知识索引
         *
         * @param request SubmitIndexAddDocumentsJobRequest
         * @return SubmitIndexAddDocumentsJobResponse
         */
        public async Task<SubmitIndexAddDocumentsJobResponse> SubmitIndexAddDocumentsJobAsync(string WorkspaceId, SubmitIndexAddDocumentsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitIndexAddDocumentsJobWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 提交索引任务
         *
         * @param request SubmitIndexJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIndexJobResponse
         */
        public SubmitIndexJobResponse SubmitIndexJobWithOptions(string WorkspaceId, SubmitIndexJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/submit_index_job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交索引任务
         *
         * @param request SubmitIndexJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIndexJobResponse
         */
        public async Task<SubmitIndexJobResponse> SubmitIndexJobWithOptionsAsync(string WorkspaceId, SubmitIndexJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexId))
            {
                query["IndexId"] = request.IndexId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIndexJob",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/index/submit_index_job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIndexJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交索引任务
         *
         * @param request SubmitIndexJobRequest
         * @return SubmitIndexJobResponse
         */
        public SubmitIndexJobResponse SubmitIndexJob(string WorkspaceId, SubmitIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitIndexJobWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 提交索引任务
         *
         * @param request SubmitIndexJobRequest
         * @return SubmitIndexJobResponse
         */
        public async Task<SubmitIndexJobResponse> SubmitIndexJobAsync(string WorkspaceId, SubmitIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitIndexJobWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

    }
}
