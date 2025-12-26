// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PAILangStudio20240710.Models;

namespace AlibabaCloud.SDK.PAILangStudio20240710
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pailangstudio", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBaseWithOptions(CreateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfig))
            {
                body["ChunkConfig"] = request.ChunkConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingConfig))
            {
                body["EmbeddingConfig"] = request.EmbeddingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexColumnConfig))
            {
                body["IndexColumnConfig"] = request.IndexColumnConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseType))
            {
                body["KnowledgeBaseType"] = request.KnowledgeBaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataConfig))
            {
                body["MetaDataConfig"] = request.MetaDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputDir))
            {
                body["OutputDir"] = request.OutputDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                body["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorDBConfig))
            {
                body["VectorDBConfig"] = request.VectorDBConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseWithOptionsAsync(CreateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkConfig))
            {
                body["ChunkConfig"] = request.ChunkConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSources))
            {
                body["DataSources"] = request.DataSources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingConfig))
            {
                body["EmbeddingConfig"] = request.EmbeddingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexColumnConfig))
            {
                body["IndexColumnConfig"] = request.IndexColumnConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseType))
            {
                body["KnowledgeBaseType"] = request.KnowledgeBaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataConfig))
            {
                body["MetaDataConfig"] = request.MetaDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputDir))
            {
                body["OutputDir"] = request.OutputDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                body["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorDBConfig))
            {
                body["VectorDBConfig"] = request.VectorDBConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public CreateKnowledgeBaseResponse CreateKnowledgeBase(CreateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseResponse> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseJobResponse
        /// </returns>
        public CreateKnowledgeBaseJobResponse CreateKnowledgeBaseJobWithOptions(string KnowledgeBaseId, CreateKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpecs))
            {
                body["EcsSpecs"] = request.EcsSpecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingConfig))
            {
                body["EmbeddingConfig"] = request.EmbeddingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                body["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeInSeconds))
            {
                body["MaxRunningTimeInSeconds"] = request.MaxRunningTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseJobResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseJobResponse> CreateKnowledgeBaseJobWithOptionsAsync(string KnowledgeBaseId, CreateKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsSpecs))
            {
                body["EcsSpecs"] = request.EcsSpecs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmbeddingConfig))
            {
                body["EmbeddingConfig"] = request.EmbeddingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                body["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRunningTimeInSeconds))
            {
                body["MaxRunningTimeInSeconds"] = request.MaxRunningTimeInSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpc))
            {
                body["UserVpc"] = request.UserVpc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKnowledgeBaseJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseJobResponse
        /// </returns>
        public CreateKnowledgeBaseJobResponse CreateKnowledgeBaseJob(string KnowledgeBaseId, CreateKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKnowledgeBaseJobWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKnowledgeBaseJobResponse
        /// </returns>
        public async Task<CreateKnowledgeBaseJobResponse> CreateKnowledgeBaseJobAsync(string KnowledgeBaseId, CreateKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKnowledgeBaseJobWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBaseWithOptions(string KnowledgeBaseId, DeleteKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseWithOptionsAsync(string KnowledgeBaseId, DeleteKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public DeleteKnowledgeBaseResponse DeleteKnowledgeBase(string KnowledgeBaseId, DeleteKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKnowledgeBaseWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseResponse> DeleteKnowledgeBaseAsync(string KnowledgeBaseId, DeleteKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKnowledgeBaseWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseJobResponse
        /// </returns>
        public DeleteKnowledgeBaseJobResponse DeleteKnowledgeBaseJobWithOptions(string KnowledgeBaseId, string KnowledgeBaseJobId, DeleteKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseJobResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseJobResponse> DeleteKnowledgeBaseJobWithOptionsAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, DeleteKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeBaseJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseJobResponse
        /// </returns>
        public DeleteKnowledgeBaseJobResponse DeleteKnowledgeBaseJob(string KnowledgeBaseId, string KnowledgeBaseJobId, DeleteKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKnowledgeBaseJobWithOptions(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKnowledgeBaseJobResponse
        /// </returns>
        public async Task<DeleteKnowledgeBaseJobResponse> DeleteKnowledgeBaseJobAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, DeleteKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKnowledgeBaseJobWithOptionsAsync(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBaseWithOptions(string KnowledgeBaseId, GetKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseWithOptionsAsync(string KnowledgeBaseId, GetKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public GetKnowledgeBaseResponse GetKnowledgeBase(string KnowledgeBaseId, GetKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKnowledgeBaseWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseResponse
        /// </returns>
        public async Task<GetKnowledgeBaseResponse> GetKnowledgeBaseAsync(string KnowledgeBaseId, GetKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKnowledgeBaseWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseJobResponse
        /// </returns>
        public GetKnowledgeBaseJobResponse GetKnowledgeBaseJobWithOptions(string KnowledgeBaseId, string KnowledgeBaseJobId, GetKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseJobResponse
        /// </returns>
        public async Task<GetKnowledgeBaseJobResponse> GetKnowledgeBaseJobWithOptionsAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, GetKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeBaseJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseJobResponse
        /// </returns>
        public GetKnowledgeBaseJobResponse GetKnowledgeBaseJob(string KnowledgeBaseId, string KnowledgeBaseJobId, GetKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKnowledgeBaseJobWithOptions(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKnowledgeBaseJobResponse
        /// </returns>
        public async Task<GetKnowledgeBaseJobResponse> GetKnowledgeBaseJobAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, GetKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKnowledgeBaseJobWithOptionsAsync(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseJobsResponse
        /// </returns>
        public ListKnowledgeBaseJobsResponse ListKnowledgeBaseJobsWithOptions(string KnowledgeBaseId, ListKnowledgeBaseJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                query["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseJobId))
            {
                query["KnowledgeBaseJobId"] = request.KnowledgeBaseJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBaseJobs",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseJobsResponse
        /// </returns>
        public async Task<ListKnowledgeBaseJobsResponse> ListKnowledgeBaseJobsWithOptionsAsync(string KnowledgeBaseId, ListKnowledgeBaseJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                query["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseJobId))
            {
                query["KnowledgeBaseJobId"] = request.KnowledgeBaseJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBaseJobs",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBaseJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseJobsResponse
        /// </returns>
        public ListKnowledgeBaseJobsResponse ListKnowledgeBaseJobs(string KnowledgeBaseId, ListKnowledgeBaseJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKnowledgeBaseJobsWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBaseJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBaseJobsResponse
        /// </returns>
        public async Task<ListKnowledgeBaseJobsResponse> ListKnowledgeBaseJobsAsync(string KnowledgeBaseId, ListKnowledgeBaseJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKnowledgeBaseJobsWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBasesWithOptions(ListKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseType))
            {
                query["KnowledgeBaseType"] = request.KnowledgeBaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesWithOptionsAsync(ListKnowledgeBasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseType))
            {
                query["KnowledgeBaseType"] = request.KnowledgeBaseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKnowledgeBasesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取知识库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKnowledgeBasesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public RetrieveKnowledgeBaseResponse RetrieveKnowledgeBaseWithOptions(string KnowledgeBaseId, RetrieveKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridStrategyConfig))
            {
                body["HybridStrategyConfig"] = request.HybridStrategyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataFilterConditions))
            {
                body["MetaDataFilterConditions"] = request.MetaDataFilterConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                body["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankConfig))
            {
                body["RerankConfig"] = request.RerankConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteConfig))
            {
                body["RewriteConfig"] = request.RewriteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScoreThreshold))
            {
                body["ScoreThreshold"] = request.ScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/action/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public async Task<RetrieveKnowledgeBaseResponse> RetrieveKnowledgeBaseWithOptionsAsync(string KnowledgeBaseId, RetrieveKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridStrategyConfig))
            {
                body["HybridStrategyConfig"] = request.HybridStrategyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataFilterConditions))
            {
                body["MetaDataFilterConditions"] = request.MetaDataFilterConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                body["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankConfig))
            {
                body["RerankConfig"] = request.RerankConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RewriteConfig))
            {
                body["RewriteConfig"] = request.RewriteConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScoreThreshold))
            {
                body["ScoreThreshold"] = request.ScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/action/retrieve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public RetrieveKnowledgeBaseResponse RetrieveKnowledgeBase(string KnowledgeBaseId, RetrieveKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetrieveKnowledgeBaseWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public async Task<RetrieveKnowledgeBaseResponse> RetrieveKnowledgeBaseAsync(string KnowledgeBaseId, RetrieveKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetrieveKnowledgeBaseWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBaseWithOptions(string KnowledgeBaseId, UpdateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdateConfig))
            {
                body["AutoUpdateConfig"] = request.AutoUpdateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindRuntime))
            {
                body["BindRuntime"] = request.BindRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataConfig))
            {
                body["MetaDataConfig"] = request.MetaDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                body["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseWithOptionsAsync(string KnowledgeBaseId, UpdateKnowledgeBaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdateConfig))
            {
                body["AutoUpdateConfig"] = request.AutoUpdateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindRuntime))
            {
                body["BindRuntime"] = request.BindRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaDataConfig))
            {
                body["MetaDataConfig"] = request.MetaDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeId))
            {
                body["RuntimeId"] = request.RuntimeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBase",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBase(string KnowledgeBaseId, UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseWithOptions(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(string KnowledgeBaseId, UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseWithOptionsAsync(KnowledgeBaseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseJobResponse
        /// </returns>
        public UpdateKnowledgeBaseJobResponse UpdateKnowledgeBaseJobWithOptions(string KnowledgeBaseId, string KnowledgeBaseJobId, UpdateKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseJobResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseJobResponse> UpdateKnowledgeBaseJobWithOptionsAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, UpdateKnowledgeBaseJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKnowledgeBaseJob",
                Version = "2024-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/v1/langstudio/knowledgebases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseId) + "/knowledgebasejobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KnowledgeBaseJobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseJobResponse
        /// </returns>
        public UpdateKnowledgeBaseJobResponse UpdateKnowledgeBaseJob(string KnowledgeBaseId, string KnowledgeBaseJobId, UpdateKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKnowledgeBaseJobWithOptions(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新知识库任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseJobResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseJobResponse> UpdateKnowledgeBaseJobAsync(string KnowledgeBaseId, string KnowledgeBaseJobId, UpdateKnowledgeBaseJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKnowledgeBaseJobWithOptionsAsync(KnowledgeBaseId, KnowledgeBaseJobId, request, headers, runtime);
        }

    }
}
