// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Searchengine20211025.Models;

namespace AlibabaCloud.SDK.Searchengine20211025
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("searchengine", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/actions/build-index
          *
          * @param request BuildIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return BuildIndexResponse
         */
        public BuildIndexResponse BuildIndexWithOptions(string instanceId, BuildIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildMode))
            {
                body["buildMode"] = request.BuildMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuildIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/build-index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuildIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/actions/build-index
          *
          * @param request BuildIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return BuildIndexResponse
         */
        public async Task<BuildIndexResponse> BuildIndexWithOptionsAsync(string instanceId, BuildIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildMode))
            {
                body["buildMode"] = request.BuildMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuildIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/build-index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuildIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/actions/build-index
          *
          * @param request BuildIndexRequest
          * @return BuildIndexResponse
         */
        public BuildIndexResponse BuildIndex(string instanceId, BuildIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BuildIndexWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/actions/build-index
          *
          * @param request BuildIndexRequest
          * @return BuildIndexResponse
         */
        public async Task<BuildIndexResponse> BuildIndexAsync(string instanceId, BuildIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BuildIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters`
          *
          * @param request CreateClusterRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateClusterWithOptions(string instanceId, CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLoad))
            {
                body["autoLoad"] = request.AutoLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataNode))
            {
                body["dataNode"] = request.DataNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryNode))
            {
                body["queryNode"] = request.QueryNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters`
          *
          * @param request CreateClusterRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(string instanceId, CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoLoad))
            {
                body["autoLoad"] = request.AutoLoad;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataNode))
            {
                body["dataNode"] = request.DataNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryNode))
            {
                body["queryNode"] = request.QueryNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters`
          *
          * @param request CreateClusterRequest
          * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateCluster(string instanceId, CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters`
          *
          * @param request CreateClusterRequest
          * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterAsync(string instanceId, CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterWithOptionsAsync(instanceId, request, headers, runtime);
        }

        public CreateDataSourceResponse CreateDataSourceWithOptions(string instanceId, CreateDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuildIndex))
            {
                body["autoBuildIndex"] = request.AutoBuildIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaroConfig))
            {
                body["saroConfig"] = request.SaroConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(string instanceId, CreateDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuildIndex))
            {
                body["autoBuildIndex"] = request.AutoBuildIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaroConfig))
            {
                body["saroConfig"] = request.SaroConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDataSourceResponse CreateDataSource(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataSourceWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataSourceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * POST
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/indexes
          * ```
          *
          * @param request CreateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndexWithOptions(string instanceId, CreateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInfo))
            {
                body["dataSourceInfo"] = request.DataSourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * POST
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/indexes
          * ```
          *
          * @param request CreateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexWithOptionsAsync(string instanceId, CreateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInfo))
            {
                body["dataSourceInfo"] = request.DataSourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * POST
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/indexes
          * ```
          *
          * @param request CreateIndexRequest
          * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndex(string instanceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * POST
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/indexes
          * ```
          *
          * @param request CreateIndexRequest
          * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexAsync(string instanceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/api/instances?dryRun=false`
          *
          * @param request CreateInstanceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/api/instances?dryRun=false`
          *
          * @param request CreateInstanceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/api/instances?dryRun=false`
          *
          * @param request CreateInstanceRequest
          * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/api/instances?dryRun=false`
          *
          * @param request CreateInstanceRequest
          * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAdvanceConfigResponse
         */
        public DeleteAdvanceConfigResponse DeleteAdvanceConfigWithOptions(string instanceId, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAdvanceConfigResponse
         */
        public async Task<DeleteAdvanceConfigResponse> DeleteAdvanceConfigWithOptionsAsync(string instanceId, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAdvanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @return DeleteAdvanceConfigResponse
         */
        public DeleteAdvanceConfigResponse DeleteAdvanceConfig(string instanceId, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAdvanceConfigWithOptions(instanceId, configName, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @return DeleteAdvanceConfigResponse
         */
        public async Task<DeleteAdvanceConfigResponse> DeleteAdvanceConfigAsync(string instanceId, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAdvanceConfigWithOptionsAsync(instanceId, configName, headers, runtime);
        }

        /**
          * ## Method
          * `DELETE`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDataSourceResponse
         */
        public DeleteDataSourceResponse DeleteDataSourceWithOptions(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * `DELETE`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDataSourceResponse
         */
        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * `DELETE`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @return DeleteDataSourceResponse
         */
        public DeleteDataSourceResponse DeleteDataSource(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataSourceWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /**
          * ## Method
          * `DELETE`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @return DeleteDataSourceResponse
         */
        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataSourceWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
          *
          * @param request DeleteIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndexWithOptions(string instanceId, string indexName, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteDataSource))
            {
                query["deleteDataSource"] = request.DeleteDataSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
          *
          * @param request DeleteIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexWithOptionsAsync(string instanceId, string indexName, DeleteIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteDataSource))
            {
                query["deleteDataSource"] = request.DeleteDataSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
          *
          * @param request DeleteIndexRequest
          * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndex(string instanceId, string indexName, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
          *
          * @param request DeleteIndexRequest
          * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexAsync(string instanceId, string indexName, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexVersionResponse
         */
        public DeleteIndexVersionResponse DeleteIndexVersionWithOptions(string instanceId, string indexName, string versionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexVersionResponse
         */
        public async Task<DeleteIndexVersionResponse> DeleteIndexVersionWithOptionsAsync(string instanceId, string indexName, string versionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
          *
          * @return DeleteIndexVersionResponse
         */
        public DeleteIndexVersionResponse DeleteIndexVersion(string instanceId, string indexName, string versionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexVersionWithOptions(instanceId, indexName, versionName, headers, runtime);
        }

        /**
          * ## Method
          *     DELETE
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
          *
          * @return DeleteIndexVersionResponse
         */
        public async Task<DeleteIndexVersionResponse> DeleteIndexVersionAsync(string instanceId, string indexName, string versionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexVersionWithOptionsAsync(instanceId, indexName, versionName, headers, runtime);
        }

        /**
          * ### Method
          * `DELETE`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `DELETE`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `DELETE`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * `DELETE`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * \\### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ForceSwitchResponse
         */
        public ForceSwitchResponse ForceSwitchWithOptions(string instanceId, string fsmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceSwitch",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/force-switch/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fsmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceSwitchResponse>(CallApi(params_, req, runtime));
        }

        /**
          * \\### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ForceSwitchResponse
         */
        public async Task<ForceSwitchResponse> ForceSwitchWithOptionsAsync(string instanceId, string fsmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceSwitch",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/force-switch/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fsmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * \\### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
          * ```
          *
          * @return ForceSwitchResponse
         */
        public ForceSwitchResponse ForceSwitch(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ForceSwitchWithOptions(instanceId, fsmId, headers, runtime);
        }

        /**
          * \\### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
          * ```
          *
          * @return ForceSwitchResponse
         */
        public async Task<ForceSwitchResponse> ForceSwitchAsync(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ForceSwitchWithOptionsAsync(instanceId, fsmId, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param request GetAdvanceConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAdvanceConfigResponse
         */
        public GetAdvanceConfigResponse GetAdvanceConfigWithOptions(string instanceId, string configName, GetAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param request GetAdvanceConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAdvanceConfigResponse
         */
        public async Task<GetAdvanceConfigResponse> GetAdvanceConfigWithOptionsAsync(string instanceId, string configName, GetAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param request GetAdvanceConfigRequest
          * @return GetAdvanceConfigResponse
         */
        public GetAdvanceConfigResponse GetAdvanceConfig(string instanceId, string configName, GetAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
          *
          * @param request GetAdvanceConfigRequest
          * @return GetAdvanceConfigResponse
         */
        public async Task<GetAdvanceConfigResponse> GetAdvanceConfigAsync(string instanceId, string configName, GetAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request GetAdvanceConfigFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAdvanceConfigFileResponse
         */
        public GetAdvanceConfigFileResponse GetAdvanceConfigFileWithOptions(string instanceId, string configName, GetAdvanceConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvanceConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvanceConfigFileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request GetAdvanceConfigFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAdvanceConfigFileResponse
         */
        public async Task<GetAdvanceConfigFileResponse> GetAdvanceConfigFileWithOptionsAsync(string instanceId, string configName, GetAdvanceConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdvanceConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdvanceConfigFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request GetAdvanceConfigFileRequest
          * @return GetAdvanceConfigFileResponse
         */
        public GetAdvanceConfigFileResponse GetAdvanceConfigFile(string instanceId, string configName, GetAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAdvanceConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request GetAdvanceConfigFileRequest
          * @return GetAdvanceConfigFileResponse
         */
        public async Task<GetAdvanceConfigFileResponse> GetAdvanceConfigFileAsync(string instanceId, string configName, GetAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAdvanceConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instance/{instanceId}/clusters/{clusterName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetClusterResponse
         */
        public GetClusterResponse GetClusterWithOptions(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instance/{instanceId}/clusters/{clusterName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetClusterResponse
         */
        public async Task<GetClusterResponse> GetClusterWithOptionsAsync(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instance/{instanceId}/clusters/{clusterName}`
          *
          * @return GetClusterResponse
         */
        public GetClusterResponse GetCluster(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterWithOptions(instanceId, clusterName, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instance/{instanceId}/clusters/{clusterName}`
          *
          * @return GetClusterResponse
         */
        public async Task<GetClusterResponse> GetClusterAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-run-time-info
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetClusterRunTimeInfoResponse
         */
        public GetClusterRunTimeInfoResponse GetClusterRunTimeInfoWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterRunTimeInfo",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-run-time-info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterRunTimeInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-run-time-info
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetClusterRunTimeInfoResponse
         */
        public async Task<GetClusterRunTimeInfoResponse> GetClusterRunTimeInfoWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterRunTimeInfo",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-run-time-info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterRunTimeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-run-time-info
          *
          * @return GetClusterRunTimeInfoResponse
         */
        public GetClusterRunTimeInfoResponse GetClusterRunTimeInfo(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterRunTimeInfoWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-run-time-info
          *
          * @return GetClusterRunTimeInfoResponse
         */
        public async Task<GetClusterRunTimeInfoResponse> GetClusterRunTimeInfoAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterRunTimeInfoWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDataSourceResponse
         */
        public GetDataSourceResponse GetDataSourceWithOptions(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDataSourceResponse
         */
        public async Task<GetDataSourceResponse> GetDataSourceWithOptionsAsync(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @return GetDataSourceResponse
         */
        public GetDataSourceResponse GetDataSource(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSourceWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @return GetDataSourceResponse
         */
        public async Task<GetDataSourceResponse> GetDataSourceAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSourceWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        public GetDataSourceDeployResponse GetDataSourceDeployWithOptions(string instanceId, string deployName, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSourceDeploy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceDeployResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataSourceDeployResponse> GetDataSourceDeployWithOptionsAsync(string instanceId, string deployName, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSourceDeploy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSourceDeployResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataSourceDeployResponse GetDataSourceDeploy(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSourceDeployWithOptions(instanceId, deployName, dataSourceName, headers, runtime);
        }

        public async Task<GetDataSourceDeployResponse> GetDataSourceDeployAsync(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSourceDeployWithOptionsAsync(instanceId, deployName, dataSourceName, headers, runtime);
        }

        /**
          * ## Method
          * GET
          * ## URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/deploy-graph
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeployGraphResponse
         */
        public GetDeployGraphResponse GetDeployGraphWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployGraph",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/deploy-graph",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployGraphResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * GET
          * ## URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/deploy-graph
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDeployGraphResponse
         */
        public async Task<GetDeployGraphResponse> GetDeployGraphWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeployGraph",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/deploy-graph",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeployGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * GET
          * ## URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/deploy-graph
          * ```
          *
          * @return GetDeployGraphResponse
         */
        public GetDeployGraphResponse GetDeployGraph(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeployGraphWithOptions(instanceId, headers, runtime);
        }

        /**
          * ## Method
          * GET
          * ## URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/deploy-graph
          * ```
          *
          * @return GetDeployGraphResponse
         */
        public async Task<GetDeployGraphResponse> GetDeployGraphAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeployGraphWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request GetFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFileResponse
         */
        public GetFileResponse GetFileWithOptions(string instanceId, string indexName, string versionName, GetFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName) + "/file",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request GetFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileWithOptionsAsync(string instanceId, string indexName, string versionName, GetFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName) + "/file",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request GetFileRequest
          * @return GetFileResponse
         */
        public GetFileResponse GetFile(string instanceId, string indexName, string versionName, GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileWithOptions(instanceId, indexName, versionName, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request GetFileRequest
          * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileAsync(string instanceId, string indexName, string versionName, GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileWithOptionsAsync(instanceId, indexName, versionName, request, headers, runtime);
        }

        public GetIndexResponse GetIndexWithOptions(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIndexResponse> GetIndexWithOptionsAsync(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIndexResponse GetIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        public async Task<GetIndexResponse> GetIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetIndexVersionResponse
         */
        public GetIndexVersionResponse GetIndexVersionWithOptions(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/index-version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetIndexVersionResponse
         */
        public async Task<GetIndexVersionResponse> GetIndexVersionWithOptionsAsync(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/index-version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @return GetIndexVersionResponse
         */
        public GetIndexVersionResponse GetIndexVersion(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexVersionWithOptions(instanceId, clusterName, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @return GetIndexVersionResponse
         */
        public async Task<GetIndexVersionResponse> GetIndexVersionAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexVersionWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        public GetNodeConfigResponse GetNodeConfigWithOptions(string instanceId, GetNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["clusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "GetNodeConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetNodeConfigResponse> GetNodeConfigWithOptionsAsync(string instanceId, GetNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["clusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "GetNodeConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node-config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetNodeConfigResponse GetNodeConfig(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeConfigWithOptions(instanceId, request, headers, runtime);
        }

        public async Task<GetNodeConfigResponse> GetNodeConfigAsync(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}`
          *
          * @param request ListAdvanceConfigDirRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAdvanceConfigDirResponse
         */
        public ListAdvanceConfigDirResponse ListAdvanceConfigDirWithOptions(string instanceId, string configName, ListAdvanceConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                query["dirName"] = request.DirName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdvanceConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdvanceConfigDirResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}`
          *
          * @param request ListAdvanceConfigDirRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAdvanceConfigDirResponse
         */
        public async Task<ListAdvanceConfigDirResponse> ListAdvanceConfigDirWithOptionsAsync(string instanceId, string configName, ListAdvanceConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                query["dirName"] = request.DirName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAdvanceConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdvanceConfigDirResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}`
          *
          * @param request ListAdvanceConfigDirRequest
          * @return ListAdvanceConfigDirResponse
         */
        public ListAdvanceConfigDirResponse ListAdvanceConfigDir(string instanceId, string configName, ListAdvanceConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAdvanceConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}`
          *
          * @param request ListAdvanceConfigDirRequest
          * @return ListAdvanceConfigDirResponse
         */
        public async Task<ListAdvanceConfigDirResponse> ListAdvanceConfigDirAsync(string instanceId, string configName, ListAdvanceConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAdvanceConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Sample requests
          * `GET /openapi/ha3/instances/ose-test1/advanced-configs`
          *
          * @param request ListAdvanceConfigsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAdvanceConfigsResponse
         */
        public ListAdvanceConfigsResponse ListAdvanceConfigsWithOptions(string instanceId, ListAdvanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["indexName"] = request.IndexName;
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
                Action = "ListAdvanceConfigs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdvanceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Sample requests
          * `GET /openapi/ha3/instances/ose-test1/advanced-configs`
          *
          * @param request ListAdvanceConfigsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAdvanceConfigsResponse
         */
        public async Task<ListAdvanceConfigsResponse> ListAdvanceConfigsWithOptionsAsync(string instanceId, ListAdvanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                query["indexName"] = request.IndexName;
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
                Action = "ListAdvanceConfigs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAdvanceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Sample requests
          * `GET /openapi/ha3/instances/ose-test1/advanced-configs`
          *
          * @param request ListAdvanceConfigsRequest
          * @return ListAdvanceConfigsResponse
         */
        public ListAdvanceConfigsResponse ListAdvanceConfigs(string instanceId, ListAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAdvanceConfigsWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ## Sample requests
          * `GET /openapi/ha3/instances/ose-test1/advanced-configs`
          *
          * @param request ListAdvanceConfigsRequest
          * @return ListAdvanceConfigsResponse
         */
        public async Task<ListAdvanceConfigsResponse> ListAdvanceConfigsAsync(string instanceId, ListAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAdvanceConfigsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-names
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClusterNamesResponse
         */
        public ListClusterNamesResponse ListClusterNamesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterNames",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/cluster-names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterNamesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-names
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClusterNamesResponse
         */
        public async Task<ListClusterNamesResponse> ListClusterNamesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterNames",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/cluster-names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-names
          *
          * @return ListClusterNamesResponse
         */
        public ListClusterNamesResponse ListClusterNames()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterNamesWithOptions(headers, runtime);
        }

        /**
          * ### Method
          * GET
          * ### URI
          * /openapi/ha3/instances/{instanceId}/cluster-names
          *
          * @return ListClusterNamesResponse
         */
        public async Task<ListClusterNamesResponse> ListClusterNamesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterNamesWithOptionsAsync(headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/cluster-tasks
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClusterTasksResponse
         */
        public ListClusterTasksResponse ListClusterTasksWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/cluster-tasks
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClusterTasksResponse
         */
        public async Task<ListClusterTasksResponse> ListClusterTasksWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/cluster-tasks
          * ```
          *
          * @return ListClusterTasksResponse
         */
        public ListClusterTasksResponse ListClusterTasks(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterTasksWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/cluster-tasks
          * ```
          *
          * @return ListClusterTasksResponse
         */
        public async Task<ListClusterTasksResponse> ListClusterTasksAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterTasksWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClustersResponse
         */
        public ListClustersResponse ListClustersWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListClustersResponse
         */
        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters
          * ```
          *
          * @return ListClustersResponse
         */
        public ListClustersResponse ListClusters(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClustersWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters
          * ```
          *
          * @return ListClustersResponse
         */
        public async Task<ListClustersResponse> ListClustersAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClustersWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourceSchemasResponse
         */
        public ListDataSourceSchemasResponse ListDataSourceSchemasWithOptions(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceSchemas",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceSchemasResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourceSchemasResponse
         */
        public async Task<ListDataSourceSchemasResponse> ListDataSourceSchemasWithOptionsAsync(string instanceId, string dataSourceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceSchemas",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas`
          *
          * @return ListDataSourceSchemasResponse
         */
        public ListDataSourceSchemasResponse ListDataSourceSchemas(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceSchemasWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas`
          *
          * @return ListDataSourceSchemasResponse
         */
        public async Task<ListDataSourceSchemasResponse> ListDataSourceSchemasAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceSchemasWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/data-source-tasks
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourceTasksResponse
         */
        public ListDataSourceTasksResponse ListDataSourceTasksWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-source-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/data-source-tasks
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourceTasksResponse
         */
        public async Task<ListDataSourceTasksResponse> ListDataSourceTasksWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-source-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/data-source-tasks
          * ```
          *
          * @return ListDataSourceTasksResponse
         */
        public ListDataSourceTasksResponse ListDataSourceTasks(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceTasksWithOptions(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/data-source-tasks
          * ```
          *
          * @return ListDataSourceTasksResponse
         */
        public async Task<ListDataSourceTasksResponse> ListDataSourceTasksAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceTasksWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourcesResponse
         */
        public ListDataSourcesResponse ListDataSourcesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources`
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDataSourcesResponse
         */
        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources`
          *
          * @return ListDataSourcesResponse
         */
        public ListDataSourcesResponse ListDataSources(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourcesWithOptions(instanceId, headers, runtime);
        }

        /**
          * ## Method
          * `GET`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources`
          *
          * @return ListDataSourcesResponse
         */
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourcesWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}`
          *
          * @param request ListDateSourceGenerationsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDateSourceGenerationsResponse
         */
        public ListDateSourceGenerationsResponse ListDateSourceGenerationsWithOptions(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStatus))
            {
                query["validStatus"] = request.ValidStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDateSourceGenerations",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/generations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDateSourceGenerationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}`
          *
          * @param request ListDateSourceGenerationsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDateSourceGenerationsResponse
         */
        public async Task<ListDateSourceGenerationsResponse> ListDateSourceGenerationsWithOptionsAsync(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidStatus))
            {
                query["validStatus"] = request.ValidStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDateSourceGenerations",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/generations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDateSourceGenerationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}`
          *
          * @param request ListDateSourceGenerationsRequest
          * @return ListDateSourceGenerationsResponse
         */
        public ListDateSourceGenerationsResponse ListDateSourceGenerations(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDateSourceGenerationsWithOptions(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}`
          *
          * @param request ListDateSourceGenerationsRequest
          * @return ListDateSourceGenerationsResponse
         */
        public async Task<ListDateSourceGenerationsResponse> ListDateSourceGenerationsAsync(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDateSourceGenerationsWithOptionsAsync(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes
          *
          * @param request ListIndexesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListIndexesResponse
         */
        public ListIndexesResponse ListIndexesWithOptions(string instanceId, ListIndexesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexes",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes
          *
          * @param request ListIndexesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListIndexesResponse
         */
        public async Task<ListIndexesResponse> ListIndexesWithOptionsAsync(string instanceId, ListIndexesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexes",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes
          *
          * @param request ListIndexesRequest
          * @return ListIndexesResponse
         */
        public ListIndexesResponse ListIndexes(string instanceId, ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexesWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          *     GET
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes
          *
          * @param request ListIndexesRequest
          * @return ListIndexesResponse
         */
        public async Task<ListIndexesResponse> ListIndexesAsync(string instanceId, ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/specs?type=qrs`
          *
          * @param request ListInstanceSpecsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstanceSpecsResponse
         */
        public ListInstanceSpecsResponse ListInstanceSpecsWithOptions(string instanceId, ListInstanceSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListInstanceSpecs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/specs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSpecsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/specs?type=qrs`
          *
          * @param request ListInstanceSpecsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstanceSpecsResponse
         */
        public async Task<ListInstanceSpecsResponse> ListInstanceSpecsWithOptionsAsync(string instanceId, ListInstanceSpecsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListInstanceSpecs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/specs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceSpecsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/specs?type=qrs`
          *
          * @param request ListInstanceSpecsRequest
          * @return ListInstanceSpecsResponse
         */
        public ListInstanceSpecsResponse ListInstanceSpecs(string instanceId, ListInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceSpecsWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/specs?type=qrs`
          *
          * @param request ListInstanceSpecsRequest
          * @return ListInstanceSpecsResponse
         */
        public async Task<ListInstanceSpecsResponse> ListInstanceSpecsAsync(string instanceId, ListInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceSpecsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/[code]/instances`
          *
          * @param tmpReq ListInstancesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListInstances",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/[code]/instances`
          *
          * @param tmpReq ListInstancesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListInstances",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/[code]/instances`
          *
          * @param request ListInstancesRequest
          * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/[code]/instances`
          *
          * @param request ListInstancesRequest
          * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
          * ```
          *
          * @param request ListOnlineConfigsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListOnlineConfigsResponse
         */
        public ListOnlineConfigsResponse ListOnlineConfigsWithOptions(string instanceId, string nodeName, ListOnlineConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineConfigs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeName) + "/online-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
          * ```
          *
          * @param request ListOnlineConfigsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListOnlineConfigsResponse
         */
        public async Task<ListOnlineConfigsResponse> ListOnlineConfigsWithOptionsAsync(string instanceId, string nodeName, ListOnlineConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOnlineConfigs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeName) + "/online-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOnlineConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
          * ```
          *
          * @param request ListOnlineConfigsRequest
          * @return ListOnlineConfigsResponse
         */
        public ListOnlineConfigsResponse ListOnlineConfigs(string instanceId, string nodeName, ListOnlineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOnlineConfigsWithOptions(instanceId, nodeName, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * GET
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
          * ```
          *
          * @param request ListOnlineConfigsRequest
          * @return ListOnlineConfigsResponse
         */
        public async Task<ListOnlineConfigsResponse> ListOnlineConfigsAsync(string instanceId, string nodeName, ListOnlineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOnlineConfigsWithOptionsAsync(instanceId, nodeName, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/query?query=xxxx`
          *
          * @param request ListQueryResultRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListQueryResultResponse
         */
        public ListQueryResultResponse ListQueryResultWithOptions(string instanceId, ListQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/query?query=xxxx`
          *
          * @param request ListQueryResultRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListQueryResultResponse
         */
        public async Task<ListQueryResultResponse> ListQueryResultWithOptionsAsync(string instanceId, ListQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/query?query=xxxx`
          *
          * @param request ListQueryResultRequest
          * @return ListQueryResultResponse
         */
        public ListQueryResultResponse ListQueryResult(string instanceId, ListQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `GET`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/query?query=xxxx`
          *
          * @param request ListQueryResultRequest
          * @return ListQueryResultResponse
         */
        public async Task<ListQueryResultResponse> ListQueryResultAsync(string instanceId, ListQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          *     put
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request ModifyAdvanceConfigFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyAdvanceConfigFileResponse
         */
        public ModifyAdvanceConfigFileResponse ModifyAdvanceConfigFileWithOptions(string instanceId, string configName, ModifyAdvanceConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAdvanceConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAdvanceConfigFileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     put
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request ModifyAdvanceConfigFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyAdvanceConfigFileResponse
         */
        public async Task<ModifyAdvanceConfigFileResponse> ModifyAdvanceConfigFileWithOptionsAsync(string instanceId, string configName, ModifyAdvanceConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAdvanceConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAdvanceConfigFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     put
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request ModifyAdvanceConfigFileRequest
          * @return ModifyAdvanceConfigFileResponse
         */
        public ModifyAdvanceConfigFileResponse ModifyAdvanceConfigFile(string instanceId, string configName, ModifyAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAdvanceConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          *     put
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
          *
          * @param request ModifyAdvanceConfigFileRequest
          * @return ModifyAdvanceConfigFileResponse
         */
        public async Task<ModifyAdvanceConfigFileResponse> ModifyAdvanceConfigFileAsync(string instanceId, string configName, ModifyAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAdvanceConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc`
          *
          * @param request ModifyClusterDescRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterDescResponse
         */
        public ModifyClusterDescResponse ModifyClusterDescWithOptions(string instanceId, string clusterName, ModifyClusterDescRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterDesc",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/desc",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterDescResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc`
          *
          * @param request ModifyClusterDescRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterDescResponse
         */
        public async Task<ModifyClusterDescResponse> ModifyClusterDescWithOptionsAsync(string instanceId, string clusterName, ModifyClusterDescRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterDesc",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/desc",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterDescResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc`
          *
          * @param request ModifyClusterDescRequest
          * @return ModifyClusterDescResponse
         */
        public ModifyClusterDescResponse ModifyClusterDesc(string instanceId, string clusterName, ModifyClusterDescRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterDescWithOptions(instanceId, clusterName, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc`
          *
          * @param request ModifyClusterDescRequest
          * @return ModifyClusterDescResponse
         */
        public async Task<ModifyClusterDescResponse> ModifyClusterDescAsync(string instanceId, string clusterName, ModifyClusterDescRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterDescWithOptionsAsync(instanceId, clusterName, request, headers, runtime);
        }

        /**
          * ## Request syntax
          *     PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
          *
          * @param request ModifyClusterOfflineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterOfflineConfigResponse
         */
        public ModifyClusterOfflineConfigResponse ModifyClusterOfflineConfigWithOptions(string instanceId, ModifyClusterOfflineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildMode))
            {
                body["buildMode"] = request.BuildMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushMode))
            {
                body["pushMode"] = request.PushMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterOfflineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-offline-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterOfflineConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Request syntax
          *     PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
          *
          * @param request ModifyClusterOfflineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterOfflineConfigResponse
         */
        public async Task<ModifyClusterOfflineConfigResponse> ModifyClusterOfflineConfigWithOptionsAsync(string instanceId, ModifyClusterOfflineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildMode))
            {
                body["buildMode"] = request.BuildMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushMode))
            {
                body["pushMode"] = request.PushMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterOfflineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-offline-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterOfflineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Request syntax
          *     PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
          *
          * @param request ModifyClusterOfflineConfigRequest
          * @return ModifyClusterOfflineConfigResponse
         */
        public ModifyClusterOfflineConfigResponse ModifyClusterOfflineConfig(string instanceId, ModifyClusterOfflineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterOfflineConfigWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ## Request syntax
          *     PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
          *
          * @param request ModifyClusterOfflineConfigRequest
          * @return ModifyClusterOfflineConfigResponse
         */
        public async Task<ModifyClusterOfflineConfigResponse> ModifyClusterOfflineConfigAsync(string instanceId, ModifyClusterOfflineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterOfflineConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/cluster-online-config`
          *
          * @param request ModifyClusterOnlineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterOnlineConfigResponse
         */
        public ModifyClusterOnlineConfigResponse ModifyClusterOnlineConfigWithOptions(string instanceId, ModifyClusterOnlineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clusters))
            {
                body["clusters"] = request.Clusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterOnlineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-online-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterOnlineConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/cluster-online-config`
          *
          * @param request ModifyClusterOnlineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyClusterOnlineConfigResponse
         */
        public async Task<ModifyClusterOnlineConfigResponse> ModifyClusterOnlineConfigWithOptionsAsync(string instanceId, ModifyClusterOnlineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clusters))
            {
                body["clusters"] = request.Clusters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterOnlineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/cluster-online-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterOnlineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/cluster-online-config`
          *
          * @param request ModifyClusterOnlineConfigRequest
          * @return ModifyClusterOnlineConfigResponse
         */
        public ModifyClusterOnlineConfigResponse ModifyClusterOnlineConfig(string instanceId, ModifyClusterOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterOnlineConfigWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/cluster-online-config`
          *
          * @param request ModifyClusterOnlineConfigRequest
          * @return ModifyClusterOnlineConfigResponse
         */
        public async Task<ModifyClusterOnlineConfigResponse> ModifyClusterOnlineConfigAsync(string instanceId, ModifyClusterOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterOnlineConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          * `PUT`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param request ModifyDataSourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDataSourceResponse
         */
        public ModifyDataSourceResponse ModifyDataSourceWithOptions(string instanceId, string dataSourceName, ModifyDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ModifyDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * `PUT`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param request ModifyDataSourceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyDataSourceResponse
         */
        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(string instanceId, string dataSourceName, ModifyDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
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
                Action = "ModifyDataSource",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * `PUT`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param request ModifyDataSourceRequest
          * @return ModifyDataSourceResponse
         */
        public ModifyDataSourceResponse ModifyDataSource(string instanceId, string dataSourceName, ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDataSourceWithOptions(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
          * ## Method
          * `PUT`
          * ## URI
          * `/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}`
          *
          * @param request ModifyDataSourceRequest
          * @return ModifyDataSourceResponse
         */
        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(string instanceId, string dataSourceName, ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDataSourceWithOptionsAsync(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request ModifyFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyFileResponse
         */
        public ModifyFileResponse ModifyFileWithOptions(string instanceId, string indexName, string versionName, ModifyFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName) + "/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request ModifyFileRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyFileResponse
         */
        public async Task<ModifyFileResponse> ModifyFileWithOptionsAsync(string instanceId, string indexName, string versionName, ModifyFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionName) + "/file",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request ModifyFileRequest
          * @return ModifyFileResponse
         */
        public ModifyFileResponse ModifyFile(string instanceId, string indexName, string versionName, ModifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFileWithOptions(instanceId, indexName, versionName, request, headers, runtime);
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
          *
          * @param request ModifyFileRequest
          * @return ModifyFileResponse
         */
        public async Task<ModifyFileResponse> ModifyFileAsync(string instanceId, string indexName, string versionName, ModifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFileWithOptionsAsync(instanceId, indexName, versionName, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/index-partition`
          *
          * @param request ModifyIndexPartitionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyIndexPartitionResponse
         */
        public ModifyIndexPartitionResponse ModifyIndexPartitionWithOptions(string instanceId, ModifyIndexPartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexInfos))
            {
                body["indexInfos"] = request.IndexInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexPartition",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/index-partition",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexPartitionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/index-partition`
          *
          * @param request ModifyIndexPartitionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyIndexPartitionResponse
         */
        public async Task<ModifyIndexPartitionResponse> ModifyIndexPartitionWithOptionsAsync(string instanceId, ModifyIndexPartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexInfos))
            {
                body["indexInfos"] = request.IndexInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexPartition",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/index-partition",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexPartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/index-partition`
          *
          * @param request ModifyIndexPartitionRequest
          * @return ModifyIndexPartitionResponse
         */
        public ModifyIndexPartitionResponse ModifyIndexPartition(string instanceId, ModifyIndexPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexPartitionWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/index-partition`
          *
          * @param request ModifyIndexPartitionRequest
          * @return ModifyIndexPartitionResponse
         */
        public async Task<ModifyIndexPartitionResponse> ModifyIndexPartitionAsync(string instanceId, ModifyIndexPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexPartitionWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param request ModifyIndexVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyIndexVersionResponse
         */
        public ModifyIndexVersionResponse ModifyIndexVersionWithOptions(string instanceId, string clusterName, ModifyIndexVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/index-version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param request ModifyIndexVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyIndexVersionResponse
         */
        public async Task<ModifyIndexVersionResponse> ModifyIndexVersionWithOptionsAsync(string instanceId, string clusterName, ModifyIndexVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName) + "/index-version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param request ModifyIndexVersionRequest
          * @return ModifyIndexVersionResponse
         */
        public ModifyIndexVersionResponse ModifyIndexVersion(string instanceId, string clusterName, ModifyIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexVersionWithOptions(instanceId, clusterName, request, headers, runtime);
        }

        /**
          * ## Method
          *     PUT
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
          *
          * @param request ModifyIndexVersionRequest
          * @return ModifyIndexVersionResponse
         */
        public async Task<ModifyIndexVersionResponse> ModifyIndexVersionAsync(string instanceId, string clusterName, ModifyIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexVersionWithOptionsAsync(instanceId, clusterName, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node-config?type=qrs&name=test
          * ```
          *
          * @param request ModifyNodeConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyNodeConfigResponse
         */
        public ModifyNodeConfigResponse ModifyNodeConfigWithOptions(string instanceId, ModifyNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["clusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDuplicateNumber))
            {
                body["dataDuplicateNumber"] = request.DataDuplicateNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFragmentNumber))
            {
                body["dataFragmentNumber"] = request.DataFragmentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowRatio))
            {
                body["flowRatio"] = request.FlowRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinServicePercent))
            {
                body["minServicePercent"] = request.MinServicePercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Published))
            {
                body["published"] = request.Published;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node-config?type=qrs&name=test
          * ```
          *
          * @param request ModifyNodeConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyNodeConfigResponse
         */
        public async Task<ModifyNodeConfigResponse> ModifyNodeConfigWithOptionsAsync(string instanceId, ModifyNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["clusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDuplicateNumber))
            {
                body["dataDuplicateNumber"] = request.DataDuplicateNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataFragmentNumber))
            {
                body["dataFragmentNumber"] = request.DataFragmentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowRatio))
            {
                body["flowRatio"] = request.FlowRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinServicePercent))
            {
                body["minServicePercent"] = request.MinServicePercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Published))
            {
                body["published"] = request.Published;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node-config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node-config?type=qrs&name=test
          * ```
          *
          * @param request ModifyNodeConfigRequest
          * @return ModifyNodeConfigResponse
         */
        public ModifyNodeConfigResponse ModifyNodeConfig(string instanceId, ModifyNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyNodeConfigWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node-config?type=qrs&name=test
          * ```
          *
          * @param request ModifyNodeConfigRequest
          * @return ModifyNodeConfigResponse
         */
        public async Task<ModifyNodeConfigResponse> ModifyNodeConfigAsync(string instanceId, ModifyNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyNodeConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * put
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
          * ```
          *
          * @param request ModifyOnlineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyOnlineConfigResponse
         */
        public ModifyOnlineConfigResponse ModifyOnlineConfigWithOptions(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOnlineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeName) + "/online-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOnlineConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * put
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
          * ```
          *
          * @param request ModifyOnlineConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyOnlineConfigResponse
         */
        public async Task<ModifyOnlineConfigResponse> ModifyOnlineConfigWithOptionsAsync(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOnlineConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/node/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeName) + "/online-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOnlineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * put
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
          * ```
          *
          * @param request ModifyOnlineConfigRequest
          * @return ModifyOnlineConfigResponse
         */
        public ModifyOnlineConfigResponse ModifyOnlineConfig(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyOnlineConfigWithOptions(instanceId, nodeName, indexName, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * put
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
          * ```
          *
          * @param request ModifyOnlineConfigRequest
          * @return ModifyOnlineConfigResponse
         */
        public async Task<ModifyOnlineConfigResponse> ModifyOnlineConfigAsync(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyOnlineConfigWithOptionsAsync(instanceId, nodeName, indexName, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/password`
          *
          * @param request ModifyPasswordRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyPasswordResponse
         */
        public ModifyPasswordResponse ModifyPasswordWithOptions(string instanceId, ModifyPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPassword",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/password",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/password`
          *
          * @param request ModifyPasswordRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ModifyPasswordResponse
         */
        public async Task<ModifyPasswordResponse> ModifyPasswordWithOptionsAsync(string instanceId, ModifyPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPassword",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/password",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/password`
          *
          * @param request ModifyPasswordRequest
          * @return ModifyPasswordResponse
         */
        public ModifyPasswordResponse ModifyPassword(string instanceId, ModifyPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPasswordWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/password`
          *
          * @param request ModifyPasswordRequest
          * @return ModifyPasswordResponse
         */
        public async Task<ModifyPasswordResponse> ModifyPasswordAsync(string instanceId, ModifyPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPasswordWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ## Method
          * ~~~
          * POST
          * ~~~
          * ## URI
          * ~~~
          * /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
          * ~~~
          *
          * @param request PublishAdvanceConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishAdvanceConfigResponse
         */
        public PublishAdvanceConfigResponse PublishAdvanceConfigWithOptions(string instanceId, string configName, PublishAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishAdvanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          * ~~~
          * POST
          * ~~~
          * ## URI
          * ~~~
          * /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
          * ~~~
          *
          * @param request PublishAdvanceConfigRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishAdvanceConfigResponse
         */
        public async Task<PublishAdvanceConfigResponse> PublishAdvanceConfigWithOptionsAsync(string instanceId, string configName, PublishAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishAdvanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          * ~~~
          * POST
          * ~~~
          * ## URI
          * ~~~
          * /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
          * ~~~
          *
          * @param request PublishAdvanceConfigRequest
          * @return PublishAdvanceConfigResponse
         */
        public PublishAdvanceConfigResponse PublishAdvanceConfig(string instanceId, string configName, PublishAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          * ~~~
          * POST
          * ~~~
          * ## URI
          * ~~~
          * /openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
          * ~~~
          *
          * @param request PublishAdvanceConfigRequest
          * @return PublishAdvanceConfigResponse
         */
        public async Task<PublishAdvanceConfigResponse> PublishAdvanceConfigAsync(string instanceId, string configName, PublishAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
          *
          * @param request PublishIndexVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishIndexVersionResponse
         */
        public PublishIndexVersionResponse PublishIndexVersionWithOptions(string instanceId, string indexName, PublishIndexVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
          *
          * @param request PublishIndexVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PublishIndexVersionResponse
         */
        public async Task<PublishIndexVersionResponse> PublishIndexVersionWithOptionsAsync(string instanceId, string indexName, PublishIndexVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishIndexVersion",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/actions/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
          *
          * @param request PublishIndexVersionRequest
          * @return PublishIndexVersionResponse
         */
        public PublishIndexVersionResponse PublishIndexVersion(string instanceId, string indexName, PublishIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishIndexVersionWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /**
          * ## Method
          *     POST
          * ## URI
          *     /openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
          *
          * @param request PublishIndexVersionRequest
          * @return PublishIndexVersionResponse
         */
        public async Task<PublishIndexVersionResponse> PublishIndexVersionAsync(string instanceId, string indexName, PublishIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishIndexVersionWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/recover-index`
          *
          * @param request RecoverIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RecoverIndexResponse
         */
        public RecoverIndexResponse RecoverIndexWithOptions(string instanceId, RecoverIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildDeployId))
            {
                body["buildDeployId"] = request.BuildDeployId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                body["indexName"] = request.IndexName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/recover-index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/recover-index`
          *
          * @param request RecoverIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RecoverIndexResponse
         */
        public async Task<RecoverIndexResponse> RecoverIndexWithOptionsAsync(string instanceId, RecoverIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildDeployId))
            {
                body["buildDeployId"] = request.BuildDeployId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                body["dataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Generation))
            {
                body["generation"] = request.Generation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                body["indexName"] = request.IndexName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/recover-index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/recover-index`
          *
          * @param request RecoverIndexRequest
          * @return RecoverIndexResponse
         */
        public RecoverIndexResponse RecoverIndex(string instanceId, RecoverIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverIndexWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `POST`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}/recover-index`
          *
          * @param request RecoverIndexRequest
          * @return RecoverIndexResponse
         */
        public async Task<RecoverIndexResponse> RecoverIndexAsync(string instanceId, RecoverIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * DELETE
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters/{clusterName}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveClusterResponse
         */
        public RemoveClusterResponse RemoveClusterWithOptions(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * DELETE
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters/{clusterName}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveClusterResponse
         */
        public async Task<RemoveClusterResponse> RemoveClusterWithOptionsAsync(string instanceId, string clusterName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveCluster",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * DELETE
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters/{clusterName}
          * ```
          *
          * @return RemoveClusterResponse
         */
        public RemoveClusterResponse RemoveCluster(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveClusterWithOptions(instanceId, clusterName, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * DELETE
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/clusters/{clusterName}
          * ```
          *
          * @return RemoveClusterResponse
         */
        public async Task<RemoveClusterResponse> RemoveClusterAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveClusterWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopTaskResponse
         */
        public StopTaskResponse StopTaskWithOptions(string instanceId, string fsmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTask",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/stop-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fsmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
          * ```
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopTaskResponse
         */
        public async Task<StopTaskResponse> StopTaskWithOptionsAsync(string instanceId, string fsmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTask",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/stop-task/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fsmId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
          * ```
          *
          * @return StopTaskResponse
         */
        public StopTaskResponse StopTask(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTaskWithOptions(instanceId, fsmId, headers, runtime);
        }

        /**
          * ### Method
          * ```java
          * PUT
          * ```
          * ### URI
          * ```java
          * /openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
          * ```
          *
          * @return StopTaskResponse
         */
        public async Task<StopTaskResponse> StopTaskAsync(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTaskWithOptionsAsync(instanceId, fsmId, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param request UpdateInstanceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstanceWithOptions(string instanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["orderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param request UpdateInstanceRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(string instanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                body["orderType"] = request.OrderType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param request UpdateInstanceRequest
          * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstance(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /**
          * ### Method
          * `PUT`
          * ### URI
          * `/openapi/ha3/instances/{instanceId}`
          *
          * @param request UpdateInstanceRequest
          * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

    }
}
