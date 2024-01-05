// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Igraph20210621.Models;

namespace AlibabaCloud.SDK.Igraph20210621
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("igraph", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateGraphResponse CreateGraphWithOptions(string instanceId, string graphName, CreateGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGraphResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGraphResponse> CreateGraphWithOptionsAsync(string instanceId, string graphName, CreateGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGraphResponse CreateGraph(string instanceId, string graphName, CreateGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGraphWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<CreateGraphResponse> CreateGraphAsync(string instanceId, string graphName, CreateGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGraphWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public CreateGraphSchemaResponse CreateGraphSchemaWithOptions(string instanceId, string graphName, CreateGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGraphSchemaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGraphSchemaResponse> CreateGraphSchemaWithOptionsAsync(string instanceId, string graphName, CreateGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGraphSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGraphSchemaResponse CreateGraphSchema(string instanceId, string graphName, CreateGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGraphSchemaWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<CreateGraphSchemaResponse> CreateGraphSchemaAsync(string instanceId, string graphName, CreateGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGraphSchemaWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public DeleteGraphResponse DeleteGraphWithOptions(string instanceId, string graphName, DeleteGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGraphResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGraphResponse> DeleteGraphWithOptionsAsync(string instanceId, string graphName, DeleteGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGraphResponse DeleteGraph(string instanceId, string graphName, DeleteGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGraphWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<DeleteGraphResponse> DeleteGraphAsync(string instanceId, string graphName, DeleteGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGraphWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public GetGraphResponse GetGraphWithOptions(string instanceId, string graphName, GetGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGraphResponse> GetGraphWithOptionsAsync(string instanceId, string graphName, GetGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGraphResponse GetGraph(string instanceId, string graphName, GetGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGraphWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<GetGraphResponse> GetGraphAsync(string instanceId, string graphName, GetGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGraphWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public GetGraphSchemaResponse GetGraphSchemaWithOptions(string instanceId, string graphName, string graphSchemaName, GetGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphSchemaName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphSchemaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetGraphSchemaResponse> GetGraphSchemaWithOptionsAsync(string instanceId, string graphName, string graphSchemaName, GetGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphSchemaName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGraphSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetGraphSchemaResponse GetGraphSchema(string instanceId, string graphName, string graphSchemaName, GetGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGraphSchemaWithOptions(instanceId, graphName, graphSchemaName, request, headers, runtime);
        }

        public async Task<GetGraphSchemaResponse> GetGraphSchemaAsync(string instanceId, string graphName, string graphSchemaName, GetGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGraphSchemaWithOptionsAsync(instanceId, graphName, graphSchemaName, request, headers, runtime);
        }

        public GetIgraphLabelBackFlowResponse GetIgraphLabelBackFlowWithOptions(string graphName, string instanceId, string labelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphLabelBackFlow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphLabelBackFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIgraphLabelBackFlowResponse> GetIgraphLabelBackFlowWithOptionsAsync(string graphName, string instanceId, string labelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphLabelBackFlow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphLabelBackFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIgraphLabelBackFlowResponse GetIgraphLabelBackFlow(string graphName, string instanceId, string labelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIgraphLabelBackFlowWithOptions(graphName, instanceId, labelName, headers, runtime);
        }

        public async Task<GetIgraphLabelBackFlowResponse> GetIgraphLabelBackFlowAsync(string graphName, string instanceId, string labelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIgraphLabelBackFlowWithOptionsAsync(graphName, instanceId, labelName, headers, runtime);
        }

        public GetIgraphLabelLastBackflowResponse GetIgraphLabelLastBackflowWithOptions(string instanceId, string graphName, string labelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphLabelLastBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow/last",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphLabelLastBackflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIgraphLabelLastBackflowResponse> GetIgraphLabelLastBackflowWithOptionsAsync(string instanceId, string graphName, string labelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphLabelLastBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow/last",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphLabelLastBackflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIgraphLabelLastBackflowResponse GetIgraphLabelLastBackflow(string instanceId, string graphName, string labelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIgraphLabelLastBackflowWithOptions(instanceId, graphName, labelName, headers, runtime);
        }

        public async Task<GetIgraphLabelLastBackflowResponse> GetIgraphLabelLastBackflowAsync(string instanceId, string graphName, string labelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIgraphLabelLastBackflowWithOptionsAsync(instanceId, graphName, labelName, headers, runtime);
        }

        public GetIgraphTableDetailResponse GetIgraphTableDetailWithOptions(string instanceId, string graphName, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphTableDetail",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphTableDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIgraphTableDetailResponse> GetIgraphTableDetailWithOptionsAsync(string instanceId, string graphName, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphTableDetail",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphTableDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIgraphTableDetailResponse GetIgraphTableDetail(string instanceId, string graphName, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIgraphTableDetailWithOptions(instanceId, graphName, tableName, headers, runtime);
        }

        public async Task<GetIgraphTableDetailResponse> GetIgraphTableDetailAsync(string instanceId, string graphName, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIgraphTableDetailWithOptionsAsync(instanceId, graphName, tableName, headers, runtime);
        }

        public GetIgraphTablesBackFlowResponse GetIgraphTablesBackFlowWithOptions(string instanceId, string graphName, GetIgraphTablesBackFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphTablesBackFlow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/backflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphTablesBackFlowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIgraphTablesBackFlowResponse> GetIgraphTablesBackFlowWithOptionsAsync(string instanceId, string graphName, GetIgraphTablesBackFlowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIgraphTablesBackFlow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/backflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIgraphTablesBackFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIgraphTablesBackFlowResponse GetIgraphTablesBackFlow(string instanceId, string graphName, GetIgraphTablesBackFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIgraphTablesBackFlowWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<GetIgraphTablesBackFlowResponse> GetIgraphTablesBackFlowAsync(string instanceId, string graphName, GetIgraphTablesBackFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIgraphTablesBackFlowWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(string instanceId, GetInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string instanceId, GetInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceResponse GetInstance(string instanceId, GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(string instanceId, GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        public GetInstanceDigestResponse GetInstanceDigestWithOptions(string instanceId, GetInstanceDigestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceDigest",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/digest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceDigestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetInstanceDigestResponse> GetInstanceDigestWithOptionsAsync(string instanceId, GetInstanceDigestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceDigest",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/digest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceDigestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetInstanceDigestResponse GetInstanceDigest(string instanceId, GetInstanceDigestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceDigestWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<GetInstanceDigestResponse> GetInstanceDigestAsync(string instanceId, GetInstanceDigestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceDigestWithOptionsAsync(instanceId, request, headers, runtime);
        }

        public GetTableDetailResponse GetTableDetailWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableDetail",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableDetailResponse> GetTableDetailWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableDetail",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableDetailResponse GetTableDetail(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableDetailWithOptions(instanceId, tableName, headers, runtime);
        }

        public async Task<GetTableDetailResponse> GetTableDetailAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableDetailWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        public GetTableLastBackflowResponse GetTableLastBackflowWithOptions(string instanceId, string tableName, GetTableLastBackflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableLastBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/table/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/backflow/last",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableLastBackflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableLastBackflowResponse> GetTableLastBackflowWithOptionsAsync(string instanceId, string tableName, GetTableLastBackflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableLastBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/table/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/backflow/last",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableLastBackflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableLastBackflowResponse GetTableLastBackflow(string instanceId, string tableName, GetTableLastBackflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableLastBackflowWithOptions(instanceId, tableName, request, headers, runtime);
        }

        public async Task<GetTableLastBackflowResponse> GetTableLastBackflowAsync(string instanceId, string tableName, GetTableLastBackflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableLastBackflowWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        public ListDemoGraphSchemasResponse ListDemoGraphSchemasWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDemoGraphSchemas",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/demo/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDemoGraphSchemasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDemoGraphSchemasResponse> ListDemoGraphSchemasWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDemoGraphSchemas",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/demo/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDemoGraphSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDemoGraphSchemasResponse ListDemoGraphSchemas()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDemoGraphSchemasWithOptions(headers, runtime);
        }

        public async Task<ListDemoGraphSchemasResponse> ListDemoGraphSchemasAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDemoGraphSchemasWithOptionsAsync(headers, runtime);
        }

        public ListGraphSchemasResponse ListGraphSchemasWithOptions(string instanceId, string graphName, ListGraphSchemasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageLimit))
            {
                query["pageLimit"] = request.PageLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSpec))
            {
                query["returnSpec"] = request.ReturnSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaStatus))
            {
                query["schemaStatus"] = request.SchemaStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGraphSchemas",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGraphSchemasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGraphSchemasResponse> ListGraphSchemasWithOptionsAsync(string instanceId, string graphName, ListGraphSchemasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageLimit))
            {
                query["pageLimit"] = request.PageLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["pageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSpec))
            {
                query["returnSpec"] = request.ReturnSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaStatus))
            {
                query["schemaStatus"] = request.SchemaStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGraphSchemas",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGraphSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListGraphSchemasResponse ListGraphSchemas(string instanceId, string graphName, ListGraphSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGraphSchemasWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<ListGraphSchemasResponse> ListGraphSchemasAsync(string instanceId, string graphName, ListGraphSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGraphSchemasWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

        public ListIgraphInstancesResponse ListIgraphInstancesWithOptions(ListIgraphInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIgraphInstancesShrinkRequest request = new ListIgraphInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageContinue))
            {
                query["pageContinue"] = request.PageContinue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageLimit))
            {
                query["pageLimit"] = request.PageLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIgraphInstances",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIgraphInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIgraphInstancesResponse> ListIgraphInstancesWithOptionsAsync(ListIgraphInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListIgraphInstancesShrinkRequest request = new ListIgraphInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageContinue))
            {
                query["pageContinue"] = request.PageContinue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageLimit))
            {
                query["pageLimit"] = request.PageLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIgraphInstances",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIgraphInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIgraphInstancesResponse ListIgraphInstances(ListIgraphInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIgraphInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ListIgraphInstancesResponse> ListIgraphInstancesAsync(ListIgraphInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIgraphInstancesWithOptionsAsync(request, headers, runtime);
        }

        public ListInstanceGraphResponse ListInstanceGraphWithOptions(string instanceId, ListInstanceGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceGraphResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInstanceGraphResponse> ListInstanceGraphWithOptionsAsync(string instanceId, ListInstanceGraphRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceGraph",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInstanceGraphResponse ListInstanceGraph(string instanceId, ListInstanceGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceGraphWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<ListInstanceGraphResponse> ListInstanceGraphAsync(string instanceId, ListInstanceGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceGraphWithOptionsAsync(instanceId, request, headers, runtime);
        }

        public PublishGraphSchemaResponse PublishGraphSchemaWithOptions(string instanceId, string graphName, string graphSchemaName, PublishGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphSchemaName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishGraphSchemaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishGraphSchemaResponse> PublishGraphSchemaWithOptionsAsync(string instanceId, string graphName, string graphSchemaName, PublishGraphSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishGraphSchema",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/schemas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphSchemaName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishGraphSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishGraphSchemaResponse PublishGraphSchema(string instanceId, string graphName, string graphSchemaName, PublishGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishGraphSchemaWithOptions(instanceId, graphName, graphSchemaName, request, headers, runtime);
        }

        public async Task<PublishGraphSchemaResponse> PublishGraphSchemaAsync(string instanceId, string graphName, string graphSchemaName, PublishGraphSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishGraphSchemaWithOptionsAsync(instanceId, graphName, graphSchemaName, request, headers, runtime);
        }

        public SearchIgraphDemoResponse SearchIgraphDemoWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchIgraphDemo",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/tool/actions/search_demo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchIgraphDemoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchIgraphDemoResponse> SearchIgraphDemoWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchIgraphDemo",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/tool/actions/search_demo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchIgraphDemoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchIgraphDemoResponse SearchIgraphDemo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchIgraphDemoWithOptions(headers, runtime);
        }

        public async Task<SearchIgraphDemoResponse> SearchIgraphDemoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchIgraphDemoWithOptionsAsync(headers, runtime);
        }

        public TriggerLabelBackflowResponse TriggerLabelBackflowWithOptions(string instanceId, string graphName, string labelName, TriggerLabelBackflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OdpsPartition))
            {
                query["odpsPartition"] = request.OdpsPartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerLabelBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerLabelBackflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerLabelBackflowResponse> TriggerLabelBackflowWithOptionsAsync(string instanceId, string graphName, string labelName, TriggerLabelBackflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OdpsPartition))
            {
                query["odpsPartition"] = request.OdpsPartition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerLabelBackflow",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/label/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(labelName) + "/backflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerLabelBackflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerLabelBackflowResponse TriggerLabelBackflow(string instanceId, string graphName, string labelName, TriggerLabelBackflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TriggerLabelBackflowWithOptions(instanceId, graphName, labelName, request, headers, runtime);
        }

        public async Task<TriggerLabelBackflowResponse> TriggerLabelBackflowAsync(string instanceId, string graphName, string labelName, TriggerLabelBackflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TriggerLabelBackflowWithOptionsAsync(instanceId, graphName, labelName, request, headers, runtime);
        }

        public UpdateGraphDescriptionResponse UpdateGraphDescriptionWithOptions(string instanceId, string graphName, UpdateGraphDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGraphDescription",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/description",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGraphDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGraphDescriptionResponse> UpdateGraphDescriptionWithOptionsAsync(string instanceId, string graphName, UpdateGraphDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGraphDescription",
                Version = "2021-06-21",
                Protocol = "HTTPS",
                Pathname = "/openapi/igraph/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/graphs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(graphName) + "/description",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGraphDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGraphDescriptionResponse UpdateGraphDescription(string instanceId, string graphName, UpdateGraphDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGraphDescriptionWithOptions(instanceId, graphName, request, headers, runtime);
        }

        public async Task<UpdateGraphDescriptionResponse> UpdateGraphDescriptionAsync(string instanceId, string graphName, UpdateGraphDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGraphDescriptionWithOptionsAsync(instanceId, graphName, request, headers, runtime);
        }

    }
}
