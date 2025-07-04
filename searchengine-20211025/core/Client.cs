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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers reindexing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/actions/build-index
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// BuildIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuildIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers reindexing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/actions/build-index
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// BuildIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuildIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers reindexing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/actions/build-index
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// BuildIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// BuildIndexResponse
        /// </returns>
        public BuildIndexResponse BuildIndex(string instanceId, BuildIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BuildIndexWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers reindexing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/actions/build-index
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// BuildIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// BuildIndexResponse
        /// </returns>
        public async Task<BuildIndexResponse> BuildIndexAsync(string instanceId, BuildIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BuildIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换实例资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换实例资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换实例资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(string instanceId, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换实例资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(string instanceId, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CloneSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// CloneSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// CloneSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneSqlInstanceResponse
        /// </returns>
        public CloneSqlInstanceResponse CloneSqlInstance(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CloneSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneSqlInstanceResponse
        /// </returns>
        public async Task<CloneSqlInstanceResponse> CloneSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, CloneSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
        public CreateAliasResponse CreateAlias(string instanceId, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAliasWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
        public async Task<CreateAliasResponse> CreateAliasAsync(string instanceId, CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAliasWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#method"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#method"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#method"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public CreateClusterResponse CreateCluster(string instanceId, CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#method"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public async Task<CreateClusterResponse> CreateClusterAsync(string instanceId, CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigDirResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigDirResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigDirResponse
        /// </returns>
        public CreateConfigDirResponse CreateConfigDir(string instanceId, string configName, CreateConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigDirResponse
        /// </returns>
        public async Task<CreateConfigDirResponse> CreateConfigDirAsync(string instanceId, string configName, CreateConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigFileResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigFileResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigFileResponse
        /// </returns>
        public CreateConfigFileResponse CreateConfigFile(string instanceId, string configName, CreateConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigFileResponse
        /// </returns>
        public async Task<CreateConfigFileResponse> CreateConfigFileAsync(string instanceId, string configName, CreateConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public CreateDataSourceResponse CreateDataSource(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataSourceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataSourceResponse
        /// </returns>
        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(string instanceId, CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataSourceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public CreateFolderResponse CreateFolder(string instanceId, string database, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFolderWithOptions(instanceId, database, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFolderResponse
        /// </returns>
        public async Task<CreateFolderResponse> CreateFolderAsync(string instanceId, string database, CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFolderWithOptionsAsync(instanceId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">POST
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">POST
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">POST
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public CreateIndexResponse CreateIndex(string instanceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">POST
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIndexResponse
        /// </returns>
        public async Task<CreateIndexResponse> CreateIndexAsync(string instanceId, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Havenask instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/api/instances?dryRun=false</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Havenask instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/api/instances?dryRun=false</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Havenask instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/api/instances?dryRun=false</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Havenask instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/api/instances?dryRun=false</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public CreateModelResponse CreateModelWithOptions(string instanceId, CreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(string instanceId, CreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModel(string instanceId, CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelAsync(string instanceId, CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public endpoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePublicUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public endpoint.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePublicUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public endpoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreatePublicUrlResponse
        /// </returns>
        public CreatePublicUrlResponse CreatePublicUrl(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePublicUrlWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a public endpoint.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreatePublicUrlResponse
        /// </returns>
        public async Task<CreatePublicUrlResponse> CreatePublicUrlAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePublicUrlWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="request">
        /// CreateSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// CreateSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlInstanceResponse
        /// </returns>
        public CreateSqlInstanceResponse CreateSqlInstance(string instanceId, string database, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSqlInstanceWithOptions(instanceId, database, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlInstanceResponse
        /// </returns>
        public async Task<CreateSqlInstanceResponse> CreateSqlInstanceAsync(string instanceId, string database, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSqlInstanceWithOptionsAsync(instanceId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public CreateTableResponse CreateTable(string instanceId, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public async Task<CreateTableResponse> CreateTableAsync(string instanceId, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public DebugModelResponse DebugModelWithOptions(string instanceId, string modelName, DebugModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnline))
            {
                query["isOnline"] = request.IsOnline;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试模型</para>
        /// </summary>
        /// 
        /// <param name="request">
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
        public async Task<DebugModelResponse> DebugModelWithOptionsAsync(string instanceId, string modelName, DebugModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnline))
            {
                query["isOnline"] = request.IsOnline;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
        public DebugModelResponse DebugModel(string instanceId, string modelName, DebugModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DebugModelWithOptions(instanceId, modelName, request, headers, runtime);
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
        public async Task<DebugModelResponse> DebugModelAsync(string instanceId, string modelName, DebugModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DebugModelWithOptionsAsync(instanceId, modelName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the details about advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the details about advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the details about advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// DeleteAdvanceConfigResponse
        /// </returns>
        public DeleteAdvanceConfigResponse DeleteAdvanceConfig(string instanceId, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAdvanceConfigWithOptions(instanceId, configName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the details about advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// DeleteAdvanceConfigResponse
        /// </returns>
        public async Task<DeleteAdvanceConfigResponse> DeleteAdvanceConfigAsync(string instanceId, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAdvanceConfigWithOptionsAsync(instanceId, configName, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
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

        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
        public DeleteAliasResponse DeleteAlias(string instanceId, string alias)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAliasWithOptions(instanceId, alias, headers, runtime);
        }

        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
        public async Task<DeleteAliasResponse> DeleteAliasAsync(string instanceId, string alias)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAliasWithOptionsAsync(instanceId, alias, headers, runtime);
        }

        /// <param name="request">
        /// DeleteConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigDirResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigDirResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigDirResponse
        /// </returns>
        public DeleteConfigDirResponse DeleteConfigDir(string instanceId, string configName, DeleteConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// DeleteConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigDirResponse
        /// </returns>
        public async Task<DeleteConfigDirResponse> DeleteConfigDirAsync(string instanceId, string configName, DeleteConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// DeleteConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigFileResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigFileResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigFileResponse
        /// </returns>
        public DeleteConfigFileResponse DeleteConfigFile(string instanceId, string configName, DeleteConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// DeleteConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigFileResponse
        /// </returns>
        public async Task<DeleteConfigFileResponse> DeleteConfigFileAsync(string instanceId, string configName, DeleteConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>DELETE</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>DELETE</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>DELETE</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public DeleteDataSourceResponse DeleteDataSource(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataSourceWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>DELETE</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteDataSourceResponse
        /// </returns>
        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataSourceWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
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

        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public DeleteFolderResponse DeleteFolder(string instanceId, string database, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFolderWithOptions(instanceId, database, folderId, headers, runtime);
        }

        /// <returns>
        /// DeleteFolderResponse
        /// </returns>
        public async Task<DeleteFolderResponse> DeleteFolderAsync(string instanceId, string database, string folderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFolderWithOptionsAsync(instanceId, database, folderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public DeleteIndexResponse DeleteIndex(string instanceId, string indexName, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}?dataSource=xxx
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexResponse
        /// </returns>
        public async Task<DeleteIndexResponse> DeleteIndexAsync(string instanceId, string indexName, DeleteIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the version of an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the version of an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the version of an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// DeleteIndexVersionResponse
        /// </returns>
        public DeleteIndexVersionResponse DeleteIndexVersion(string instanceId, string indexName, string versionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexVersionWithOptions(instanceId, indexName, versionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the version of an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>DELETE
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// DeleteIndexVersionResponse
        /// </returns>
        public async Task<DeleteIndexVersionResponse> DeleteIndexVersionAsync(string instanceId, string indexName, string versionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexVersionWithOptionsAsync(instanceId, indexName, versionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>DELETE</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>DELETE</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>DELETE</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public DeleteInstanceResponse DeleteInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>DELETE</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteInstanceResponse
        /// </returns>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
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
        public DeleteModelResponse DeleteModelWithOptions(string instanceId, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
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
        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(string instanceId, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
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
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModel(string instanceId, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelWithOptions(instanceId, modelName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模型</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelAsync(string instanceId, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelWithOptionsAsync(instanceId, modelName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除公网域名</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePublicUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除公网域名</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePublicUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除公网域名</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePublicUrlResponse
        /// </returns>
        public DeletePublicUrlResponse DeletePublicUrl(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePublicUrlWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除公网域名</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeletePublicUrlResponse
        /// </returns>
        public async Task<DeletePublicUrlResponse> DeletePublicUrlAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePublicUrlWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSqlInstanceResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSqlInstanceResponse
        /// </returns>
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

        /// <returns>
        /// DeleteSqlInstanceResponse
        /// </returns>
        public DeleteSqlInstanceResponse DeleteSqlInstance(string instanceId, string database, string sqlInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSqlInstanceWithOptions(instanceId, database, sqlInstanceId, headers, runtime);
        }

        /// <returns>
        /// DeleteSqlInstanceResponse
        /// </returns>
        public async Task<DeleteSqlInstanceResponse> DeleteSqlInstanceAsync(string instanceId, string database, string sqlInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public DeleteTableResponse DeleteTable(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableWithOptions(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteTableResponse
        /// </returns>
        public async Task<DeleteTableResponse> DeleteTableAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
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
        /// <para>Queries available regions.</para>
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

        /// <param name="request">
        /// ExecuteSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// ExecuteSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// ExecuteSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlInstanceResponse
        /// </returns>
        public ExecuteSqlInstanceResponse ExecuteSqlInstance(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ExecuteSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSqlInstanceResponse
        /// </returns>
        public async Task<ExecuteSqlInstanceResponse> ExecuteSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, ExecuteSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a forced switchover.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForceSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a forced switchover.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForceSwitchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a forced switchover.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ForceSwitchResponse
        /// </returns>
        public ForceSwitchResponse ForceSwitch(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ForceSwitchWithOptions(instanceId, fsmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a forced switchover.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/force-switch/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ForceSwitchResponse
        /// </returns>
        public async Task<ForceSwitchResponse> ForceSwitchAsync(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ForceSwitchWithOptionsAsync(instanceId, fsmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigResponse
        /// </returns>
        public GetAdvanceConfigResponse GetAdvanceConfig(string instanceId, string configName, GetAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigResponse
        /// </returns>
        public async Task<GetAdvanceConfigResponse> GetAdvanceConfigAsync(string instanceId, string configName, GetAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigFileResponse
        /// </returns>
        public GetAdvanceConfigFileResponse GetAdvanceConfigFile(string instanceId, string configName, GetAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAdvanceConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an advanced configuration file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAdvanceConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAdvanceConfigFileResponse
        /// </returns>
        public async Task<GetAdvanceConfigFileResponse> GetAdvanceConfigFileAsync(string instanceId, string configName, GetAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAdvanceConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instance/{instanceId}/clusters/{clusterName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instance/{instanceId}/clusters/{clusterName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instance/{instanceId}/clusters/{clusterName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public GetClusterResponse GetCluster(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterWithOptions(instanceId, clusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instance/{instanceId}/clusters/{clusterName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public async Task<GetClusterResponse> GetClusterAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime information about a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-run-time-info</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterRunTimeInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime information about a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-run-time-info</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterRunTimeInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime information about a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-run-time-info</para>
        /// </description>
        /// 
        /// <returns>
        /// GetClusterRunTimeInfoResponse
        /// </returns>
        public GetClusterRunTimeInfoResponse GetClusterRunTimeInfo(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterRunTimeInfoWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the runtime information about a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-run-time-info</para>
        /// </description>
        /// 
        /// <returns>
        /// GetClusterRunTimeInfoResponse
        /// </returns>
        public async Task<GetClusterRunTimeInfoResponse> GetClusterRunTimeInfoAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterRunTimeInfoWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// GetDataSourceResponse
        /// </returns>
        public GetDataSourceResponse GetDataSource(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSourceWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}</c></para>
        /// </description>
        /// 
        /// <returns>
        /// GetDataSourceResponse
        /// </returns>
        public async Task<GetDataSourceResponse> GetDataSourceAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSourceWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceDeployResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataSourceDeployResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDataSourceDeployResponse
        /// </returns>
        public GetDataSourceDeployResponse GetDataSourceDeploy(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSourceDeployWithOptions(instanceId, deployName, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDataSourceDeployResponse
        /// </returns>
        public async Task<GetDataSourceDeployResponse> GetDataSourceDeployAsync(string instanceId, string deployName, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSourceDeployWithOptionsAsync(instanceId, deployName, dataSourceName, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSchemaResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSchemaResponse
        /// </returns>
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

        /// <returns>
        /// GetDatabaseSchemaResponse
        /// </returns>
        public GetDatabaseSchemaResponse GetDatabaseSchema(string instanceId, string database, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatabaseSchemaWithOptions(instanceId, database, tableName, headers, runtime);
        }

        /// <returns>
        /// GetDatabaseSchemaResponse
        /// </returns>
        public async Task<GetDatabaseSchemaResponse> GetDatabaseSchemaAsync(string instanceId, string database, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatabaseSchemaWithOptionsAsync(instanceId, database, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the overview of the deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para>GET</para>
        /// <h2>URI</h2>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/deploy-graph
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeployGraphResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the overview of the deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para>GET</para>
        /// <h2>URI</h2>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/deploy-graph
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeployGraphResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the overview of the deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para>GET</para>
        /// <h2>URI</h2>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/deploy-graph
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetDeployGraphResponse
        /// </returns>
        public GetDeployGraphResponse GetDeployGraph(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeployGraphWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the overview of the deployment.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para>GET</para>
        /// <h2>URI</h2>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/deploy-graph
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetDeployGraphResponse
        /// </returns>
        public async Task<GetDeployGraphResponse> GetDeployGraphAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeployGraphWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an index table version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an index table version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an index table version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileResponse
        /// </returns>
        public GetFileResponse GetFile(string instanceId, string indexName, string versionName, GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileWithOptions(instanceId, indexName, versionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an index table version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFileRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileResponse
        /// </returns>
        public async Task<GetFileResponse> GetFileAsync(string instanceId, string indexName, string versionName, GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileWithOptionsAsync(instanceId, indexName, versionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetIndexResponse
        /// </returns>
        public GetIndexResponse GetIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetIndexResponse
        /// </returns>
        public async Task<GetIndexResponse> GetIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online effective policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexOnlineStrategyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online effective policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexOnlineStrategyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online effective policy of an index.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIndexOnlineStrategyResponse
        /// </returns>
        public GetIndexOnlineStrategyResponse GetIndexOnlineStrategy(string instanceId, string dataSourceName, string deployName, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexOnlineStrategyWithOptions(instanceId, dataSourceName, deployName, indexName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online effective policy of an index.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIndexOnlineStrategyResponse
        /// </returns>
        public async Task<GetIndexOnlineStrategyResponse> GetIndexOnlineStrategyAsync(string instanceId, string dataSourceName, string deployName, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexOnlineStrategyWithOptionsAsync(instanceId, dataSourceName, deployName, indexName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about index versions that the current index version can be rolled back to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about index versions that the current index version can be rolled back to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about index versions that the current index version can be rolled back to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetIndexVersionResponse
        /// </returns>
        public GetIndexVersionResponse GetIndexVersion(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexVersionWithOptions(instanceId, clusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about index versions that the current index version can be rolled back to.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetIndexVersionResponse
        /// </returns>
        public async Task<GetIndexVersionResponse> GetIndexVersionAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexVersionWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID和模型名称查询特定模型的详细配置信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定实例下的特定模型的详细信息，包括模型类型、URL、状态等。</description></item>
        /// <item><description>确保提供的<c>instanceId</c>和<c>modelName</c>是有效的，否则可能返回错误或找不到资源。</description></item>
        /// <item><description>返回的数据结构中包含了模型的内容（如请求头、参数等）以及创建和更新时间，有助于了解模型的具体配置及其最新状态。</description></item>
        /// </list>
        /// </description>
        /// 
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
        public GetModelResponse GetModelWithOptions(string instanceId, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
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
        /// <para>通过实例ID和模型名称查询特定模型的详细配置信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定实例下的特定模型的详细信息，包括模型类型、URL、状态等。</description></item>
        /// <item><description>确保提供的<c>instanceId</c>和<c>modelName</c>是有效的，否则可能返回错误或找不到资源。</description></item>
        /// <item><description>返回的数据结构中包含了模型的内容（如请求头、参数等）以及创建和更新时间，有助于了解模型的具体配置及其最新状态。</description></item>
        /// </list>
        /// </description>
        /// 
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
        public async Task<GetModelResponse> GetModelWithOptionsAsync(string instanceId, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
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
        /// <para>通过实例ID和模型名称查询特定模型的详细配置信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定实例下的特定模型的详细信息，包括模型类型、URL、状态等。</description></item>
        /// <item><description>确保提供的<c>instanceId</c>和<c>modelName</c>是有效的，否则可能返回错误或找不到资源。</description></item>
        /// <item><description>返回的数据结构中包含了模型的内容（如请求头、参数等）以及创建和更新时间，有助于了解模型的具体配置及其最新状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public GetModelResponse GetModel(string instanceId, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelWithOptions(instanceId, modelName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID和模型名称查询特定模型的详细配置信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API用于获取指定实例下的特定模型的详细信息，包括模型类型、URL、状态等。</description></item>
        /// <item><description>确保提供的<c>instanceId</c>和<c>modelName</c>是有效的，否则可能返回错误或找不到资源。</description></item>
        /// <item><description>返回的数据结构中包含了模型的内容（如请求头、参数等）以及创建和更新时间，有助于了解模型的具体配置及其最新状态。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public async Task<GetModelResponse> GetModelAsync(string instanceId, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelWithOptionsAsync(instanceId, modelName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the configuration information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the configuration information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the configuration information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeConfigResponse
        /// </returns>
        public GetNodeConfigResponse GetNodeConfig(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeConfigWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the configuration information of a node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeConfigResponse
        /// </returns>
        public async Task<GetNodeConfigResponse> GetNodeConfigAsync(string instanceId, GetNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// GetSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// GetSqlInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlInstanceResponse
        /// </returns>
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

        /// <param name="request">
        /// GetSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlInstanceResponse
        /// </returns>
        public GetSqlInstanceResponse GetSqlInstance(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlInstanceWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// GetSqlInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlInstanceResponse
        /// </returns>
        public async Task<GetSqlInstanceResponse> GetSqlInstanceAsync(string instanceId, string database, string sqlInstanceId, GetSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlInstanceWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public GetTableResponse GetTable(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableWithOptions(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public async Task<GetTableResponse> GetTableAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an index version based on the ID of the full index version.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableGenerationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an index version based on the ID of the full index version.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableGenerationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an index version based on the ID of the full index version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableGenerationResponse
        /// </returns>
        public GetTableGenerationResponse GetTableGeneration(string instanceId, string tableName, string generationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableGenerationWithOptions(instanceId, tableName, generationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an index version based on the ID of the full index version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableGenerationResponse
        /// </returns>
        public async Task<GetTableGenerationResponse> GetTableGenerationAsync(string instanceId, string tableName, string generationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableGenerationWithOptionsAsync(instanceId, tableName, generationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the files in an advanced configuration directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigDirResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the files in an advanced configuration directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigDirRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigDirResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the files in an advanced configuration directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigDirResponse
        /// </returns>
        public ListAdvanceConfigDirResponse ListAdvanceConfigDir(string instanceId, string configName, ListAdvanceConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAdvanceConfigDirWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the files in an advanced configuration directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/dir?dirName={dirName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigDirRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigDirResponse
        /// </returns>
        public async Task<ListAdvanceConfigDirResponse> ListAdvanceConfigDirAsync(string instanceId, string configName, ListAdvanceConfigDirRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAdvanceConfigDirWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Sample requests</h2>
        /// <para><c>GET /openapi/ha3/instances/ose-test1/advanced-configs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Sample requests</h2>
        /// <para><c>GET /openapi/ha3/instances/ose-test1/advanced-configs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Sample requests</h2>
        /// <para><c>GET /openapi/ha3/instances/ose-test1/advanced-configs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigsResponse
        /// </returns>
        public ListAdvanceConfigsResponse ListAdvanceConfigs(string instanceId, ListAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAdvanceConfigsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Sample requests</h2>
        /// <para><c>GET /openapi/ha3/instances/ose-test1/advanced-configs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAdvanceConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAdvanceConfigsResponse
        /// </returns>
        public async Task<ListAdvanceConfigsResponse> ListAdvanceConfigsAsync(string instanceId, ListAdvanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAdvanceConfigsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
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

        /// <returns>
        /// ListAliasesResponse
        /// </returns>
        public ListAliasesResponse ListAliases(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAliasesWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListAliasesResponse
        /// </returns>
        public async Task<ListAliasesResponse> ListAliasesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAliasesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-names</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterNamesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-names</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterNamesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-names</para>
        /// </description>
        /// 
        /// <returns>
        /// ListClusterNamesResponse
        /// </returns>
        public ListClusterNamesResponse ListClusterNames()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterNamesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para>GET</para>
        /// <h3>URI</h3>
        /// <para>/openapi/ha3/instances/{instanceId}/cluster-names</para>
        /// </description>
        /// 
        /// <returns>
        /// ListClusterNamesResponse
        /// </returns>
        public async Task<ListClusterNamesResponse> ListClusterNamesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterNamesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/cluster-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/cluster-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClusterTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/cluster-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListClusterTasksResponse
        /// </returns>
        public ListClusterTasksResponse ListClusterTasks(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterTasksWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries cluster tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/cluster-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListClusterTasksResponse
        /// </returns>
        public async Task<ListClusterTasksResponse> ListClusterTasksAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterTasksWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClusters(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClustersWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClustersWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the schema information about a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceSchemasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the schema information about a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceSchemasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the schema information about a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas</c></para>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourceSchemasResponse
        /// </returns>
        public ListDataSourceSchemasResponse ListDataSourceSchemas(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceSchemasWithOptions(instanceId, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the schema information about a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/schemas</c></para>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourceSchemasResponse
        /// </returns>
        public async Task<ListDataSourceSchemasResponse> ListDataSourceSchemasAsync(string instanceId, string dataSourceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceSchemasWithOptionsAsync(instanceId, dataSourceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays data source tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/data-source-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays data source tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/data-source-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays data source tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/data-source-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourceTasksResponse
        /// </returns>
        public ListDataSourceTasksResponse ListDataSourceTasks(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceTasksWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays data source tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/data-source-tasks
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourceTasksResponse
        /// </returns>
        public async Task<ListDataSourceTasksResponse> ListDataSourceTasksAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceTasksWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of data sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of data sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources</c></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of data sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources</c></para>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSources(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourcesWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of data sources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <para><c>GET</c></para>
        /// <h2>URI</h2>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources</c></para>
        /// </description>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourcesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
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

        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public ListDatabasesResponse ListDatabases(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatabasesWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatabasesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical index versions of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDateSourceGenerationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDateSourceGenerationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical index versions of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDateSourceGenerationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDateSourceGenerationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical index versions of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDateSourceGenerationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDateSourceGenerationsResponse
        /// </returns>
        public ListDateSourceGenerationsResponse ListDateSourceGenerations(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDateSourceGenerationsWithOptions(instanceId, dataSourceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical index versions of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/data-sources/{dataSourceName}/generations?domainName={domainName}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDateSourceGenerationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDateSourceGenerationsResponse
        /// </returns>
        public async Task<ListDateSourceGenerationsResponse> ListDateSourceGenerationsAsync(string instanceId, string dataSourceName, ListDateSourceGenerationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDateSourceGenerationsWithOptionsAsync(instanceId, dataSourceName, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexRecoverRecordsResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexRecoverRecordsResponse
        /// </returns>
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

        /// <returns>
        /// ListIndexRecoverRecordsResponse
        /// </returns>
        public ListIndexRecoverRecordsResponse ListIndexRecoverRecords(string indexName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexRecoverRecordsWithOptions(indexName, instanceId, headers, runtime);
        }

        /// <returns>
        /// ListIndexRecoverRecordsResponse
        /// </returns>
        public async Task<ListIndexRecoverRecordsResponse> ListIndexRecoverRecordsAsync(string indexName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexRecoverRecordsWithOptionsAsync(indexName, instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the index list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the index list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the index list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexesResponse
        /// </returns>
        public ListIndexesResponse ListIndexes(string instanceId, ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the index list.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>GET
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIndexesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIndexesResponse
        /// </returns>
        public async Task<ListIndexesResponse> ListIndexesAsync(string instanceId, ListIndexesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the specifications of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/specs?type=qrs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceSpecsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceSpecsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the specifications of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/specs?type=qrs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceSpecsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceSpecsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the specifications of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/specs?type=qrs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceSpecsResponse
        /// </returns>
        public ListInstanceSpecsResponse ListInstanceSpecs(string instanceId, ListInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceSpecsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the specifications of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/specs?type=qrs</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceSpecsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceSpecsResponse
        /// </returns>
        public async Task<ListInstanceSpecsResponse> ListInstanceSpecsAsync(string instanceId, ListInstanceSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceSpecsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances</c></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances</c></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
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

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
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

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public ListLogsResponse ListLogs(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public async Task<ListLogsResponse> ListLogsAsync(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定条件下的模型列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从指定实例中获取模型列表，支持通过模型名称、类型以及分页参数进行筛选。请求时需提供实例ID作为路径参数，其他筛选条件为可选的查询参数。</para>
        /// </description>
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
        public ListModelsResponse ListModelsWithOptions(string instanceId, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListModels",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models",
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
        /// <para>通过实例ID查询指定条件下的模型列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从指定实例中获取模型列表，支持通过模型名称、类型以及分页参数进行筛选。请求时需提供实例ID作为路径参数，其他筛选条件为可选的查询参数。</para>
        /// </description>
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
        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(string instanceId, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListModels",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models",
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
        /// <para>通过实例ID查询指定条件下的模型列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从指定实例中获取模型列表，支持通过模型名称、类型以及分页参数进行筛选。请求时需提供实例ID作为路径参数，其他筛选条件为可选的查询参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModels(string instanceId, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过实例ID查询指定条件下的模型列表。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从指定实例中获取模型列表，支持通过模型名称、类型以及分页参数进行筛选。请求时需提供实例ID作为路径参数，其他筛选条件为可选的查询参数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsAsync(string instanceId, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an online configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOnlineConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineConfigsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an online configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOnlineConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineConfigsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an online configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOnlineConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineConfigsResponse
        /// </returns>
        public ListOnlineConfigsResponse ListOnlineConfigs(string instanceId, string nodeName, ListOnlineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOnlineConfigsWithOptions(instanceId, nodeName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an online configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">GET
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs?domain={domain}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ListOnlineConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOnlineConfigsResponse
        /// </returns>
        public async Task<ListOnlineConfigsResponse> ListOnlineConfigsAsync(string instanceId, string nodeName, ListOnlineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOnlineConfigsWithOptionsAsync(instanceId, nodeName, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPausePolicysResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPausePolicysResponse
        /// </returns>
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

        /// <returns>
        /// ListPausePolicysResponse
        /// </returns>
        public ListPausePolicysResponse ListPausePolicys(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPausePolicysWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListPausePolicysResponse
        /// </returns>
        public async Task<ListPausePolicysResponse> ListPausePolicysAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPausePolicysWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版使用POST请求获取搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPostQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPostQueryResultResponse
        /// </returns>
        public ListPostQueryResultResponse ListPostQueryResultWithOptions(string instanceId, ListPostQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版使用POST请求获取搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPostQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPostQueryResultResponse
        /// </returns>
        public async Task<ListPostQueryResultResponse> ListPostQueryResultWithOptionsAsync(string instanceId, ListPostQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版使用POST请求获取搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPostQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPostQueryResultResponse
        /// </returns>
        public ListPostQueryResultResponse ListPostQueryResult(string instanceId, ListPostQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPostQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版使用POST请求获取搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPostQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPostQueryResultResponse
        /// </returns>
        public async Task<ListPostQueryResultResponse> ListPostQueryResultAsync(string instanceId, ListPostQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPostQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the query result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/query?query=xxxx</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueryResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the query result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/query?query=xxxx</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueryResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the query result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/query?query=xxxx</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueryResultResponse
        /// </returns>
        public ListQueryResultResponse ListQueryResult(string instanceId, ListQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the query result.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>GET</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/query?query=xxxx</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueryResultResponse
        /// </returns>
        public async Task<ListQueryResultResponse> ListQueryResultAsync(string instanceId, ListQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版获取rest查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRestQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRestQueryResultResponse
        /// </returns>
        public ListRestQueryResultResponse ListRestQueryResultWithOptions(string instanceId, ListRestQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版获取rest查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRestQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRestQueryResultResponse
        /// </returns>
        public async Task<ListRestQueryResultResponse> ListRestQueryResultWithOptionsAsync(string instanceId, ListRestQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版获取rest查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRestQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRestQueryResultResponse
        /// </returns>
        public ListRestQueryResultResponse ListRestQueryResult(string instanceId, ListRestQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRestQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>召回引擎版获取rest查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRestQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRestQueryResultResponse
        /// </returns>
        public async Task<ListRestQueryResultResponse> ListRestQueryResultAsync(string instanceId, ListRestQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRestQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过数据源配置获取schema信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchemasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过数据源配置获取schema信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchemasResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过数据源配置获取schema信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchemasResponse
        /// </returns>
        public ListSchemasResponse ListSchemas(string instanceId, ListSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSchemasWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过数据源配置获取schema信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchemasResponse
        /// </returns>
        public async Task<ListSchemasResponse> ListSchemasAsync(string instanceId, ListSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSchemasWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index versions.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableGenerationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index versions.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableGenerationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index versions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTableGenerationsResponse
        /// </returns>
        public ListTableGenerationsResponse ListTableGenerations(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableGenerationsWithOptions(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index versions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTableGenerationsResponse
        /// </returns>
        public async Task<ListTableGenerationsResponse> ListTableGenerationsAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableGenerationsWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTables(string instanceId, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of index tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesAsync(string instanceId, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群任务列表（数据源+集群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群任务列表（数据源+集群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群任务列表（数据源+集群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasks(string instanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群任务列表（数据源+集群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksAsync(string instanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量检索版获取向量查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVectorQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVectorQueryResultResponse
        /// </returns>
        public ListVectorQueryResultResponse ListVectorQueryResultWithOptions(string instanceId, ListVectorQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量检索版获取向量查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVectorQueryResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVectorQueryResultResponse
        /// </returns>
        public async Task<ListVectorQueryResultResponse> ListVectorQueryResultWithOptionsAsync(string instanceId, ListVectorQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量检索版获取向量查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVectorQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVectorQueryResultResponse
        /// </returns>
        public ListVectorQueryResultResponse ListVectorQueryResult(string instanceId, ListVectorQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVectorQueryResultWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向量检索版获取向量查询搜索测试结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVectorQueryResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVectorQueryResultResponse
        /// </returns>
        public async Task<ListVectorQueryResultResponse> ListVectorQueryResultAsync(string instanceId, ListVectorQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVectorQueryResultWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigResponse
        /// </returns>
        public ModifyAdvanceConfigResponse ModifyAdvanceConfig(string instanceId, string configName, ModifyAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigResponse
        /// </returns>
        public async Task<ModifyAdvanceConfigResponse> ModifyAdvanceConfigAsync(string instanceId, string configName, ModifyAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>put
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAdvanceConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>put
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAdvanceConfigFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>put
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAdvanceConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigFileResponse
        /// </returns>
        public ModifyAdvanceConfigFileResponse ModifyAdvanceConfigFile(string instanceId, string configName, ModifyAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAdvanceConfigFileWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>put
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/file?fileName={fileName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAdvanceConfigFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAdvanceConfigFileResponse
        /// </returns>
        public async Task<ModifyAdvanceConfigFileResponse> ModifyAdvanceConfigFileAsync(string instanceId, string configName, ModifyAdvanceConfigFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAdvanceConfigFileWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAliasResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyAliasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAliasResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAliasResponse
        /// </returns>
        public ModifyAliasResponse ModifyAlias(string instanceId, string alias, ModifyAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAliasWithOptions(instanceId, alias, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAliasResponse
        /// </returns>
        public async Task<ModifyAliasResponse> ModifyAliasAsync(string instanceId, string alias, ModifyAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAliasWithOptionsAsync(instanceId, alias, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterDescRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterDescResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterDescRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterDescResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterDescRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterDescResponse
        /// </returns>
        public ModifyClusterDescResponse ModifyClusterDesc(string instanceId, string clusterName, ModifyClusterDescRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterDescWithOptions(instanceId, clusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/desc</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterDescRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterDescResponse
        /// </returns>
        public async Task<ModifyClusterDescResponse> ModifyClusterDescAsync(string instanceId, string clusterName, ModifyClusterDescRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterDescWithOptionsAsync(instanceId, clusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration information of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request syntax</h2>
        /// <pre><c>PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOfflineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOfflineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration information of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request syntax</h2>
        /// <pre><c>PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOfflineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOfflineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration information of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request syntax</h2>
        /// <pre><c>PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOfflineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOfflineConfigResponse
        /// </returns>
        public ModifyClusterOfflineConfigResponse ModifyClusterOfflineConfig(string instanceId, ModifyClusterOfflineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterOfflineConfigWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration information of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request syntax</h2>
        /// <pre><c>PUT /openapi/ha3/instances/{instanceId}/cluster-offline-config
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOfflineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOfflineConfigResponse
        /// </returns>
        public async Task<ModifyClusterOfflineConfigResponse> ModifyClusterOfflineConfigAsync(string instanceId, ModifyClusterOfflineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterOfflineConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online configuration of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/cluster-online-config</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOnlineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOnlineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online configuration of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/cluster-online-config</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOnlineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOnlineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online configuration of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/cluster-online-config</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOnlineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOnlineConfigResponse
        /// </returns>
        public ModifyClusterOnlineConfigResponse ModifyClusterOnlineConfig(string instanceId, ModifyClusterOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterOnlineConfigWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online configuration of a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/cluster-online-config</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyClusterOnlineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyClusterOnlineConfigResponse
        /// </returns>
        public async Task<ModifyClusterOnlineConfigResponse> ModifyClusterOnlineConfigAsync(string instanceId, ModifyClusterOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterOnlineConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceDeployRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceDeployResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceDeployRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceDeployResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceDeployResponse
        /// </returns>
        public ModifyDataSourceDeployResponse ModifyDataSourceDeploy(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDataSourceDeployWithOptions(instanceId, deployName, dataSourceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据源部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDataSourceDeployRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceDeployResponse
        /// </returns>
        public async Task<ModifyDataSourceDeployResponse> ModifyDataSourceDeployAsync(string instanceId, string deployName, string dataSourceName, ModifyDataSourceDeployRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDataSourceDeployWithOptionsAsync(instanceId, deployName, dataSourceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileResponse
        /// </returns>
        public ModifyFileResponse ModifyFile(string instanceId, string indexName, string versionName, ModifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFileWithOptions(instanceId, indexName, versionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/versions/{versionName}/file?fileName=/root/test.txt
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileResponse
        /// </returns>
        public async Task<ModifyFileResponse> ModifyFileAsync(string instanceId, string indexName, string versionName, ModifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFileWithOptionsAsync(instanceId, indexName, versionName, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexResponse
        /// </returns>
        public ModifyIndexResponse ModifyIndex(string instanceId, string indexName, ModifyIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexResponse
        /// </returns>
        public async Task<ModifyIndexResponse> ModifyIndexAsync(string instanceId, string indexName, ModifyIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyIndexOnlineStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexOnlineStrategyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyIndexOnlineStrategyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexOnlineStrategyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyIndexOnlineStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexOnlineStrategyResponse
        /// </returns>
        public ModifyIndexOnlineStrategyResponse ModifyIndexOnlineStrategy(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexOnlineStrategyWithOptions(instanceId, dataSourceName, deployName, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the online policy of an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyIndexOnlineStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexOnlineStrategyResponse
        /// </returns>
        public async Task<ModifyIndexOnlineStrategyResponse> ModifyIndexOnlineStrategyAsync(string instanceId, string dataSourceName, string deployName, string indexName, ModifyIndexOnlineStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexOnlineStrategyWithOptionsAsync(instanceId, dataSourceName, deployName, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about index partitions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/index-partition</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexPartitionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexPartitionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about index partitions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/index-partition</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexPartitionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexPartitionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about index partitions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/index-partition</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexPartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexPartitionResponse
        /// </returns>
        public ModifyIndexPartitionResponse ModifyIndexPartition(string instanceId, ModifyIndexPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexPartitionWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about index partitions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/index-partition</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexPartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexPartitionResponse
        /// </returns>
        public async Task<ModifyIndexPartitionResponse> ModifyIndexPartitionAsync(string instanceId, ModifyIndexPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexPartitionWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the index version of a cluster (an index version rollback).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the index version of a cluster (an index version rollback).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the index version of a cluster (an index version rollback).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexVersionResponse
        /// </returns>
        public ModifyIndexVersionResponse ModifyIndexVersion(string instanceId, string clusterName, ModifyIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyIndexVersionWithOptions(instanceId, clusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the index version of a cluster (an index version rollback).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Method</h2>
        /// <pre><c>PUT
        /// </c></pre>
        /// <h2><a href="#uri"></a>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/clusters/{clusterName}/index-version
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIndexVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIndexVersionResponse
        /// </returns>
        public async Task<ModifyIndexVersionResponse> ModifyIndexVersionAsync(string instanceId, string clusterName, ModifyIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyIndexVersionWithOptionsAsync(instanceId, clusterName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改模型详情，修改模型状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyModelResponse
        /// </returns>
        public ModifyModelResponse ModifyModelWithOptions(string instanceId, string modelName, ModifyModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改模型详情，修改模型状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyModelResponse
        /// </returns>
        public async Task<ModifyModelResponse> ModifyModelWithOptionsAsync(string instanceId, string modelName, ModifyModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyModel",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改模型详情，修改模型状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyModelResponse
        /// </returns>
        public ModifyModelResponse ModifyModel(string instanceId, string modelName, ModifyModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyModelWithOptions(instanceId, modelName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改模型详情，修改模型状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyModelRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyModelResponse
        /// </returns>
        public async Task<ModifyModelResponse> ModifyModelAsync(string instanceId, string modelName, ModifyModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyModelWithOptionsAsync(instanceId, modelName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node-config?type=qrs&amp;name=test
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node-config?type=qrs&amp;name=test
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node-config?type=qrs&amp;name=test
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeConfigResponse
        /// </returns>
        public ModifyNodeConfigResponse ModifyNodeConfig(string instanceId, ModifyNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyNodeConfigWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node-config?type=qrs&amp;name=test
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyNodeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodeConfigResponse
        /// </returns>
        public async Task<ModifyNodeConfigResponse> ModifyNodeConfigAsync(string instanceId, ModifyNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyNodeConfigWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies online configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">put
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOnlineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOnlineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies online configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">put
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOnlineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOnlineConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies online configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">put
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOnlineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOnlineConfigResponse
        /// </returns>
        public ModifyOnlineConfigResponse ModifyOnlineConfig(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyOnlineConfigWithOptions(instanceId, nodeName, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies online configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">put
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/node/{nodeName}/online-configs/{indexName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyOnlineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyOnlineConfigResponse
        /// </returns>
        public async Task<ModifyOnlineConfigResponse> ModifyOnlineConfigAsync(string instanceId, string nodeName, string indexName, ModifyOnlineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyOnlineConfigWithOptionsAsync(instanceId, nodeName, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/password</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPasswordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/password</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPasswordRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPasswordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/password</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPasswordResponse
        /// </returns>
        public ModifyPasswordResponse ModifyPassword(string instanceId, ModifyPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPasswordWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例的密码</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/password</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPasswordResponse
        /// </returns>
        public async Task<ModifyPasswordResponse> ModifyPasswordAsync(string instanceId, ModifyPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPasswordWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyPausePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPausePolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyPausePolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPausePolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// ModifyPausePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPausePolicyResponse
        /// </returns>
        public ModifyPausePolicyResponse ModifyPausePolicy(string instanceId, ModifyPausePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPausePolicyWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ModifyPausePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPausePolicyResponse
        /// </returns>
        public async Task<ModifyPausePolicyResponse> ModifyPausePolicyAsync(string instanceId, ModifyPausePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPausePolicyWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改公网域名访问白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPublicUrlIpListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPublicUrlIpListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改公网域名访问白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPublicUrlIpListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPublicUrlIpListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改公网域名访问白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPublicUrlIpListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPublicUrlIpListResponse
        /// </returns>
        public ModifyPublicUrlIpListResponse ModifyPublicUrlIpList(string instanceId, ModifyPublicUrlIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPublicUrlIpListWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改公网域名访问白名单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPublicUrlIpListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPublicUrlIpListResponse
        /// </returns>
        public async Task<ModifyPublicUrlIpListResponse> ModifyPublicUrlIpListAsync(string instanceId, ModifyPublicUrlIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPublicUrlIpListWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定实例ID来修改数据节点的副本或分片数量。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定实例下的数据节点副本数或分片数。请求时，需提供实例ID，并在请求体中指定要修改的<c>replica</c>（副本数）或<c>partition</c>（分片数）。请注意，这两个参数都是可选的，但至少需要提供其中一个以执行更新操作。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySearcherReplicaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySearcherReplicaResponse
        /// </returns>
        public ModifySearcherReplicaResponse ModifySearcherReplicaWithOptions(string instanceId, ModifySearcherReplicaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySearcherReplica",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/replica",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySearcherReplicaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定实例ID来修改数据节点的副本或分片数量。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定实例下的数据节点副本数或分片数。请求时，需提供实例ID，并在请求体中指定要修改的<c>replica</c>（副本数）或<c>partition</c>（分片数）。请注意，这两个参数都是可选的，但至少需要提供其中一个以执行更新操作。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySearcherReplicaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySearcherReplicaResponse
        /// </returns>
        public async Task<ModifySearcherReplicaResponse> ModifySearcherReplicaWithOptionsAsync(string instanceId, ModifySearcherReplicaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                body["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replica))
            {
                body["replica"] = request.Replica;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySearcherReplica",
                Version = "2021-10-25",
                Protocol = "HTTPS",
                Pathname = "/openapi/ha3/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/replica",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySearcherReplicaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定实例ID来修改数据节点的副本或分片数量。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定实例下的数据节点副本数或分片数。请求时，需提供实例ID，并在请求体中指定要修改的<c>replica</c>（副本数）或<c>partition</c>（分片数）。请注意，这两个参数都是可选的，但至少需要提供其中一个以执行更新操作。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySearcherReplicaRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySearcherReplicaResponse
        /// </returns>
        public ModifySearcherReplicaResponse ModifySearcherReplica(string instanceId, ModifySearcherReplicaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySearcherReplicaWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过指定实例ID来修改数据节点的副本或分片数量。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API允许用户修改特定实例下的数据节点副本数或分片数。请求时，需提供实例ID，并在请求体中指定要修改的<c>replica</c>（副本数）或<c>partition</c>（分片数）。请注意，这两个参数都是可选的，但至少需要提供其中一个以执行更新操作。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySearcherReplicaRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySearcherReplicaResponse
        /// </returns>
        public async Task<ModifySearcherReplicaResponse> ModifySearcherReplicaAsync(string instanceId, ModifySearcherReplicaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySearcherReplicaWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTableResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTableResponse
        /// </returns>
        public ModifyTableResponse ModifyTable(string instanceId, string tableName, ModifyTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyTableWithOptions(instanceId, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an index table.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTableResponse
        /// </returns>
        public async Task<ModifyTableResponse> ModifyTableAsync(string instanceId, string tableName, ModifyTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyTableWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a version of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a version of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishAdvanceConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishAdvanceConfigResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a version of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishAdvanceConfigResponse
        /// </returns>
        public PublishAdvanceConfigResponse PublishAdvanceConfig(string instanceId, string configName, PublishAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishAdvanceConfigWithOptions(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a version of advanced configurations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/advanced-configs/{configName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishAdvanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishAdvanceConfigResponse
        /// </returns>
        public async Task<PublishAdvanceConfigResponse> PublishAdvanceConfigAsync(string instanceId, string configName, PublishAdvanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishAdvanceConfigWithOptionsAsync(instanceId, configName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishIndexVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishIndexVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishIndexVersionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishIndexVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishIndexVersionResponse
        /// </returns>
        public PublishIndexVersionResponse PublishIndexVersion(string instanceId, string indexName, PublishIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishIndexVersionWithOptions(instanceId, indexName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a specified index version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Method</h2>
        /// <pre><c>POST
        /// </c></pre>
        /// <h2>URI</h2>
        /// <pre><c>/openapi/ha3/instances/{instanceId}/indexes/{indexName}/actions/publish
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishIndexVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishIndexVersionResponse
        /// </returns>
        public async Task<PublishIndexVersionResponse> PublishIndexVersionAsync(string instanceId, string indexName, PublishIndexVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishIndexVersionWithOptionsAsync(instanceId, indexName, request, headers, runtime);
        }

        /// <param name="request">
        /// PushDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentsResponse
        /// </returns>
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

        /// <param name="request">
        /// PushDocumentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentsResponse
        /// </returns>
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

        /// <param name="request">
        /// PushDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentsResponse
        /// </returns>
        public PushDocumentsResponse PushDocuments(string instanceId, string dataSourceName, PushDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDocumentsWithOptions(instanceId, dataSourceName, request, headers, runtime);
        }

        /// <param name="request">
        /// PushDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentsResponse
        /// </returns>
        public async Task<PushDocumentsResponse> PushDocumentsAsync(string instanceId, string dataSourceName, PushDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDocumentsWithOptionsAsync(instanceId, dataSourceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores data from an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/recover-index</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoverIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores data from an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/recover-index</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoverIndexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverIndexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores data from an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/recover-index</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoverIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverIndexResponse
        /// </returns>
        public RecoverIndexResponse RecoverIndex(string instanceId, RecoverIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverIndexWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores data from an index.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>POST</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}/recover-index</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RecoverIndexRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverIndexResponse
        /// </returns>
        public async Task<RecoverIndexResponse> RecoverIndexAsync(string instanceId, RecoverIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverIndexWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReindexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReindexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReindexRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReindexResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReindexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReindexResponse
        /// </returns>
        public ReindexResponse Reindex(string instanceId, string tableName, ReindexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReindexWithOptions(instanceId, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReindexRequest
        /// </param>
        /// 
        /// <returns>
        /// ReindexResponse
        /// </returns>
        public async Task<ReindexResponse> ReindexAsync(string instanceId, string tableName, ReindexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReindexWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">DELETE
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters/{clusterName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">DELETE
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters/{clusterName}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">DELETE
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters/{clusterName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// RemoveClusterResponse
        /// </returns>
        public RemoveClusterResponse RemoveCluster(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveClusterWithOptions(instanceId, clusterName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <pre><code class="language-java">DELETE
        /// </c></pre>
        /// <h3>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/clusters/{clusterName}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// RemoveClusterResponse
        /// </returns>
        public async Task<RemoveClusterResponse> RemoveClusterAsync(string instanceId, string clusterName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveClusterWithOptionsAsync(instanceId, clusterName, headers, runtime);
        }

        /// <param name="request">
        /// RenameFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameFolderResponse
        /// </returns>
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

        /// <param name="request">
        /// RenameFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameFolderResponse
        /// </returns>
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

        /// <param name="request">
        /// RenameFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameFolderResponse
        /// </returns>
        public RenameFolderResponse RenameFolder(string instanceId, string database, string folderId, RenameFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameFolderWithOptions(instanceId, database, folderId, request, headers, runtime);
        }

        /// <param name="request">
        /// RenameFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameFolderResponse
        /// </returns>
        public async Task<RenameFolderResponse> RenameFolderAsync(string instanceId, string database, string folderId, RenameFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameFolderWithOptionsAsync(instanceId, database, folderId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartIndexResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartIndexResponse
        /// </returns>
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

        /// <returns>
        /// StartIndexResponse
        /// </returns>
        public StartIndexResponse StartIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /// <returns>
        /// StartIndexResponse
        /// </returns>
        public async Task<StartIndexResponse> StartIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopIndexResponse
        /// </returns>
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

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopIndexResponse
        /// </returns>
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

        /// <returns>
        /// StopIndexResponse
        /// </returns>
        public StopIndexResponse StopIndex(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopIndexWithOptions(instanceId, indexName, headers, runtime);
        }

        /// <returns>
        /// StopIndexResponse
        /// </returns>
        public async Task<StopIndexResponse> StopIndexAsync(string instanceId, string indexName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopIndexWithOptionsAsync(instanceId, indexName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an FSM task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an FSM task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an FSM task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public StopTaskResponse StopTask(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTaskWithOptions(instanceId, fsmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an FSM task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Method</h3>
        /// <pre><code class="language-java">PUT
        /// </c></pre>
        /// <h3><a href="#uri"></a>URI</h3>
        /// <pre><code class="language-java">/openapi/ha3/instances/{instanceId}/stop-task/{fsmId}
        /// </c></pre>
        /// </description>
        /// 
        /// <returns>
        /// StopTaskResponse
        /// </returns>
        public async Task<StopTaskResponse> StopTaskAsync(string instanceId, string fsmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTaskWithOptionsAsync(instanceId, fsmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstance(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Method</h3>
        /// <para><c>PUT</c></para>
        /// <h3>URI</h3>
        /// <para><c>/openapi/ha3/instances/{instanceId}</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceContentResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceContentResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceContentResponse
        /// </returns>
        public UpdateSqlInstanceContentResponse UpdateSqlInstanceContent(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceContentWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceContentResponse
        /// </returns>
        public async Task<UpdateSqlInstanceContentResponse> UpdateSqlInstanceContentAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceContentWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceNameResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceNameResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceNameResponse
        /// </returns>
        public UpdateSqlInstanceNameResponse UpdateSqlInstanceName(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceNameWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceNameResponse
        /// </returns>
        public async Task<UpdateSqlInstanceNameResponse> UpdateSqlInstanceNameAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceNameWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceParamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceParamsResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceParamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceParamsResponse
        /// </returns>
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

        /// <param name="request">
        /// UpdateSqlInstanceParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceParamsResponse
        /// </returns>
        public UpdateSqlInstanceParamsResponse UpdateSqlInstanceParams(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceParamsWithOptions(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// UpdateSqlInstanceParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSqlInstanceParamsResponse
        /// </returns>
        public async Task<UpdateSqlInstanceParamsResponse> UpdateSqlInstanceParamsAsync(string instanceId, string database, string sqlInstanceId, UpdateSqlInstanceParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceParamsWithOptionsAsync(instanceId, database, sqlInstanceId, request, headers, runtime);
        }

    }
}
