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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-zhangjiakou", "agentloop.cn-zhangjiakou.aliyuncs.com"},
                {"cn-shenzhen", "agentloop.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai", "agentloop.cn-shanghai.aliyuncs.com"},
                {"cn-hongkong", "agentloop.cn-hongkong.aliyuncs.com"},
                {"cn-hangzhou", "agentloop.cn-hangzhou.aliyuncs.com"},
                {"cn-guangzhou", "agentloop.cn-guangzhou.aliyuncs.com"},
                {"cn-chengdu", "agentloop.cn-chengdu.aliyuncs.com"},
                {"cn-beijing", "agentloop.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "agentloop.ap-southeast-1.aliyuncs.com"},
            };
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
        /// <para>Appends structured data rows to a specified dataset without requiring the client to construct SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDataResponse
        /// </returns>
        public AddDatasetDataResponse AddDatasetDataWithOptions(string agentSpace, string datasetName, AddDatasetDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataArray))
            {
                body["dataArray"] = request.DataArray;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatasetData",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/rows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatasetDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Appends structured data rows to a specified dataset without requiring the client to construct SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDataResponse
        /// </returns>
        public async Task<AddDatasetDataResponse> AddDatasetDataWithOptionsAsync(string agentSpace, string datasetName, AddDatasetDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataArray))
            {
                body["dataArray"] = request.DataArray;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDatasetData",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/dataset/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(datasetName) + "/rows",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDatasetDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Appends structured data rows to a specified dataset without requiring the client to construct SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDataRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDataResponse
        /// </returns>
        public AddDatasetDataResponse AddDatasetData(string agentSpace, string datasetName, AddDatasetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddDatasetDataWithOptions(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Appends structured data rows to a specified dataset without requiring the client to construct SQL statements.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDatasetDataRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDatasetDataResponse
        /// </returns>
        public async Task<AddDatasetDataResponse> AddDatasetDataAsync(string agentSpace, string datasetName, AddDatasetDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddDatasetDataWithOptionsAsync(agentSpace, datasetName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPipelineRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPipelineRunResponse
        /// </returns>
        public CancelPipelineRunResponse CancelPipelineRunWithOptions(string agentSpace, string pipelineName, string runId, CancelPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipelineRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPipelineRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPipelineRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelPipelineRunResponse
        /// </returns>
        public async Task<CancelPipelineRunResponse> CancelPipelineRunWithOptionsAsync(string agentSpace, string pipelineName, string runId, CancelPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipelineRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPipelineRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPipelineRunResponse
        /// </returns>
        public CancelPipelineRunResponse CancelPipelineRun(string agentSpace, string pipelineName, string runId, CancelPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelPipelineRunWithOptions(agentSpace, pipelineName, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelPipelineRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelPipelineRunResponse
        /// </returns>
        public async Task<CancelPipelineRunResponse> CancelPipelineRunAsync(string agentSpace, string pipelineName, string runId, CancelPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelPipelineRunWithOptionsAsync(agentSpace, pipelineName, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AgentSpace.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrajectoryStoreEnabled))
            {
                body["trajectoryStoreEnabled"] = request.TrajectoryStoreEnabled;
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
        /// <para>Creates an AgentSpace.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrajectoryStoreEnabled))
            {
                body["trajectoryStoreEnabled"] = request.TrajectoryStoreEnabled;
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
        /// <para>Creates an AgentSpace.</para>
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
        /// <para>Creates an AgentSpace.</para>
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
        /// <para>Creates a context store.</para>
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
        /// <para>Creates a context store.</para>
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
        /// <para>Creates a context store.</para>
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
        /// <para>Creates a context store.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates an API key.</para>
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
        /// <para>Creates a dataset.</para>
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
        /// <para>Creates a dataset.</para>
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
        /// <para>Creates a dataset.</para>
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
        /// <para>Creates a dataset.</para>
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
        /// <para>Creates an evaluation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calls the CreateEvaluationTask operation to create an evaluation task in a specified AgentSpace. The server verifies AgentSpace permissions, initializes evaluation result storage, checks the uniqueness of the task name, and asynchronously creates and executes an EvaluationRun based on <c>taskMode</c> and <c>runStrategies</c>.
        /// This operation is applicable to running built-in or custom evaluators on Trace, Dataset, or SLS Log data. It supports two execution strategies: historical backfill and continuous evaluation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluationTaskResponse
        /// </returns>
        public CreateEvaluationTaskResponse CreateEvaluationTaskWithOptions(string agentSpace, CreateEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFilter))
            {
                body["dataFilter"] = request.DataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluators))
            {
                body["evaluators"] = request.Evaluators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStrategies))
            {
                body["runStrategies"] = request.RunStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                body["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calls the CreateEvaluationTask operation to create an evaluation task in a specified AgentSpace. The server verifies AgentSpace permissions, initializes evaluation result storage, checks the uniqueness of the task name, and asynchronously creates and executes an EvaluationRun based on <c>taskMode</c> and <c>runStrategies</c>.
        /// This operation is applicable to running built-in or custom evaluators on Trace, Dataset, or SLS Log data. It supports two execution strategies: historical backfill and continuous evaluation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluationTaskResponse
        /// </returns>
        public async Task<CreateEvaluationTaskResponse> CreateEvaluationTaskWithOptionsAsync(string agentSpace, CreateEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFilter))
            {
                body["dataFilter"] = request.DataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["dataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluators))
            {
                body["evaluators"] = request.Evaluators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStrategies))
            {
                body["runStrategies"] = request.RunStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                body["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calls the CreateEvaluationTask operation to create an evaluation task in a specified AgentSpace. The server verifies AgentSpace permissions, initializes evaluation result storage, checks the uniqueness of the task name, and asynchronously creates and executes an EvaluationRun based on <c>taskMode</c> and <c>runStrategies</c>.
        /// This operation is applicable to running built-in or custom evaluators on Trace, Dataset, or SLS Log data. It supports two execution strategies: historical backfill and continuous evaluation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluationTaskResponse
        /// </returns>
        public CreateEvaluationTaskResponse CreateEvaluationTask(string agentSpace, CreateEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEvaluationTaskWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Calls the CreateEvaluationTask operation to create an evaluation task in a specified AgentSpace. The server verifies AgentSpace permissions, initializes evaluation result storage, checks the uniqueness of the task name, and asynchronously creates and executes an EvaluationRun based on <c>taskMode</c> and <c>runStrategies</c>.
        /// This operation is applicable to running built-in or custom evaluators on Trace, Dataset, or SLS Log data. It supports two execution strategies: historical backfill and continuous evaluation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluationTaskResponse
        /// </returns>
        public async Task<CreateEvaluationTaskResponse> CreateEvaluationTaskAsync(string agentSpace, CreateEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEvaluationTaskWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorResponse
        /// </returns>
        public CreateEvaluatorResponse CreateEvaluatorWithOptions(string agentSpace, CreateEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["metricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["versionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorResponse
        /// </returns>
        public async Task<CreateEvaluatorResponse> CreateEvaluatorWithOptionsAsync(string agentSpace, CreateEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                body["metricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["versionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorResponse
        /// </returns>
        public CreateEvaluatorResponse CreateEvaluator(string agentSpace, CreateEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEvaluatorWithOptions(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorResponse
        /// </returns>
        public async Task<CreateEvaluatorResponse> CreateEvaluatorAsync(string agentSpace, CreateEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEvaluatorWithOptionsAsync(agentSpace, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorSkillResponse
        /// </returns>
        public CreateEvaluatorSkillResponse CreateEvaluatorSkillWithOptions(string name, CreateEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatorSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorSkillResponse
        /// </returns>
        public async Task<CreateEvaluatorSkillResponse> CreateEvaluatorSkillWithOptionsAsync(string name, CreateEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillName))
            {
                body["skillName"] = request.SkillName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEvaluatorSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorSkillResponse
        /// </returns>
        public CreateEvaluatorSkillResponse CreateEvaluatorSkill(string name, CreateEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEvaluatorSkillWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEvaluatorSkillResponse
        /// </returns>
        public async Task<CreateEvaluatorSkillResponse> CreateEvaluatorSkillAsync(string name, CreateEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEvaluatorSkillWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an AgentSpace.</para>
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
        /// <para>Deletes an AgentSpace.</para>
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
        /// <para>Deletes an AgentSpace.</para>
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
        /// <para>Deletes an AgentSpace.</para>
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
        /// <para>Deletes a context store.</para>
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
        /// <para>Deletes a context store.</para>
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
        /// <para>Deletes a context store.</para>
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
        /// <para>Deletes a context store.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes an API key.</para>
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
        /// <para>Deletes a dataset.</para>
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
        /// <para>Deletes a dataset.</para>
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
        /// <para>Deletes a dataset.</para>
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
        /// <para>Deletes a dataset.</para>
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
        /// <para>Deletes an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationRunResponse
        /// </returns>
        public DeleteEvaluationRunResponse DeleteEvaluationRunWithOptions(string agentSpace, string taskId, string runId, DeleteEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluationRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationRunResponse
        /// </returns>
        public async Task<DeleteEvaluationRunResponse> DeleteEvaluationRunWithOptionsAsync(string agentSpace, string taskId, string runId, DeleteEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluationRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationRunResponse
        /// </returns>
        public DeleteEvaluationRunResponse DeleteEvaluationRun(string agentSpace, string taskId, string runId, DeleteEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEvaluationRunWithOptions(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationRunResponse
        /// </returns>
        public async Task<DeleteEvaluationRunResponse> DeleteEvaluationRunAsync(string agentSpace, string taskId, string runId, DeleteEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEvaluationRunWithOptionsAsync(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationTaskResponse
        /// </returns>
        public DeleteEvaluationTaskResponse DeleteEvaluationTaskWithOptions(string agentSpace, string taskId, DeleteEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationTaskResponse
        /// </returns>
        public async Task<DeleteEvaluationTaskResponse> DeleteEvaluationTaskWithOptionsAsync(string agentSpace, string taskId, DeleteEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationTaskResponse
        /// </returns>
        public DeleteEvaluationTaskResponse DeleteEvaluationTask(string agentSpace, string taskId, DeleteEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEvaluationTaskWithOptions(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluationTaskResponse
        /// </returns>
        public async Task<DeleteEvaluationTaskResponse> DeleteEvaluationTaskAsync(string agentSpace, string taskId, DeleteEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEvaluationTaskWithOptionsAsync(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorResponse
        /// </returns>
        public DeleteEvaluatorResponse DeleteEvaluatorWithOptions(string agentSpace, string name, DeleteEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorResponse
        /// </returns>
        public async Task<DeleteEvaluatorResponse> DeleteEvaluatorWithOptionsAsync(string agentSpace, string name, DeleteEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorResponse
        /// </returns>
        public DeleteEvaluatorResponse DeleteEvaluator(string agentSpace, string name, DeleteEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEvaluatorWithOptions(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorResponse
        /// </returns>
        public async Task<DeleteEvaluatorResponse> DeleteEvaluatorAsync(string agentSpace, string name, DeleteEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEvaluatorWithOptionsAsync(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorSkillResponse
        /// </returns>
        public DeleteEvaluatorSkillResponse DeleteEvaluatorSkillWithOptions(string name, string skillName, DeleteEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluatorSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorSkillResponse
        /// </returns>
        public async Task<DeleteEvaluatorSkillResponse> DeleteEvaluatorSkillWithOptionsAsync(string name, string skillName, DeleteEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEvaluatorSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorSkillResponse
        /// </returns>
        public DeleteEvaluatorSkillResponse DeleteEvaluatorSkill(string name, string skillName, DeleteEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEvaluatorSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEvaluatorSkillResponse
        /// </returns>
        public async Task<DeleteEvaluatorSkillResponse> DeleteEvaluatorSkillAsync(string name, string skillName, DeleteEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEvaluatorSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a pipeline.</para>
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
        /// <para>Deletes a pipeline.</para>
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
        /// <para>Deletes a pipeline.</para>
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
        /// <para>Deletes a pipeline.</para>
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
        /// <para>Queries regions.</para>
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
        /// <para>Queries regions.</para>
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
        /// <para>Queries regions.</para>
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
        /// <para>Queries regions.</para>
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
        /// <para>Executes a query statement.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
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
        /// <para>Executes a query statement.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                body["length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxOutputLength))
            {
                body["maxOutputLength"] = request.MaxOutputLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
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
        /// <para>Executes a query statement.</para>
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
        /// <para>Executes a query statement.</para>
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
        /// <para>Queries an AgentSpace.</para>
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
        /// <para>Queries an AgentSpace.</para>
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
        /// <para>Queries an AgentSpace.</para>
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
        /// <para>Queries an AgentSpace.</para>
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
        /// <para>Queries a context store.</para>
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
        /// <para>Queries a context store.</para>
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
        /// <para>Queries a context store.</para>
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
        /// <para>Queries a context store.</para>
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
        /// <para>Retrieves an API key.</para>
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
        /// <para>Retrieves an API key.</para>
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
        /// <para>Retrieves an API key.</para>
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
        /// <para>Retrieves an API key.</para>
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
        /// <para>Queries a dataset.</para>
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
        /// <para>Queries a dataset.</para>
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
        /// <para>Queries a dataset.</para>
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
        /// <para>Queries a dataset.</para>
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
        /// <para>Retrieves the details of an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationRunResponse
        /// </returns>
        public GetEvaluationRunResponse GetEvaluationRunWithOptions(string agentSpace, string taskId, string runId, GetEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationRunResponse
        /// </returns>
        public async Task<GetEvaluationRunResponse> GetEvaluationRunWithOptionsAsync(string agentSpace, string taskId, string runId, GetEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationRunResponse
        /// </returns>
        public GetEvaluationRunResponse GetEvaluationRun(string agentSpace, string taskId, string runId, GetEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEvaluationRunWithOptions(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationRunResponse
        /// </returns>
        public async Task<GetEvaluationRunResponse> GetEvaluationRunAsync(string agentSpace, string taskId, string runId, GetEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEvaluationRunWithOptionsAsync(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationTaskResponse
        /// </returns>
        public GetEvaluationTaskResponse GetEvaluationTaskWithOptions(string agentSpace, string taskId, GetEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationTaskResponse
        /// </returns>
        public async Task<GetEvaluationTaskResponse> GetEvaluationTaskWithOptionsAsync(string agentSpace, string taskId, GetEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationTaskResponse
        /// </returns>
        public GetEvaluationTaskResponse GetEvaluationTask(string agentSpace, string taskId, GetEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEvaluationTaskWithOptions(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluationTaskResponse
        /// </returns>
        public async Task<GetEvaluationTaskResponse> GetEvaluationTaskAsync(string agentSpace, string taskId, GetEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEvaluationTaskWithOptionsAsync(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorResponse
        /// </returns>
        public GetEvaluatorResponse GetEvaluatorWithOptions(string agentSpace, string name, GetEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorResponse
        /// </returns>
        public async Task<GetEvaluatorResponse> GetEvaluatorWithOptionsAsync(string agentSpace, string name, GetEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorResponse
        /// </returns>
        public GetEvaluatorResponse GetEvaluator(string agentSpace, string name, GetEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEvaluatorWithOptions(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorResponse
        /// </returns>
        public async Task<GetEvaluatorResponse> GetEvaluatorAsync(string agentSpace, string name, GetEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEvaluatorWithOptionsAsync(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorSkillResponse
        /// </returns>
        public GetEvaluatorSkillResponse GetEvaluatorSkillWithOptions(string name, string skillName, GetEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluatorSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorSkillResponse
        /// </returns>
        public async Task<GetEvaluatorSkillResponse> GetEvaluatorSkillWithOptionsAsync(string name, string skillName, GetEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEvaluatorSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorSkillResponse
        /// </returns>
        public GetEvaluatorSkillResponse GetEvaluatorSkill(string name, string skillName, GetEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEvaluatorSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEvaluatorSkillResponse
        /// </returns>
        public async Task<GetEvaluatorSkillResponse> GetEvaluatorSkillAsync(string name, string skillName, GetEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEvaluatorSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a CI/CD pipeline.</para>
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
        /// <para>Queries a CI/CD pipeline.</para>
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
        /// <para>Queries a CI/CD pipeline.</para>
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
        /// <para>Queries a CI/CD pipeline.</para>
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
        /// <para>Queries the details of a single pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineRunResponse
        /// </returns>
        public GetPipelineRunResponse GetPipelineRunWithOptions(string agentSpace, string pipelineName, string runId, GetPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineRunResponse
        /// </returns>
        public async Task<GetPipelineRunResponse> GetPipelineRunWithOptionsAsync(string agentSpace, string pipelineName, string runId, GetPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineRunResponse
        /// </returns>
        public GetPipelineRunResponse GetPipelineRun(string agentSpace, string pipelineName, string runId, GetPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineRunWithOptions(agentSpace, pipelineName, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a single pipeline run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineRunResponse
        /// </returns>
        public async Task<GetPipelineRunResponse> GetPipelineRunAsync(string agentSpace, string pipelineName, string runId, GetPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineRunWithOptionsAsync(agentSpace, pipelineName, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries pipeline run statistics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineStatsResponse
        /// </returns>
        public GetPipelineStatsResponse GetPipelineStatsWithOptions(string agentSpace, string pipelineName, GetPipelineStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineStats",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries pipeline run statistics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineStatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineStatsResponse
        /// </returns>
        public async Task<GetPipelineStatsResponse> GetPipelineStatsWithOptionsAsync(string agentSpace, string pipelineName, GetPipelineStatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineStats",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/stats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries pipeline run statistics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineStatsResponse
        /// </returns>
        public GetPipelineStatsResponse GetPipelineStats(string agentSpace, string pipelineName, GetPipelineStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineStatsWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries pipeline run statistics.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPipelineStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPipelineStatsResponse
        /// </returns>
        public async Task<GetPipelineStatsResponse> GetPipelineStatsAsync(string agentSpace, string pipelineName, GetPipelineStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineStatsWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AgentSpaces.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
        /// <para>Queries a list of AgentSpaces.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
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
        /// <para>Queries a list of AgentSpaces.</para>
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
        /// <para>Queries a list of AgentSpaces.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Retrieves a list of API keys.</para>
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
        /// <para>Queries a list of context stores.</para>
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
        /// <para>Queries a list of context stores.</para>
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
        /// <para>Queries a list of context stores.</para>
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
        /// <para>Queries a list of context stores.</para>
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
        /// <para>Queries a list of datasets.</para>
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
        /// <para>Queries a list of datasets.</para>
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
        /// <para>Queries a list of datasets.</para>
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
        /// <para>Queries a list of datasets.</para>
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
        /// <para>Queries the list of evaluation runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationRunsResponse
        /// </returns>
        public ListEvaluationRunsResponse ListEvaluationRunsWithOptions(string agentSpace, string taskId, ListEvaluationRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunType))
            {
                query["runType"] = request.RunType;
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
                Action = "ListEvaluationRuns",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of evaluation runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationRunsResponse
        /// </returns>
        public async Task<ListEvaluationRunsResponse> ListEvaluationRunsWithOptionsAsync(string agentSpace, string taskId, ListEvaluationRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunType))
            {
                query["runType"] = request.RunType;
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
                Action = "ListEvaluationRuns",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of evaluation runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationRunsResponse
        /// </returns>
        public ListEvaluationRunsResponse ListEvaluationRuns(string agentSpace, string taskId, ListEvaluationRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEvaluationRunsWithOptions(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of evaluation runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationRunsResponse
        /// </returns>
        public async Task<ListEvaluationRunsResponse> ListEvaluationRunsAsync(string agentSpace, string taskId, ListEvaluationRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEvaluationRunsWithOptionsAsync(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationTasksResponse
        /// </returns>
        public ListEvaluationTasksResponse ListEvaluationTasksWithOptions(ListEvaluationTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["dataType"] = request.DataType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                query["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluationTasks",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationTasksResponse
        /// </returns>
        public async Task<ListEvaluationTasksResponse> ListEvaluationTasksWithOptionsAsync(ListEvaluationTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["dataType"] = request.DataType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskMode))
            {
                query["taskMode"] = request.TaskMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluationTasks",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluationTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationTasksResponse
        /// </returns>
        public ListEvaluationTasksResponse ListEvaluationTasks(ListEvaluationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEvaluationTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluation tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluationTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluationTasksResponse
        /// </returns>
        public async Task<ListEvaluationTasksResponse> ListEvaluationTasksAsync(ListEvaluationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEvaluationTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skill list of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorSkillsResponse
        /// </returns>
        public ListEvaluatorSkillsResponse ListEvaluatorSkillsWithOptions(string name, ListEvaluatorSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListEvaluatorSkills",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluatorSkillsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skill list of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorSkillsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorSkillsResponse
        /// </returns>
        public async Task<ListEvaluatorSkillsResponse> ListEvaluatorSkillsWithOptionsAsync(string name, ListEvaluatorSkillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListEvaluatorSkills",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluatorSkillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skill list of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorSkillsResponse
        /// </returns>
        public ListEvaluatorSkillsResponse ListEvaluatorSkills(string name, ListEvaluatorSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEvaluatorSkillsWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the skill list of an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorSkillsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorSkillsResponse
        /// </returns>
        public async Task<ListEvaluatorSkillsResponse> ListEvaluatorSkillsAsync(string name, ListEvaluatorSkillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEvaluatorSkillsWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluators.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorsResponse
        /// </returns>
        public ListEvaluatorsResponse ListEvaluatorsWithOptions(ListEvaluatorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluators",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluatorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluators.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorsResponse
        /// </returns>
        public async Task<ListEvaluatorsResponse> ListEvaluatorsWithOptionsAsync(ListEvaluatorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEvaluators",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEvaluatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluators.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorsResponse
        /// </returns>
        public ListEvaluatorsResponse ListEvaluators(ListEvaluatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEvaluatorsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of evaluators.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEvaluatorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEvaluatorsResponse
        /// </returns>
        public async Task<ListEvaluatorsResponse> ListEvaluatorsAsync(ListEvaluatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEvaluatorsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution history list of a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelineRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelineRunsResponse
        /// </returns>
        public ListPipelineRunsResponse ListPipelineRunsWithOptions(string agentSpace, string pipelineName, ListPipelineRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["triggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineRuns",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution history list of a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelineRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelineRunsResponse
        /// </returns>
        public async Task<ListPipelineRunsResponse> ListPipelineRunsWithOptionsAsync(string agentSpace, string pipelineName, ListPipelineRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["triggerType"] = request.TriggerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineRuns",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution history list of a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelineRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelineRunsResponse
        /// </returns>
        public ListPipelineRunsResponse ListPipelineRuns(string agentSpace, string pipelineName, ListPipelineRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineRunsWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution history list of a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelineRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelineRunsResponse
        /// </returns>
        public async Task<ListPipelineRunsResponse> ListPipelineRunsAsync(string agentSpace, string pipelineName, ListPipelineRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineRunsWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists CI/CD pipelines.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStatus))
            {
                query["scheduleStatus"] = request.ScheduleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["scheduleType"] = request.ScheduleType;
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
        /// <para>Lists CI/CD pipelines.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStatus))
            {
                query["scheduleStatus"] = request.ScheduleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["scheduleType"] = request.ScheduleType;
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
        /// <para>Lists CI/CD pipelines.</para>
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
        /// <para>Lists CI/CD pipelines.</para>
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
        /// <para>Pauses a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PausePipelineResponse
        /// </returns>
        public PausePipelineResponse PausePipelineWithOptions(string agentSpace, string pipelineName, PausePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PausePipelineResponse
        /// </returns>
        public async Task<PausePipelineResponse> PausePipelineWithOptionsAsync(string agentSpace, string pipelineName, PausePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// PausePipelineResponse
        /// </returns>
        public PausePipelineResponse PausePipeline(string agentSpace, string pipelineName, PausePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PausePipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PausePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// PausePipelineResponse
        /// </returns>
        public async Task<PausePipelineResponse> PausePipelineAsync(string agentSpace, string pipelineName, PausePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PausePipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumePipelineResponse
        /// </returns>
        public ResumePipelineResponse ResumePipelineWithOptions(string agentSpace, string pipelineName, ResumePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumePipelineResponse
        /// </returns>
        public async Task<ResumePipelineResponse> ResumePipelineWithOptionsAsync(string agentSpace, string pipelineName, ResumePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumePipelineResponse
        /// </returns>
        public ResumePipelineResponse ResumePipeline(string agentSpace, string pipelineName, ResumePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumePipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumePipelineResponse
        /// </returns>
        public async Task<ResumePipelineResponse> ResumePipelineAsync(string agentSpace, string pipelineName, ResumePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumePipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a pipeline execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunPipelineResponse
        /// </returns>
        public RunPipelineResponse RunPipelineWithOptions(string agentSpace, string pipelineName, RunPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunPipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunPipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a pipeline execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunPipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunPipelineResponse
        /// </returns>
        public async Task<RunPipelineResponse> RunPipelineWithOptionsAsync(string agentSpace, string pipelineName, RunPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTime))
            {
                body["fromTime"] = request.FromTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTime))
            {
                body["toTime"] = request.ToTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunPipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a pipeline execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// RunPipelineResponse
        /// </returns>
        public RunPipelineResponse RunPipeline(string agentSpace, string pipelineName, RunPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunPipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a pipeline execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunPipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// RunPipelineResponse
        /// </returns>
        public async Task<RunPipelineResponse> RunPipelineAsync(string agentSpace, string pipelineName, RunPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunPipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches contexts.</para>
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
        /// <para>Searches contexts.</para>
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
        /// <para>Searches contexts.</para>
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
        /// <para>Searches contexts.</para>
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
        /// <para>Stops a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminatePipelineResponse
        /// </returns>
        public TerminatePipelineResponse TerminatePipelineWithOptions(string agentSpace, string pipelineName, TerminatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminatePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminatePipelineResponse
        /// </returns>
        public async Task<TerminatePipelineResponse> TerminatePipelineWithOptionsAsync(string agentSpace, string pipelineName, TerminatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminatePipeline",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/agentspace/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineName) + "/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminatePipelineResponse
        /// </returns>
        public TerminatePipelineResponse TerminatePipeline(string agentSpace, string pipelineName, TerminatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminatePipelineWithOptions(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminatePipelineResponse
        /// </returns>
        public async Task<TerminatePipelineResponse> TerminatePipelineAsync(string agentSpace, string pipelineName, TerminatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminatePipelineWithOptionsAsync(agentSpace, pipelineName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an AgentSpace.</para>
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
        /// <para>Updates an AgentSpace.</para>
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
        /// <para>Updates an AgentSpace.</para>
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
        /// <para>Updates an AgentSpace.</para>
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
        /// <para>Modifies the configuration of a context store.</para>
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
        /// <para>Modifies the configuration of a context store.</para>
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
        /// <para>Modifies the configuration of a context store.</para>
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
        /// <para>Modifies the configuration of a context store.</para>
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
        /// <para>Updates a dataset.</para>
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
        /// <para>Updates a dataset.</para>
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
        /// <para>Updates a dataset.</para>
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
        /// <para>Updates a dataset.</para>
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
        /// <para>Updates an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationRunResponse
        /// </returns>
        public UpdateEvaluationRunResponse UpdateEvaluationRunWithOptions(string agentSpace, string taskId, string runId, UpdateEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluationRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationRunResponse
        /// </returns>
        public async Task<UpdateEvaluationRunResponse> UpdateEvaluationRunWithOptionsAsync(string agentSpace, string taskId, string runId, UpdateEvaluationRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateEvaluationRun",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/run/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluationRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationRunResponse
        /// </returns>
        public UpdateEvaluationRunResponse UpdateEvaluationRun(string agentSpace, string taskId, string runId, UpdateEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEvaluationRunWithOptions(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationRunResponse
        /// </returns>
        public async Task<UpdateEvaluationRunResponse> UpdateEvaluationRunAsync(string agentSpace, string taskId, string runId, UpdateEvaluationRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEvaluationRunWithOptionsAsync(agentSpace, taskId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationTaskResponse
        /// </returns>
        public UpdateEvaluationTaskResponse UpdateEvaluationTaskWithOptions(string agentSpace, string taskId, UpdateEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFilter))
            {
                body["dataFilter"] = request.DataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluators))
            {
                body["evaluators"] = request.Evaluators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStrategies))
            {
                body["runStrategies"] = request.RunStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluationTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationTaskResponse
        /// </returns>
        public async Task<UpdateEvaluationTaskResponse> UpdateEvaluationTaskWithOptionsAsync(string agentSpace, string taskId, UpdateEvaluationTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFilter))
            {
                body["dataFilter"] = request.DataFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluators))
            {
                body["evaluators"] = request.Evaluators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunStrategies))
            {
                body["runStrategies"] = request.RunStrategies;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluationTask",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluation-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationTaskResponse
        /// </returns>
        public UpdateEvaluationTaskResponse UpdateEvaluationTask(string agentSpace, string taskId, UpdateEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEvaluationTaskWithOptions(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluationTaskResponse
        /// </returns>
        public async Task<UpdateEvaluationTaskResponse> UpdateEvaluationTaskAsync(string agentSpace, string taskId, UpdateEvaluationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEvaluationTaskWithOptionsAsync(agentSpace, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorResponse
        /// </returns>
        public UpdateEvaluatorResponse UpdateEvaluatorWithOptions(string agentSpace, string name, UpdateEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["versionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorResponse
        /// </returns>
        public async Task<UpdateEvaluatorResponse> UpdateEvaluatorWithOptionsAsync(string agentSpace, string name, UpdateEvaluatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["versionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluator",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluators/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(agentSpace) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorResponse
        /// </returns>
        public UpdateEvaluatorResponse UpdateEvaluator(string agentSpace, string name, UpdateEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEvaluatorWithOptions(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorResponse
        /// </returns>
        public async Task<UpdateEvaluatorResponse> UpdateEvaluatorAsync(string agentSpace, string name, UpdateEvaluatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEvaluatorWithOptionsAsync(agentSpace, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorSkillResponse
        /// </returns>
        public UpdateEvaluatorSkillResponse UpdateEvaluatorSkillWithOptions(string name, string skillName, UpdateEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluatorSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorSkillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorSkillResponse
        /// </returns>
        public async Task<UpdateEvaluatorSkillResponse> UpdateEvaluatorSkillWithOptionsAsync(string name, string skillName, UpdateEvaluatorSkillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSpace))
            {
                query["agentSpace"] = request.AgentSpace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEvaluatorSkill",
                Version = "2026-05-20",
                Protocol = "HTTPS",
                Pathname = "/api/v1/evaluator/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/skill/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(skillName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEvaluatorSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorSkillResponse
        /// </returns>
        public UpdateEvaluatorSkillResponse UpdateEvaluatorSkill(string name, string skillName, UpdateEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEvaluatorSkillWithOptions(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an evaluator skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEvaluatorSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEvaluatorSkillResponse
        /// </returns>
        public async Task<UpdateEvaluatorSkillResponse> UpdateEvaluatorSkillAsync(string name, string skillName, UpdateEvaluatorSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEvaluatorSkillWithOptionsAsync(name, skillName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a pipeline.</para>
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
        /// <para>Updates a pipeline.</para>
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
        /// <para>Updates a pipeline.</para>
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
        /// <para>Updates a pipeline.</para>
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

    }
}
