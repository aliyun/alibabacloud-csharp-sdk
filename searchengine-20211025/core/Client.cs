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
         * @summary Triggers reindexing.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
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
         * @summary Triggers reindexing.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
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
         * @summary Triggers reindexing.
         *
         * @description ## Method
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
         * @summary Triggers reindexing.
         *
         * @description ## Method
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
         * @summary 更换实例资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(string instanceId, ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["newResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/change-resource-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更换实例资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(string instanceId, ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["newResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/change-resource-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更换实例资源组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(string instanceId, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 更换实例资源组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(string instanceId, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @param request CloneSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneSqlInstanceResponse
         */
        public CloneSqlInstanceResponse CloneSqlInstanceWithOptions(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/actions/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneSqlInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CloneSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneSqlInstanceResponse
         */
        public async Task<CloneSqlInstanceResponse> CloneSqlInstanceWithOptionsAsync(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFolderId))
            {
                body["targetFolderId"] = request.TargetFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/actions/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneSqlInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CloneSqlInstanceRequest
         * @return CloneSqlInstanceResponse
         */
        public CloneSqlInstanceResponse CloneSqlInstance(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request CloneSqlInstanceRequest
         * @return CloneSqlInstanceResponse
         */
        public async Task<CloneSqlInstanceResponse> CloneSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request CreateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAliasWithOptions(string instanceId, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(string instanceId, CreateAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAlias(string instanceId, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAliasWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasAsync(string instanceId, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAliasWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Creates a cluster.
         *
         * @description ### [](#method)Method
         * `POST`
         * ### [](#uri)URI
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
         * @summary Creates a cluster.
         *
         * @description ### [](#method)Method
         * `POST`
         * ### [](#uri)URI
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
         * @summary Creates a cluster.
         *
         * @description ### [](#method)Method
         * `POST`
         * ### [](#uri)URI
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
         * @summary Creates a cluster.
         *
         * @description ### [](#method)Method
         * `POST`
         * ### [](#uri)URI
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

        /**
         * @param request CreateConfigDirRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigDirResponse
         */
        public CreateConfigDirResponse CreateConfigDirWithOptions(string instanceId, string configName, CreateConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                body["dirName"] = request.DirName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                body["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigDirResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateConfigDirRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigDirResponse
         */
        public async Task<CreateConfigDirResponse> CreateConfigDirWithOptionsAsync(string instanceId, string configName, CreateConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                body["dirName"] = request.DirName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                body["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigDirResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateConfigDirRequest
         * @return CreateConfigDirResponse
         */
        public CreateConfigDirResponse CreateConfigDir(string instanceId, string configName, CreateConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request CreateConfigDirRequest
         * @return CreateConfigDirResponse
         */
        public async Task<CreateConfigDirResponse> CreateConfigDirAsync(string instanceId, string configName, CreateConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request CreateConfigFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigFileResponse
         */
        public CreateConfigFileResponse CreateConfigFileWithOptions(string instanceId, string configName, CreateConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                body["ossPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                body["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateConfigFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigFileResponse
         */
        public async Task<CreateConfigFileResponse> CreateConfigFileWithOptionsAsync(string instanceId, string configName, CreateConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                body["ossPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                body["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateConfigFileRequest
         * @return CreateConfigFileResponse
         */
        public CreateConfigFileResponse CreateConfigFile(string instanceId, string configName, CreateConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request CreateConfigFileRequest
         * @return CreateConfigFileResponse
         */
        public async Task<CreateConfigFileResponse> CreateConfigFileAsync(string instanceId, string configName, CreateConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
         * @summary Creates data sources.
         *
         * @param request CreateDataSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataSourceResponse
         */
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

        /**
         * @summary Creates data sources.
         *
         * @param request CreateDataSourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataSourceResponse
         */
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

        /**
         * @summary Creates data sources.
         *
         * @param request CreateDataSourceRequest
         * @return CreateDataSourceResponse
         */
        public CreateDataSourceResponse CreateDataSource(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataSourceWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Creates data sources.
         *
         * @param request CreateDataSourceRequest
         * @return CreateDataSourceResponse
         */
        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataSourceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @param request CreateFolderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolderWithOptions(string instanceId, string database, CreateFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
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
                Action = "CreateFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateFolderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderWithOptionsAsync(string instanceId, string database, CreateFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
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
                Action = "CreateFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public CreateFolderResponse CreateFolder(string instanceId, string database, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFolderWithOptions(instanceId, database, request, headers, runtime);
        }

        /**
         * @param request CreateFolderRequest
         * @return CreateFolderResponse
         */
        public async Task<CreateFolderResponse> CreateFolderAsync(string instanceId, string database, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFolderWithOptionsAsync(instanceId, database, request, headers, runtime);
        }

        /**
         * @summary Creates an index.
         *
         * @description ### Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParallelNum))
            {
                body["buildParallelNum"] = request.BuildParallelNum;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeParallelNum))
            {
                body["mergeParallelNum"] = request.MergeParallelNum;
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
         * @summary Creates an index.
         *
         * @description ### Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParallelNum))
            {
                body["buildParallelNum"] = request.BuildParallelNum;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeParallelNum))
            {
                body["mergeParallelNum"] = request.MergeParallelNum;
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
         * @summary Creates an index.
         *
         * @description ### Method
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
         * @summary Creates an index.
         *
         * @description ### Method
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
         * @summary Creates a Havenask instance.
         *
         * @description ### [](#)Method
         * `POST`
         * ### [](#uri)URI
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
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
         * @summary Creates a Havenask instance.
         *
         * @description ### [](#)Method
         * `POST`
         * ### [](#uri)URI
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
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
         * @summary Creates a Havenask instance.
         *
         * @description ### [](#)Method
         * `POST`
         * ### [](#uri)URI
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
         * @summary Creates a Havenask instance.
         *
         * @description ### [](#)Method
         * `POST`
         * ### [](#uri)URI
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
         * @summary Creates a public endpoint.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePublicUrlResponse
         */
        public CreatePublicUrlResponse CreatePublicUrlWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePublicUrl",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePublicUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a public endpoint.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePublicUrlResponse
         */
        public async Task<CreatePublicUrlResponse> CreatePublicUrlWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePublicUrl",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePublicUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a public endpoint.
         *
         * @return CreatePublicUrlResponse
         */
        public CreatePublicUrlResponse CreatePublicUrl(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePublicUrlWithOptions(instanceId, headers, runtime);
        }

        /**
         * @summary Creates a public endpoint.
         *
         * @return CreatePublicUrlResponse
         */
        public async Task<CreatePublicUrlResponse> CreatePublicUrlAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePublicUrlWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @param request CreateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlInstanceResponse
         */
        public CreateSqlInstanceResponse CreateSqlInstanceWithOptions(string instanceId, string database, CreateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlInstanceResponse
         */
        public async Task<CreateSqlInstanceResponse> CreateSqlInstanceWithOptionsAsync(string instanceId, string database, CreateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateSqlInstanceRequest
         * @return CreateSqlInstanceResponse
         */
        public CreateSqlInstanceResponse CreateSqlInstance(string instanceId, string database, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSqlInstanceWithOptions(instanceId, database, request, headers, runtime);
        }

        /**
         * @param request CreateSqlInstanceRequest
         * @return CreateSqlInstanceResponse
         */
        public async Task<CreateSqlInstanceResponse> CreateSqlInstanceAsync(string instanceId, string database, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSqlInstanceWithOptionsAsync(instanceId, database, request, headers, runtime);
        }

        /**
         * @summary Creates an index table.
         *
         * @param request CreateTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableResponse
         */
        public CreateTableResponse CreateTableWithOptions(string instanceId, CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessConfig))
            {
                body["dataProcessConfig"] = request.DataProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessorCount))
            {
                body["dataProcessorCount"] = request.DataProcessorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldSchema))
            {
                body["fieldSchema"] = request.FieldSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCount))
            {
                body["partitionCount"] = request.PartitionCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawSchema))
            {
                body["rawSchema"] = request.RawSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorIndex))
            {
                body["vectorIndex"] = request.VectorIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an index table.
         *
         * @param request CreateTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableResponse
         */
        public async Task<CreateTableResponse> CreateTableWithOptionsAsync(string instanceId, CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessConfig))
            {
                body["dataProcessConfig"] = request.DataProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessorCount))
            {
                body["dataProcessorCount"] = request.DataProcessorCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldSchema))
            {
                body["fieldSchema"] = request.FieldSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCount))
            {
                body["partitionCount"] = request.PartitionCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawSchema))
            {
                body["rawSchema"] = request.RawSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorIndex))
            {
                body["vectorIndex"] = request.VectorIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an index table.
         *
         * @param request CreateTableRequest
         * @return CreateTableResponse
         */
        public CreateTableResponse CreateTable(string instanceId, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Creates an index table.
         *
         * @param request CreateTableRequest
         * @return CreateTableResponse
         */
        public async Task<CreateTableResponse> CreateTableAsync(string instanceId, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Deletes the details about advanced configurations.
         *
         * @description ## Method
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
         * @summary Deletes the details about advanced configurations.
         *
         * @description ## Method
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
         * @summary Deletes the details about advanced configurations.
         *
         * @description ## Method
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
         * @summary Deletes the details about advanced configurations.
         *
         * @description ## Method
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAliasWithOptions(string instanceId, string alias, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(alias),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(string instanceId, string alias, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(alias),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAlias(string instanceId, string alias)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAliasWithOptions(instanceId, alias, headers, runtime);
        }

        /**
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasAsync(string instanceId, string alias)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAliasWithOptionsAsync(instanceId, alias, headers, runtime);
        }

        /**
         * @param request DeleteConfigDirRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigDirResponse
         */
        public DeleteConfigDirResponse DeleteConfigDirWithOptions(string instanceId, string configName, DeleteConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                query["dirName"] = request.DirName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                query["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigDirResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigDirRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigDirResponse
         */
        public async Task<DeleteConfigDirResponse> DeleteConfigDirWithOptionsAsync(string instanceId, string configName, DeleteConfigDirRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirName))
            {
                query["dirName"] = request.DirName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                query["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigDir",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/dir",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigDirResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigDirRequest
         * @return DeleteConfigDirResponse
         */
        public DeleteConfigDirResponse DeleteConfigDir(string instanceId, string configName, DeleteConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request DeleteConfigDirRequest
         * @return DeleteConfigDirResponse
         */
        public async Task<DeleteConfigDirResponse> DeleteConfigDirAsync(string instanceId, string configName, DeleteConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request DeleteConfigFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigFileResponse
         */
        public DeleteConfigFileResponse DeleteConfigFileWithOptions(string instanceId, string configName, DeleteConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                query["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigFileRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigFileResponse
         */
        public async Task<DeleteConfigFileResponse> DeleteConfigFileWithOptionsAsync(string instanceId, string configName, DeleteConfigFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFullPath))
            {
                query["parentFullPath"] = request.ParentFullPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigFile",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName) + "/file",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigFileRequest
         * @return DeleteConfigFileResponse
         */
        public DeleteConfigFileResponse DeleteConfigFile(string instanceId, string configName, DeleteConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request DeleteConfigFileRequest
         * @return DeleteConfigFileResponse
         */
        public async Task<DeleteConfigFileResponse> DeleteConfigFileAsync(string instanceId, string configName, DeleteConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
         * @summary Deletes a specified data source.
         *
         * @description ## Method
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
         * @summary Deletes a specified data source.
         *
         * @description ## Method
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
         * @summary Deletes a specified data source.
         *
         * @description ## Method
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
         * @summary Deletes a specified data source.
         *
         * @description ## Method
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolderWithOptions(string instanceId, string database, string folderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderWithOptionsAsync(string instanceId, string database, string folderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DeleteFolderResponse
         */
        public DeleteFolderResponse DeleteFolder(string instanceId, string database, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFolderWithOptions(instanceId, database, folderId, headers, runtime);
        }

        /**
         * @return DeleteFolderResponse
         */
        public async Task<DeleteFolderResponse> DeleteFolderAsync(string instanceId, string database, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFolderWithOptionsAsync(instanceId, database, folderId, headers, runtime);
        }

        /**
         * @summary Deletes an index.
         *
         * @description ## Method
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
         * @summary Deletes an index.
         *
         * @description ## Method
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
         * @summary Deletes an index.
         *
         * @description ## Method
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
         * @summary Deletes an index.
         *
         * @description ## Method
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
         * @summary Deletes the version of an index.
         *
         * @description ## Method
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
         * @summary Deletes the version of an index.
         *
         * @description ## Method
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
         * @summary Deletes the version of an index.
         *
         * @description ## Method
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
         * @summary Deletes the version of an index.
         *
         * @description ## Method
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
         * @summary Deletes a specified instance.
         *
         * @description ### Method
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
         * @summary Deletes a specified instance.
         *
         * @description ### Method
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
         * @summary Deletes a specified instance.
         *
         * @description ### Method
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
         * @summary Deletes a specified instance.
         *
         * @description ### Method
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
         * @summary 删除公网域名
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePublicUrlResponse
         */
        public DeletePublicUrlResponse DeletePublicUrlWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePublicUrl",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePublicUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除公网域名
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePublicUrlResponse
         */
        public async Task<DeletePublicUrlResponse> DeletePublicUrlWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePublicUrl",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePublicUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除公网域名
         *
         * @return DeletePublicUrlResponse
         */
        public DeletePublicUrlResponse DeletePublicUrl(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePublicUrlWithOptions(instanceId, headers, runtime);
        }

        /**
         * @summary 删除公网域名
         *
         * @return DeletePublicUrlResponse
         */
        public async Task<DeletePublicUrlResponse> DeletePublicUrlAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePublicUrlWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSqlInstanceResponse
         */
        public DeleteSqlInstanceResponse DeleteSqlInstanceWithOptions(string instanceId, string database, string sqlInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSqlInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSqlInstanceResponse
         */
        public async Task<DeleteSqlInstanceResponse> DeleteSqlInstanceWithOptionsAsync(string instanceId, string database, string sqlInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSqlInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DeleteSqlInstanceResponse
         */
        public DeleteSqlInstanceResponse DeleteSqlInstance(string instanceId, string database, string sqlInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSqlInstanceWithOptions(instanceId, database, sqlInstanceId, headers, runtime);
        }

        /**
         * @return DeleteSqlInstanceResponse
         */
        public async Task<DeleteSqlInstanceResponse> DeleteSqlInstanceAsync(string instanceId, string database, string sqlInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, headers, runtime);
        }

        /**
         * @summary Deletes an index table.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableResponse
         */
        public DeleteTableResponse DeleteTableWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an index table.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableResponse
         */
        public async Task<DeleteTableResponse> DeleteTableWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an index table.
         *
         * @return DeleteTableResponse
         */
        public DeleteTableResponse DeleteTable(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableWithOptions(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Deletes an index table.
         *
         * @return DeleteTableResponse
         */
        public async Task<DeleteTableResponse> DeleteTableAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @param request DescribeRegionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries available regions.
         *
         * @param request DescribeRegionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries available regions.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request ExecuteSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteSqlInstanceResponse
         */
        public ExecuteSqlInstanceResponse ExecuteSqlInstanceWithOptions(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CombineParam))
            {
                body["combineParam"] = request.CombineParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicParam))
            {
                body["dynamicParam"] = request.DynamicParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kvpair))
            {
                body["kvpair"] = request.Kvpair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaticParam))
            {
                body["staticParam"] = request.StaticParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/actions/execution",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ExecuteSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteSqlInstanceResponse
         */
        public async Task<ExecuteSqlInstanceResponse> ExecuteSqlInstanceWithOptionsAsync(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CombineParam))
            {
                body["combineParam"] = request.CombineParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicParam))
            {
                body["dynamicParam"] = request.DynamicParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kvpair))
            {
                body["kvpair"] = request.Kvpair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaticParam))
            {
                body["staticParam"] = request.StaticParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/actions/execution",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSqlInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ExecuteSqlInstanceRequest
         * @return ExecuteSqlInstanceResponse
         */
        public ExecuteSqlInstanceResponse ExecuteSqlInstance(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request ExecuteSqlInstanceRequest
         * @return ExecuteSqlInstanceResponse
         */
        public async Task<ExecuteSqlInstanceResponse> ExecuteSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @summary Performs a forced switchover.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Performs a forced switchover.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Performs a forced switchover.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Performs a forced switchover.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Queries the information about an advanced configuration.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration file.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration file.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration file.
         *
         * @description ## Method
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
         * @summary Queries the information about an advanced configuration file.
         *
         * @description ## Method
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
         * @summary Queries the details of a cluster.
         *
         * @description ### Method
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
         * @summary Queries the details of a cluster.
         *
         * @description ### Method
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
         * @summary Queries the details of a cluster.
         *
         * @description ### Method
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
         * @summary Queries the details of a cluster.
         *
         * @description ### Method
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
         * @summary Queries the runtime information about a specified cluster.
         *
         * @description ### Method
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
         * @summary Queries the runtime information about a specified cluster.
         *
         * @description ### Method
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
         * @summary Queries the runtime information about a specified cluster.
         *
         * @description ### Method
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
         * @summary Queries the runtime information about a specified cluster.
         *
         * @description ### Method
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
         * @summary Obtains a data source.
         *
         * @description ### Method
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
         * @summary Obtains a data source.
         *
         * @description ### Method
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
         * @summary Obtains a data source.
         *
         * @description ### Method
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
         * @summary Obtains a data source.
         *
         * @description ### Method
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

        /**
         * @summary 获取数据源部署信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataSourceDeployResponse
         */
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

        /**
         * @summary 获取数据源部署信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataSourceDeployResponse
         */
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

        /**
         * @summary 获取数据源部署信息
         *
         * @return GetDataSourceDeployResponse
         */
        public GetDataSourceDeployResponse GetDataSourceDeploy(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSourceDeployWithOptions(instanceId, deployName, dataSourceName, headers, runtime);
        }

        /**
         * @summary 获取数据源部署信息
         *
         * @return GetDataSourceDeployResponse
         */
        public async Task<GetDataSourceDeployResponse> GetDataSourceDeployAsync(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSourceDeployWithOptionsAsync(instanceId, deployName, dataSourceName, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabaseSchemaResponse
         */
        public GetDatabaseSchemaResponse GetDatabaseSchemaWithOptions(string instanceId, string database, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabaseSchema",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseSchemaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabaseSchemaResponse
         */
        public async Task<GetDatabaseSchemaResponse> GetDatabaseSchemaWithOptionsAsync(string instanceId, string database, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabaseSchema",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetDatabaseSchemaResponse
         */
        public GetDatabaseSchemaResponse GetDatabaseSchema(string instanceId, string database, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatabaseSchemaWithOptions(instanceId, database, tableName, headers, runtime);
        }

        /**
         * @return GetDatabaseSchemaResponse
         */
        public async Task<GetDatabaseSchemaResponse> GetDatabaseSchemaAsync(string instanceId, string database, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatabaseSchemaWithOptionsAsync(instanceId, database, tableName, headers, runtime);
        }

        /**
         * @summary Displays the overview of the deployment.
         *
         * @description ## Method
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
         * @summary Displays the overview of the deployment.
         *
         * @description ## Method
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
         * @summary Displays the overview of the deployment.
         *
         * @description ## Method
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
         * @summary Displays the overview of the deployment.
         *
         * @description ## Method
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
         * @summary Queries the details of an index table version.
         *
         * @description ## Method
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
         * @summary Queries the details of an index table version.
         *
         * @description ## Method
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
         * @summary Queries the details of an index table version.
         *
         * @description ## Method
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
         * @summary Queries the details of an index table version.
         *
         * @description ## Method
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

        /**
         * @summary Queries the information about an index version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexResponse
         */
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

        /**
         * @summary Queries the information about an index version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexResponse
         */
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

        /**
         * @summary Queries the information about an index version.
         *
         * @return GetIndexResponse
         */
        public GetIndexResponse GetIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /**
         * @summary Queries the information about an index version.
         *
         * @return GetIndexResponse
         */
        public async Task<GetIndexResponse> GetIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /**
         * @summary Queries the online effective policy of an index.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexOnlineStrategyResponse
         */
        public GetIndexOnlineStrategyResponse GetIndexOnlineStrategyWithOptions(string instanceId, string dataSourceName, string deployName, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexOnlineStrategy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/online-strategy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexOnlineStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the online effective policy of an index.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIndexOnlineStrategyResponse
         */
        public async Task<GetIndexOnlineStrategyResponse> GetIndexOnlineStrategyWithOptionsAsync(string instanceId, string dataSourceName, string deployName, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndexOnlineStrategy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/online-strategy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexOnlineStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the online effective policy of an index.
         *
         * @return GetIndexOnlineStrategyResponse
         */
        public GetIndexOnlineStrategyResponse GetIndexOnlineStrategy(string instanceId, string dataSourceName, string deployName, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexOnlineStrategyWithOptions(instanceId, dataSourceName, deployName, indexName, headers, runtime);
        }

        /**
         * @summary Queries the online effective policy of an index.
         *
         * @return GetIndexOnlineStrategyResponse
         */
        public async Task<GetIndexOnlineStrategyResponse> GetIndexOnlineStrategyAsync(string instanceId, string dataSourceName, string deployName, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexOnlineStrategyWithOptionsAsync(instanceId, dataSourceName, deployName, indexName, headers, runtime);
        }

        /**
         * @summary Queries the information about index versions that the current index version can be rolled back to.
         *
         * @description ## Method
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
         * @summary Queries the information about index versions that the current index version can be rolled back to.
         *
         * @description ## Method
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
         * @summary Queries the information about index versions that the current index version can be rolled back to.
         *
         * @description ## Method
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
         * @summary Queries the information about index versions that the current index version can be rolled back to.
         *
         * @description ## Method
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
         * @summary Queries the details of an instance based on the instance ID.
         *
         * @description ### Method
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
         * @summary Queries the details of an instance based on the instance ID.
         *
         * @description ### Method
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
         * @summary Queries the details of an instance based on the instance ID.
         *
         * @description ### Method
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
         * @summary Queries the details of an instance based on the instance ID.
         *
         * @description ### Method
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

        /**
         * @summary Gets the configuration information of a node.
         *
         * @param request GetNodeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeConfigResponse
         */
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

        /**
         * @summary Gets the configuration information of a node.
         *
         * @param request GetNodeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeConfigResponse
         */
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

        /**
         * @summary Gets the configuration information of a node.
         *
         * @param request GetNodeConfigRequest
         * @return GetNodeConfigResponse
         */
        public GetNodeConfigResponse GetNodeConfig(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeConfigWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Gets the configuration information of a node.
         *
         * @param request GetNodeConfigRequest
         * @return GetNodeConfigResponse
         */
        public async Task<GetNodeConfigResponse> GetNodeConfigAsync(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @param request GetSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSqlInstanceResponse
         */
        public GetSqlInstanceResponse GetSqlInstanceWithOptions(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSqlInstanceResponse
         */
        public async Task<GetSqlInstanceResponse> GetSqlInstanceWithOptionsAsync(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSqlInstance",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetSqlInstanceRequest
         * @return GetSqlInstanceResponse
         */
        public GetSqlInstanceResponse GetSqlInstance(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request GetSqlInstanceRequest
         * @return GetSqlInstanceResponse
         */
        public async Task<GetSqlInstanceResponse> GetSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @summary Queries the information about an index table.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableResponse
         */
        public GetTableResponse GetTableWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an index table.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableResponse
         */
        public async Task<GetTableResponse> GetTableWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an index table.
         *
         * @return GetTableResponse
         */
        public GetTableResponse GetTable(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableWithOptions(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Queries the information about an index table.
         *
         * @return GetTableResponse
         */
        public async Task<GetTableResponse> GetTableAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Queries the status of an index version based on the ID of the full index version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableGenerationResponse
         */
        public GetTableGenerationResponse GetTableGenerationWithOptions(string instanceId, string tableName, string generationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableGeneration",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/index_versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableGenerationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of an index version based on the ID of the full index version.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableGenerationResponse
         */
        public async Task<GetTableGenerationResponse> GetTableGenerationWithOptionsAsync(string instanceId, string tableName, string generationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableGeneration",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/index_versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of an index version based on the ID of the full index version.
         *
         * @return GetTableGenerationResponse
         */
        public GetTableGenerationResponse GetTableGeneration(string instanceId, string tableName, string generationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableGenerationWithOptions(instanceId, tableName, generationId, headers, runtime);
        }

        /**
         * @summary Queries the status of an index version based on the ID of the full index version.
         *
         * @return GetTableGenerationResponse
         */
        public async Task<GetTableGenerationResponse> GetTableGenerationAsync(string instanceId, string tableName, string generationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableGenerationWithOptionsAsync(instanceId, tableName, generationId, headers, runtime);
        }

        /**
         * @summary Queries the files in an advanced configuration directory.
         *
         * @description ## Method
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
         * @summary Queries the files in an advanced configuration directory.
         *
         * @description ## Method
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
         * @summary Queries the files in an advanced configuration directory.
         *
         * @description ## Method
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
         * @summary Queries the files in an advanced configuration directory.
         *
         * @description ## Method
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
         * @summary Obtains a list of advanced configurations.
         *
         * @description ## Sample requests
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
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
         * @summary Obtains a list of advanced configurations.
         *
         * @description ## Sample requests
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
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
         * @summary Obtains a list of advanced configurations.
         *
         * @description ## Sample requests
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
         * @summary Obtains a list of advanced configurations.
         *
         * @description ## Sample requests
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliasesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliases(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAliasesWithOptions(instanceId, headers, runtime);
        }

        /**
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAliasesWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @summary Queries cluster names.
         *
         * @description ### Method
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
         * @summary Queries cluster names.
         *
         * @description ### Method
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
         * @summary Queries cluster names.
         *
         * @description ### Method
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
         * @summary Queries cluster names.
         *
         * @description ### Method
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
         * @summary Queries cluster tasks.
         *
         * @description ### Method
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
         * @summary Queries cluster tasks.
         *
         * @description ### Method
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
         * @summary Queries cluster tasks.
         *
         * @description ### Method
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
         * @summary Queries cluster tasks.
         *
         * @description ### Method
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
         * @summary Queries clusters.
         *
         * @description ### Method
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
         * @summary Queries clusters.
         *
         * @description ### Method
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
         * @summary Queries clusters.
         *
         * @description ### Method
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
         * @summary Queries clusters.
         *
         * @description ### Method
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
         * @summary Queries the schema information about a data source.
         *
         * @description ## Method
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
         * @summary Queries the schema information about a data source.
         *
         * @description ## Method
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
         * @summary Queries the schema information about a data source.
         *
         * @description ## Method
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
         * @summary Queries the schema information about a data source.
         *
         * @description ## Method
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
         * @summary Displays data source tasks.
         *
         * @description ### [](#)Method
         * ```java
         * GET
         * ```
         * ### [](#uri)URI
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
         * @summary Displays data source tasks.
         *
         * @description ### [](#)Method
         * ```java
         * GET
         * ```
         * ### [](#uri)URI
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
         * @summary Displays data source tasks.
         *
         * @description ### [](#)Method
         * ```java
         * GET
         * ```
         * ### [](#uri)URI
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
         * @summary Displays data source tasks.
         *
         * @description ### [](#)Method
         * ```java
         * GET
         * ```
         * ### [](#uri)URI
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
         * @summary Obtains the list of data sources.
         *
         * @description ## Method
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
         * @summary Obtains the list of data sources.
         *
         * @description ## Method
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
         * @summary Obtains the list of data sources.
         *
         * @description ## Method
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
         * @summary Obtains the list of data sources.
         *
         * @description ## Method
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatabasesResponse
         */
        public ListDatabasesResponse ListDatabasesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatabasesResponse
         */
        public async Task<ListDatabasesResponse> ListDatabasesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ListDatabasesResponse
         */
        public ListDatabasesResponse ListDatabases(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatabasesWithOptions(instanceId, headers, runtime);
        }

        /**
         * @return ListDatabasesResponse
         */
        public async Task<ListDatabasesResponse> ListDatabasesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatabasesWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @summary Queries the historical index versions of a data source.
         *
         * @description ### Method
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
         * @summary Queries the historical index versions of a data source.
         *
         * @description ### Method
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
         * @summary Queries the historical index versions of a data source.
         *
         * @description ### Method
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
         * @summary Queries the historical index versions of a data source.
         *
         * @description ### Method
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndexRecoverRecordsResponse
         */
        public ListIndexRecoverRecordsResponse ListIndexRecoverRecordsWithOptions(string indexName, string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexRecoverRecords",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/actions/list-recover-records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexRecoverRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndexRecoverRecordsResponse
         */
        public async Task<ListIndexRecoverRecordsResponse> ListIndexRecoverRecordsWithOptionsAsync(string indexName, string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexRecoverRecords",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/actions/list-recover-records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexRecoverRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ListIndexRecoverRecordsResponse
         */
        public ListIndexRecoverRecordsResponse ListIndexRecoverRecords(string indexName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexRecoverRecordsWithOptions(indexName, instanceId, headers, runtime);
        }

        /**
         * @return ListIndexRecoverRecordsResponse
         */
        public async Task<ListIndexRecoverRecordsResponse> ListIndexRecoverRecordsAsync(string indexName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexRecoverRecordsWithOptionsAsync(indexName, instanceId, headers, runtime);
        }

        /**
         * @summary Obtains the index list.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
         * @summary Obtains the index list.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMode))
            {
                query["newMode"] = request.NewMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
         * @summary Obtains the index list.
         *
         * @description ## Method
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
         * @summary Obtains the index list.
         *
         * @description ## Method
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
         * @summary Queries the specifications of an instance.
         *
         * @description ### Method
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
         * @summary Queries the specifications of an instance.
         *
         * @description ### Method
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
         * @summary Queries the specifications of an instance.
         *
         * @description ### Method
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
         * @summary Queries the specifications of an instance.
         *
         * @description ### Method
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
         * @summary Queries a list of instances.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
         * `/openapi/ha3/instances`
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                query["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
         * @summary Queries a list of instances.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
         * `/openapi/ha3/instances`
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Catalog))
            {
                query["catalog"] = request.Catalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                query["dataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
         * @summary Queries a list of instances.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
         * `/openapi/ha3/instances`
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
         * @summary Queries a list of instances.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
         * `/openapi/ha3/instances`
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
         * @param request ListLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogsResponse
         */
        public ListLogsResponse ListLogsWithOptions(string instanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "ListLogs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogsResponse
         */
        public async Task<ListLogsResponse> ListLogsWithOptionsAsync(string instanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "ListLogs",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListLogsRequest
         * @return ListLogsResponse
         */
        public ListLogsResponse ListLogs(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogsWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request ListLogsRequest
         * @return ListLogsResponse
         */
        public async Task<ListLogsResponse> ListLogsAsync(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries the details of an online configuration.
         *
         * @description ### Method
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
         * @summary Queries the details of an online configuration.
         *
         * @description ### Method
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
         * @summary Queries the details of an online configuration.
         *
         * @description ### Method
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
         * @summary Queries the details of an online configuration.
         *
         * @description ### Method
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
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPausePolicysResponse
         */
        public ListPausePolicysResponse ListPausePolicysWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPausePolicys",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/pause-policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPausePolicysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPausePolicysResponse
         */
        public async Task<ListPausePolicysResponse> ListPausePolicysWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPausePolicys",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/pause-policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPausePolicysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ListPausePolicysResponse
         */
        public ListPausePolicysResponse ListPausePolicys(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPausePolicysWithOptions(instanceId, headers, runtime);
        }

        /**
         * @return ListPausePolicysResponse
         */
        public async Task<ListPausePolicysResponse> ListPausePolicysAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPausePolicysWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @param request ListPostQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPostQueryResultResponse
         */
        public ListPostQueryResultResponse ListPostQueryResultWithOptions(string instanceId, ListPostQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListPostQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPostQueryResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListPostQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPostQueryResultResponse
         */
        public async Task<ListPostQueryResultResponse> ListPostQueryResultWithOptionsAsync(string instanceId, ListPostQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
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
                Action = "ListPostQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPostQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListPostQueryResultRequest
         * @return ListPostQueryResultResponse
         */
        public ListPostQueryResultResponse ListPostQueryResult(string instanceId, ListPostQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPostQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request ListPostQueryResultRequest
         * @return ListPostQueryResultResponse
         */
        public async Task<ListPostQueryResultResponse> ListPostQueryResultAsync(string instanceId, ListPostQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPostQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries the query result.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
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
         * @summary Queries the query result.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
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
         * @summary Queries the query result.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
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
         * @summary Queries the query result.
         *
         * @description ### [](#)Method
         * `GET`
         * ### [](#uri)URI
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
         * @param request ListRestQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRestQueryResultResponse
         */
        public ListRestQueryResultResponse ListRestQueryResultWithOptions(string instanceId, ListRestQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                body["indexName"] = request.IndexName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRestQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rest-query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRestQueryResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListRestQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRestQueryResultResponse
         */
        public async Task<ListRestQueryResultResponse> ListRestQueryResultWithOptionsAsync(string instanceId, ListRestQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexName))
            {
                body["indexName"] = request.IndexName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRestQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rest-query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRestQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListRestQueryResultRequest
         * @return ListRestQueryResultResponse
         */
        public ListRestQueryResultResponse ListRestQueryResult(string instanceId, ListRestQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRestQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request ListRestQueryResultRequest
         * @return ListRestQueryResultResponse
         */
        public async Task<ListRestQueryResultResponse> ListRestQueryResultAsync(string instanceId, ListRestQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRestQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 通过数据源配置获取schema信息
         *
         * @param request ListSchemasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchemasResponse
         */
        public ListSchemasResponse ListSchemasWithOptions(string instanceId, ListSchemasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessSecret))
            {
                query["accessSecret"] = request.AccessSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
                Action = "ListSchemas",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchemasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过数据源配置获取schema信息
         *
         * @param request ListSchemasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchemasResponse
         */
        public async Task<ListSchemasResponse> ListSchemasWithOptionsAsync(string instanceId, ListSchemasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessSecret))
            {
                query["accessSecret"] = request.AccessSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
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
                Action = "ListSchemas",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/schemas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过数据源配置获取schema信息
         *
         * @param request ListSchemasRequest
         * @return ListSchemasResponse
         */
        public ListSchemasResponse ListSchemas(string instanceId, ListSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSchemasWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 通过数据源配置获取schema信息
         *
         * @param request ListSchemasRequest
         * @return ListSchemasResponse
         */
        public async Task<ListSchemasResponse> ListSchemasAsync(string instanceId, ListSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSchemasWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of index versions.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableGenerationsResponse
         */
        public ListTableGenerationsResponse ListTableGenerationsWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableGenerations",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/index_versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableGenerationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of index versions.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableGenerationsResponse
         */
        public async Task<ListTableGenerationsResponse> ListTableGenerationsWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableGenerations",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/index_versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableGenerationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of index versions.
         *
         * @return ListTableGenerationsResponse
         */
        public ListTableGenerationsResponse ListTableGenerations(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableGenerationsWithOptions(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Queries a list of index versions.
         *
         * @return ListTableGenerationsResponse
         */
        public async Task<ListTableGenerationsResponse> ListTableGenerationsAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableGenerationsWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /**
         * @summary Queries a list of index tables.
         *
         * @param request ListTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTablesResponse
         */
        public ListTablesResponse ListTablesWithOptions(string instanceId, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTables",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of index tables.
         *
         * @param request ListTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTablesResponse
         */
        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(string instanceId, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTables",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of index tables.
         *
         * @param request ListTablesRequest
         * @return ListTablesResponse
         */
        public ListTablesResponse ListTables(string instanceId, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of index tables.
         *
         * @param request ListTablesRequest
         * @return ListTablesResponse
         */
        public async Task<ListTablesResponse> ListTablesAsync(string instanceId, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 查标签接口
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查标签接口
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查标签接口
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查标签接口
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取集群任务列表（数据源+集群）
         *
         * @param request ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasksWithOptions(string instanceId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群任务列表（数据源+集群）
         *
         * @param request ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(string instanceId, ListTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群任务列表（数据源+集群）
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasks(string instanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 获取集群任务列表（数据源+集群）
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksAsync(string instanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @param request ListVectorQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVectorQueryResultResponse
         */
        public ListVectorQueryResultResponse ListVectorQueryResultWithOptions(string instanceId, ListVectorQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorQueryType))
            {
                query["vectorQueryType"] = request.VectorQueryType;
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
                Action = "ListVectorQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/vector-query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVectorQueryResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListVectorQueryResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVectorQueryResultResponse
         */
        public async Task<ListVectorQueryResultResponse> ListVectorQueryResultWithOptionsAsync(string instanceId, ListVectorQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorQueryType))
            {
                query["vectorQueryType"] = request.VectorQueryType;
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
                Action = "ListVectorQueryResult",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/vector-query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVectorQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListVectorQueryResultRequest
         * @return ListVectorQueryResultResponse
         */
        public ListVectorQueryResultResponse ListVectorQueryResult(string instanceId, ListVectorQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVectorQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request ListVectorQueryResultRequest
         * @return ListVectorQueryResultResponse
         */
        public async Task<ListVectorQueryResultResponse> ListVectorQueryResultAsync(string instanceId, ListVectorQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVectorQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @param request ModifyAdvanceConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAdvanceConfigResponse
         */
        public ModifyAdvanceConfigResponse ModifyAdvanceConfigWithOptions(string instanceId, string configName, ModifyAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["updateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAdvanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyAdvanceConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAdvanceConfigResponse
         */
        public async Task<ModifyAdvanceConfigResponse> ModifyAdvanceConfigWithOptionsAsync(string instanceId, string configName, ModifyAdvanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                body["updateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAdvanceConfig",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/advanced-configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAdvanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyAdvanceConfigRequest
         * @return ModifyAdvanceConfigResponse
         */
        public ModifyAdvanceConfigResponse ModifyAdvanceConfig(string instanceId, string configName, ModifyAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /**
         * @param request ModifyAdvanceConfigRequest
         * @return ModifyAdvanceConfigResponse
         */
        public async Task<ModifyAdvanceConfigResponse> ModifyAdvanceConfigAsync(string instanceId, string configName, ModifyAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /**
         * @summary Modifies the advanced configurations.
         *
         * @description ## Method
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
         * @summary Modifies the advanced configurations.
         *
         * @description ## Method
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
         * @summary Modifies the advanced configurations.
         *
         * @description ## Method
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
         * @summary Modifies the advanced configurations.
         *
         * @description ## Method
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
         * @param request ModifyAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAliasResponse
         */
        public ModifyAliasResponse ModifyAliasWithOptions(string instanceId, string alias, ModifyAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(alias),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyAliasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAliasResponse
         */
        public async Task<ModifyAliasResponse> ModifyAliasWithOptionsAsync(string instanceId, string alias, ModifyAliasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["index"] = request.Index;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAlias",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/aliases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(alias),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyAliasRequest
         * @return ModifyAliasResponse
         */
        public ModifyAliasResponse ModifyAlias(string instanceId, string alias, ModifyAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAliasWithOptions(instanceId, alias, request, headers, runtime);
        }

        /**
         * @param request ModifyAliasRequest
         * @return ModifyAliasResponse
         */
        public async Task<ModifyAliasResponse> ModifyAliasAsync(string instanceId, string alias, ModifyAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAliasWithOptionsAsync(instanceId, alias, request, headers, runtime);
        }

        /**
         * @summary Modifies the description of a specified cluster.
         *
         * @description ### [](#)Method
         * `PUT`
         * ### [](#uri)URI
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
         * @summary Modifies the description of a specified cluster.
         *
         * @description ### [](#)Method
         * `PUT`
         * ### [](#uri)URI
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
         * @summary Modifies the description of a specified cluster.
         *
         * @description ### [](#)Method
         * `PUT`
         * ### [](#uri)URI
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
         * @summary Modifies the description of a specified cluster.
         *
         * @description ### [](#)Method
         * `PUT`
         * ### [](#uri)URI
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
         * @summary Modifies the configuration information of a cluster.
         *
         * @description ## Request syntax
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
         * @summary Modifies the configuration information of a cluster.
         *
         * @description ## Request syntax
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
         * @summary Modifies the configuration information of a cluster.
         *
         * @description ## Request syntax
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
         * @summary Modifies the configuration information of a cluster.
         *
         * @description ## Request syntax
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
         * @summary Modifies the online configuration of a cluster.
         *
         * @description ### Method
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
         * @summary Modifies the online configuration of a cluster.
         *
         * @description ### Method
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
         * @summary Modifies the online configuration of a cluster.
         *
         * @description ### Method
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
         * @summary Modifies the online configuration of a cluster.
         *
         * @description ### Method
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
         * @summary 修改数据源部署信息
         *
         * @param request ModifyDataSourceDeployRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataSourceDeployResponse
         */
        public ModifyDataSourceDeployResponse ModifyDataSourceDeployWithOptions(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationId))
            {
                query["generationId"] = request.GenerationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuildIndex))
            {
                body["autoBuildIndex"] = request.AutoBuildIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processor))
            {
                body["processor"] = request.Processor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                body["storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Swift))
            {
                body["swift"] = request.Swift;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceDeploy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceDeployResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改数据源部署信息
         *
         * @param request ModifyDataSourceDeployRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataSourceDeployResponse
         */
        public async Task<ModifyDataSourceDeployResponse> ModifyDataSourceDeployWithOptionsAsync(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerationId))
            {
                query["generationId"] = request.GenerationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuildIndex))
            {
                body["autoBuildIndex"] = request.AutoBuildIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processor))
            {
                body["processor"] = request.Processor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                body["storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Swift))
            {
                body["swift"] = request.Swift;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceDeploy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceDeployResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改数据源部署信息
         *
         * @param request ModifyDataSourceDeployRequest
         * @return ModifyDataSourceDeployResponse
         */
        public ModifyDataSourceDeployResponse ModifyDataSourceDeploy(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDataSourceDeployWithOptions(instanceId, deployName, dataSourceName, request, headers, runtime);
        }

        /**
         * @summary 修改数据源部署信息
         *
         * @param request ModifyDataSourceDeployRequest
         * @return ModifyDataSourceDeployResponse
         */
        public async Task<ModifyDataSourceDeployResponse> ModifyDataSourceDeployAsync(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDataSourceDeployWithOptionsAsync(instanceId, deployName, dataSourceName, request, headers, runtime);
        }

        /**
         * @summary Modifies a file.
         *
         * @description ## Method
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
         * @summary Modifies a file.
         *
         * @description ## Method
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
         * @summary Modifies a file.
         *
         * @description ## Method
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
         * @summary Modifies a file.
         *
         * @description ## Method
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
         * @param request ModifyIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIndexResponse
         */
        public ModifyIndexResponse ModifyIndexWithOptions(string instanceId, string indexName, ModifyIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParallelNum))
            {
                body["buildParallelNum"] = request.BuildParallelNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                body["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfigName))
            {
                body["clusterConfigName"] = request.ClusterConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeParallelNum))
            {
                body["mergeParallelNum"] = request.MergeParallelNum;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyIndexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIndexResponse
         */
        public async Task<ModifyIndexResponse> ModifyIndexWithOptionsAsync(string instanceId, string indexName, ModifyIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParallelNum))
            {
                body["buildParallelNum"] = request.BuildParallelNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                body["cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfigName))
            {
                body["clusterConfigName"] = request.ClusterConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeParallelNum))
            {
                body["mergeParallelNum"] = request.MergeParallelNum;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyIndexRequest
         * @return ModifyIndexResponse
         */
        public ModifyIndexResponse ModifyIndex(string instanceId, string indexName, ModifyIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /**
         * @param request ModifyIndexRequest
         * @return ModifyIndexResponse
         */
        public async Task<ModifyIndexResponse> ModifyIndexAsync(string instanceId, string indexName, ModifyIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /**
         * @summary Modifies the online policy of an index.
         *
         * @param request ModifyIndexOnlineStrategyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIndexOnlineStrategyResponse
         */
        public ModifyIndexOnlineStrategyResponse ModifyIndexOnlineStrategyWithOptions(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRate))
            {
                body["changeRate"] = request.ChangeRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexOnlineStrategy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/online-strategy",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexOnlineStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the online policy of an index.
         *
         * @param request ModifyIndexOnlineStrategyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIndexOnlineStrategyResponse
         */
        public async Task<ModifyIndexOnlineStrategyResponse> ModifyIndexOnlineStrategyWithOptionsAsync(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRate))
            {
                body["changeRate"] = request.ChangeRate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIndexOnlineStrategy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/deploys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployName) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/online-strategy",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIndexOnlineStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the online policy of an index.
         *
         * @param request ModifyIndexOnlineStrategyRequest
         * @return ModifyIndexOnlineStrategyResponse
         */
        public ModifyIndexOnlineStrategyResponse ModifyIndexOnlineStrategy(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexOnlineStrategyWithOptions(instanceId, dataSourceName, deployName, indexName, request, headers, runtime);
        }

        /**
         * @summary Modifies the online policy of an index.
         *
         * @param request ModifyIndexOnlineStrategyRequest
         * @return ModifyIndexOnlineStrategyResponse
         */
        public async Task<ModifyIndexOnlineStrategyResponse> ModifyIndexOnlineStrategyAsync(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexOnlineStrategyWithOptionsAsync(instanceId, dataSourceName, deployName, indexName, request, headers, runtime);
        }

        /**
         * @summary Modifies the information about index partitions.
         *
         * @description ### Method
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
         * @summary Modifies the information about index partitions.
         *
         * @description ### Method
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
         * @summary Modifies the information about index partitions.
         *
         * @description ### Method
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
         * @summary Modifies the information about index partitions.
         *
         * @description ### Method
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
         * @summary Modifies the index version of a cluster (an index version rollback).
         *
         * @description ## [](#)Method
         *     PUT
         * ## [](#uri)URI
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
         * @summary Modifies the index version of a cluster (an index version rollback).
         *
         * @description ## [](#)Method
         *     PUT
         * ## [](#uri)URI
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
         * @summary Modifies the index version of a cluster (an index version rollback).
         *
         * @description ## [](#)Method
         *     PUT
         * ## [](#uri)URI
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
         * @summary Modifies the index version of a cluster (an index version rollback).
         *
         * @description ## [](#)Method
         *     PUT
         * ## [](#uri)URI
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
         * @summary Modifies the configurations of a node.
         *
         * @description ### Method
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
         * @summary Modifies the configurations of a node.
         *
         * @description ### Method
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
         * @summary Modifies the configurations of a node.
         *
         * @description ### Method
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
         * @summary Modifies the configurations of a node.
         *
         * @description ### Method
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
         * @summary Modifies online configurations.
         *
         * @description ### Method
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
         * @summary Modifies online configurations.
         *
         * @description ### Method
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
         * @summary Modifies online configurations.
         *
         * @description ### Method
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
         * @summary Modifies online configurations.
         *
         * @description ### Method
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
         * @summary 修改实例的密码
         *
         * @description ### Method
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
         * @summary 修改实例的密码
         *
         * @description ### Method
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
         * @summary 修改实例的密码
         *
         * @description ### Method
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
         * @summary 修改实例的密码
         *
         * @description ### Method
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
         * @param request ModifyPausePolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPausePolicyResponse
         */
        public ModifyPausePolicyResponse ModifyPausePolicyWithOptions(string instanceId, ModifyPausePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyPausePolicy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/pause-policies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPausePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyPausePolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPausePolicyResponse
         */
        public async Task<ModifyPausePolicyResponse> ModifyPausePolicyWithOptionsAsync(string instanceId, ModifyPausePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyPausePolicy",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/pause-policies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPausePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyPausePolicyRequest
         * @return ModifyPausePolicyResponse
         */
        public ModifyPausePolicyResponse ModifyPausePolicy(string instanceId, ModifyPausePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPausePolicyWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @param request ModifyPausePolicyRequest
         * @return ModifyPausePolicyResponse
         */
        public async Task<ModifyPausePolicyResponse> ModifyPausePolicyAsync(string instanceId, ModifyPausePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPausePolicyWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 修改公网域名访问白名单
         *
         * @param request ModifyPublicUrlIpListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPublicUrlIpListResponse
         */
        public ModifyPublicUrlIpListResponse ModifyPublicUrlIpListWithOptions(string instanceId, ModifyPublicUrlIpListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyPublicUrlIpList",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url-ip-list",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPublicUrlIpListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改公网域名访问白名单
         *
         * @param request ModifyPublicUrlIpListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPublicUrlIpListResponse
         */
        public async Task<ModifyPublicUrlIpListResponse> ModifyPublicUrlIpListWithOptionsAsync(string instanceId, ModifyPublicUrlIpListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ModifyPublicUrlIpList",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/public-url-ip-list",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPublicUrlIpListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改公网域名访问白名单
         *
         * @param request ModifyPublicUrlIpListRequest
         * @return ModifyPublicUrlIpListResponse
         */
        public ModifyPublicUrlIpListResponse ModifyPublicUrlIpList(string instanceId, ModifyPublicUrlIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPublicUrlIpListWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 修改公网域名访问白名单
         *
         * @param request ModifyPublicUrlIpListRequest
         * @return ModifyPublicUrlIpListResponse
         */
        public async Task<ModifyPublicUrlIpListResponse> ModifyPublicUrlIpListAsync(string instanceId, ModifyPublicUrlIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPublicUrlIpListWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Modifies an index table.
         *
         * @param request ModifyTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTableResponse
         */
        public ModifyTableResponse ModifyTableWithOptions(string instanceId, string tableName, ModifyTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessConfig))
            {
                body["dataProcessConfig"] = request.DataProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldSchema))
            {
                body["fieldSchema"] = request.FieldSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCount))
            {
                body["partitionCount"] = request.PartitionCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawSchema))
            {
                body["rawSchema"] = request.RawSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorIndex))
            {
                body["vectorIndex"] = request.VectorIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies an index table.
         *
         * @param request ModifyTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTableResponse
         */
        public async Task<ModifyTableResponse> ModifyTableWithOptionsAsync(string instanceId, string tableName, ModifyTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProcessConfig))
            {
                body["dataProcessConfig"] = request.DataProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                body["dataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldSchema))
            {
                body["fieldSchema"] = request.FieldSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionCount))
            {
                body["partitionCount"] = request.PartitionCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawSchema))
            {
                body["rawSchema"] = request.RawSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VectorIndex))
            {
                body["vectorIndex"] = request.VectorIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTable",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies an index table.
         *
         * @param request ModifyTableRequest
         * @return ModifyTableResponse
         */
        public ModifyTableResponse ModifyTable(string instanceId, string tableName, ModifyTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyTableWithOptions(instanceId, tableName, request, headers, runtime);
        }

        /**
         * @summary Modifies an index table.
         *
         * @param request ModifyTableRequest
         * @return ModifyTableResponse
         */
        public async Task<ModifyTableResponse> ModifyTableAsync(string instanceId, string tableName, ModifyTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyTableWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        /**
         * @summary Publishes a version of advanced configurations.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
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
         * @summary Publishes a version of advanced configurations.
         *
         * @description ## Method
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
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
         * @summary Publishes a version of advanced configurations.
         *
         * @description ## Method
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
         * @summary Publishes a version of advanced configurations.
         *
         * @description ## Method
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
         * @summary Publishes a specified index version.
         *
         * @description ## Method
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
         * @summary Publishes a specified index version.
         *
         * @description ## Method
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
         * @summary Publishes a specified index version.
         *
         * @description ## Method
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
         * @summary Publishes a specified index version.
         *
         * @description ## Method
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
         * @param request PushDocumentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDocumentsResponse
         */
        public PushDocumentsResponse PushDocumentsWithOptions(string instanceId, string dataSourceName, PushDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkField))
            {
                query["pkField"] = request.PkField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDocuments",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request PushDocumentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDocumentsResponse
         */
        public async Task<PushDocumentsResponse> PushDocumentsWithOptionsAsync(string instanceId, string dataSourceName, PushDocumentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PkField))
            {
                query["pkField"] = request.PkField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDocuments",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request PushDocumentsRequest
         * @return PushDocumentsResponse
         */
        public PushDocumentsResponse PushDocuments(string instanceId, string dataSourceName, PushDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDocumentsWithOptions(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
         * @param request PushDocumentsRequest
         * @return PushDocumentsResponse
         */
        public async Task<PushDocumentsResponse> PushDocumentsAsync(string instanceId, string dataSourceName, PushDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDocumentsWithOptionsAsync(instanceId, dataSourceName, request, headers, runtime);
        }

        /**
         * @summary Restores data from an index.
         *
         * @description ### Method
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
         * @summary Restores data from an index.
         *
         * @description ### Method
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
         * @summary Restores data from an index.
         *
         * @description ### Method
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
         * @summary Restores data from an index.
         *
         * @description ### Method
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
         * @summary Rebuilds an index.
         *
         * @param request ReindexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReindexResponse
         */
        public ReindexResponse ReindexWithOptions(string instanceId, string tableName, ReindexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDataPath))
            {
                body["ossDataPath"] = request.OssDataPath;
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
                Action = "Reindex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/reindex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReindexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Rebuilds an index.
         *
         * @param request ReindexRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReindexResponse
         */
        public async Task<ReindexResponse> ReindexWithOptionsAsync(string instanceId, string tableName, ReindexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTimeSec))
            {
                body["dataTimeSec"] = request.DataTimeSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssDataPath))
            {
                body["ossDataPath"] = request.OssDataPath;
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
                Action = "Reindex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/reindex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReindexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Rebuilds an index.
         *
         * @param request ReindexRequest
         * @return ReindexResponse
         */
        public ReindexResponse Reindex(string instanceId, string tableName, ReindexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReindexWithOptions(instanceId, tableName, request, headers, runtime);
        }

        /**
         * @summary Rebuilds an index.
         *
         * @param request ReindexRequest
         * @return ReindexResponse
         */
        public async Task<ReindexResponse> ReindexAsync(string instanceId, string tableName, ReindexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReindexWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        /**
         * @summary Deletes a cluster.
         *
         * @description ### Method
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
         * @summary Deletes a cluster.
         *
         * @description ### Method
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
         * @summary Deletes a cluster.
         *
         * @description ### Method
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
         * @summary Deletes a cluster.
         *
         * @description ### Method
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
         * @param request RenameFolderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameFolderResponse
         */
        public RenameFolderResponse RenameFolderWithOptions(string instanceId, string database, string folderId, RenameFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RenameFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameFolderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RenameFolderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameFolderResponse
         */
        public async Task<RenameFolderResponse> RenameFolderWithOptionsAsync(string instanceId, string database, string folderId, RenameFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RenameFolder",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/folders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(folderId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RenameFolderRequest
         * @return RenameFolderResponse
         */
        public RenameFolderResponse RenameFolder(string instanceId, string database, string folderId, RenameFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameFolderWithOptions(instanceId, database, folderId, request, headers, runtime);
        }

        /**
         * @param request RenameFolderRequest
         * @return RenameFolderResponse
         */
        public async Task<RenameFolderResponse> RenameFolderAsync(string instanceId, string database, string folderId, RenameFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameFolderWithOptionsAsync(instanceId, database, folderId, request, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartIndexResponse
         */
        public StartIndexResponse StartIndexWithOptions(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/startIndex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartIndexResponse
         */
        public async Task<StartIndexResponse> StartIndexWithOptionsAsync(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/startIndex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return StartIndexResponse
         */
        public StartIndexResponse StartIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /**
         * @return StartIndexResponse
         */
        public async Task<StartIndexResponse> StartIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopIndexResponse
         */
        public StopIndexResponse StopIndexWithOptions(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/stopIndex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopIndexResponse
         */
        public async Task<StopIndexResponse> StopIndexWithOptionsAsync(string instanceId, string indexName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopIndex",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/indexes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(indexName) + "/stopIndex",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return StopIndexResponse
         */
        public StopIndexResponse StopIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /**
         * @return StopIndexResponse
         */
        public async Task<StopIndexResponse> StopIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /**
         * @summary Stops an FSM task.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Stops an FSM task.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Stops an FSM task.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary Stops an FSM task.
         *
         * @description ### [](#)Method
         * ```java
         * PUT
         * ```
         * ### [](#uri)URI
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
         * @summary 打标签接口
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 打标签接口
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 打标签接口
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 打标签接口
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删标签接口
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删标签接口
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/resource-tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删标签接口
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删标签接口
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a specified instance.
         *
         * @description ### Method
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
         * @summary Modifies the configuration of a specified instance.
         *
         * @description ### Method
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
         * @summary Modifies the configuration of a specified instance.
         *
         * @description ### Method
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
         * @summary Modifies the configuration of a specified instance.
         *
         * @description ### Method
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

        /**
         * @param request UpdateSqlInstanceContentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceContentResponse
         */
        public UpdateSqlInstanceContentResponse UpdateSqlInstanceContentWithOptions(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstanceContent",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/content",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceContentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceContentResponse
         */
        public async Task<UpdateSqlInstanceContentResponse> UpdateSqlInstanceContentWithOptionsAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstanceContent",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/content",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceContentRequest
         * @return UpdateSqlInstanceContentResponse
         */
        public UpdateSqlInstanceContentResponse UpdateSqlInstanceContent(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceContentWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request UpdateSqlInstanceContentRequest
         * @return UpdateSqlInstanceContentResponse
         */
        public async Task<UpdateSqlInstanceContentResponse> UpdateSqlInstanceContentAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceContentWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request UpdateSqlInstanceNameRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceNameResponse
         */
        public UpdateSqlInstanceNameResponse UpdateSqlInstanceNameWithOptions(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateSqlInstanceName",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceNameRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceNameResponse
         */
        public async Task<UpdateSqlInstanceNameResponse> UpdateSqlInstanceNameWithOptionsAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateSqlInstanceName",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/name",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceNameRequest
         * @return UpdateSqlInstanceNameResponse
         */
        public UpdateSqlInstanceNameResponse UpdateSqlInstanceName(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceNameWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request UpdateSqlInstanceNameRequest
         * @return UpdateSqlInstanceNameResponse
         */
        public async Task<UpdateSqlInstanceNameResponse> UpdateSqlInstanceNameAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceNameWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request UpdateSqlInstanceParamsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceParamsResponse
         */
        public UpdateSqlInstanceParamsResponse UpdateSqlInstanceParamsWithOptions(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CombineParam))
            {
                body["combineParam"] = request.CombineParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicParam))
            {
                body["dynamicParam"] = request.DynamicParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kvpair))
            {
                body["kvpair"] = request.Kvpair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaticParam))
            {
                body["staticParam"] = request.StaticParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstanceParams",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/params",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceParamsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceParamsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceParamsResponse
         */
        public async Task<UpdateSqlInstanceParamsResponse> UpdateSqlInstanceParamsWithOptionsAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CombineParam))
            {
                body["combineParam"] = request.CombineParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicParam))
            {
                body["dynamicParam"] = request.DynamicParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kvpair))
            {
                body["kvpair"] = request.Kvpair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaticParam))
            {
                body["staticParam"] = request.StaticParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstanceParams",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sql-studio/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/sql-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sqlInstanceId) + "/params",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSqlInstanceParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateSqlInstanceParamsRequest
         * @return UpdateSqlInstanceParamsResponse
         */
        public UpdateSqlInstanceParamsResponse UpdateSqlInstanceParams(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceParamsWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /**
         * @param request UpdateSqlInstanceParamsRequest
         * @return UpdateSqlInstanceParamsResponse
         */
        public async Task<UpdateSqlInstanceParamsResponse> UpdateSqlInstanceParamsAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceParamsWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

    }
}
