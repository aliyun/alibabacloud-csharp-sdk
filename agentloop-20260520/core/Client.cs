// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AgentLoop20260520.Models;

namespace AlibabaCloud.SDK.AgentLoop20260520
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("agentloop", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>给记忆库中增加数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMem0MemoriesResponse
        /// </returns>
        public AddMem0MemoriesResponse AddMem0MemoriesWithOptions(AddMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMem0MemoriesResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给记忆库中增加数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddMem0MemoriesResponse
        /// </returns>
        public async Task<AddMem0MemoriesResponse> AddMem0MemoriesWithOptionsAsync(AddMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMem0MemoriesResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给记忆库中增加数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMem0MemoriesResponse
        /// </returns>
        public AddMem0MemoriesResponse AddMem0Memories(AddMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMem0MemoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>给记忆库中增加数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// AddMem0MemoriesResponse
        /// </returns>
        public async Task<AddMem0MemoriesResponse> AddMem0MemoriesAsync(AddMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMem0MemoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpaceResponse
        /// </returns>
        public CreateAgentSpaceResponse CreateAgentSpaceWithOptions(CreateAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                body["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsWorkspace))
            {
                body["cmsWorkspace"] = request.CmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpaceResponse
        /// </returns>
        public async Task<CreateAgentSpaceResponse> CreateAgentSpaceWithOptionsAsync(CreateAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                body["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsWorkspace))
            {
                body["cmsWorkspace"] = request.CmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentSpaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpaceResponse
        /// </returns>
        public CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAgentSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentSpaceResponse
        /// </returns>
        public async Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAgentSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreResponse
        /// </returns>
        public CreateContextStoreResponse CreateContextStoreWithOptions(string agentSpace, CreateContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreName))
            {
                body["contextStoreName"] = request.ContextStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                body["contextType"] = request.ContextType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreResponse
        /// </returns>
        public async Task<CreateContextStoreResponse> CreateContextStoreWithOptionsAsync(string agentSpace, CreateContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreName))
            {
                body["contextStoreName"] = request.ContextStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                body["contextType"] = request.ContextType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreResponse
        /// </returns>
        public CreateContextStoreResponse CreateContextStore(string agentSpace, CreateContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateContextStoreWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreResponse
        /// </returns>
        public async Task<CreateContextStoreResponse> CreateContextStoreAsync(string agentSpace, CreateContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateContextStoreWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreAPIKeyResponse
        /// </returns>
        public CreateContextStoreAPIKeyResponse CreateContextStoreAPIKeyWithOptions(string agentSpace, string contextStoreName, CreateContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextStoreAPIKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreAPIKeyResponse
        /// </returns>
        public async Task<CreateContextStoreAPIKeyResponse> CreateContextStoreAPIKeyWithOptionsAsync(string agentSpace, string contextStoreName, CreateContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextStoreAPIKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreAPIKeyResponse
        /// </returns>
        public CreateContextStoreAPIKeyResponse CreateContextStoreAPIKey(string agentSpace, string contextStoreName, CreateContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateContextStoreAPIKeyWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextStoreAPIKeyResponse
        /// </returns>
        public async Task<CreateContextStoreAPIKeyResponse> CreateContextStoreAPIKeyAsync(string agentSpace, string contextStoreName, CreateContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateContextStoreAPIKeyWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDatasetWithOptions(string agentSpace, CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(string agentSpace, CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["datasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDataset(string agentSpace, CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetAsync(string agentSpace, CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpaceResponse
        /// </returns>
        public DeleteAgentSpaceResponse DeleteAgentSpaceWithOptions(string agentSpace, DeleteAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCmsWorkspace))
            {
                query["deleteCmsWorkspace"] = request.DeleteCmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMseNamespace))
            {
                query["deleteMseNamespace"] = request.DeleteMseNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteSlsProject))
            {
                query["deleteSlsProject"] = request.DeleteSlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpaceResponse
        /// </returns>
        public async Task<DeleteAgentSpaceResponse> DeleteAgentSpaceWithOptionsAsync(string agentSpace, DeleteAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteCmsWorkspace))
            {
                query["deleteCmsWorkspace"] = request.DeleteCmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteMseNamespace))
            {
                query["deleteMseNamespace"] = request.DeleteMseNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteSlsProject))
            {
                query["deleteSlsProject"] = request.DeleteSlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentSpaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpaceResponse
        /// </returns>
        public DeleteAgentSpaceResponse DeleteAgentSpace(string agentSpace, DeleteAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAgentSpaceWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentSpaceResponse
        /// </returns>
        public async Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(string agentSpace, DeleteAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAgentSpaceWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreResponse
        /// </returns>
        public DeleteContextStoreResponse DeleteContextStoreWithOptions(string agentSpace, string contextStoreName, DeleteContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreResponse
        /// </returns>
        public async Task<DeleteContextStoreResponse> DeleteContextStoreWithOptionsAsync(string agentSpace, string contextStoreName, DeleteContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreResponse
        /// </returns>
        public DeleteContextStoreResponse DeleteContextStore(string agentSpace, string contextStoreName, DeleteContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteContextStoreWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreResponse
        /// </returns>
        public async Task<DeleteContextStoreResponse> DeleteContextStoreAsync(string agentSpace, string contextStoreName, DeleteContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteContextStoreWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreAPIKeyResponse
        /// </returns>
        public DeleteContextStoreAPIKeyResponse DeleteContextStoreAPIKeyWithOptions(string agentSpace, string contextStoreName, string name, DeleteContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextStoreAPIKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreAPIKeyResponse
        /// </returns>
        public async Task<DeleteContextStoreAPIKeyResponse> DeleteContextStoreAPIKeyWithOptionsAsync(string agentSpace, string contextStoreName, string name, DeleteContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextStoreAPIKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreAPIKeyResponse
        /// </returns>
        public DeleteContextStoreAPIKeyResponse DeleteContextStoreAPIKey(string agentSpace, string contextStoreName, string name, DeleteContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteContextStoreAPIKeyWithOptions(agentSpace, contextStoreName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextStoreAPIKeyResponse
        /// </returns>
        public async Task<DeleteContextStoreAPIKeyResponse> DeleteContextStoreAPIKeyAsync(string agentSpace, string contextStoreName, string name, DeleteContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteContextStoreAPIKeyWithOptionsAsync(agentSpace, contextStoreName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDatasetWithOptions(string agentSpace, string datasetName, DeleteDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(string agentSpace, string datasetName, DeleteDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDataset(string agentSpace, string datasetName, DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetWithOptions(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(string agentSpace, string datasetName, DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetWithOptionsAsync(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoriesResponse
        /// </returns>
        public DeleteMem0MemoriesResponse DeleteMem0MemoriesWithOptions(DeleteMem0MemoriesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMem0MemoriesShrinkRequest request = new DeleteMem0MemoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "metadata", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                query["metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories",
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMem0MemoriesResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoriesResponse
        /// </returns>
        public async Task<DeleteMem0MemoriesResponse> DeleteMem0MemoriesWithOptionsAsync(DeleteMem0MemoriesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteMem0MemoriesShrinkRequest request = new DeleteMem0MemoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Metadata))
            {
                request.MetadataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Metadata, "metadata", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["agent_id"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["app_id"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetadataShrink))
            {
                query["metadata"] = request.MetadataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["run_id"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["user_id"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories",
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMem0MemoriesResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoriesResponse
        /// </returns>
        public DeleteMem0MemoriesResponse DeleteMem0Memories(DeleteMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMem0MemoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoriesResponse
        /// </returns>
        public async Task<DeleteMem0MemoriesResponse> DeleteMem0MemoriesAsync(DeleteMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMem0MemoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoryResponse
        /// </returns>
        public DeleteMem0MemoryResponse DeleteMem0MemoryWithOptions(string memoryId, DeleteMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMem0MemoryResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoryResponse
        /// </returns>
        public async Task<DeleteMem0MemoryResponse> DeleteMem0MemoryWithOptionsAsync(string memoryId, DeleteMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMem0MemoryResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoryResponse
        /// </returns>
        public DeleteMem0MemoryResponse DeleteMem0Memory(string memoryId, DeleteMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMem0MemoryWithOptions(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMem0MemoryResponse
        /// </returns>
        public async Task<DeleteMem0MemoryResponse> DeleteMem0MemoryAsync(string memoryId, DeleteMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMem0MemoryWithOptionsAsync(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public DeletePipelineResponse DeletePipelineWithOptions(string agentSpace, string pipelineName, DeletePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(string agentSpace, string pipelineName, DeletePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public DeletePipelineResponse DeletePipeline(string agentSpace, string pipelineName, DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePipelineResponse
        /// </returns>
        public async Task<DeletePipelineResponse> DeletePipelineAsync(string agentSpace, string pipelineName, DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Regions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
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
                Action = "DescribeRegions",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Regions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["language"] = request.Language;
            }
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
                Action = "DescribeRegions",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Regions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Regions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public ExecuteQueryResponse ExecuteQueryWithOptions(string agentSpace, string datasetName, ExecuteQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteQuery",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public async Task<ExecuteQueryResponse> ExecuteQueryWithOptionsAsync(string agentSpace, string datasetName, ExecuteQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteQuery",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public ExecuteQueryResponse ExecuteQuery(string agentSpace, string datasetName, ExecuteQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteQueryWithOptions(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行查询语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteQueryResponse
        /// </returns>
        public async Task<ExecuteQueryResponse> ExecuteQueryAsync(string agentSpace, string datasetName, ExecuteQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteQueryWithOptionsAsync(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpaceResponse
        /// </returns>
        public GetAgentSpaceResponse GetAgentSpaceWithOptions(string agentSpace, GetAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpaceResponse
        /// </returns>
        public async Task<GetAgentSpaceResponse> GetAgentSpaceWithOptionsAsync(string agentSpace, GetAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentSpaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpaceResponse
        /// </returns>
        public GetAgentSpaceResponse GetAgentSpace(string agentSpace, GetAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAgentSpaceWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentSpaceResponse
        /// </returns>
        public async Task<GetAgentSpaceResponse> GetAgentSpaceAsync(string agentSpace, GetAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAgentSpaceWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreResponse
        /// </returns>
        public GetContextStoreResponse GetContextStoreWithOptions(string agentSpace, string contextStoreName, GetContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreResponse
        /// </returns>
        public async Task<GetContextStoreResponse> GetContextStoreWithOptionsAsync(string agentSpace, string contextStoreName, GetContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreResponse
        /// </returns>
        public GetContextStoreResponse GetContextStore(string agentSpace, string contextStoreName, GetContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetContextStoreWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreResponse
        /// </returns>
        public async Task<GetContextStoreResponse> GetContextStoreAsync(string agentSpace, string contextStoreName, GetContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetContextStoreWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreAPIKeyResponse
        /// </returns>
        public GetContextStoreAPIKeyResponse GetContextStoreAPIKeyWithOptions(string agentSpace, string contextStoreName, string name, GetContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextStoreAPIKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreAPIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreAPIKeyResponse
        /// </returns>
        public async Task<GetContextStoreAPIKeyResponse> GetContextStoreAPIKeyWithOptionsAsync(string agentSpace, string contextStoreName, string name, GetContextStoreAPIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextStoreAPIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextStoreAPIKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreAPIKeyResponse
        /// </returns>
        public GetContextStoreAPIKeyResponse GetContextStoreAPIKey(string agentSpace, string contextStoreName, string name, GetContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetContextStoreAPIKeyWithOptions(agentSpace, contextStoreName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetContextStoreAPIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextStoreAPIKeyResponse
        /// </returns>
        public async Task<GetContextStoreAPIKeyResponse> GetContextStoreAPIKeyAsync(string agentSpace, string contextStoreName, string name, GetContextStoreAPIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetContextStoreAPIKeyWithOptionsAsync(agentSpace, contextStoreName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDatasetWithOptions(string agentSpace, string datasetName, GetDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(string agentSpace, string datasetName, GetDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDataset(string agentSpace, string datasetName, GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetWithOptions(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetAsync(string agentSpace, string datasetName, GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetWithOptionsAsync(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoriesResponse
        /// </returns>
        public GetMem0MemoriesResponse GetMem0MemoriesWithOptions(GetMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGraph))
            {
                query["enable_graph"] = request.EnableGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v2/memories",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetMem0MemoriesResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoriesResponse
        /// </returns>
        public async Task<GetMem0MemoriesResponse> GetMem0MemoriesWithOptionsAsync(GetMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGraph))
            {
                query["enable_graph"] = request.EnableGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v2/memories",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetMem0MemoriesResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoriesResponse
        /// </returns>
        public GetMem0MemoriesResponse GetMem0Memories(GetMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMem0MemoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoriesResponse
        /// </returns>
        public async Task<GetMem0MemoriesResponse> GetMem0MemoriesAsync(GetMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMem0MemoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoryResponse
        /// </returns>
        public GetMem0MemoryResponse GetMem0MemoryWithOptions(string memoryId, GetMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMem0MemoryResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoryResponse
        /// </returns>
        public async Task<GetMem0MemoryResponse> GetMem0MemoryWithOptionsAsync(string memoryId, GetMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMem0MemoryResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoryResponse
        /// </returns>
        public GetMem0MemoryResponse GetMem0Memory(string memoryId, GetMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMem0MemoryWithOptions(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMem0MemoryResponse
        /// </returns>
        public async Task<GetMem0MemoryResponse> GetMem0MemoryAsync(string memoryId, GetMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMem0MemoryWithOptionsAsync(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipelineWithOptions(string agentSpace, string pipelineName, GetPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string agentSpace, string pipelineName, GetPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipeline(string agentSpace, string pipelineName, GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineAsync(string agentSpace, string pipelineName, GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentSpacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpacesResponse
        /// </returns>
        public ListAgentSpacesResponse ListAgentSpacesWithOptions(ListAgentSpacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
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
                Action = "ListAgentSpaces",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSpacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentSpacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpacesResponse
        /// </returns>
        public async Task<ListAgentSpacesResponse> ListAgentSpacesWithOptionsAsync(ListAgentSpacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
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
                Action = "ListAgentSpaces",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAgentSpacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpacesResponse
        /// </returns>
        public ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAgentSpacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询AgentSpace列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAgentSpacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAgentSpacesResponse
        /// </returns>
        public async Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAgentSpacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoreAPIKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoreAPIKeysResponse
        /// </returns>
        public ListContextStoreAPIKeysResponse ListContextStoreAPIKeysWithOptions(string agentSpace, string contextStoreName, ListContextStoreAPIKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListContextStoreAPIKeys",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextStoreAPIKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoreAPIKeysRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoreAPIKeysResponse
        /// </returns>
        public async Task<ListContextStoreAPIKeysResponse> ListContextStoreAPIKeysWithOptionsAsync(string agentSpace, string contextStoreName, ListContextStoreAPIKeysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListContextStoreAPIKeys",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/apikey",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextStoreAPIKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoreAPIKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoreAPIKeysResponse
        /// </returns>
        public ListContextStoreAPIKeysResponse ListContextStoreAPIKeys(string agentSpace, string contextStoreName, ListContextStoreAPIKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListContextStoreAPIKeysWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取 API Key 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoreAPIKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoreAPIKeysResponse
        /// </returns>
        public async Task<ListContextStoreAPIKeysResponse> ListContextStoreAPIKeysAsync(string agentSpace, string contextStoreName, ListContextStoreAPIKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListContextStoreAPIKeysWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoresRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoresResponse
        /// </returns>
        public ListContextStoresResponse ListContextStoresWithOptions(string agentSpace, ListContextStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreName))
            {
                query["contextStoreName"] = request.ContextStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                query["contextType"] = request.ContextType;
            }
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
                Action = "ListContextStores",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextStoresResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoresRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoresResponse
        /// </returns>
        public async Task<ListContextStoresResponse> ListContextStoresWithOptionsAsync(string agentSpace, ListContextStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreName))
            {
                query["contextStoreName"] = request.ContextStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                query["contextType"] = request.ContextType;
            }
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
                Action = "ListContextStores",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoresResponse
        /// </returns>
        public ListContextStoresResponse ListContextStores(string agentSpace, ListContextStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListContextStoresWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询上下文库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContextStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextStoresResponse
        /// </returns>
        public async Task<ListContextStoresResponse> ListContextStoresAsync(string agentSpace, ListContextStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListContextStoresWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasetsWithOptions(string agentSpace, ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["datasetName"] = request.DatasetName;
            }
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
                Action = "ListDatasets",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(string agentSpace, ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["datasetName"] = request.DatasetName;
            }
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
                Action = "ListDatasets",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasets(string agentSpace, ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetsWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsAsync(string agentSpace, ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetsWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelinesWithOptions(string agentSpace, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(string agentSpace, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelines(string agentSpace, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelinesWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesAsync(string agentSpace, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelinesWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索上下文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchContextResponse
        /// </returns>
        public SearchContextResponse SearchContextWithOptions(string agentSpace, string contextStoreName, SearchContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formatted))
            {
                body["formatted"] = request.Formatted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalOption))
            {
                body["retrievalOption"] = request.RetrievalOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchContext",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/context/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchContextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索上下文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchContextResponse
        /// </returns>
        public async Task<SearchContextResponse> SearchContextWithOptionsAsync(string agentSpace, string contextStoreName, SearchContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formatted))
            {
                body["formatted"] = request.Formatted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetrievalOption))
            {
                body["retrievalOption"] = request.RetrievalOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                body["threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchContext",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName) + "/context/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchContextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索上下文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContextRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchContextResponse
        /// </returns>
        public SearchContextResponse SearchContext(string agentSpace, string contextStoreName, SearchContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchContextWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索上下文</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchContextRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchContextResponse
        /// </returns>
        public async Task<SearchContextResponse> SearchContextAsync(string agentSpace, string contextStoreName, SearchContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchContextWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMem0MemoriesResponse
        /// </returns>
        public SearchMem0MemoriesResponse SearchMem0MemoriesWithOptions(SearchMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGraph))
            {
                query["enable_graph"] = request.EnableGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v2/memories/search",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SearchMem0MemoriesResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMem0MemoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMem0MemoriesResponse
        /// </returns>
        public async Task<SearchMem0MemoriesResponse> SearchMem0MemoriesWithOptionsAsync(SearchMem0MemoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGraph))
            {
                query["enable_graph"] = request.EnableGraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMem0Memories",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v2/memories/search",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SearchMem0MemoriesResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMem0MemoriesResponse
        /// </returns>
        public SearchMem0MemoriesResponse SearchMem0Memories(SearchMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchMem0MemoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆库内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMem0MemoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMem0MemoriesResponse
        /// </returns>
        public async Task<SearchMem0MemoriesResponse> SearchMem0MemoriesAsync(SearchMem0MemoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchMem0MemoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpaceResponse
        /// </returns>
        public UpdateAgentSpaceResponse UpdateAgentSpaceWithOptions(string agentSpace, UpdateAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsWorkspace))
            {
                body["cmsWorkspace"] = request.CmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentSpaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentSpaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpaceResponse
        /// </returns>
        public async Task<UpdateAgentSpaceResponse> UpdateAgentSpaceWithOptionsAsync(string agentSpace, UpdateAgentSpaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsWorkspace))
            {
                body["cmsWorkspace"] = request.CmsWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgentSpace",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentSpaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpaceResponse
        /// </returns>
        public UpdateAgentSpaceResponse UpdateAgentSpace(string agentSpace, UpdateAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAgentSpaceWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AgentSpace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentSpaceResponse
        /// </returns>
        public async Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(string agentSpace, UpdateAgentSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAgentSpaceWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改上下文库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextStoreResponse
        /// </returns>
        public UpdateContextStoreResponse UpdateContextStoreWithOptions(string agentSpace, string contextStoreName, UpdateContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                body["contextType"] = request.ContextType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改上下文库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContextStoreRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextStoreResponse
        /// </returns>
        public async Task<UpdateContextStoreResponse> UpdateContextStoreWithOptionsAsync(string agentSpace, string contextStoreName, UpdateContextStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextType))
            {
                body["contextType"] = request.ContextType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextStore",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/contextstore/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(contextStoreName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改上下文库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextStoreResponse
        /// </returns>
        public UpdateContextStoreResponse UpdateContextStore(string agentSpace, string contextStoreName, UpdateContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateContextStoreWithOptions(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改上下文库配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContextStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextStoreResponse
        /// </returns>
        public async Task<UpdateContextStoreResponse> UpdateContextStoreAsync(string agentSpace, string contextStoreName, UpdateContextStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateContextStoreWithOptionsAsync(agentSpace, contextStoreName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDatasetWithOptions(string agentSpace, string datasetName, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(string agentSpace, string datasetName, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDataset(string agentSpace, string datasetName, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetWithOptions(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(string agentSpace, string datasetName, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetWithOptionsAsync(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMem0MemoryResponse
        /// </returns>
        public UpdateMem0MemoryResponse UpdateMem0MemoryWithOptions(string memoryId, UpdateMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMem0MemoryResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMem0MemoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMem0MemoryResponse
        /// </returns>
        public async Task<UpdateMem0MemoryResponse> UpdateMem0MemoryWithOptionsAsync(string memoryId, UpdateMem0MemoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextStoreId))
            {
                query["context_store_id"] = request.ContextStoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["org_id"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["project_id"] = request.ProjectId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMem0Memory",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/memories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(memoryId),
                Method = "PUT",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMem0MemoryResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMem0MemoryResponse
        /// </returns>
        public UpdateMem0MemoryResponse UpdateMem0Memory(string memoryId, UpdateMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMem0MemoryWithOptions(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改记忆</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMem0MemoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMem0MemoryResponse
        /// </returns>
        public async Task<UpdateMem0MemoryResponse> UpdateMem0MemoryAsync(string memoryId, UpdateMem0MemoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMem0MemoryWithOptionsAsync(memoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public UpdatePipelineResponse UpdatePipelineWithOptions(string agentSpace, string pipelineName, UpdatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public async Task<UpdatePipelineResponse> UpdatePipelineWithOptionsAsync(string agentSpace, string pipelineName, UpdatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutePolicy))
            {
                body["executePolicy"] = request.ExecutePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pipeline))
            {
                body["pipeline"] = request.Pipeline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sink))
            {
                body["sink"] = request.Sink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public UpdatePipelineResponse UpdatePipeline(string agentSpace, string pipelineName, UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePipelineResponse
        /// </returns>
        public async Task<UpdatePipelineResponse> UpdatePipelineAsync(string agentSpace, string pipelineName, UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验 Mem0 / ContextStore API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateMem0APIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateMem0APIKeyResponse
        /// </returns>
        public ValidateMem0APIKeyResponse ValidateMem0APIKeyWithOptions(ValidateMem0APIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateMem0APIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/ping",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateMem0APIKeyResponse>(DoROARequest(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验 Mem0 / ContextStore API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateMem0APIKeyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateMem0APIKeyResponse
        /// </returns>
        public async Task<ValidateMem0APIKeyResponse> ValidateMem0APIKeyWithOptionsAsync(ValidateMem0APIKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateMem0APIKey",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/v1/ping",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateMem0APIKeyResponse>(await DoROARequestAsync(params_.Action, params_.Version, params_.Protocol, params_.Method, params_.AuthType, params_.Pathname, params_.BodyType, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验 Mem0 / ContextStore API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateMem0APIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateMem0APIKeyResponse
        /// </returns>
        public ValidateMem0APIKeyResponse ValidateMem0APIKey(ValidateMem0APIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateMem0APIKeyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验 Mem0 / ContextStore API Key</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateMem0APIKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateMem0APIKeyResponse
        /// </returns>
        public async Task<ValidateMem0APIKeyResponse> ValidateMem0APIKeyAsync(ValidateMem0APIKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateMem0APIKeyWithOptionsAsync(request, headers, runtime);
        }

    }
}
