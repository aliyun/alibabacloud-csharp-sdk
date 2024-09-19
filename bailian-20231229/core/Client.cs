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
         * @param request AddCategoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCategoryResponse
         */
        public AddCategoryResponse AddCategoryWithOptions(string WorkspaceId, AddCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddCategoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCategoryResponse
         */
        public async Task<AddCategoryResponse> AddCategoryWithOptionsAsync(string WorkspaceId, AddCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddCategoryRequest
         * @return AddCategoryResponse
         */
        public AddCategoryResponse AddCategory(string WorkspaceId, AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddCategoryWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @param request AddCategoryRequest
         * @return AddCategoryResponse
         */
        public async Task<AddCategoryResponse> AddCategoryAsync(string WorkspaceId, AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddCategoryWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 将临时上传的文档导入百炼数据中心，导入成功之后会自动触发文档解析。
         *
         * @param tmpReq AddFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public AddFileResponse AddFileWithOptions(string WorkspaceId, AddFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFileShrinkRequest request = new AddFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
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
         * @param tmpReq AddFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFileResponse
         */
        public async Task<AddFileResponse> AddFileWithOptionsAsync(string WorkspaceId, AddFileRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddFileShrinkRequest request = new AddFileShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
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
         * @summary 创建并发布智能体应用
         *
         * @param tmpReq CreateAndPulishAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndPulishAgentResponse
         */
        public CreateAndPulishAgentResponse CreateAndPulishAgentWithOptions(string workspaceId, CreateAndPulishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPulishAgentShrinkRequest request = new CreateAndPulishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
                Action = "CreateAndPulishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPulishAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建并发布智能体应用
         *
         * @param tmpReq CreateAndPulishAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndPulishAgentResponse
         */
        public async Task<CreateAndPulishAgentResponse> CreateAndPulishAgentWithOptionsAsync(string workspaceId, CreateAndPulishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAndPulishAgentShrinkRequest request = new CreateAndPulishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
                Action = "CreateAndPulishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndPulishAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建并发布智能体应用
         *
         * @param request CreateAndPulishAgentRequest
         * @return CreateAndPulishAgentResponse
         */
        public CreateAndPulishAgentResponse CreateAndPulishAgent(string workspaceId, CreateAndPulishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAndPulishAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建并发布智能体应用
         *
         * @param request CreateAndPulishAgentRequest
         * @return CreateAndPulishAgentResponse
         */
        public async Task<CreateAndPulishAgentResponse> CreateAndPulishAgentAsync(string workspaceId, CreateAndPulishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAndPulishAgentWithOptionsAsync(workspaceId, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
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
         * @summary 创建Memory
         *
         * @param request CreateMemoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemoryResponse
         */
        public CreateMemoryResponse CreateMemoryWithOptions(string workspaceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建Memory
         *
         * @param request CreateMemoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemoryResponse
         */
        public async Task<CreateMemoryResponse> CreateMemoryWithOptionsAsync(string workspaceId, CreateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Memory
         *
         * @param request CreateMemoryRequest
         * @return CreateMemoryResponse
         */
        public CreateMemoryResponse CreateMemory(string workspaceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建Memory
         *
         * @param request CreateMemoryRequest
         * @return CreateMemoryResponse
         */
        public async Task<CreateMemoryResponse> CreateMemoryAsync(string workspaceId, CreateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 创建记忆Node
         *
         * @param request CreateMemoryNodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemoryNodeResponse
         */
        public CreateMemoryNodeResponse CreateMemoryNodeWithOptions(string workspaceId, string memoryId, CreateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建记忆Node
         *
         * @param request CreateMemoryNodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemoryNodeResponse
         */
        public async Task<CreateMemoryNodeResponse> CreateMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, CreateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建记忆Node
         *
         * @param request CreateMemoryNodeRequest
         * @return CreateMemoryNodeResponse
         */
        public CreateMemoryNodeResponse CreateMemoryNode(string workspaceId, string memoryId, CreateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemoryNodeWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 创建记忆Node
         *
         * @param request CreateMemoryNodeRequest
         * @return CreateMemoryNodeResponse
         */
        public async Task<CreateMemoryNodeResponse> CreateMemoryNodeAsync(string workspaceId, string memoryId, CreateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemoryNodeWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 删除智能体
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAgentResponse
         */
        public DeleteAgentResponse DeleteAgentWithOptions(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除智能体
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAgentResponse
         */
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除智能体
         *
         * @return DeleteAgentResponse
         */
        public DeleteAgentResponse DeleteAgent(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentWithOptions(workspaceId, appCode, headers, runtime);
        }

        /**
         * @summary 删除智能体
         *
         * @return DeleteAgentResponse
         */
        public async Task<DeleteAgentResponse> DeleteAgentAsync(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentWithOptionsAsync(workspaceId, appCode, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCategoryResponse
         */
        public DeleteCategoryResponse DeleteCategoryWithOptions(string CategoryId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCategoryResponse
         */
        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(string CategoryId, string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/category/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryId) + "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DeleteCategoryResponse
         */
        public DeleteCategoryResponse DeleteCategory(string CategoryId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCategoryWithOptions(CategoryId, WorkspaceId, headers, runtime);
        }

        /**
         * @return DeleteCategoryResponse
         */
        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(string CategoryId, string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCategoryWithOptionsAsync(CategoryId, WorkspaceId, headers, runtime);
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
         * @summary 删除memory
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemoryResponse
         */
        public DeleteMemoryResponse DeleteMemoryWithOptions(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除memory
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemoryResponse
         */
        public async Task<DeleteMemoryResponse> DeleteMemoryWithOptionsAsync(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除memory
         *
         * @return DeleteMemoryResponse
         */
        public DeleteMemoryResponse DeleteMemory(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryWithOptions(workspaceId, memoryId, headers, runtime);
        }

        /**
         * @summary 删除memory
         *
         * @return DeleteMemoryResponse
         */
        public async Task<DeleteMemoryResponse> DeleteMemoryAsync(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryWithOptionsAsync(workspaceId, memoryId, headers, runtime);
        }

        /**
         * @summary 删除记忆Node
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemoryNodeResponse
         */
        public DeleteMemoryNodeResponse DeleteMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除记忆Node
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemoryNodeResponse
         */
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除记忆Node
         *
         * @return DeleteMemoryNodeResponse
         */
        public DeleteMemoryNodeResponse DeleteMemoryNode(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /**
         * @summary 删除记忆Node
         *
         * @return DeleteMemoryNodeResponse
         */
        public async Task<DeleteMemoryNodeResponse> DeleteMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
         * @summary 获取memory
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemoryResponse
         */
        public GetMemoryResponse GetMemoryWithOptions(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取memory
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemoryResponse
         */
        public async Task<GetMemoryResponse> GetMemoryWithOptionsAsync(string workspaceId, string memoryId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取memory
         *
         * @return GetMemoryResponse
         */
        public GetMemoryResponse GetMemory(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryWithOptions(workspaceId, memoryId, headers, runtime);
        }

        /**
         * @summary 获取memory
         *
         * @return GetMemoryResponse
         */
        public async Task<GetMemoryResponse> GetMemoryAsync(string workspaceId, string memoryId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryWithOptionsAsync(workspaceId, memoryId, headers, runtime);
        }

        /**
         * @summary 获取记忆Node
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemoryNodeResponse
         */
        public GetMemoryNodeResponse GetMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取记忆Node
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemoryNodeResponse
         */
        public async Task<GetMemoryNodeResponse> GetMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取记忆Node
         *
         * @return GetMemoryNodeResponse
         */
        public GetMemoryNodeResponse GetMemoryNode(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /**
         * @summary 获取记忆Node
         *
         * @return GetMemoryNodeResponse
         */
        public async Task<GetMemoryNodeResponse> GetMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, headers, runtime);
        }

        /**
         * @summary 获取发布态智能体应用
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublishedAgentResponse
         */
        public GetPublishedAgentResponse GetPublishedAgentWithOptions(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishedAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取发布态智能体应用
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublishedAgentResponse
         */
        public async Task<GetPublishedAgentResponse> GetPublishedAgentWithOptionsAsync(string workspaceId, string appCode, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublishedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取发布态智能体应用
         *
         * @return GetPublishedAgentResponse
         */
        public GetPublishedAgentResponse GetPublishedAgent(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPublishedAgentWithOptions(workspaceId, appCode, headers, runtime);
        }

        /**
         * @summary 获取发布态智能体应用
         *
         * @return GetPublishedAgentResponse
         */
        public async Task<GetPublishedAgentResponse> GetPublishedAgentAsync(string workspaceId, string appCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPublishedAgentWithOptionsAsync(workspaceId, appCode, headers, runtime);
        }

        /**
         * @summary ListCategory
         *
         * @param request ListCategoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategoryResponse
         */
        public ListCategoryResponse ListCategoryWithOptions(string WorkspaceId, ListCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/categories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListCategory
         *
         * @param request ListCategoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCategoryResponse
         */
        public async Task<ListCategoryResponse> ListCategoryWithOptionsAsync(string WorkspaceId, ListCategoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryType))
            {
                body["CategoryType"] = request.CategoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryId))
            {
                body["ParentCategoryId"] = request.ParentCategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCategory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/categories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListCategory
         *
         * @param request ListCategoryRequest
         * @return ListCategoryResponse
         */
        public ListCategoryResponse ListCategory(string WorkspaceId, ListCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCategoryWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary ListCategory
         *
         * @param request ListCategoryRequest
         * @return ListCategoryResponse
         */
        public async Task<ListCategoryResponse> ListCategoryAsync(string WorkspaceId, ListCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCategoryWithOptionsAsync(WorkspaceId, request, headers, runtime);
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
         * @summary 获取文档列表
         *
         * @param request ListFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFileResponse
         */
        public ListFileResponse ListFileWithOptions(string WorkspaceId, ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档列表
         *
         * @param request ListFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFileResponse
         */
        public async Task<ListFileResponse> ListFileWithOptionsAsync(string WorkspaceId, ListFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFile",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/datacenter/files",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档列表
         *
         * @param request ListFileRequest
         * @return ListFileResponse
         */
        public ListFileResponse ListFile(string WorkspaceId, ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取文档列表
         *
         * @param request ListFileRequest
         * @return ListFileResponse
         */
        public async Task<ListFileResponse> ListFileAsync(string WorkspaceId, ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
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
         * @summary 获取memory
         *
         * @param request ListMemoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMemoriesResponse
         */
        public ListMemoriesResponse ListMemoriesWithOptions(string workspaceId, ListMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMemories",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取memory
         *
         * @param request ListMemoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMemoriesResponse
         */
        public async Task<ListMemoriesResponse> ListMemoriesWithOptionsAsync(string workspaceId, ListMemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMemories",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取memory
         *
         * @param request ListMemoriesRequest
         * @return ListMemoriesResponse
         */
        public ListMemoriesResponse ListMemories(string workspaceId, ListMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoriesWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取memory
         *
         * @param request ListMemoriesRequest
         * @return ListMemoriesResponse
         */
        public async Task<ListMemoriesResponse> ListMemoriesAsync(string workspaceId, ListMemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoriesWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 获取记忆Node列表
         *
         * @param request ListMemoryNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMemoryNodesResponse
         */
        public ListMemoryNodesResponse ListMemoryNodesWithOptions(string workspaceId, string memoryId, ListMemoryNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMemoryNodes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取记忆Node列表
         *
         * @param request ListMemoryNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMemoryNodesResponse
         */
        public async Task<ListMemoryNodesResponse> ListMemoryNodesWithOptionsAsync(string workspaceId, string memoryId, ListMemoryNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMemoryNodes",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMemoryNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取记忆Node列表
         *
         * @param request ListMemoryNodesRequest
         * @return ListMemoryNodesResponse
         */
        public ListMemoryNodesResponse ListMemoryNodes(string workspaceId, string memoryId, ListMemoryNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMemoryNodesWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 获取记忆Node列表
         *
         * @param request ListMemoryNodesRequest
         * @return ListMemoryNodesResponse
         */
        public async Task<ListMemoryNodesResponse> ListMemoryNodesAsync(string workspaceId, string memoryId, ListMemoryNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMemoryNodesWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 查询已发布的智能体应用列表
         *
         * @param request ListPublishedAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedAgentResponse
         */
        public ListPublishedAgentResponse ListPublishedAgentWithOptions(string workspaceId, ListPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
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
                Action = "ListPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询已发布的智能体应用列表
         *
         * @param request ListPublishedAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedAgentResponse
         */
        public async Task<ListPublishedAgentResponse> ListPublishedAgentWithOptionsAsync(string workspaceId, ListPublishedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
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
                Action = "ListPublishedAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询已发布的智能体应用列表
         *
         * @param request ListPublishedAgentRequest
         * @return ListPublishedAgentResponse
         */
        public ListPublishedAgentResponse ListPublishedAgent(string workspaceId, ListPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询已发布的智能体应用列表
         *
         * @param request ListPublishedAgentRequest
         * @return ListPublishedAgentResponse
         */
        public async Task<ListPublishedAgentResponse> ListPublishedAgentAsync(string workspaceId, ListPublishedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedAgentWithOptionsAsync(workspaceId, request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Images))
            {
                request.ImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Images, "Images", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchFilters))
            {
                request.SearchFiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchFilters, "SearchFilters", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesShrink))
            {
                query["Images"] = request.ImagesShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFiltersShrink))
            {
                query["SearchFilters"] = request.SearchFiltersShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Images))
            {
                request.ImagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Images, "Images", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rerank))
            {
                request.RerankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rerank, "Rerank", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rewrite))
            {
                request.RewriteShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rewrite, "Rewrite", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SearchFilters))
            {
                request.SearchFiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SearchFilters, "SearchFilters", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesShrink))
            {
                query["Images"] = request.ImagesShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFiltersShrink))
            {
                query["SearchFilters"] = request.SearchFiltersShrink;
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

        /**
         * @summary 更新并发布智能体应用
         *
         * @param tmpReq UpdateAndPublishAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAndPublishAgentResponse
         */
        public UpdateAndPublishAgentResponse UpdateAndPublishAgentWithOptions(string workspaceId, string appCode, UpdateAndPublishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentShrinkRequest request = new UpdateAndPublishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
                Action = "UpdateAndPublishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新并发布智能体应用
         *
         * @param tmpReq UpdateAndPublishAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAndPublishAgentResponse
         */
        public async Task<UpdateAndPublishAgentResponse> UpdateAndPublishAgentWithOptionsAsync(string workspaceId, string appCode, UpdateAndPublishAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAndPublishAgentShrinkRequest request = new UpdateAndPublishAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationConfig))
            {
                request.ApplicationConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationConfig, "applicationConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigShrink))
            {
                body["applicationConfig"] = request.ApplicationConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
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
                Action = "UpdateAndPublishAgent",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/application/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appCode),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAndPublishAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新并发布智能体应用
         *
         * @param request UpdateAndPublishAgentRequest
         * @return UpdateAndPublishAgentResponse
         */
        public UpdateAndPublishAgentResponse UpdateAndPublishAgent(string workspaceId, string appCode, UpdateAndPublishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAndPublishAgentWithOptions(workspaceId, appCode, request, headers, runtime);
        }

        /**
         * @summary 更新并发布智能体应用
         *
         * @param request UpdateAndPublishAgentRequest
         * @return UpdateAndPublishAgentResponse
         */
        public async Task<UpdateAndPublishAgentResponse> UpdateAndPublishAgentAsync(string workspaceId, string appCode, UpdateAndPublishAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAndPublishAgentWithOptionsAsync(workspaceId, appCode, request, headers, runtime);
        }

        /**
         * @summary 更新memory
         *
         * @param request UpdateMemoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemoryResponse
         */
        public UpdateMemoryResponse UpdateMemoryWithOptions(string workspaceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新memory
         *
         * @param request UpdateMemoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemoryResponse
         */
        public async Task<UpdateMemoryResponse> UpdateMemoryWithOptionsAsync(string workspaceId, string memoryId, UpdateMemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemory",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新memory
         *
         * @param request UpdateMemoryRequest
         * @return UpdateMemoryResponse
         */
        public UpdateMemoryResponse UpdateMemory(string workspaceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryWithOptions(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 更新memory
         *
         * @param request UpdateMemoryRequest
         * @return UpdateMemoryResponse
         */
        public async Task<UpdateMemoryResponse> UpdateMemoryAsync(string workspaceId, string memoryId, UpdateMemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryWithOptionsAsync(workspaceId, memoryId, request, headers, runtime);
        }

        /**
         * @summary 更新记忆Node
         *
         * @param request UpdateMemoryNodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemoryNodeResponse
         */
        public UpdateMemoryNodeResponse UpdateMemoryNodeWithOptions(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新记忆Node
         *
         * @param request UpdateMemoryNodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemoryNodeResponse
         */
        public async Task<UpdateMemoryNodeResponse> UpdateMemoryNodeWithOptionsAsync(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMemoryNode",
                Version = "2023-12-29",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId) + "/memoryNodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryNodeId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemoryNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新记忆Node
         *
         * @param request UpdateMemoryNodeRequest
         * @return UpdateMemoryNodeResponse
         */
        public UpdateMemoryNodeResponse UpdateMemoryNode(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMemoryNodeWithOptions(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

        /**
         * @summary 更新记忆Node
         *
         * @param request UpdateMemoryNodeRequest
         * @return UpdateMemoryNodeResponse
         */
        public async Task<UpdateMemoryNodeResponse> UpdateMemoryNodeAsync(string workspaceId, string memoryId, string memoryNodeId, UpdateMemoryNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMemoryNodeWithOptionsAsync(workspaceId, memoryId, memoryNodeId, request, headers, runtime);
        }

    }
}
