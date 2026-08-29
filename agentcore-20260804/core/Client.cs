// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentCore20260804.Models;

namespace AlibabaCloud.SDK.AgentCore20260804
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentcore", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>批量删除模型</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteModelsResponse
        /// </returns>
        public BatchDeleteModelsResponse BatchDeleteModelsWithOptions(string workspaceId, BatchDeleteModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteModelsShrinkRequest request = new BatchDeleteModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/actions/batch-delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除模型</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchDeleteModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteModelsResponse
        /// </returns>
        public async Task<BatchDeleteModelsResponse> BatchDeleteModelsWithOptionsAsync(string workspaceId, BatchDeleteModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteModelsShrinkRequest request = new BatchDeleteModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/actions/batch-delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteModelsResponse
        /// </returns>
        public BatchDeleteModelsResponse BatchDeleteModels(string workspaceId, BatchDeleteModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteModelsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteModelsResponse
        /// </returns>
        public async Task<BatchDeleteModelsResponse> BatchDeleteModelsAsync(string workspaceId, BatchDeleteModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteModelsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// BatchUploadSkillsViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUploadSkillsViaOssResponse
        /// </returns>
        public BatchUploadSkillsViaOssResponse BatchUploadSkillsViaOssWithOptions(string workspaceId, BatchUploadSkillsViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadSkillsViaOssShrinkRequest request = new BatchUploadSkillsViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadSkillsViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/batch-upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadSkillsViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// BatchUploadSkillsViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUploadSkillsViaOssResponse
        /// </returns>
        public async Task<BatchUploadSkillsViaOssResponse> BatchUploadSkillsViaOssWithOptionsAsync(string workspaceId, BatchUploadSkillsViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUploadSkillsViaOssShrinkRequest request = new BatchUploadSkillsViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUploadSkillsViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/batch-upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUploadSkillsViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchUploadSkillsViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUploadSkillsViaOssResponse
        /// </returns>
        public BatchUploadSkillsViaOssResponse BatchUploadSkillsViaOss(string workspaceId, BatchUploadSkillsViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchUploadSkillsViaOssWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Uploads Skill ZIP packages in bulk through OSS and returns the processing result of each Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchUploadSkillsViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUploadSkillsViaOssResponse
        /// </returns>
        public async Task<BatchUploadSkillsViaOssResponse> BatchUploadSkillsViaOssAsync(string workspaceId, BatchUploadSkillsViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchUploadSkillsViaOssWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentIMChannelResponse
        /// </returns>
        public CreateAgentIMChannelResponse CreateAgentIMChannelWithOptions(string workspaceId, string agentId, CreateAgentIMChannelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentIMChannelShrinkRequest request = new CreateAgentIMChannelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentIMChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentIMChannelResponse
        /// </returns>
        public async Task<CreateAgentIMChannelResponse> CreateAgentIMChannelWithOptionsAsync(string workspaceId, string agentId, CreateAgentIMChannelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentIMChannelShrinkRequest request = new CreateAgentIMChannelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentIMChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentIMChannelResponse
        /// </returns>
        public CreateAgentIMChannelResponse CreateAgentIMChannel(string workspaceId, string agentId, CreateAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentIMChannelWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an IM channel for a specified agent and binds a publicly accessible ServiceEndpoint.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentIMChannelResponse
        /// </returns>
        public async Task<CreateAgentIMChannelResponse> CreateAgentIMChannelAsync(string workspaceId, string agentId, CreateAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentIMChannelWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecResponse
        /// </returns>
        public CreateAgentSpecResponse CreateAgentSpecWithOptions(string workspaceId, CreateAgentSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSpecShrinkRequest request = new CreateAgentSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecResponse
        /// </returns>
        public async Task<CreateAgentSpecResponse> CreateAgentSpecWithOptionsAsync(string workspaceId, CreateAgentSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSpecShrinkRequest request = new CreateAgentSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecResponse
        /// </returns>
        public CreateAgentSpecResponse CreateAgentSpec(string workspaceId, CreateAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentSpecWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an AgentSpec in the specified workspace and generates the first draft version. Returns a resource conflict error if an AgentSpec with the same name already exists.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecResponse
        /// </returns>
        public async Task<CreateAgentSpecResponse> CreateAgentSpecAsync(string workspaceId, CreateAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentSpecWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecVersionResponse
        /// </returns>
        public CreateAgentSpecVersionResponse CreateAgentSpecVersionWithOptions(string workspaceId, string agentSpecName, CreateAgentSpecVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSpecVersionShrinkRequest request = new CreateAgentSpecVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpecVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecVersionResponse
        /// </returns>
        public async Task<CreateAgentSpecVersionResponse> CreateAgentSpecVersionWithOptionsAsync(string workspaceId, string agentSpecName, CreateAgentSpecVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentSpecVersionShrinkRequest request = new CreateAgentSpecVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpecVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecVersionResponse
        /// </returns>
        public CreateAgentSpecVersionResponse CreateAgentSpecVersion(string workspaceId, string agentSpecName, CreateAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentSpecVersionWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Creates a new draft version for an existing AgentSpec. The AgentSpec must exist, and there must not be a draft currently being edited.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpecVersionResponse
        /// </returns>
        public async Task<CreateAgentSpecVersionResponse> CreateAgentSpecVersionAsync(string workspaceId, string agentSpecName, CreateAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentSpecVersionWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredentialWithOptions(string workspaceId, CreateCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCredentialShrinkRequest request = new CreateCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialWithOptionsAsync(string workspaceId, CreateCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCredentialShrinkRequest request = new CreateCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public CreateCredentialResponse CreateCredential(string workspaceId, CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCredentialWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCredentialResponse
        /// </returns>
        public async Task<CreateCredentialResponse> CreateCredentialAsync(string workspaceId, CreateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCredentialWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentResponse
        /// </returns>
        public CreateExternalAgentResponse CreateExternalAgentWithOptions(string workspaceId, CreateExternalAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateExternalAgentShrinkRequest request = new CreateExternalAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentResponse
        /// </returns>
        public async Task<CreateExternalAgentResponse> CreateExternalAgentWithOptionsAsync(string workspaceId, CreateExternalAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateExternalAgentShrinkRequest request = new CreateExternalAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentResponse
        /// </returns>
        public CreateExternalAgentResponse CreateExternalAgent(string workspaceId, CreateExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExternalAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an external agent in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentResponse
        /// </returns>
        public async Task<CreateExternalAgentResponse> CreateExternalAgentAsync(string workspaceId, CreateExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExternalAgentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentBootstrapTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentBootstrapTokenResponse
        /// </returns>
        public CreateExternalAgentBootstrapTokenResponse CreateExternalAgentBootstrapTokenWithOptions(string workspaceId, string agentId, CreateExternalAgentBootstrapTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["networkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExternalAgentBootstrapToken",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/bootstrap/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalAgentBootstrapTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentBootstrapTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentBootstrapTokenResponse
        /// </returns>
        public async Task<CreateExternalAgentBootstrapTokenResponse> CreateExternalAgentBootstrapTokenWithOptionsAsync(string workspaceId, string agentId, CreateExternalAgentBootstrapTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["networkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExternalAgentBootstrapToken",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/bootstrap/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExternalAgentBootstrapTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentBootstrapTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentBootstrapTokenResponse
        /// </returns>
        public CreateExternalAgentBootstrapTokenResponse CreateExternalAgentBootstrapToken(string workspaceId, string agentId, CreateExternalAgentBootstrapTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExternalAgentBootstrapTokenWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a Bootstrap Token and CMS configuration required for connecting a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExternalAgentBootstrapTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExternalAgentBootstrapTokenResponse
        /// </returns>
        public async Task<CreateExternalAgentBootstrapTokenResponse> CreateExternalAgentBootstrapTokenAsync(string workspaceId, string agentId, CreateExternalAgentBootstrapTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExternalAgentBootstrapTokenWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an external identity provider to a specified workspace for single sign-on and organization member synchronization. Each workspace can be bound to at most one external identity provider. The binding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public CreateIdentityProviderResponse CreateIdentityProviderWithOptions(string workspaceId, CreateIdentityProviderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIdentityProviderShrinkRequest request = new CreateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an external identity provider to a specified workspace for single sign-on and organization member synchronization. Each workspace can be bound to at most one external identity provider. The binding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public async Task<CreateIdentityProviderResponse> CreateIdentityProviderWithOptionsAsync(string workspaceId, CreateIdentityProviderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateIdentityProviderShrinkRequest request = new CreateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an external identity provider to a specified workspace for single sign-on and organization member synchronization. Each workspace can be bound to at most one external identity provider. The binding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public CreateIdentityProviderResponse CreateIdentityProvider(string workspaceId, CreateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIdentityProviderWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an external identity provider to a specified workspace for single sign-on and organization member synchronization. Each workspace can be bound to at most one external identity provider. The binding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdentityProviderResponse
        /// </returns>
        public async Task<CreateIdentityProviderResponse> CreateIdentityProviderAsync(string workspaceId, CreateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIdentityProviderWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a managed agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateManagedAgentResponse
        /// </returns>
        public CreateManagedAgentResponse CreateManagedAgentWithOptions(string workspaceId, CreateManagedAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateManagedAgentShrinkRequest request = new CreateManagedAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManagedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a managed agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateManagedAgentResponse
        /// </returns>
        public async Task<CreateManagedAgentResponse> CreateManagedAgentWithOptionsAsync(string workspaceId, CreateManagedAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateManagedAgentShrinkRequest request = new CreateManagedAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManagedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a managed agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateManagedAgentResponse
        /// </returns>
        public CreateManagedAgentResponse CreateManagedAgent(string workspaceId, CreateManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateManagedAgentWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a managed agent in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateManagedAgentResponse
        /// </returns>
        public async Task<CreateManagedAgentResponse> CreateManagedAgentAsync(string workspaceId, CreateManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateManagedAgentWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public CreateMcpResponse CreateMcpWithOptions(string workspaceId, CreateMcpRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMcpShrinkRequest request = new CreateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public async Task<CreateMcpResponse> CreateMcpWithOptionsAsync(string workspaceId, CreateMcpRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMcpShrinkRequest request = new CreateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public CreateMcpResponse CreateMcp(string workspaceId, CreateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMcpWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates an MCP service in a specified workspace. The creation is an asynchronous process. You can check whether the service is ready by using the returned status or by calling a query operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMcpResponse
        /// </returns>
        public async Task<CreateMcpResponse> CreateMcpAsync(string workspaceId, CreateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMcpWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model configuration under a specified model connection in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModelWithOptions(string workspaceId, CreateModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model configuration under a specified model connection in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(string workspaceId, CreateModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelShrinkRequest request = new CreateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model configuration under a specified model connection in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModel(string workspaceId, CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model configuration under a specified model connection in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelAsync(string workspaceId, CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型连接</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelConnectionResponse
        /// </returns>
        public CreateModelConnectionResponse CreateModelConnectionWithOptions(string workspaceId, CreateModelConnectionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelConnectionShrinkRequest request = new CreateModelConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型连接</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelConnectionResponse
        /// </returns>
        public async Task<CreateModelConnectionResponse> CreateModelConnectionWithOptionsAsync(string workspaceId, CreateModelConnectionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateModelConnectionShrinkRequest request = new CreateModelConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelConnectionResponse
        /// </returns>
        public CreateModelConnectionResponse CreateModelConnection(string workspaceId, CreateModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelConnectionWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelConnectionResponse
        /// </returns>
        public async Task<CreateModelConnectionResponse> CreateModelConnectionAsync(string workspaceId, CreateModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelConnectionWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSkillDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillDraftResponse
        /// </returns>
        public CreateSkillDraftResponse CreateSkillDraftWithOptions(string workspaceId, CreateSkillDraftRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSkillDraftShrinkRequest request = new CreateSkillDraftShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillDraft",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSkillDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillDraftResponse
        /// </returns>
        public async Task<CreateSkillDraftResponse> CreateSkillDraftWithOptionsAsync(string workspaceId, CreateSkillDraftRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSkillDraftShrinkRequest request = new CreateSkillDraftShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillDraft",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillDraftResponse
        /// </returns>
        public CreateSkillDraftResponse CreateSkillDraft(string workspaceId, CreateSkillDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSkillDraftWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Creates a Skill in the specified workspace and generates a draft version that can be further edited. You can derive a draft from an existing version or specify a target version and commit message.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSkillDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillDraftResponse
        /// </returns>
        public async Task<CreateSkillDraftResponse> CreateSkillDraftAsync(string workspaceId, CreateSkillDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSkillDraftWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeamWithOptions(string workspaceId, CreateTeamRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTeamShrinkRequest request = new CreateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamWithOptionsAsync(string workspaceId, CreateTeamRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTeamShrinkRequest request = new CreateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public CreateTeamResponse CreateTeam(string workspaceId, CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTeamWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTeamResponse
        /// </returns>
        public async Task<CreateTeamResponse> CreateTeamAsync(string workspaceId, CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTeamWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUserWithOptions(string workspaceId, CreateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(string workspaceId, CreateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserShrinkRequest request = new CreateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(string workspaceId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(string workspaceId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentCore workspace control plane record. The server completes the state transition from Initializing to Initialized within the same transaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nCreates an AgentCore workspace control plane record. The server completes the state transition from <c>Initializing</c> to <c>Initialized</c> within the same transaction. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceShrinkRequest request = new CreateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentCore workspace control plane record. The server completes the state transition from Initializing to Initialized within the same transaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nCreates an AgentCore workspace control plane record. The server completes the state transition from <c>Initializing</c> to <c>Initialized</c> within the same transaction. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWorkspaceShrinkRequest request = new CreateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentCore workspace control plane record. The server completes the state transition from Initializing to Initialized within the same transaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nCreates an AgentCore workspace control plane record. The server completes the state transition from <c>Initializing</c> to <c>Initialized</c> within the same transaction. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentCore workspace control plane record. The server completes the state transition from Initializing to Initialized within the same transaction.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nCreates an AgentCore workspace control plane record. The server completes the state transition from <c>Initializing</c> to <c>Initialized</c> within the same transaction. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DebugModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugModelResponse
        /// </returns>
        public DebugModelResponse DebugModelWithOptions(string workspaceId, string modelId, DebugModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DebugModelShrinkRequest request = new DebugModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId) + "/actions/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DebugModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugModelResponse
        /// </returns>
        public async Task<DebugModelResponse> DebugModelWithOptionsAsync(string workspaceId, string modelId, DebugModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DebugModelShrinkRequest request = new DebugModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId) + "/actions/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugModelResponse
        /// </returns>
        public DebugModelResponse DebugModel(string workspaceId, string modelId, DebugModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DebugModelWithOptions(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugModelResponse
        /// </returns>
        public async Task<DebugModelResponse> DebugModelAsync(string workspaceId, string modelId, DebugModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DebugModelWithOptionsAsync(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentIMChannelResponse
        /// </returns>
        public DeleteAgentIMChannelResponse DeleteAgentIMChannelWithOptions(string workspaceId, string agentId, string imChannelId, DeleteAgentIMChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentIMChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentIMChannelResponse
        /// </returns>
        public async Task<DeleteAgentIMChannelResponse> DeleteAgentIMChannelWithOptionsAsync(string workspaceId, string agentId, string imChannelId, DeleteAgentIMChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentIMChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentIMChannelResponse
        /// </returns>
        public DeleteAgentIMChannelResponse DeleteAgentIMChannel(string workspaceId, string agentId, string imChannelId, DeleteAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentIMChannelWithOptions(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an IM channel of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentIMChannelResponse
        /// </returns>
        public async Task<DeleteAgentIMChannelResponse> DeleteAgentIMChannelAsync(string workspaceId, string agentId, string imChannelId, DeleteAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentIMChannelWithOptionsAsync(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecResponse
        /// </returns>
        public DeleteAgentSpecResponse DeleteAgentSpecWithOptions(string workspaceId, string agentSpecName, DeleteAgentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecResponse
        /// </returns>
        public async Task<DeleteAgentSpecResponse> DeleteAgentSpecWithOptionsAsync(string workspaceId, string agentSpecName, DeleteAgentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecResponse
        /// </returns>
        public DeleteAgentSpecResponse DeleteAgentSpec(string workspaceId, string agentSpecName, DeleteAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentSpecWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified AgentSpec along with all its versions and metadata. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecResponse
        /// </returns>
        public async Task<DeleteAgentSpecResponse> DeleteAgentSpecAsync(string workspaceId, string agentSpecName, DeleteAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentSpecWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecVersionResponse
        /// </returns>
        public DeleteAgentSpecVersionResponse DeleteAgentSpecVersionWithOptions(string workspaceId, string agentSpecName, DeleteAgentSpecVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/draft",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpecVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecVersionResponse
        /// </returns>
        public async Task<DeleteAgentSpecVersionResponse> DeleteAgentSpecVersionWithOptionsAsync(string workspaceId, string agentSpecName, DeleteAgentSpecVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/draft",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpecVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecVersionResponse
        /// </returns>
        public DeleteAgentSpecVersionResponse DeleteAgentSpecVersion(string workspaceId, string agentSpecName, DeleteAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentSpecVersionWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified AgentSpec and clears the draft version pointer.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpecVersionResponse
        /// </returns>
        public async Task<DeleteAgentSpecVersionResponse> DeleteAgentSpecVersionAsync(string workspaceId, string agentSpecName, DeleteAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentSpecVersionWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredentialWithOptions(string workspaceId, string credentialId, DeleteCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialWithOptionsAsync(string workspaceId, string credentialId, DeleteCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public DeleteCredentialResponse DeleteCredential(string workspaceId, string credentialId, DeleteCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCredentialWithOptions(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCredentialResponse
        /// </returns>
        public async Task<DeleteCredentialResponse> DeleteCredentialAsync(string workspaceId, string credentialId, DeleteCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCredentialWithOptionsAsync(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExternalAgentResponse
        /// </returns>
        public DeleteExternalAgentResponse DeleteExternalAgentWithOptions(string workspaceId, string agentId, DeleteExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExternalAgentResponse
        /// </returns>
        public async Task<DeleteExternalAgentResponse> DeleteExternalAgentWithOptionsAsync(string workspaceId, string agentId, DeleteExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExternalAgentResponse
        /// </returns>
        public DeleteExternalAgentResponse DeleteExternalAgent(string workspaceId, string agentId, DeleteExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExternalAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExternalAgentResponse
        /// </returns>
        public async Task<DeleteExternalAgentResponse> DeleteExternalAgentAsync(string workspaceId, string agentId, DeleteExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExternalAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds the external identity provider from a specified workspace and cleans up users synchronized by that identity provider. The unbinding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public DeleteIdentityProviderResponse DeleteIdentityProviderWithOptions(string workspaceId, string identityProviderType, DeleteIdentityProviderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds the external identity provider from a specified workspace and cleans up users synchronized by that identity provider. The unbinding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public async Task<DeleteIdentityProviderResponse> DeleteIdentityProviderWithOptionsAsync(string workspaceId, string identityProviderType, DeleteIdentityProviderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds the external identity provider from a specified workspace and cleans up users synchronized by that identity provider. The unbinding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public DeleteIdentityProviderResponse DeleteIdentityProvider(string workspaceId, string identityProviderType, DeleteIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIdentityProviderWithOptions(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds the external identity provider from a specified workspace and cleans up users synchronized by that identity provider. The unbinding is an asynchronous operation. After the API returns, you can track the progress by querying the status through GetIdentityProvider.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdentityProviderResponse
        /// </returns>
        public async Task<DeleteIdentityProviderResponse> DeleteIdentityProviderAsync(string workspaceId, string identityProviderType, DeleteIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIdentityProviderWithOptionsAsync(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagedAgentResponse
        /// </returns>
        public DeleteManagedAgentResponse DeleteManagedAgentWithOptions(string workspaceId, string agentId, DeleteManagedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteManagedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagedAgentResponse
        /// </returns>
        public async Task<DeleteManagedAgentResponse> DeleteManagedAgentWithOptionsAsync(string workspaceId, string agentId, DeleteManagedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteManagedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagedAgentResponse
        /// </returns>
        public DeleteManagedAgentResponse DeleteManagedAgent(string workspaceId, string agentId, DeleteManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteManagedAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteManagedAgentResponse
        /// </returns>
        public async Task<DeleteManagedAgentResponse> DeleteManagedAgentAsync(string workspaceId, string agentId, DeleteManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteManagedAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public DeleteMcpResponse DeleteMcpWithOptions(string mcpServerId, string workspaceId, DeleteMcpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public async Task<DeleteMcpResponse> DeleteMcpWithOptionsAsync(string mcpServerId, string workspaceId, DeleteMcpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public DeleteMcpResponse DeleteMcp(string mcpServerId, string workspaceId, DeleteMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMcpWithOptions(mcpServerId, workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a specified MCP service. The deletion is an asynchronous process. After the deletion is complete, the MCP service is no longer returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMcpResponse
        /// </returns>
        public async Task<DeleteMcpResponse> DeleteMcpAsync(string mcpServerId, string workspaceId, DeleteMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMcpWithOptionsAsync(mcpServerId, workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModelWithOptions(string workspaceId, string modelId, DeleteModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(string workspaceId, string modelId, DeleteModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModel(string workspaceId, string modelId, DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelWithOptions(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelAsync(string workspaceId, string modelId, DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelWithOptionsAsync(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelConnectionResponse
        /// </returns>
        public DeleteModelConnectionResponse DeleteModelConnectionWithOptions(string workspaceId, string connectionId, DeleteModelConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelConnectionResponse
        /// </returns>
        public async Task<DeleteModelConnectionResponse> DeleteModelConnectionWithOptionsAsync(string workspaceId, string connectionId, DeleteModelConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelConnectionResponse
        /// </returns>
        public DeleteModelConnectionResponse DeleteModelConnection(string workspaceId, string connectionId, DeleteModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelConnectionWithOptions(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelConnectionResponse
        /// </returns>
        public async Task<DeleteModelConnectionResponse> DeleteModelConnectionAsync(string workspaceId, string connectionId, DeleteModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelConnectionWithOptionsAsync(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkillWithOptions(string workspaceId, string skillName, DeleteSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillWithOptionsAsync(string workspaceId, string skillName, DeleteSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkill(string workspaceId, string skillName, DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSkillWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes a skill and its related version data from a specified workspace. This operation is irreversible.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillAsync(string workspaceId, string skillName, DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSkillWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillDraftResponse
        /// </returns>
        public DeleteSkillDraftResponse DeleteSkillDraftWithOptions(string workspaceId, string skillName, DeleteSkillDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillDraft",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/draft",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillDraftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillDraftRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillDraftResponse
        /// </returns>
        public async Task<DeleteSkillDraftResponse> DeleteSkillDraftWithOptionsAsync(string workspaceId, string skillName, DeleteSkillDraftRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillDraft",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/draft",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillDraftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillDraftResponse
        /// </returns>
        public DeleteSkillDraftResponse DeleteSkillDraft(string workspaceId, string skillName, DeleteSkillDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSkillDraftWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Deletes the draft version currently being edited for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSkillDraftRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillDraftResponse
        /// </returns>
        public async Task<DeleteSkillDraftResponse> DeleteSkillDraftAsync(string workspaceId, string skillName, DeleteSkillDraftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSkillDraftWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeamWithOptions(string workspaceId, string teamId, DeleteTeamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamWithOptionsAsync(string workspaceId, string teamId, DeleteTeamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public DeleteTeamResponse DeleteTeam(string workspaceId, string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTeamWithOptions(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTeamResponse
        /// </returns>
        public async Task<DeleteTeamResponse> DeleteTeamAsync(string workspaceId, string teamId, DeleteTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTeamWithOptionsAsync(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUserWithOptions(string workspaceId, string agentCoreUserId, DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(string workspaceId, string agentCoreUserId, DeleteUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUser(string workspaceId, string agentCoreUserId, DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserWithOptions(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserAsync(string workspaceId, string agentCoreUserId, DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserWithOptionsAsync(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the control plane record of a specified workspace. The server completes the state transition from Deleting to Deleted within the same transaction. When you repeatedly delete a workspace that is in the Deleting or Deleted state, the server handles the request with idempotence semantics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nDeletes the control plane record of a specified workspace. The server completes the state transition from <c>Deleting</c> to <c>Deleted</c> within the same transaction. When you repeatedly delete a workspace that is in the <c>Deleting</c> or <c>Deleted</c> state, the server handles the request with idempotence semantics.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string workspaceId, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the control plane record of a specified workspace. The server completes the state transition from Deleting to Deleted within the same transaction. When you repeatedly delete a workspace that is in the Deleting or Deleted state, the server handles the request with idempotence semantics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nDeletes the control plane record of a specified workspace. The server completes the state transition from <c>Deleting</c> to <c>Deleted</c> within the same transaction. When you repeatedly delete a workspace that is in the <c>Deleting</c> or <c>Deleted</c> state, the server handles the request with idempotence semantics.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string workspaceId, DeleteWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the control plane record of a specified workspace. The server completes the state transition from Deleting to Deleted within the same transaction. When you repeatedly delete a workspace that is in the Deleting or Deleted state, the server handles the request with idempotence semantics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nDeletes the control plane record of a specified workspace. The server completes the state transition from <c>Deleting</c> to <c>Deleted</c> within the same transaction. When you repeatedly delete a workspace that is in the <c>Deleting</c> or <c>Deleted</c> state, the server handles the request with idempotence semantics.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string workspaceId, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the control plane record of a specified workspace. The server completes the state transition from Deleting to Deleted within the same transaction. When you repeatedly delete a workspace that is in the Deleting or Deleted state, the server handles the request with idempotence semantics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nDeletes the control plane record of a specified workspace. The server completes the state transition from <c>Deleting</c> to <c>Deleted</c> within the same transaction. When you repeatedly delete a workspace that is in the <c>Deleting</c> or <c>Deleted</c> state, the server handles the request with idempotence semantics.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string workspaceId, DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec, which is used to download the AgentSpec ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadAgentSpecViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadAgentSpecViaOssResponse
        /// </returns>
        public DownloadAgentSpecViaOssResponse DownloadAgentSpecViaOssWithOptions(string workspaceId, string agentSpecName, DownloadAgentSpecViaOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpecVersion))
            {
                query["agentSpecVersion"] = request.AgentSpecVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadAgentSpecViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/actions/download-via-oss",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadAgentSpecViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec, which is used to download the AgentSpec ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadAgentSpecViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadAgentSpecViaOssResponse
        /// </returns>
        public async Task<DownloadAgentSpecViaOssResponse> DownloadAgentSpecViaOssWithOptionsAsync(string workspaceId, string agentSpecName, DownloadAgentSpecViaOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpecVersion))
            {
                query["agentSpecVersion"] = request.AgentSpecVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadAgentSpecViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/actions/download-via-oss",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadAgentSpecViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec, which is used to download the AgentSpec ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadAgentSpecViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadAgentSpecViaOssResponse
        /// </returns>
        public DownloadAgentSpecViaOssResponse DownloadAgentSpecViaOss(string workspaceId, string agentSpecName, DownloadAgentSpecViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DownloadAgentSpecViaOssWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified AgentSpec, which is used to download the AgentSpec ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadAgentSpecViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadAgentSpecViaOssResponse
        /// </returns>
        public async Task<DownloadAgentSpecViaOssResponse> DownloadAgentSpecViaOssAsync(string workspaceId, string agentSpecName, DownloadAgentSpecViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DownloadAgentSpecViaOssWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadSkillVersionViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadSkillVersionViaOssResponse
        /// </returns>
        public DownloadSkillVersionViaOssResponse DownloadSkillVersionViaOssWithOptions(string workspaceId, string skillName, string skillVersion, DownloadSkillVersionViaOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadSkillVersionViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/download-via-oss",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadSkillVersionViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadSkillVersionViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadSkillVersionViaOssResponse
        /// </returns>
        public async Task<DownloadSkillVersionViaOssResponse> DownloadSkillVersionViaOssWithOptionsAsync(string workspaceId, string skillName, string skillVersion, DownloadSkillVersionViaOssRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadSkillVersionViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/download-via-oss",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadSkillVersionViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadSkillVersionViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadSkillVersionViaOssResponse
        /// </returns>
        public DownloadSkillVersionViaOssResponse DownloadSkillVersionViaOss(string workspaceId, string skillName, string skillVersion, DownloadSkillVersionViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DownloadSkillVersionViaOssWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves a pre-signed OSS download URL for a specified Skill version, which is used to download the corresponding Skill ZIP package.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DownloadSkillVersionViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadSkillVersionViaOssResponse
        /// </returns>
        public async Task<DownloadSkillVersionViaOssResponse> DownloadSkillVersionViaOssAsync(string workspaceId, string skillName, string skillVersion, DownloadSkillVersionViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DownloadSkillVersionViaOssWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ForcePublishSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForcePublishSkillVersionResponse
        /// </returns>
        public ForcePublishSkillVersionResponse ForcePublishSkillVersionWithOptions(string workspaceId, string skillName, string skillVersion, ForcePublishSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ForcePublishSkillVersionShrinkRequest request = new ForcePublishSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForcePublishSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/force-publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForcePublishSkillVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ForcePublishSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForcePublishSkillVersionResponse
        /// </returns>
        public async Task<ForcePublishSkillVersionResponse> ForcePublishSkillVersionWithOptionsAsync(string workspaceId, string skillName, string skillVersion, ForcePublishSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ForcePublishSkillVersionShrinkRequest request = new ForcePublishSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForcePublishSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/force-publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForcePublishSkillVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ForcePublishSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ForcePublishSkillVersionResponse
        /// </returns>
        public ForcePublishSkillVersionResponse ForcePublishSkillVersion(string workspaceId, string skillName, string skillVersion, ForcePublishSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ForcePublishSkillVersionWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Skips the regular review process and forcibly publishes the specified Skill version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ForcePublishSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ForcePublishSkillVersionResponse
        /// </returns>
        public async Task<ForcePublishSkillVersionResponse> ForcePublishSkillVersionAsync(string workspaceId, string skillName, string skillVersion, ForcePublishSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ForcePublishSkillVersionWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIMChannelResponse
        /// </returns>
        public GetAgentIMChannelResponse GetAgentIMChannelWithOptions(string workspaceId, string agentId, string imChannelId, GetAgentIMChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIMChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIMChannelResponse
        /// </returns>
        public async Task<GetAgentIMChannelResponse> GetAgentIMChannelWithOptionsAsync(string workspaceId, string agentId, string imChannelId, GetAgentIMChannelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentIMChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIMChannelResponse
        /// </returns>
        public GetAgentIMChannelResponse GetAgentIMChannel(string workspaceId, string agentId, string imChannelId, GetAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentIMChannelWithOptions(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified agent IM channel.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentIMChannelResponse
        /// </returns>
        public async Task<GetAgentIMChannelResponse> GetAgentIMChannelAsync(string workspaceId, string agentId, string imChannelId, GetAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentIMChannelWithOptionsAsync(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecResponse
        /// </returns>
        public GetAgentSpecResponse GetAgentSpecWithOptions(string workspaceId, string agentSpecName, GetAgentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecResponse
        /// </returns>
        public async Task<GetAgentSpecResponse> GetAgentSpecWithOptionsAsync(string workspaceId, string agentSpecName, GetAgentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecResponse
        /// </returns>
        public GetAgentSpecResponse GetAgentSpec(string workspaceId, string agentSpecName, GetAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentSpecWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the governance details of a specified AgentSpec, including basic information, governance pointers, and summaries of all versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecResponse
        /// </returns>
        public async Task<GetAgentSpecResponse> GetAgentSpecAsync(string workspaceId, string agentSpecName, GetAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentSpecWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecImportFileUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecImportFileUrlResponse
        /// </returns>
        public GetAgentSpecImportFileUrlResponse GetAgentSpecImportFileUrlWithOptions(string workspaceId, GetAgentSpecImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecImportFileUrl",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-spec-actions/get-import-file-url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecImportFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecImportFileUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecImportFileUrlResponse
        /// </returns>
        public async Task<GetAgentSpecImportFileUrlResponse> GetAgentSpecImportFileUrlWithOptionsAsync(string workspaceId, GetAgentSpecImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecImportFileUrl",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-spec-actions/get-import-file-url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecImportFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecImportFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecImportFileUrlResponse
        /// </returns>
        public GetAgentSpecImportFileUrlResponse GetAgentSpecImportFileUrl(string workspaceId, GetAgentSpecImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentSpecImportFileUrlWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing an AgentSpec ZIP package. After the upload is complete, call the AgentSpec OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecImportFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecImportFileUrlResponse
        /// </returns>
        public async Task<GetAgentSpecImportFileUrlResponse> GetAgentSpecImportFileUrlAsync(string workspaceId, GetAgentSpecImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentSpecImportFileUrlWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecLatestRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecLatestResponse
        /// </returns>
        public GetAgentSpecLatestResponse GetAgentSpecLatestWithOptions(string workspaceId, string agentSpecName, GetAgentSpecLatestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecLatest",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/latest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecLatestResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecLatestRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecLatestResponse
        /// </returns>
        public async Task<GetAgentSpecLatestResponse> GetAgentSpecLatestWithOptionsAsync(string workspaceId, string agentSpecName, GetAgentSpecLatestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecLatest",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/latest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecLatestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecLatestRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecLatestResponse
        /// </returns>
        public GetAgentSpecLatestResponse GetAgentSpecLatest(string workspaceId, string agentSpecName, GetAgentSpecLatestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentSpecLatestWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the full content of the latest version of a specified AgentSpec for editing or viewing.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecLatestRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecLatestResponse
        /// </returns>
        public async Task<GetAgentSpecLatestResponse> GetAgentSpecLatestAsync(string workspaceId, string agentSpecName, GetAgentSpecLatestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentSpecLatestWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecVersionResponse
        /// </returns>
        public GetAgentSpecVersionResponse GetAgentSpecVersionWithOptions(string workspaceId, string agentSpecName, string agentSpecVersion, GetAgentSpecVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecVersionResponse
        /// </returns>
        public async Task<GetAgentSpecVersionResponse> GetAgentSpecVersionWithOptionsAsync(string workspaceId, string agentSpecName, string agentSpecVersion, GetAgentSpecVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpecVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecVersionResponse
        /// </returns>
        public GetAgentSpecVersionResponse GetAgentSpecVersion(string workspaceId, string agentSpecName, string agentSpecVersion, GetAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentSpecVersionWithOptions(workspaceId, agentSpecName, agentSpecVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete content of a specified AgentSpec version, including manifest content, resource files, and metadata.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpecVersionResponse
        /// </returns>
        public async Task<GetAgentSpecVersionResponse> GetAgentSpecVersionAsync(string workspaceId, string agentSpecName, string agentSpecVersion, GetAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentSpecVersionWithOptionsAsync(workspaceId, agentSpecName, agentSpecVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredentialWithOptions(string workspaceId, string credentialId, GetCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialWithOptionsAsync(string workspaceId, string credentialId, GetCredentialRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public GetCredentialResponse GetCredential(string workspaceId, string credentialId, GetCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCredentialWithOptions(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCredentialResponse
        /// </returns>
        public async Task<GetCredentialResponse> GetCredentialAsync(string workspaceId, string credentialId, GetCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCredentialWithOptionsAsync(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentResponse
        /// </returns>
        public GetExternalAgentResponse GetExternalAgentWithOptions(string workspaceId, string agentId, GetExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentResponse
        /// </returns>
        public async Task<GetExternalAgentResponse> GetExternalAgentWithOptionsAsync(string workspaceId, string agentId, GetExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentResponse
        /// </returns>
        public GetExternalAgentResponse GetExternalAgent(string workspaceId, string agentId, GetExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExternalAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentResponse
        /// </returns>
        public async Task<GetExternalAgentResponse> GetExternalAgentAsync(string workspaceId, string agentId, GetExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExternalAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentBootstrapOptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentBootstrapOptionsResponse
        /// </returns>
        public GetExternalAgentBootstrapOptionsResponse GetExternalAgentBootstrapOptionsWithOptions(string workspaceId, string agentId, GetExternalAgentBootstrapOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalAgentBootstrapOptions",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/bootstrap/options",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalAgentBootstrapOptionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentBootstrapOptionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentBootstrapOptionsResponse
        /// </returns>
        public async Task<GetExternalAgentBootstrapOptionsResponse> GetExternalAgentBootstrapOptionsWithOptionsAsync(string workspaceId, string agentId, GetExternalAgentBootstrapOptionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalAgentBootstrapOptions",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/bootstrap/options",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalAgentBootstrapOptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentBootstrapOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentBootstrapOptionsResponse
        /// </returns>
        public GetExternalAgentBootstrapOptionsResponse GetExternalAgentBootstrapOptions(string workspaceId, string agentId, GetExternalAgentBootstrapOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExternalAgentBootstrapOptionsWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available network types for a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetExternalAgentBootstrapOptionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExternalAgentBootstrapOptionsResponse
        /// </returns>
        public async Task<GetExternalAgentBootstrapOptionsResponse> GetExternalAgentBootstrapOptionsAsync(string workspaceId, string agentId, GetExternalAgentBootstrapOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExternalAgentBootstrapOptionsWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the binding details of an external identity provider for a specified workspace, including the binding status, application configuration, and callback URLs that need to be configured on the identity provider side. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public GetIdentityProviderResponse GetIdentityProviderWithOptions(string workspaceId, string identityProviderType, GetIdentityProviderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the binding details of an external identity provider for a specified workspace, including the binding status, application configuration, and callback URLs that need to be configured on the identity provider side. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public async Task<GetIdentityProviderResponse> GetIdentityProviderWithOptionsAsync(string workspaceId, string identityProviderType, GetIdentityProviderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the binding details of an external identity provider for a specified workspace, including the binding status, application configuration, and callback URLs that need to be configured on the identity provider side. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public GetIdentityProviderResponse GetIdentityProvider(string workspaceId, string identityProviderType, GetIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIdentityProviderWithOptions(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the binding details of an external identity provider for a specified workspace, including the binding status, application configuration, and callback URLs that need to be configured on the identity provider side. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdentityProviderResponse
        /// </returns>
        public async Task<GetIdentityProviderResponse> GetIdentityProviderAsync(string workspaceId, string identityProviderType, GetIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIdentityProviderWithOptionsAsync(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManagedAgentResponse
        /// </returns>
        public GetManagedAgentResponse GetManagedAgentWithOptions(string workspaceId, string agentId, GetManagedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManagedAgentResponse
        /// </returns>
        public async Task<GetManagedAgentResponse> GetManagedAgentWithOptionsAsync(string workspaceId, string agentId, GetManagedAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManagedAgentResponse
        /// </returns>
        public GetManagedAgentResponse GetManagedAgent(string workspaceId, string agentId, GetManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetManagedAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManagedAgentResponse
        /// </returns>
        public async Task<GetManagedAgentResponse> GetManagedAgentAsync(string workspaceId, string agentId, GetManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetManagedAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public GetMcpResponse GetMcpWithOptions(string workspaceId, string mcpServerId, GetMcpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public async Task<GetMcpResponse> GetMcpWithOptionsAsync(string workspaceId, string mcpServerId, GetMcpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public GetMcpResponse GetMcp(string workspaceId, string mcpServerId, GetMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMcpWithOptions(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the details of a specified MCP service, including its address, type, status, authentication configuration, and protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMcpResponse
        /// </returns>
        public async Task<GetMcpResponse> GetMcpAsync(string workspaceId, string mcpServerId, GetMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMcpWithOptionsAsync(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration and region of a model in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public GetModelResponse GetModelWithOptions(string workspaceId, string modelId, GetModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration and region of a model in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public async Task<GetModelResponse> GetModelWithOptionsAsync(string workspaceId, string modelId, GetModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration and region of a model in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public GetModelResponse GetModel(string workspaceId, string modelId, GetModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelWithOptions(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the detailed configuration and region of a model in a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public async Task<GetModelResponse> GetModelAsync(string workspaceId, string modelId, GetModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelWithOptionsAsync(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelConnectionResponse
        /// </returns>
        public GetModelConnectionResponse GetModelConnectionWithOptions(string workspaceId, string connectionId, GetModelConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelConnectionResponse
        /// </returns>
        public async Task<GetModelConnectionResponse> GetModelConnectionWithOptionsAsync(string workspaceId, string connectionId, GetModelConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelConnectionResponse
        /// </returns>
        public GetModelConnectionResponse GetModelConnection(string workspaceId, string connectionId, GetModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelConnectionWithOptions(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelConnectionResponse
        /// </returns>
        public async Task<GetModelConnectionResponse> GetModelConnectionAsync(string workspaceId, string connectionId, GetModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelConnectionWithOptionsAsync(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified service endpoint, including target routing, access URLs, authentication configuration, and current status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the details of a specified service endpoint. A service endpoint (ServiceEndpoint) provides a stable access URL for a specific agent version (AgentVersion) or workspace collaboration component. The response includes target routing, access URL list, authentication configuration, and current lifecycle status.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public GetServiceEndpointResponse GetServiceEndpointWithOptions(string workspaceId, string serviceEndpointId, GetServiceEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpoint",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceEndpointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified service endpoint, including target routing, access URLs, authentication configuration, and current status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the details of a specified service endpoint. A service endpoint (ServiceEndpoint) provides a stable access URL for a specific agent version (AgentVersion) or workspace collaboration component. The response includes target routing, access URL list, authentication configuration, and current lifecycle status.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public async Task<GetServiceEndpointResponse> GetServiceEndpointWithOptionsAsync(string workspaceId, string serviceEndpointId, GetServiceEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpoint",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceEndpointId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified service endpoint, including target routing, access URLs, authentication configuration, and current status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the details of a specified service endpoint. A service endpoint (ServiceEndpoint) provides a stable access URL for a specific agent version (AgentVersion) or workspace collaboration component. The response includes target routing, access URL list, authentication configuration, and current lifecycle status.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public GetServiceEndpointResponse GetServiceEndpoint(string workspaceId, string serviceEndpointId, GetServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceEndpointWithOptions(workspaceId, serviceEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specified service endpoint, including target routing, access URLs, authentication configuration, and current status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the details of a specified service endpoint. A service endpoint (ServiceEndpoint) provides a stable access URL for a specific agent version (AgentVersion) or workspace collaboration component. The response includes target routing, access URL list, authentication configuration, and current lifecycle status.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointResponse
        /// </returns>
        public async Task<GetServiceEndpointResponse> GetServiceEndpointAsync(string workspaceId, string serviceEndpointId, GetServiceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceEndpointWithOptionsAsync(workspaceId, serviceEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the currently active API Key and its invocation method for a specified service endpoint within a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the currently active API Key for a specified service endpoint. The call succeeds only when the service endpoint has API_KEY authentication enabled and the gateway consumer and credentials are ready. The service reads the API Key from the gateway in real time. AgentCore does not persist the plaintext. Keep the returned API Key secure and avoid logging it or exposing it in public configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointApiKeyResponse
        /// </returns>
        public GetServiceEndpointApiKeyResponse GetServiceEndpointApiKeyWithOptions(string workspaceId, string serviceEndpointId, GetServiceEndpointApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpointApiKey",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceEndpointId) + "/api-key/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the currently active API Key and its invocation method for a specified service endpoint within a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the currently active API Key for a specified service endpoint. The call succeeds only when the service endpoint has API_KEY authentication enabled and the gateway consumer and credentials are ready. The service reads the API Key from the gateway in real time. AgentCore does not persist the plaintext. Keep the returned API Key secure and avoid logging it or exposing it in public configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointApiKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointApiKeyResponse
        /// </returns>
        public async Task<GetServiceEndpointApiKeyResponse> GetServiceEndpointApiKeyWithOptionsAsync(string workspaceId, string serviceEndpointId, GetServiceEndpointApiKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceEndpointApiKey",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(serviceEndpointId) + "/api-key/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEndpointApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the currently active API Key and its invocation method for a specified service endpoint within a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the currently active API Key for a specified service endpoint. The call succeeds only when the service endpoint has API_KEY authentication enabled and the gateway consumer and credentials are ready. The service reads the API Key from the gateway in real time. AgentCore does not persist the plaintext. Keep the returned API Key secure and avoid logging it or exposing it in public configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointApiKeyResponse
        /// </returns>
        public GetServiceEndpointApiKeyResponse GetServiceEndpointApiKey(string workspaceId, string serviceEndpointId, GetServiceEndpointApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceEndpointApiKeyWithOptions(workspaceId, serviceEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the currently active API Key and its invocation method for a specified service endpoint within a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the currently active API Key for a specified service endpoint. The call succeeds only when the service endpoint has API_KEY authentication enabled and the gateway consumer and credentials are ready. The service reads the API Key from the gateway in real time. AgentCore does not persist the plaintext. Keep the returned API Key secure and avoid logging it or exposing it in public configurations.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceEndpointApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceEndpointApiKeyResponse
        /// </returns>
        public async Task<GetServiceEndpointApiKeyResponse> GetServiceEndpointApiKeyAsync(string workspaceId, string serviceEndpointId, GetServiceEndpointApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceEndpointApiKeyWithOptionsAsync(workspaceId, serviceEndpointId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillDetailResponse
        /// </returns>
        public GetSkillDetailResponse GetSkillDetailWithOptions(string workspaceId, string skillName, GetSkillDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillDetail",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillDetailResponse
        /// </returns>
        public async Task<GetSkillDetailResponse> GetSkillDetailWithOptionsAsync(string workspaceId, string skillName, GetSkillDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillDetail",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillDetailResponse
        /// </returns>
        public GetSkillDetailResponse GetSkillDetail(string workspaceId, string skillName, GetSkillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSkillDetailWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the basic information, version status, labels, visibility scope, and version list of a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillDetailResponse
        /// </returns>
        public async Task<GetSkillDetailResponse> GetSkillDetailAsync(string workspaceId, string skillName, GetSkillDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSkillDetailWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillImportFileUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillImportFileUrlResponse
        /// </returns>
        public GetSkillImportFileUrlResponse GetSkillImportFileUrlWithOptions(string workspaceId, GetSkillImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillImportFileUrl",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/get-import-file-url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillImportFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillImportFileUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillImportFileUrlResponse
        /// </returns>
        public async Task<GetSkillImportFileUrlResponse> GetSkillImportFileUrlWithOptionsAsync(string workspaceId, GetSkillImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillImportFileUrl",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/get-import-file-url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillImportFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillImportFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillImportFileUrlResponse
        /// </returns>
        public GetSkillImportFileUrlResponse GetSkillImportFileUrl(string workspaceId, GetSkillImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSkillImportFileUrlWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Retrieves the OSS pre-signed upload URL and object name required for importing a Skill ZIP package. After the upload is complete, call the Skill OSS upload operation to complete the import.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillImportFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillImportFileUrlResponse
        /// </returns>
        public async Task<GetSkillImportFileUrlResponse> GetSkillImportFileUrlAsync(string workspaceId, GetSkillImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSkillImportFileUrlWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillVersionDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillVersionDetailResponse
        /// </returns>
        public GetSkillVersionDetailResponse GetSkillVersionDetailWithOptions(string workspaceId, string skillName, string skillVersion, GetSkillVersionDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillVersionDetail",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillVersionDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillVersionDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillVersionDetailResponse
        /// </returns>
        public async Task<GetSkillVersionDetailResponse> GetSkillVersionDetailWithOptionsAsync(string workspaceId, string skillName, string skillVersion, GetSkillVersionDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillVersionDetail",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillVersionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillVersionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillVersionDetailResponse
        /// </returns>
        public GetSkillVersionDetailResponse GetSkillVersionDetail(string workspaceId, string skillName, string skillVersion, GetSkillVersionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSkillVersionDetailWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the complete details of a specified Skill version, including version metadata, Skill content, and associated resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSkillVersionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillVersionDetailResponse
        /// </returns>
        public async Task<GetSkillVersionDetailResponse> GetSkillVersionDetailAsync(string workspaceId, string skillName, string skillVersion, GetSkillVersionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSkillVersionDetailWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeamWithOptions(string workspaceId, string teamId, GetTeamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamWithOptionsAsync(string workspaceId, string teamId, GetTeamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public GetTeamResponse GetTeam(string workspaceId, string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTeamWithOptions(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTeamResponse
        /// </returns>
        public async Task<GetTeamResponse> GetTeamAsync(string workspaceId, string teamId, GetTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTeamWithOptionsAsync(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUserWithOptions(string workspaceId, string agentCoreUserId, GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserWithOptionsAsync(string workspaceId, string agentCoreUserId, GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(string workspaceId, string agentCoreUserId, GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(string workspaceId, string agentCoreUserId, GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string workspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries workspace details by workspace ID, including lifecycle status, CMS Workspace, AIRegistry Namespace, and current network policy.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plug-in status of a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the plug-in status of a specified workspace. Returns whether the plug-in is enabled, its lifecycle status, and the currently effective configuration. Currently, two types of plug-ins are supported: collaboration and agentloop. If a plug-in is not installed, its status is DISABLED.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspacePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspacePluginResponse
        /// </returns>
        public GetWorkspacePluginResponse GetWorkspacePluginWithOptions(string workspaceId, string pluginName, GetWorkspacePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspacePlugin",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacePluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plug-in status of a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the plug-in status of a specified workspace. Returns whether the plug-in is enabled, its lifecycle status, and the currently effective configuration. Currently, two types of plug-ins are supported: collaboration and agentloop. If a plug-in is not installed, its status is DISABLED.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspacePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspacePluginResponse
        /// </returns>
        public async Task<GetWorkspacePluginResponse> GetWorkspacePluginWithOptionsAsync(string workspaceId, string pluginName, GetWorkspacePluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspacePlugin",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspacePluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plug-in status of a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the plug-in status of a specified workspace. Returns whether the plug-in is enabled, its lifecycle status, and the currently effective configuration. Currently, two types of plug-ins are supported: collaboration and agentloop. If a plug-in is not installed, its status is DISABLED.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspacePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspacePluginResponse
        /// </returns>
        public GetWorkspacePluginResponse GetWorkspacePlugin(string workspaceId, string pluginName, GetWorkspacePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspacePluginWithOptions(workspaceId, pluginName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plug-in status of a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nQueries the plug-in status of a specified workspace. Returns whether the plug-in is enabled, its lifecycle status, and the currently effective configuration. Currently, two types of plug-ins are supported: collaboration and agentloop. If a plug-in is not installed, its status is DISABLED.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspacePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspacePluginResponse
        /// </returns>
        public async Task<GetWorkspacePluginResponse> GetWorkspacePluginAsync(string workspaceId, string pluginName, GetWorkspacePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspacePluginWithOptionsAsync(workspaceId, pluginName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plugin for a specified AgentCore workspace. Currently supports the collaboration plugin. The installation process is executed asynchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nInstalls a plugin for a specified AgentCore workspace. Currently supports the <c>collaboration</c> plugin. Plugin configuration is passed through the <c>Config</c> parameter, and different plugins can define their own configuration structures. The <c>collaboration</c> plugin uses <c>Config.NetworkConfiguration</c> to specify VPC and public network access policies. The installation process is executed asynchronously. When you repeatedly call this operation for a plugin with the same name that is being installed or already installed, the operation returns the current status with idempotent semantics if the configuration is the same. If the configuration is different, the operation returns an operation conflict error.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallWorkspacePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallWorkspacePluginResponse
        /// </returns>
        public InstallWorkspacePluginResponse InstallWorkspacePluginWithOptions(string workspaceId, string pluginName, InstallWorkspacePluginRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallWorkspacePluginShrinkRequest request = new InstallWorkspacePluginShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallWorkspacePlugin",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallWorkspacePluginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plugin for a specified AgentCore workspace. Currently supports the collaboration plugin. The installation process is executed asynchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nInstalls a plugin for a specified AgentCore workspace. Currently supports the <c>collaboration</c> plugin. Plugin configuration is passed through the <c>Config</c> parameter, and different plugins can define their own configuration structures. The <c>collaboration</c> plugin uses <c>Config.NetworkConfiguration</c> to specify VPC and public network access policies. The installation process is executed asynchronously. When you repeatedly call this operation for a plugin with the same name that is being installed or already installed, the operation returns the current status with idempotent semantics if the configuration is the same. If the configuration is different, the operation returns an operation conflict error.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallWorkspacePluginRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallWorkspacePluginResponse
        /// </returns>
        public async Task<InstallWorkspacePluginResponse> InstallWorkspacePluginWithOptionsAsync(string workspaceId, string pluginName, InstallWorkspacePluginRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallWorkspacePluginShrinkRequest request = new InstallWorkspacePluginShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallWorkspacePlugin",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/plugins/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pluginName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallWorkspacePluginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plugin for a specified AgentCore workspace. Currently supports the collaboration plugin. The installation process is executed asynchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nInstalls a plugin for a specified AgentCore workspace. Currently supports the <c>collaboration</c> plugin. Plugin configuration is passed through the <c>Config</c> parameter, and different plugins can define their own configuration structures. The <c>collaboration</c> plugin uses <c>Config.NetworkConfiguration</c> to specify VPC and public network access policies. The installation process is executed asynchronously. When you repeatedly call this operation for a plugin with the same name that is being installed or already installed, the operation returns the current status with idempotent semantics if the configuration is the same. If the configuration is different, the operation returns an operation conflict error.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallWorkspacePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallWorkspacePluginResponse
        /// </returns>
        public InstallWorkspacePluginResponse InstallWorkspacePlugin(string workspaceId, string pluginName, InstallWorkspacePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallWorkspacePluginWithOptions(workspaceId, pluginName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs a plugin for a specified AgentCore workspace. Currently supports the collaboration plugin. The installation process is executed asynchronously.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nInstalls a plugin for a specified AgentCore workspace. Currently supports the <c>collaboration</c> plugin. Plugin configuration is passed through the <c>Config</c> parameter, and different plugins can define their own configuration structures. The <c>collaboration</c> plugin uses <c>Config.NetworkConfiguration</c> to specify VPC and public network access policies. The installation process is executed asynchronously. When you repeatedly call this operation for a plugin with the same name that is being installed or already installed, the operation returns the current status with idempotent semantics if the configuration is the same. If the configuration is different, the operation returns an operation conflict error.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallWorkspacePluginRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallWorkspacePluginResponse
        /// </returns>
        public async Task<InstallWorkspacePluginResponse> InstallWorkspacePluginAsync(string workspaceId, string pluginName, InstallWorkspacePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallWorkspacePluginWithOptionsAsync(workspaceId, pluginName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentIMChannelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentIMChannelsResponse
        /// </returns>
        public ListAgentIMChannelsResponse ListAgentIMChannelsWithOptions(string workspaceId, string agentId, ListAgentIMChannelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAgentIMChannels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentIMChannelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentIMChannelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentIMChannelsResponse
        /// </returns>
        public async Task<ListAgentIMChannelsResponse> ListAgentIMChannelsWithOptionsAsync(string workspaceId, string agentId, ListAgentIMChannelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListAgentIMChannels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentIMChannelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentIMChannelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentIMChannelsResponse
        /// </returns>
        public ListAgentIMChannelsResponse ListAgentIMChannels(string workspaceId, string agentId, ListAgentIMChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentIMChannelsWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the IM channel list of a specified agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentIMChannelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentIMChannelsResponse
        /// </returns>
        public async Task<ListAgentIMChannelsResponse> ListAgentIMChannelsAsync(string workspaceId, string agentId, ListAgentIMChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentIMChannelsWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSpecsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpecsResponse
        /// </returns>
        public ListAgentSpecsResponse ListAgentSpecsWithOptions(string workspaceId, ListAgentSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpecName))
            {
                query["agentSpecName"] = request.AgentSpecName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTag))
            {
                query["bizTag"] = request.BizTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCapabilities))
            {
                query["withCapabilities"] = request.WithCapabilities;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentSpecs",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSpecsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSpecsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpecsResponse
        /// </returns>
        public async Task<ListAgentSpecsResponse> ListAgentSpecsWithOptionsAsync(string workspaceId, ListAgentSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpecName))
            {
                query["agentSpecName"] = request.AgentSpecName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTag))
            {
                query["bizTag"] = request.BizTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithCapabilities))
            {
                query["withCapabilities"] = request.WithCapabilities;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentSpecs",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpecsResponse
        /// </returns>
        public ListAgentSpecsResponse ListAgentSpecs(string workspaceId, ListAgentSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentSpecsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries AgentSpec resources in a specified workspace by using paging, supporting name search, sorting, and filtering by owner, visibility scope, and business labels.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAgentSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpecsResponse
        /// </returns>
        public async Task<ListAgentSpecsResponse> ListAgentSpecsAsync(string workspaceId, ListAgentSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentSpecsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of teams to which specified agents belong. Specify the agent IDs through agentIds to retrieve the membership information between each agent and its teams, including the team ID, team name, and the role that the agent assumes in the team.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAgentTeamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentTeamsResponse
        /// </returns>
        public ListAgentTeamsResponse ListAgentTeamsWithOptions(string workspaceId, ListAgentTeamsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAgentTeamsShrinkRequest request = new ListAgentTeamsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentTeams",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-team-memberships",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentTeamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of teams to which specified agents belong. Specify the agent IDs through agentIds to retrieve the membership information between each agent and its teams, including the team ID, team name, and the role that the agent assumes in the team.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAgentTeamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentTeamsResponse
        /// </returns>
        public async Task<ListAgentTeamsResponse> ListAgentTeamsWithOptionsAsync(string workspaceId, ListAgentTeamsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAgentTeamsShrinkRequest request = new ListAgentTeamsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAgentTeams",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-team-memberships",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentTeamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of teams to which specified agents belong. Specify the agent IDs through agentIds to retrieve the membership information between each agent and its teams, including the team ID, team name, and the role that the agent assumes in the team.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentTeamsResponse
        /// </returns>
        public ListAgentTeamsResponse ListAgentTeams(string workspaceId, ListAgentTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentTeamsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of teams to which specified agents belong. Specify the agent IDs through agentIds to retrieve the membership information between each agent and its teams, including the team ID, team name, and the role that the agent assumes in the team.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentTeamsResponse
        /// </returns>
        public async Task<ListAgentTeamsResponse> ListAgentTeamsAsync(string workspaceId, ListAgentTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentTeamsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentialsWithOptions(string workspaceId, ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["credentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListCredentials",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsWithOptionsAsync(string workspaceId, ListCredentialsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["credentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListCredentials",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public ListCredentialsResponse ListCredentials(string workspaceId, ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCredentialsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询凭证列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCredentialsResponse
        /// </returns>
        public async Task<ListCredentialsResponse> ListCredentialsAsync(string workspaceId, ListCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCredentialsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalAgentsResponse
        /// </returns>
        public ListExternalAgentsResponse ListExternalAgentsWithOptions(string workspaceId, ListExternalAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListExternalAgents",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExternalAgentsResponse
        /// </returns>
        public async Task<ListExternalAgentsResponse> ListExternalAgentsWithOptionsAsync(string workspaceId, ListExternalAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListExternalAgents",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExternalAgentsResponse
        /// </returns>
        public ListExternalAgentsResponse ListExternalAgents(string workspaceId, ListExternalAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExternalAgentsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of external agents in a specified workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExternalAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExternalAgentsResponse
        /// </returns>
        public async Task<ListExternalAgentsResponse> ListExternalAgentsAsync(string workspaceId, ListExternalAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExternalAgentsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the external identity provider bound to a specified workspace. Each workspace can be bound to at most one external identity provider, so the response returns at most one record. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public ListIdentityProvidersResponse ListIdentityProvidersWithOptions(string workspaceId, ListIdentityProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListIdentityProviders",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the external identity provider bound to a specified workspace. Each workspace can be bound to at most one external identity provider, so the response returns at most one record. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public async Task<ListIdentityProvidersResponse> ListIdentityProvidersWithOptionsAsync(string workspaceId, ListIdentityProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListIdentityProviders",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentityProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the external identity provider bound to a specified workspace. Each workspace can be bound to at most one external identity provider, so the response returns at most one record. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public ListIdentityProvidersResponse ListIdentityProviders(string workspaceId, ListIdentityProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIdentityProvidersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the external identity provider bound to a specified workspace. Each workspace can be bound to at most one external identity provider, so the response returns at most one record. Application secret configurations are not returned.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdentityProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentityProvidersResponse
        /// </returns>
        public async Task<ListIdentityProvidersResponse> ListIdentityProvidersAsync(string workspaceId, ListIdentityProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIdentityProvidersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of managed agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of managed agents in a specified workspace by using paging. Returns summary information for each agent, including the identity, name, status, template, and specifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedAgentsResponse
        /// </returns>
        public ListManagedAgentsResponse ListManagedAgentsWithOptions(string workspaceId, ListManagedAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListManagedAgents",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of managed agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of managed agents in a specified workspace by using paging. Returns summary information for each agent, including the identity, name, status, template, and specifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedAgentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedAgentsResponse
        /// </returns>
        public async Task<ListManagedAgentsResponse> ListManagedAgentsWithOptionsAsync(string workspaceId, ListManagedAgentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListManagedAgents",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of managed agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of managed agents in a specified workspace by using paging. Returns summary information for each agent, including the identity, name, status, template, and specifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedAgentsResponse
        /// </returns>
        public ListManagedAgentsResponse ListManagedAgents(string workspaceId, ListManagedAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListManagedAgentsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of managed agents in a specified workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of managed agents in a specified workspace by using paging. Returns summary information for each agent, including the identity, name, status, template, and specifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedAgentsResponse
        /// </returns>
        public async Task<ListManagedAgentsResponse> ListManagedAgentsAsync(string workspaceId, ListManagedAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListManagedAgentsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public ListMcpToolsResponse ListMcpToolsWithOptions(string workspaceId, string mcpServerId, ListMcpToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMcpTools",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/tools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public async Task<ListMcpToolsResponse> ListMcpToolsWithOptionsAsync(string workspaceId, string mcpServerId, ListMcpToolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMcpTools",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId) + "/tools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public ListMcpToolsResponse ListMcpTools(string workspaceId, string mcpServerId, ListMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMcpToolsWithOptions(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries the list of tools exposed by a specified MCP service and their input/output schemas.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpToolsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpToolsResponse
        /// </returns>
        public async Task<ListMcpToolsResponse> ListMcpToolsAsync(string workspaceId, string mcpServerId, ListMcpToolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMcpToolsWithOptionsAsync(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public ListMcpsResponse ListMcpsWithOptions(string workspaceId, ListMcpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcps",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public async Task<ListMcpsResponse> ListMcpsWithOptionsAsync(string workspaceId, ListMcpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMcps",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMcpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public ListMcpsResponse ListMcps(string workspaceId, ListMcpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMcpsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Queries MCP services and their configurations and statuses in a specified workspace by using paging.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMcpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMcpsResponse
        /// </returns>
        public async Task<ListMcpsResponse> ListMcpsAsync(string workspaceId, ListMcpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMcpsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询指定 AgentCore 工作空间中的模型连接。支持通过 <c>Name</c> 按名称筛选，并通过 <c>SearchType</c> 选择精确匹配或模糊匹配；支持按模型提供商类型和调用协议筛选，并支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelConnectionsResponse
        /// </returns>
        public ListModelConnectionsResponse ListModelConnectionsWithOptions(string workspaceId, ListModelConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeModels))
            {
                query["includeModels"] = request.IncludeModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["providerType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelConnections",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询指定 AgentCore 工作空间中的模型连接。支持通过 <c>Name</c> 按名称筛选，并通过 <c>SearchType</c> 选择精确匹配或模糊匹配；支持按模型提供商类型和调用协议筛选，并支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelConnectionsResponse
        /// </returns>
        public async Task<ListModelConnectionsResponse> ListModelConnectionsWithOptionsAsync(string workspaceId, ListModelConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeModels))
            {
                query["includeModels"] = request.IncludeModels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                query["providerType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelConnections",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询指定 AgentCore 工作空间中的模型连接。支持通过 <c>Name</c> 按名称筛选，并通过 <c>SearchType</c> 选择精确匹配或模糊匹配；支持按模型提供商类型和调用协议筛选，并支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelConnectionsResponse
        /// </returns>
        public ListModelConnectionsResponse ListModelConnections(string workspaceId, ListModelConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelConnectionsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型连接列表</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>查询指定 AgentCore 工作空间中的模型连接。支持通过 <c>Name</c> 按名称筛选，并通过 <c>SearchType</c> 选择精确匹配或模糊匹配；支持按模型提供商类型和调用协议筛选，并支持分页查询。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelConnectionsResponse
        /// </returns>
        public async Task<ListModelConnectionsResponse> ListModelConnectionsAsync(string workspaceId, ListModelConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelConnectionsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries models in a specified workspace by using paging. Supports filtering by model connection and model name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModelsWithOptions(string workspaceId, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["connectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["modelName"] = request.ModelName;
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
                Action = "ListModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries models in a specified workspace by using paging. Supports filtering by model connection and model name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(string workspaceId, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["connectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["modelName"] = request.ModelName;
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
                Action = "ListModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries models in a specified workspace by using paging. Supports filtering by model connection and model name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModels(string workspaceId, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries models in a specified workspace by using paging. Supports filtering by model connection and model name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsAsync(string workspaceId, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预定义模型供应商目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelProvidersResponse
        /// </returns>
        public ListPredefinedModelProvidersResponse ListPredefinedModelProvidersWithOptions(ListPredefinedModelProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedModelProviders",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/model-catalog/providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedModelProvidersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预定义模型供应商目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelProvidersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelProvidersResponse
        /// </returns>
        public async Task<ListPredefinedModelProvidersResponse> ListPredefinedModelProvidersWithOptionsAsync(ListPredefinedModelProvidersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedModelProviders",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/model-catalog/providers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedModelProvidersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预定义模型供应商目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelProvidersResponse
        /// </returns>
        public ListPredefinedModelProvidersResponse ListPredefinedModelProviders(ListPredefinedModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPredefinedModelProvidersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预定义模型供应商目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelProvidersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelProvidersResponse
        /// </returns>
        public async Task<ListPredefinedModelProvidersResponse> ListPredefinedModelProvidersAsync(ListPredefinedModelProvidersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPredefinedModelProvidersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the models and their capability information for a specified provider in the AgentCore built-in model catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelsResponse
        /// </returns>
        public ListPredefinedModelsResponse ListPredefinedModelsWithOptions(string providerType, ListPredefinedModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/model-catalog/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(providerType) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the models and their capability information for a specified provider in the AgentCore built-in model catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelsResponse
        /// </returns>
        public async Task<ListPredefinedModelsResponse> ListPredefinedModelsWithOptionsAsync(string providerType, ListPredefinedModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPredefinedModels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/model-catalog/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(providerType) + "/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPredefinedModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the models and their capability information for a specified provider in the AgentCore built-in model catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelsResponse
        /// </returns>
        public ListPredefinedModelsResponse ListPredefinedModels(string providerType, ListPredefinedModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPredefinedModelsWithOptions(providerType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the models and their capability information for a specified provider in the AgentCore built-in model catalog.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPredefinedModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPredefinedModelsResponse
        /// </returns>
        public async Task<ListPredefinedModelsResponse> ListPredefinedModelsAsync(string providerType, ListPredefinedModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPredefinedModelsWithOptionsAsync(providerType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries service endpoints in a specified workspace by using paging. Supports filtering by target type, agent, collaboration component, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries service endpoints in a specified workspace by using paging. Filter results by targetType, agentId, agentVersion, resourceBindingId, collaborationComponent, and status. Use maxResults to specify the maximum number of records per page, and use nextToken to retrieve the next page. If maxResults is not specified, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public ListServiceEndpointsResponse ListServiceEndpointsWithOptions(string workspaceId, ListServiceEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationComponent))
            {
                query["collaborationComponent"] = request.CollaborationComponent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceBindingId))
            {
                query["resourceBindingId"] = request.ResourceBindingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEndpoints",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries service endpoints in a specified workspace by using paging. Supports filtering by target type, agent, collaboration component, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries service endpoints in a specified workspace by using paging. Filter results by targetType, agentId, agentVersion, resourceBindingId, collaborationComponent, and status. Use maxResults to specify the maximum number of records per page, and use nextToken to retrieve the next page. If maxResults is not specified, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public async Task<ListServiceEndpointsResponse> ListServiceEndpointsWithOptionsAsync(string workspaceId, ListServiceEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["agentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollaborationComponent))
            {
                query["collaborationComponent"] = request.CollaborationComponent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceBindingId))
            {
                query["resourceBindingId"] = request.ResourceBindingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEndpoints",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/service-endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries service endpoints in a specified workspace by using paging. Supports filtering by target type, agent, collaboration component, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries service endpoints in a specified workspace by using paging. Filter results by targetType, agentId, agentVersion, resourceBindingId, collaborationComponent, and status. Use maxResults to specify the maximum number of records per page, and use nextToken to retrieve the next page. If maxResults is not specified, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public ListServiceEndpointsResponse ListServiceEndpoints(string workspaceId, ListServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceEndpointsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries service endpoints in a specified workspace by using paging. Supports filtering by target type, agent, collaboration component, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries service endpoints in a specified workspace by using paging. Filter results by targetType, agentId, agentVersion, resourceBindingId, collaborationComponent, and status. Use maxResults to specify the maximum number of records per page, and use nextToken to retrieve the next page. If maxResults is not specified, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListServiceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceEndpointsResponse
        /// </returns>
        public async Task<ListServiceEndpointsResponse> ListServiceEndpointsAsync(string workspaceId, ListServiceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceEndpointsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkillsWithOptions(string workspaceId, ListSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsWithOptionsAsync(string workspaceId, ListSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["pageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                query["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkills",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public ListSkillsResponse ListSkills(string workspaceId, ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSkillsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Performs a paged query of Skills in a specified workspace, and returns basic Skill information, version status, and paging details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillsResponse
        /// </returns>
        public async Task<ListSkillsResponse> ListSkillsAsync(string workspaceId, ListSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSkillsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public ListTeamsResponse ListTeamsWithOptions(string workspaceId, ListTeamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListTeams",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public async Task<ListTeamsResponse> ListTeamsWithOptionsAsync(string workspaceId, ListTeamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListTeams",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTeamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public ListTeamsResponse ListTeams(string workspaceId, ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTeamsWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询团队列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTeamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTeamsResponse
        /// </returns>
        public async Task<ListTeamsResponse> ListTeamsAsync(string workspaceId, ListTeamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTeamsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(string workspaceId, ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListUsers",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(string workspaceId, ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameLike))
            {
                query["nameLike"] = request.NameLike;
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
                Action = "ListUsers",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(string workspaceId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(string workspaceId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of Deleted by default. Results are stably sorted by creation order on the server side.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of <c>Deleted</c> by default. Results are stably sorted by creation order on the server side. Use <c>nextToken</c> to retrieve the next page, <c>skip</c> to skip a specified number of workspaces, <c>maxResults</c> to specify the maximum number of records per page, and <c>nameLike</c> to filter workspaces by name using fuzzy match. If <c>maxResults</c> is not specified or is set to 0, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of Deleted by default. Results are stably sorted by creation order on the server side.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of <c>Deleted</c> by default. Results are stably sorted by creation order on the server side. Use <c>nextToken</c> to retrieve the next page, <c>skip</c> to skip a specified number of workspaces, <c>maxResults</c> to specify the maximum number of records per page, and <c>nameLike</c> to filter workspaces by name using fuzzy match. If <c>maxResults</c> is not specified or is set to 0, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of Deleted by default. Results are stably sorted by creation order on the server side.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of <c>Deleted</c> by default. Results are stably sorted by creation order on the server side. Use <c>nextToken</c> to retrieve the next page, <c>skip</c> to skip a specified number of workspaces, <c>maxResults</c> to specify the maximum number of records per page, and <c>nameLike</c> to filter workspaces by name using fuzzy match. If <c>maxResults</c> is not specified or is set to 0, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of Deleted by default. Results are stably sorted by creation order on the server side.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description\nQueries workspaces under the current tenant with paging. The list does not return soft-deleted records with a status of <c>Deleted</c> by default. Results are stably sorted by creation order on the server side. Use <c>nextToken</c> to retrieve the next page, <c>skip</c> to skip a specified number of workspaces, <c>maxResults</c> to specify the maximum number of records per page, and <c>nameLike</c> to filter workspaces by name using fuzzy match. If <c>maxResults</c> is not specified or is set to 0, the server returns 20 records by default.\n</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OfflineSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineSkillResponse
        /// </returns>
        public OfflineSkillResponse OfflineSkillWithOptions(string workspaceId, string skillName, OfflineSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OfflineSkillShrinkRequest request = new OfflineSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/actions/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OfflineSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineSkillResponse
        /// </returns>
        public async Task<OfflineSkillResponse> OfflineSkillWithOptionsAsync(string workspaceId, string skillName, OfflineSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OfflineSkillShrinkRequest request = new OfflineSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/actions/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OfflineSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineSkillResponse
        /// </returns>
        public OfflineSkillResponse OfflineSkill(string workspaceId, string skillName, OfflineSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineSkillWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Takes the online version of a specified Skill offline so that it is no longer used as the online version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OfflineSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineSkillResponse
        /// </returns>
        public async Task<OfflineSkillResponse> OfflineSkillAsync(string workspaceId, string skillName, OfflineSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineSkillWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OnlineSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineSkillResponse
        /// </returns>
        public OnlineSkillResponse OnlineSkillWithOptions(string workspaceId, string skillName, OnlineSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OnlineSkillShrinkRequest request = new OnlineSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/actions/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OnlineSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineSkillResponse
        /// </returns>
        public async Task<OnlineSkillResponse> OnlineSkillWithOptionsAsync(string workspaceId, string skillName, OnlineSkillRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OnlineSkillShrinkRequest request = new OnlineSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineSkill",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/actions/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineSkillResponse
        /// </returns>
        public OnlineSkillResponse OnlineSkill(string workspaceId, string skillName, OnlineSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineSkillWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Sets a specified Skill version as the online version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineSkillResponse
        /// </returns>
        public async Task<OnlineSkillResponse> OnlineSkillAsync(string workspaceId, string skillName, OnlineSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineSkillWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PrecheckSkillUploadViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckSkillUploadViaOssResponse
        /// </returns>
        public PrecheckSkillUploadViaOssResponse PrecheckSkillUploadViaOssWithOptions(string workspaceId, PrecheckSkillUploadViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PrecheckSkillUploadViaOssShrinkRequest request = new PrecheckSkillUploadViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckSkillUploadViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/precheck-upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckSkillUploadViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PrecheckSkillUploadViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckSkillUploadViaOssResponse
        /// </returns>
        public async Task<PrecheckSkillUploadViaOssResponse> PrecheckSkillUploadViaOssWithOptionsAsync(string workspaceId, PrecheckSkillUploadViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PrecheckSkillUploadViaOssShrinkRequest request = new PrecheckSkillUploadViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckSkillUploadViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/precheck-upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckSkillUploadViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckSkillUploadViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckSkillUploadViaOssResponse
        /// </returns>
        public PrecheckSkillUploadViaOssResponse PrecheckSkillUploadViaOss(string workspaceId, PrecheckSkillUploadViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PrecheckSkillUploadViaOssWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Parses and checks one or more Skill ZIP packages uploaded to OSS, and returns the name, version, and conflict check results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckSkillUploadViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckSkillUploadViaOssResponse
        /// </returns>
        public async Task<PrecheckSkillUploadViaOssResponse> PrecheckSkillUploadViaOssAsync(string workspaceId, PrecheckSkillUploadViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PrecheckSkillUploadViaOssWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PublishSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishSkillVersionResponse
        /// </returns>
        public PublishSkillVersionResponse PublishSkillVersionWithOptions(string workspaceId, string skillName, string skillVersion, PublishSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishSkillVersionShrinkRequest request = new PublishSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishSkillVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PublishSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishSkillVersionResponse
        /// </returns>
        public async Task<PublishSkillVersionResponse> PublishSkillVersionWithOptionsAsync(string workspaceId, string skillName, string skillVersion, PublishSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PublishSkillVersionShrinkRequest request = new PublishSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishSkillVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishSkillVersionResponse
        /// </returns>
        public PublishSkillVersionResponse PublishSkillVersion(string workspaceId, string skillName, string skillVersion, PublishSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishSkillVersionWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Publishes a specified Skill version to change its state to published.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishSkillVersionResponse
        /// </returns>
        public async Task<PublishSkillVersionResponse> PublishSkillVersionAsync(string workspaceId, string skillName, string skillVersion, PublishSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishSkillVersionWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RedraftSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedraftSkillVersionResponse
        /// </returns>
        public RedraftSkillVersionResponse RedraftSkillVersionWithOptions(string workspaceId, string skillName, string skillVersion, RedraftSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RedraftSkillVersionShrinkRequest request = new RedraftSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RedraftSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/redraft",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedraftSkillVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RedraftSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedraftSkillVersionResponse
        /// </returns>
        public async Task<RedraftSkillVersionResponse> RedraftSkillVersionWithOptionsAsync(string workspaceId, string skillName, string skillVersion, RedraftSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RedraftSkillVersionShrinkRequest request = new RedraftSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RedraftSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/redraft",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedraftSkillVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedraftSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RedraftSkillVersionResponse
        /// </returns>
        public RedraftSkillVersionResponse RedraftSkillVersion(string workspaceId, string skillName, string skillVersion, RedraftSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RedraftSkillVersionWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Converts a specified Skill version back into an editable draft for further modifications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedraftSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// RedraftSkillVersionResponse
        /// </returns>
        public async Task<RedraftSkillVersionResponse> RedraftSkillVersionAsync(string workspaceId, string skillName, string skillVersion, RedraftSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RedraftSkillVersionWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPasswordWithOptions(string workspaceId, ResetUserPasswordRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetUserPasswordShrinkRequest request = new ResetUserPasswordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/actions/reset-password",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ResetUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(string workspaceId, ResetUserPasswordRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ResetUserPasswordShrinkRequest request = new ResetUserPasswordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetUserPassword",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/actions/reset-password",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public ResetUserPasswordResponse ResetUserPassword(string workspaceId, ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetUserPasswordWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetUserPasswordResponse
        /// </returns>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(string workspaceId, ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetUserPasswordWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentSpecVersionResponse
        /// </returns>
        public SubmitAgentSpecVersionResponse SubmitAgentSpecVersionWithOptions(string workspaceId, string agentSpecName, string agentSpecVersion, SubmitAgentSpecVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitAgentSpecVersionShrinkRequest request = new SubmitAgentSpecVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecVersion) + "/actions/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAgentSpecVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitAgentSpecVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentSpecVersionResponse
        /// </returns>
        public async Task<SubmitAgentSpecVersionResponse> SubmitAgentSpecVersionWithOptionsAsync(string workspaceId, string agentSpecName, string agentSpecVersion, SubmitAgentSpecVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitAgentSpecVersionShrinkRequest request = new SubmitAgentSpecVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAgentSpecVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecVersion) + "/actions/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAgentSpecVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentSpecVersionResponse
        /// </returns>
        public SubmitAgentSpecVersionResponse SubmitAgentSpecVersion(string workspaceId, string agentSpecName, string agentSpecVersion, SubmitAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitAgentSpecVersionWithOptions(workspaceId, agentSpecName, agentSpecVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified AgentSpec draft version for review. If no release pipeline is configured, the version is published directly to online status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitAgentSpecVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentSpecVersionResponse
        /// </returns>
        public async Task<SubmitAgentSpecVersionResponse> SubmitAgentSpecVersionAsync(string workspaceId, string agentSpecName, string agentSpecVersion, SubmitAgentSpecVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitAgentSpecVersionWithOptionsAsync(workspaceId, agentSpecName, agentSpecVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSkillVersionResponse
        /// </returns>
        public SubmitSkillVersionResponse SubmitSkillVersionWithOptions(string workspaceId, string skillName, string skillVersion, SubmitSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSkillVersionShrinkRequest request = new SubmitSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSkillVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SubmitSkillVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSkillVersionResponse
        /// </returns>
        public async Task<SubmitSkillVersionResponse> SubmitSkillVersionWithOptionsAsync(string workspaceId, string skillName, string skillVersion, SubmitSkillVersionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSkillVersionShrinkRequest request = new SubmitSkillVersionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSkillVersion",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillVersion) + "/actions/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSkillVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSkillVersionResponse
        /// </returns>
        public SubmitSkillVersionResponse SubmitSkillVersion(string workspaceId, string skillName, string skillVersion, SubmitSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitSkillVersionWithOptions(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Submits a specified draft version of a skill for review.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitSkillVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSkillVersionResponse
        /// </returns>
        public async Task<SubmitSkillVersionResponse> SubmitSkillVersionAsync(string workspaceId, string skillName, string skillVersion, SubmitSkillVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitSkillVersionWithOptionsAsync(workspaceId, skillName, skillVersion, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelResponse
        /// </returns>
        public UpdateAgentIMChannelResponse UpdateAgentIMChannelWithOptions(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentIMChannelShrinkRequest request = new UpdateAgentIMChannelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentIMChannelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentIMChannelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelResponse
        /// </returns>
        public async Task<UpdateAgentIMChannelResponse> UpdateAgentIMChannelWithOptionsAsync(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentIMChannelShrinkRequest request = new UpdateAgentIMChannelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentIMChannel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentIMChannelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelResponse
        /// </returns>
        public UpdateAgentIMChannelResponse UpdateAgentIMChannel(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentIMChannelWithOptions(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the ServiceEndpoint binding, enabled/disabled status, or channel behavior configuration of an IM channel. At least one updatable field must be provided.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentIMChannelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelResponse
        /// </returns>
        public async Task<UpdateAgentIMChannelResponse> UpdateAgentIMChannelAsync(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentIMChannelWithOptionsAsync(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentIMChannelCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelCredentialResponse
        /// </returns>
        public UpdateAgentIMChannelCredentialResponse UpdateAgentIMChannelCredentialWithOptions(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentIMChannelCredentialShrinkRequest request = new UpdateAgentIMChannelCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentIMChannelCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId) + "/actions/update-credential",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentIMChannelCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentIMChannelCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelCredentialResponse
        /// </returns>
        public async Task<UpdateAgentIMChannelCredentialResponse> UpdateAgentIMChannelCredentialWithOptionsAsync(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentIMChannelCredentialShrinkRequest request = new UpdateAgentIMChannelCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentIMChannelCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId) + "/im-channels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(imChannelId) + "/actions/update-credential",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentIMChannelCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentIMChannelCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelCredentialResponse
        /// </returns>
        public UpdateAgentIMChannelCredentialResponse UpdateAgentIMChannelCredential(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentIMChannelCredentialWithOptions(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a full update of the channel credential for a specified IM channel of an agent. Secrets are not returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentIMChannelCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentIMChannelCredentialResponse
        /// </returns>
        public async Task<UpdateAgentIMChannelCredentialResponse> UpdateAgentIMChannelCredentialAsync(string workspaceId, string agentId, string imChannelId, UpdateAgentIMChannelCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentIMChannelCredentialWithOptionsAsync(workspaceId, agentId, imChannelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpecResponse
        /// </returns>
        public UpdateAgentSpecResponse UpdateAgentSpecWithOptions(string workspaceId, string agentSpecName, UpdateAgentSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentSpecShrinkRequest request = new UpdateAgentSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateAgentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpecResponse
        /// </returns>
        public async Task<UpdateAgentSpecResponse> UpdateAgentSpecWithOptionsAsync(string workspaceId, string agentSpecName, UpdateAgentSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAgentSpecShrinkRequest request = new UpdateAgentSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentSpec",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-specs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpecName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpecResponse
        /// </returns>
        public UpdateAgentSpecResponse UpdateAgentSpec(string workspaceId, string agentSpecName, UpdateAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentSpecWithOptions(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags, version labels, and visibility scope of a specified AgentSpec. Fields that are not provided remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAgentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpecResponse
        /// </returns>
        public async Task<UpdateAgentSpecResponse> UpdateAgentSpecAsync(string workspaceId, string agentSpecName, UpdateAgentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentSpecWithOptionsAsync(workspaceId, agentSpecName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredentialWithOptions(string workspaceId, string credentialId, UpdateCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCredentialShrinkRequest request = new UpdateCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCredentialRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialWithOptionsAsync(string workspaceId, string credentialId, UpdateCredentialRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCredentialShrinkRequest request = new UpdateCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredential",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/credentials/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(credentialId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public UpdateCredentialResponse UpdateCredential(string workspaceId, string credentialId, UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCredentialWithOptions(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialResponse
        /// </returns>
        public async Task<UpdateCredentialResponse> UpdateCredentialAsync(string workspaceId, string credentialId, UpdateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCredentialWithOptionsAsync(workspaceId, credentialId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExternalAgentResponse
        /// </returns>
        public UpdateExternalAgentResponse UpdateExternalAgentWithOptions(string workspaceId, string agentId, UpdateExternalAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateExternalAgentShrinkRequest request = new UpdateExternalAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateExternalAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExternalAgentResponse
        /// </returns>
        public async Task<UpdateExternalAgentResponse> UpdateExternalAgentWithOptionsAsync(string workspaceId, string agentId, UpdateExternalAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateExternalAgentShrinkRequest request = new UpdateExternalAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExternalAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/external-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExternalAgentResponse
        /// </returns>
        public UpdateExternalAgentResponse UpdateExternalAgent(string workspaceId, string agentId, UpdateExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExternalAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the configuration of a specified external agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateExternalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExternalAgentResponse
        /// </returns>
        public async Task<UpdateExternalAgentResponse> UpdateExternalAgentAsync(string workspaceId, string agentId, UpdateExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExternalAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the login switch, member synchronization switch, or application configuration of a specified external identity provider in a workspace. Unspecified properties remain unchanged. The update is an asynchronous operation. After the API returns, you can call GetIdentityProvider to query the status and track progress.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public UpdateIdentityProviderResponse UpdateIdentityProviderWithOptions(string workspaceId, string identityProviderType, UpdateIdentityProviderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIdentityProviderShrinkRequest request = new UpdateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityProviderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the login switch, member synchronization switch, or application configuration of a specified external identity provider in a workspace. Unspecified properties remain unchanged. The update is an asynchronous operation. After the API returns, you can call GetIdentityProvider to query the status and track progress.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public async Task<UpdateIdentityProviderResponse> UpdateIdentityProviderWithOptionsAsync(string workspaceId, string identityProviderType, UpdateIdentityProviderRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateIdentityProviderShrinkRequest request = new UpdateIdentityProviderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdentityProvider",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/identity-providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identityProviderType),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdentityProviderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the login switch, member synchronization switch, or application configuration of a specified external identity provider in a workspace. Unspecified properties remain unchanged. The update is an asynchronous operation. After the API returns, you can call GetIdentityProvider to query the status and track progress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public UpdateIdentityProviderResponse UpdateIdentityProvider(string workspaceId, string identityProviderType, UpdateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIdentityProviderWithOptions(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the login switch, member synchronization switch, or application configuration of a specified external identity provider in a workspace. Unspecified properties remain unchanged. The update is an asynchronous operation. After the API returns, you can call GetIdentityProvider to query the status and track progress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdentityProviderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdentityProviderResponse
        /// </returns>
        public async Task<UpdateIdentityProviderResponse> UpdateIdentityProviderAsync(string workspaceId, string identityProviderType, UpdateIdentityProviderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIdentityProviderWithOptionsAsync(workspaceId, identityProviderType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagedAgentResponse
        /// </returns>
        public UpdateManagedAgentResponse UpdateManagedAgentWithOptions(string workspaceId, string agentId, UpdateManagedAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateManagedAgentShrinkRequest request = new UpdateManagedAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateManagedAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateManagedAgentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagedAgentResponse
        /// </returns>
        public async Task<UpdateManagedAgentResponse> UpdateManagedAgentWithOptionsAsync(string workspaceId, string agentId, UpdateManagedAgentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateManagedAgentShrinkRequest request = new UpdateManagedAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateManagedAgent",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/managed-agents/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateManagedAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagedAgentResponse
        /// </returns>
        public UpdateManagedAgentResponse UpdateManagedAgent(string workspaceId, string agentId, UpdateManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateManagedAgentWithOptions(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration of a specified managed agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateManagedAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateManagedAgentResponse
        /// </returns>
        public async Task<UpdateManagedAgentResponse> UpdateManagedAgentAsync(string workspaceId, string agentId, UpdateManagedAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateManagedAgentWithOptionsAsync(workspaceId, agentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public UpdateMcpResponse UpdateMcpWithOptions(string workspaceId, string mcpServerId, UpdateMcpRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMcpShrinkRequest request = new UpdateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMcpRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public async Task<UpdateMcpResponse> UpdateMcpWithOptionsAsync(string workspaceId, string mcpServerId, UpdateMcpRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMcpShrinkRequest request = new UpdateMcpShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMcp",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/mcp-servers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(mcpServerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMcpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public UpdateMcpResponse UpdateMcp(string workspaceId, string mcpServerId, UpdateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMcpWithOptions(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the address, description, authentication, or Swagger configuration of a specified MCP service. The MCP type and protocol cannot be modified after creation. The update is an asynchronous process.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMcpRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMcpResponse
        /// </returns>
        public async Task<UpdateMcpResponse> UpdateMcpAsync(string workspaceId, string mcpServerId, UpdateMcpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMcpWithOptionsAsync(workspaceId, mcpServerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified model. Other model configurations cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModelWithOptions(string workspaceId, string modelId, UpdateModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelShrinkRequest request = new UpdateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified model. Other model configurations cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelWithOptionsAsync(string workspaceId, string modelId, UpdateModelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelShrinkRequest request = new UpdateModelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified model. Other model configurations cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModel(string workspaceId, string modelId, UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelWithOptions(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a specified model. Other model configurations cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelAsync(string workspaceId, string modelId, UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelWithOptionsAsync(workspaceId, modelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the mutable configuration of a specified model connection and resubmits the publish task. The protocol cannot be modified after the model connection is created.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelConnectionResponse
        /// </returns>
        public UpdateModelConnectionResponse UpdateModelConnectionWithOptions(string workspaceId, string connectionId, UpdateModelConnectionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelConnectionShrinkRequest request = new UpdateModelConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the mutable configuration of a specified model connection and resubmits the publish task. The protocol cannot be modified after the model connection is created.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateModelConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelConnectionResponse
        /// </returns>
        public async Task<UpdateModelConnectionResponse> UpdateModelConnectionWithOptionsAsync(string workspaceId, string connectionId, UpdateModelConnectionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateModelConnectionShrinkRequest request = new UpdateModelConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelConnection",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/model-connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(connectionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the mutable configuration of a specified model connection and resubmits the publish task. The protocol cannot be modified after the model connection is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelConnectionResponse
        /// </returns>
        public UpdateModelConnectionResponse UpdateModelConnection(string workspaceId, string connectionId, UpdateModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelConnectionWithOptions(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the mutable configuration of a specified model connection and resubmits the publish task. The protocol cannot be modified after the model connection is created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelConnectionResponse
        /// </returns>
        public async Task<UpdateModelConnectionResponse> UpdateModelConnectionAsync(string workspaceId, string connectionId, UpdateModelConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelConnectionWithOptionsAsync(workspaceId, connectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillBizTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillBizTagsResponse
        /// </returns>
        public UpdateSkillBizTagsResponse UpdateSkillBizTagsWithOptions(string workspaceId, string skillName, UpdateSkillBizTagsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillBizTagsShrinkRequest request = new UpdateSkillBizTagsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillBizTags",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/biz-tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillBizTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillBizTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillBizTagsResponse
        /// </returns>
        public async Task<UpdateSkillBizTagsResponse> UpdateSkillBizTagsWithOptionsAsync(string workspaceId, string skillName, UpdateSkillBizTagsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillBizTagsShrinkRequest request = new UpdateSkillBizTagsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillBizTags",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/biz-tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillBizTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillBizTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillBizTagsResponse
        /// </returns>
        public UpdateSkillBizTagsResponse UpdateSkillBizTags(string workspaceId, string skillName, UpdateSkillBizTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSkillBizTagsWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Updates the business tags of a specified Skill. Other attributes that are not included in the request remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillBizTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillBizTagsResponse
        /// </returns>
        public async Task<UpdateSkillBizTagsResponse> UpdateSkillBizTagsAsync(string workspaceId, string skillName, UpdateSkillBizTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSkillBizTagsWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillLabelsResponse
        /// </returns>
        public UpdateSkillLabelsResponse UpdateSkillLabelsWithOptions(string workspaceId, string skillName, UpdateSkillLabelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillLabelsShrinkRequest request = new UpdateSkillLabelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillLabels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillLabelsResponse
        /// </returns>
        public async Task<UpdateSkillLabelsResponse> UpdateSkillLabelsWithOptionsAsync(string workspaceId, string skillName, UpdateSkillLabelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillLabelsShrinkRequest request = new UpdateSkillLabelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillLabels",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillLabelsResponse
        /// </returns>
        public UpdateSkillLabelsResponse UpdateSkillLabels(string workspaceId, string skillName, UpdateSkillLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSkillLabelsWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the version labels and their mappings for a specified Skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillLabelsResponse
        /// </returns>
        public async Task<UpdateSkillLabelsResponse> UpdateSkillLabelsAsync(string workspaceId, string skillName, UpdateSkillLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSkillLabelsWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillScopeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillScopeResponse
        /// </returns>
        public UpdateSkillScopeResponse UpdateSkillScopeWithOptions(string workspaceId, string skillName, UpdateSkillScopeRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillScopeShrinkRequest request = new UpdateSkillScopeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillScope",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/scope",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillScopeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillScopeResponse
        /// </returns>
        public async Task<UpdateSkillScopeResponse> UpdateSkillScopeWithOptionsAsync(string workspaceId, string skillName, UpdateSkillScopeRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillScopeShrinkRequest request = new UpdateSkillScopeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillScope",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skills/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName) + "/scope",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillScopeResponse
        /// </returns>
        public UpdateSkillScopeResponse UpdateSkillScope(string workspaceId, string skillName, UpdateSkillScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSkillScopeWithOptions(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>Updates the visibility scope of a specified skill.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSkillScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillScopeResponse
        /// </returns>
        public async Task<UpdateSkillScopeResponse> UpdateSkillScopeAsync(string workspaceId, string skillName, UpdateSkillScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSkillScopeWithOptionsAsync(workspaceId, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeamWithOptions(string workspaceId, string teamId, UpdateTeamRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTeamShrinkRequest request = new UpdateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTeamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamWithOptionsAsync(string workspaceId, string teamId, UpdateTeamRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTeamShrinkRequest request = new UpdateTeamShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTeam",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/teams/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(teamId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTeamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public UpdateTeamResponse UpdateTeam(string workspaceId, string teamId, UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTeamWithOptions(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新团队</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTeamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTeamResponse
        /// </returns>
        public async Task<UpdateTeamResponse> UpdateTeamAsync(string workspaceId, string teamId, UpdateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTeamWithOptionsAsync(workspaceId, teamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUserWithOptions(string workspaceId, string agentCoreUserId, UpdateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(string workspaceId, string agentCoreUserId, UpdateUserRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateUserShrinkRequest request = new UpdateUserShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentCoreUserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(string workspaceId, string agentCoreUserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserWithOptions(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(string workspaceId, string agentCoreUserId, UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserWithOptionsAsync(workspaceId, agentCoreUserId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name or network configuration of a workspace. Only workspaces in the Initialized status can be updated. Status, TenantId, and RegionId are maintained by the server and cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nUpdates the name or network configuration of a workspace. Only workspaces in the <c>Initialized</c> status can be updated. <c>Status</c>, <c>TenantId</c>, and <c>RegionId</c> are maintained by the server and cannot be modified through this operation. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must also provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspaceWithOptions(string workspaceId, UpdateWorkspaceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceShrinkRequest request = new UpdateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name or network configuration of a workspace. Only workspaces in the Initialized status can be updated. Status, TenantId, and RegionId are maintained by the server and cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nUpdates the name or network configuration of a workspace. Only workspaces in the <c>Initialized</c> status can be updated. <c>Status</c>, <c>TenantId</c>, and <c>RegionId</c> are maintained by the server and cannot be modified through this operation. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must also provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceWithOptionsAsync(string workspaceId, UpdateWorkspaceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateWorkspaceShrinkRequest request = new UpdateWorkspaceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name or network configuration of a workspace. Only workspaces in the Initialized status can be updated. Status, TenantId, and RegionId are maintained by the server and cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nUpdates the name or network configuration of a workspace. Only workspaces in the <c>Initialized</c> status can be updated. <c>Status</c>, <c>TenantId</c>, and <c>RegionId</c> are maintained by the server and cannot be modified through this operation. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must also provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspace(string workspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name or network configuration of a workspace. Only workspaces in the Initialized status can be updated. Status, TenantId, and RegionId are maintained by the server and cannot be modified through this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description\nUpdates the name or network configuration of a workspace. Only workspaces in the <c>Initialized</c> status can be updated. <c>Status</c>, <c>TenantId</c>, and <c>RegionId</c> are maintained by the server and cannot be modified through this operation. The network configuration uses <c>Enabled</c> to specify whether to enable VPC networking. When enabled, you must also provide <c>VpcId</c> and at least one <c>VSwitchIds</c>.\n.</h2>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(string workspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UploadAgentSpecViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadAgentSpecViaOssResponse
        /// </returns>
        public UploadAgentSpecViaOssResponse UploadAgentSpecViaOssWithOptions(string workspaceId, UploadAgentSpecViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadAgentSpecViaOssShrinkRequest request = new UploadAgentSpecViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadAgentSpecViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-spec-actions/upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAgentSpecViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UploadAgentSpecViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadAgentSpecViaOssResponse
        /// </returns>
        public async Task<UploadAgentSpecViaOssResponse> UploadAgentSpecViaOssWithOptionsAsync(string workspaceId, UploadAgentSpecViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadAgentSpecViaOssShrinkRequest request = new UploadAgentSpecViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadAgentSpecViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/agent-spec-actions/upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAgentSpecViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadAgentSpecViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadAgentSpecViaOssResponse
        /// </returns>
        public UploadAgentSpecViaOssResponse UploadAgentSpecViaOss(string workspaceId, UploadAgentSpecViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadAgentSpecViaOssWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded AgentSpec ZIP package from OSS, parses it, and imports the AgentSpec into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadAgentSpecViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadAgentSpecViaOssResponse
        /// </returns>
        public async Task<UploadAgentSpecViaOssResponse> UploadAgentSpecViaOssAsync(string workspaceId, UploadAgentSpecViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadAgentSpecViaOssWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UploadSkillViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadSkillViaOssResponse
        /// </returns>
        public UploadSkillViaOssResponse UploadSkillViaOssWithOptions(string workspaceId, UploadSkillViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadSkillViaOssShrinkRequest request = new UploadSkillViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadSkillViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadSkillViaOssResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UploadSkillViaOssRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadSkillViaOssResponse
        /// </returns>
        public async Task<UploadSkillViaOssResponse> UploadSkillViaOssWithOptionsAsync(string workspaceId, UploadSkillViaOssRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadSkillViaOssShrinkRequest request = new UploadSkillViaOssShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                body["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadSkillViaOss",
                Version = "2026-08-04",
                Protocol = "HTTPS",
                Pathname = "/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/skill-actions/upload-via-oss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadSkillViaOssResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadSkillViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadSkillViaOssResponse
        /// </returns>
        public UploadSkillViaOssResponse UploadSkillViaOss(string workspaceId, UploadSkillViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadSkillViaOssWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>Retrieves an uploaded Skill ZIP package from OSS, parses it, and imports the Skill into the current workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadSkillViaOssRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadSkillViaOssResponse
        /// </returns>
        public async Task<UploadSkillViaOssResponse> UploadSkillViaOssAsync(string workspaceId, UploadSkillViaOssRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadSkillViaOssWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
