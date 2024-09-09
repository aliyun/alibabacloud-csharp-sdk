// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiFeatureStore20230621.Models;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paifeaturestore", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 检测资源连接状态。
         *
         * @param request CheckInstanceDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceDatasourceResponse
         */
        public CheckInstanceDatasourceResponse CheckInstanceDatasourceWithOptions(string InstanceId, CheckInstanceDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/action/checkdatasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检测资源连接状态。
         *
         * @param request CheckInstanceDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceDatasourceResponse
         */
        public async Task<CheckInstanceDatasourceResponse> CheckInstanceDatasourceWithOptionsAsync(string InstanceId, CheckInstanceDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/action/checkdatasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检测资源连接状态。
         *
         * @param request CheckInstanceDatasourceRequest
         * @return CheckInstanceDatasourceResponse
         */
        public CheckInstanceDatasourceResponse CheckInstanceDatasource(string InstanceId, CheckInstanceDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceDatasourceWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 检测资源连接状态。
         *
         * @param request CheckInstanceDatasourceRequest
         * @return CheckInstanceDatasourceResponse
         */
        public async Task<CheckInstanceDatasourceResponse> CheckInstanceDatasourceAsync(string InstanceId, CheckInstanceDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceDatasourceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建数据源。
         *
         * @param request CreateDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatasourceResponse
         */
        public CreateDatasourceResponse CreateDatasourceWithOptions(string InstanceId, CreateDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
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
                Action = "CreateDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建数据源。
         *
         * @param request CreateDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatasourceResponse
         */
        public async Task<CreateDatasourceResponse> CreateDatasourceWithOptionsAsync(string InstanceId, CreateDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
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
                Action = "CreateDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建数据源。
         *
         * @param request CreateDatasourceRequest
         * @return CreateDatasourceResponse
         */
        public CreateDatasourceResponse CreateDatasource(string InstanceId, CreateDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasourceWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建数据源。
         *
         * @param request CreateDatasourceRequest
         * @return CreateDatasourceResponse
         */
        public async Task<CreateDatasourceResponse> CreateDatasourceAsync(string InstanceId, CreateDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasourceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征实体
         *
         * @param request CreateFeatureEntityRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureEntityResponse
         */
        public CreateFeatureEntityResponse CreateFeatureEntityWithOptions(string InstanceId, CreateFeatureEntityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinId))
            {
                body["JoinId"] = request.JoinId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureEntityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建特征实体
         *
         * @param request CreateFeatureEntityRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureEntityResponse
         */
        public async Task<CreateFeatureEntityResponse> CreateFeatureEntityWithOptionsAsync(string InstanceId, CreateFeatureEntityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinId))
            {
                body["JoinId"] = request.JoinId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建特征实体
         *
         * @param request CreateFeatureEntityRequest
         * @return CreateFeatureEntityResponse
         */
        public CreateFeatureEntityResponse CreateFeatureEntity(string InstanceId, CreateFeatureEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureEntityWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征实体
         *
         * @param request CreateFeatureEntityRequest
         * @return CreateFeatureEntityResponse
         */
        public async Task<CreateFeatureEntityResponse> CreateFeatureEntityAsync(string InstanceId, CreateFeatureEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureEntityWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征视图。
         *
         * @param request CreateFeatureViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureViewResponse
         */
        public CreateFeatureViewResponse CreateFeatureViewWithOptions(string InstanceId, CreateFeatureViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureEntityId))
            {
                body["FeatureEntityId"] = request.FeatureEntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterDatasourceId))
            {
                body["RegisterDatasourceId"] = request.RegisterDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterTable))
            {
                body["RegisterTable"] = request.RegisterTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncOnlineTable))
            {
                body["SyncOnlineTable"] = request.SyncOnlineTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                body["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteMethod))
            {
                body["WriteMethod"] = request.WriteMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteToFeatureDB))
            {
                body["WriteToFeatureDB"] = request.WriteToFeatureDB;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建特征视图。
         *
         * @param request CreateFeatureViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureViewResponse
         */
        public async Task<CreateFeatureViewResponse> CreateFeatureViewWithOptionsAsync(string InstanceId, CreateFeatureViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureEntityId))
            {
                body["FeatureEntityId"] = request.FeatureEntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterDatasourceId))
            {
                body["RegisterDatasourceId"] = request.RegisterDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterTable))
            {
                body["RegisterTable"] = request.RegisterTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncOnlineTable))
            {
                body["SyncOnlineTable"] = request.SyncOnlineTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                body["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteMethod))
            {
                body["WriteMethod"] = request.WriteMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WriteToFeatureDB))
            {
                body["WriteToFeatureDB"] = request.WriteToFeatureDB;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建特征视图。
         *
         * @param request CreateFeatureViewRequest
         * @return CreateFeatureViewResponse
         */
        public CreateFeatureViewResponse CreateFeatureView(string InstanceId, CreateFeatureViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureViewWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征视图。
         *
         * @param request CreateFeatureViewRequest
         * @return CreateFeatureViewResponse
         */
        public async Task<CreateFeatureViewResponse> CreateFeatureViewAsync(string InstanceId, CreateFeatureViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureViewWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建Feature Store实例。
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建Feature Store实例。
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Feature Store实例。
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
         * @summary 创建Feature Store实例。
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
         * @summary 创建label表
         *
         * @param request CreateLabelTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabelTableResponse
         */
        public CreateLabelTableResponse CreateLabelTableWithOptions(string InstanceId, CreateLabelTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                body["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建label表
         *
         * @param request CreateLabelTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabelTableResponse
         */
        public async Task<CreateLabelTableResponse> CreateLabelTableWithOptionsAsync(string InstanceId, CreateLabelTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                body["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建label表
         *
         * @param request CreateLabelTableRequest
         * @return CreateLabelTableResponse
         */
        public CreateLabelTableResponse CreateLabelTable(string InstanceId, CreateLabelTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLabelTableWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建label表
         *
         * @param request CreateLabelTableRequest
         * @return CreateLabelTableResponse
         */
        public async Task<CreateLabelTableResponse> CreateLabelTableAsync(string InstanceId, CreateLabelTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLabelTableWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建模型特征。
         *
         * @param request CreateModelFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateModelFeatureResponse
         */
        public CreateModelFeatureResponse CreateModelFeatureWithOptions(string InstanceId, CreateModelFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelPriorityLevel))
            {
                body["LabelPriorityLevel"] = request.LabelPriorityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableId))
            {
                body["LabelTableId"] = request.LabelTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatureViewIds))
            {
                body["SequenceFeatureViewIds"] = request.SequenceFeatureViewIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建模型特征。
         *
         * @param request CreateModelFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateModelFeatureResponse
         */
        public async Task<CreateModelFeatureResponse> CreateModelFeatureWithOptionsAsync(string InstanceId, CreateModelFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelPriorityLevel))
            {
                body["LabelPriorityLevel"] = request.LabelPriorityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableId))
            {
                body["LabelTableId"] = request.LabelTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatureViewIds))
            {
                body["SequenceFeatureViewIds"] = request.SequenceFeatureViewIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建模型特征。
         *
         * @param request CreateModelFeatureRequest
         * @return CreateModelFeatureResponse
         */
        public CreateModelFeatureResponse CreateModelFeature(string InstanceId, CreateModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelFeatureWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建模型特征。
         *
         * @param request CreateModelFeatureRequest
         * @return CreateModelFeatureResponse
         */
        public async Task<CreateModelFeatureResponse> CreateModelFeatureAsync(string InstanceId, CreateModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelFeatureWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建训练样本FG表。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateModelFeatureTrainingSetFGTableResponse
         */
        public CreateModelFeatureTrainingSetFGTableResponse CreateModelFeatureTrainingSetFGTableWithOptions(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelFeatureTrainingSetFGTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/trainingsetfgtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelFeatureTrainingSetFGTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建训练样本FG表。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateModelFeatureTrainingSetFGTableResponse
         */
        public async Task<CreateModelFeatureTrainingSetFGTableResponse> CreateModelFeatureTrainingSetFGTableWithOptionsAsync(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelFeatureTrainingSetFGTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/trainingsetfgtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelFeatureTrainingSetFGTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建训练样本FG表。
         *
         * @return CreateModelFeatureTrainingSetFGTableResponse
         */
        public CreateModelFeatureTrainingSetFGTableResponse CreateModelFeatureTrainingSetFGTable(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelFeatureTrainingSetFGTableWithOptions(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 创建训练样本FG表。
         *
         * @return CreateModelFeatureTrainingSetFGTableResponse
         */
        public async Task<CreateModelFeatureTrainingSetFGTableResponse> CreateModelFeatureTrainingSetFGTableAsync(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelFeatureTrainingSetFGTableWithOptionsAsync(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 创建FeatureStore项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(string InstanceId, CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineDatasourceId))
            {
                body["OfflineDatasourceId"] = request.OfflineDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineLifeCycle))
            {
                body["OfflineLifeCycle"] = request.OfflineLifeCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineDatasourceId))
            {
                body["OnlineDatasourceId"] = request.OnlineDatasourceId;
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
                Action = "CreateProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建FeatureStore项目
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(string InstanceId, CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineDatasourceId))
            {
                body["OfflineDatasourceId"] = request.OfflineDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineLifeCycle))
            {
                body["OfflineLifeCycle"] = request.OfflineLifeCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineDatasourceId))
            {
                body["OnlineDatasourceId"] = request.OnlineDatasourceId;
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
                Action = "CreateProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建FeatureStore项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(string InstanceId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建FeatureStore项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(string InstanceId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建feature store服务账户角色
         *
         * @param request CreateServiceIdentityRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceIdentityRoleResponse
         */
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRoleWithOptions(CreateServiceIdentityRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/serviceidentityroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建feature store服务账户角色
         *
         * @param request CreateServiceIdentityRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceIdentityRoleResponse
         */
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleWithOptionsAsync(CreateServiceIdentityRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceIdentityRole",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/serviceidentityroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建feature store服务账户角色
         *
         * @param request CreateServiceIdentityRoleRequest
         * @return CreateServiceIdentityRoleResponse
         */
        public CreateServiceIdentityRoleResponse CreateServiceIdentityRole(CreateServiceIdentityRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceIdentityRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建feature store服务账户角色
         *
         * @param request CreateServiceIdentityRoleRequest
         * @return CreateServiceIdentityRoleResponse
         */
        public async Task<CreateServiceIdentityRoleResponse> CreateServiceIdentityRoleAsync(CreateServiceIdentityRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceIdentityRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除指定数据源。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatasourceResponse
         */
        public DeleteDatasourceResponse DeleteDatasourceWithOptions(string InstanceId, string DatasourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定数据源。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatasourceResponse
         */
        public async Task<DeleteDatasourceResponse> DeleteDatasourceWithOptionsAsync(string InstanceId, string DatasourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定数据源。
         *
         * @return DeleteDatasourceResponse
         */
        public DeleteDatasourceResponse DeleteDatasource(string InstanceId, string DatasourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasourceWithOptions(InstanceId, DatasourceId, headers, runtime);
        }

        /**
         * @summary 删除指定数据源。
         *
         * @return DeleteDatasourceResponse
         */
        public async Task<DeleteDatasourceResponse> DeleteDatasourceAsync(string InstanceId, string DatasourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasourceWithOptionsAsync(InstanceId, DatasourceId, headers, runtime);
        }

        /**
         * @summary 删除指定特征实体
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureEntityResponse
         */
        public DeleteFeatureEntityResponse DeleteFeatureEntityWithOptions(string InstanceId, string FeatureEntityId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureEntityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定特征实体
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureEntityResponse
         */
        public async Task<DeleteFeatureEntityResponse> DeleteFeatureEntityWithOptionsAsync(string InstanceId, string FeatureEntityId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定特征实体
         *
         * @return DeleteFeatureEntityResponse
         */
        public DeleteFeatureEntityResponse DeleteFeatureEntity(string InstanceId, string FeatureEntityId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFeatureEntityWithOptions(InstanceId, FeatureEntityId, headers, runtime);
        }

        /**
         * @summary 删除指定特征实体
         *
         * @return DeleteFeatureEntityResponse
         */
        public async Task<DeleteFeatureEntityResponse> DeleteFeatureEntityAsync(string InstanceId, string FeatureEntityId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFeatureEntityWithOptionsAsync(InstanceId, FeatureEntityId, headers, runtime);
        }

        /**
         * @summary 删除指定特征视图。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureViewResponse
         */
        public DeleteFeatureViewResponse DeleteFeatureViewWithOptions(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定特征视图。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFeatureViewResponse
         */
        public async Task<DeleteFeatureViewResponse> DeleteFeatureViewWithOptionsAsync(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFeatureViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定特征视图。
         *
         * @return DeleteFeatureViewResponse
         */
        public DeleteFeatureViewResponse DeleteFeatureView(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFeatureViewWithOptions(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 删除指定特征视图。
         *
         * @return DeleteFeatureViewResponse
         */
        public async Task<DeleteFeatureViewResponse> DeleteFeatureViewAsync(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFeatureViewWithOptionsAsync(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 删除label表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLabelTableResponse
         */
        public DeleteLabelTableResponse DeleteLabelTableWithOptions(string InstanceId, string LabelTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLabelTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除label表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLabelTableResponse
         */
        public async Task<DeleteLabelTableResponse> DeleteLabelTableWithOptionsAsync(string InstanceId, string LabelTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLabelTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除label表
         *
         * @return DeleteLabelTableResponse
         */
        public DeleteLabelTableResponse DeleteLabelTable(string InstanceId, string LabelTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLabelTableWithOptions(InstanceId, LabelTableId, headers, runtime);
        }

        /**
         * @summary 删除label表
         *
         * @return DeleteLabelTableResponse
         */
        public async Task<DeleteLabelTableResponse> DeleteLabelTableAsync(string InstanceId, string LabelTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLabelTableWithOptionsAsync(InstanceId, LabelTableId, headers, runtime);
        }

        /**
         * @summary 删除指定模型特征。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteModelFeatureResponse
         */
        public DeleteModelFeatureResponse DeleteModelFeatureWithOptions(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定模型特征。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteModelFeatureResponse
         */
        public async Task<DeleteModelFeatureResponse> DeleteModelFeatureWithOptionsAsync(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定模型特征。
         *
         * @return DeleteModelFeatureResponse
         */
        public DeleteModelFeatureResponse DeleteModelFeature(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelFeatureWithOptions(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 删除指定模型特征。
         *
         * @return DeleteModelFeatureResponse
         */
        public async Task<DeleteModelFeatureResponse> DeleteModelFeatureAsync(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelFeatureWithOptionsAsync(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 删除指定Feature Store项目。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProjectWithOptions(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定Feature Store项目。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定Feature Store项目。
         *
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 删除指定Feature Store项目。
         *
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 导出训练样本FG表。
         *
         * @param request ExportModelFeatureTrainingSetFGTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportModelFeatureTrainingSetFGTableResponse
         */
        public ExportModelFeatureTrainingSetFGTableResponse ExportModelFeatureTrainingSetFGTableWithOptions(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetFGTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSetFgConfig))
            {
                body["TrainingSetFgConfig"] = request.TrainingSetFgConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportModelFeatureTrainingSetFGTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/action/exporttrainingsetfgtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportModelFeatureTrainingSetFGTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出训练样本FG表。
         *
         * @param request ExportModelFeatureTrainingSetFGTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportModelFeatureTrainingSetFGTableResponse
         */
        public async Task<ExportModelFeatureTrainingSetFGTableResponse> ExportModelFeatureTrainingSetFGTableWithOptionsAsync(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetFGTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSetFgConfig))
            {
                body["TrainingSetFgConfig"] = request.TrainingSetFgConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportModelFeatureTrainingSetFGTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/action/exporttrainingsetfgtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportModelFeatureTrainingSetFGTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出训练样本FG表。
         *
         * @param request ExportModelFeatureTrainingSetFGTableRequest
         * @return ExportModelFeatureTrainingSetFGTableResponse
         */
        public ExportModelFeatureTrainingSetFGTableResponse ExportModelFeatureTrainingSetFGTable(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetFGTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportModelFeatureTrainingSetFGTableWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 导出训练样本FG表。
         *
         * @param request ExportModelFeatureTrainingSetFGTableRequest
         * @return ExportModelFeatureTrainingSetFGTableResponse
         */
        public async Task<ExportModelFeatureTrainingSetFGTableResponse> ExportModelFeatureTrainingSetFGTableAsync(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetFGTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportModelFeatureTrainingSetFGTableWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 导出训练集表。
         *
         * @param request ExportModelFeatureTrainingSetTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportModelFeatureTrainingSetTableResponse
         */
        public ExportModelFeatureTrainingSetTableResponse ExportModelFeatureTrainingSetTableWithOptions(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureViewConfig))
            {
                body["FeatureViewConfig"] = request.FeatureViewConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelInputConfig))
            {
                body["LabelInputConfig"] = request.LabelInputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIterateInterval))
            {
                body["RealTimeIterateInterval"] = request.RealTimeIterateInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimePartitionCountValue))
            {
                body["RealTimePartitionCountValue"] = request.RealTimePartitionCountValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSetConfig))
            {
                body["TrainingSetConfig"] = request.TrainingSetConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportModelFeatureTrainingSetTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/action/exporttrainingsettable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportModelFeatureTrainingSetTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出训练集表。
         *
         * @param request ExportModelFeatureTrainingSetTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportModelFeatureTrainingSetTableResponse
         */
        public async Task<ExportModelFeatureTrainingSetTableResponse> ExportModelFeatureTrainingSetTableWithOptionsAsync(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureViewConfig))
            {
                body["FeatureViewConfig"] = request.FeatureViewConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelInputConfig))
            {
                body["LabelInputConfig"] = request.LabelInputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimeIterateInterval))
            {
                body["RealTimeIterateInterval"] = request.RealTimeIterateInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTimePartitionCountValue))
            {
                body["RealTimePartitionCountValue"] = request.RealTimePartitionCountValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSetConfig))
            {
                body["TrainingSetConfig"] = request.TrainingSetConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportModelFeatureTrainingSetTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/action/exporttrainingsettable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportModelFeatureTrainingSetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出训练集表。
         *
         * @param request ExportModelFeatureTrainingSetTableRequest
         * @return ExportModelFeatureTrainingSetTableResponse
         */
        public ExportModelFeatureTrainingSetTableResponse ExportModelFeatureTrainingSetTable(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExportModelFeatureTrainingSetTableWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 导出训练集表。
         *
         * @param request ExportModelFeatureTrainingSetTableRequest
         * @return ExportModelFeatureTrainingSetTableResponse
         */
        public async Task<ExportModelFeatureTrainingSetTableResponse> ExportModelFeatureTrainingSetTableAsync(string InstanceId, string ModelFeatureId, ExportModelFeatureTrainingSetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExportModelFeatureTrainingSetTableWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 获取数据源详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasourceResponse
         */
        public GetDatasourceResponse GetDatasourceWithOptions(string InstanceId, string DatasourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据源详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasourceResponse
         */
        public async Task<GetDatasourceResponse> GetDatasourceWithOptionsAsync(string InstanceId, string DatasourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据源详细信息。
         *
         * @return GetDatasourceResponse
         */
        public GetDatasourceResponse GetDatasource(string InstanceId, string DatasourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasourceWithOptions(InstanceId, DatasourceId, headers, runtime);
        }

        /**
         * @summary 获取数据源详细信息。
         *
         * @return GetDatasourceResponse
         */
        public async Task<GetDatasourceResponse> GetDatasourceAsync(string InstanceId, string DatasourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasourceWithOptionsAsync(InstanceId, DatasourceId, headers, runtime);
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasourceTableResponse
         */
        public GetDatasourceTableResponse GetDatasourceTableWithOptions(string InstanceId, string DatasourceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasourceTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasourceTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasourceTableResponse
         */
        public async Task<GetDatasourceTableResponse> GetDatasourceTableWithOptionsAsync(string InstanceId, string DatasourceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasourceTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasourceTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @return GetDatasourceTableResponse
         */
        public GetDatasourceTableResponse GetDatasourceTable(string InstanceId, string DatasourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasourceTableWithOptions(InstanceId, DatasourceId, TableName, headers, runtime);
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @return GetDatasourceTableResponse
         */
        public async Task<GetDatasourceTableResponse> GetDatasourceTableAsync(string InstanceId, string DatasourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasourceTableWithOptionsAsync(InstanceId, DatasourceId, TableName, headers, runtime);
        }

        /**
         * @summary 获取特征实体详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureEntityResponse
         */
        public GetFeatureEntityResponse GetFeatureEntityWithOptions(string InstanceId, string FeatureEntityId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureEntityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征实体详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureEntityResponse
         */
        public async Task<GetFeatureEntityResponse> GetFeatureEntityWithOptionsAsync(string InstanceId, string FeatureEntityId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征实体详细信息
         *
         * @return GetFeatureEntityResponse
         */
        public GetFeatureEntityResponse GetFeatureEntity(string InstanceId, string FeatureEntityId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureEntityWithOptions(InstanceId, FeatureEntityId, headers, runtime);
        }

        /**
         * @summary 获取特征实体详细信息
         *
         * @return GetFeatureEntityResponse
         */
        public async Task<GetFeatureEntityResponse> GetFeatureEntityAsync(string InstanceId, string FeatureEntityId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureEntityWithOptionsAsync(InstanceId, FeatureEntityId, headers, runtime);
        }

        /**
         * @summary 获取特征视图详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureViewResponse
         */
        public GetFeatureViewResponse GetFeatureViewWithOptions(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureViewResponse
         */
        public async Task<GetFeatureViewResponse> GetFeatureViewWithOptionsAsync(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureView",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图详细信息。
         *
         * @return GetFeatureViewResponse
         */
        public GetFeatureViewResponse GetFeatureView(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureViewWithOptions(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 获取特征视图详细信息。
         *
         * @return GetFeatureViewResponse
         */
        public async Task<GetFeatureViewResponse> GetFeatureViewAsync(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureViewWithOptionsAsync(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 获取实例详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例详细信息
         *
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取实例详细信息
         *
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取Label表详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLabelTableResponse
         */
        public GetLabelTableResponse GetLabelTableWithOptions(string InstanceId, string LabelTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Label表详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLabelTableResponse
         */
        public async Task<GetLabelTableResponse> GetLabelTableWithOptionsAsync(string InstanceId, string LabelTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Label表详细信息。
         *
         * @return GetLabelTableResponse
         */
        public GetLabelTableResponse GetLabelTable(string InstanceId, string LabelTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLabelTableWithOptions(InstanceId, LabelTableId, headers, runtime);
        }

        /**
         * @summary 获取Label表详细信息。
         *
         * @return GetLabelTableResponse
         */
        public async Task<GetLabelTableResponse> GetLabelTableAsync(string InstanceId, string LabelTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLabelTableWithOptionsAsync(InstanceId, LabelTableId, headers, runtime);
        }

        /**
         * @summary 获取模型特征详情。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureResponse
         */
        public GetModelFeatureResponse GetModelFeatureWithOptions(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征详情。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureResponse
         */
        public async Task<GetModelFeatureResponse> GetModelFeatureWithOptionsAsync(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征详情。
         *
         * @return GetModelFeatureResponse
         */
        public GetModelFeatureResponse GetModelFeature(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelFeatureWithOptions(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取模型特征详情。
         *
         * @return GetModelFeatureResponse
         */
        public async Task<GetModelFeatureResponse> GetModelFeatureAsync(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelFeatureWithOptionsAsync(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取模型特征的FG特征配置信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureFGFeatureResponse
         */
        public GetModelFeatureFGFeatureResponse GetModelFeatureFGFeatureWithOptions(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeatureFGFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fgfeature",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureFGFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征的FG特征配置信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureFGFeatureResponse
         */
        public async Task<GetModelFeatureFGFeatureResponse> GetModelFeatureFGFeatureWithOptionsAsync(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeatureFGFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fgfeature",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureFGFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征的FG特征配置信息。
         *
         * @return GetModelFeatureFGFeatureResponse
         */
        public GetModelFeatureFGFeatureResponse GetModelFeatureFGFeature(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelFeatureFGFeatureWithOptions(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取模型特征的FG特征配置信息。
         *
         * @return GetModelFeatureFGFeatureResponse
         */
        public async Task<GetModelFeatureFGFeatureResponse> GetModelFeatureFGFeatureAsync(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelFeatureFGFeatureWithOptionsAsync(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取模型特征的fg.json文件配置信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureFGInfoResponse
         */
        public GetModelFeatureFGInfoResponse GetModelFeatureFGInfoWithOptions(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeatureFGInfo",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fginfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureFGInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征的fg.json文件配置信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetModelFeatureFGInfoResponse
         */
        public async Task<GetModelFeatureFGInfoResponse> GetModelFeatureFGInfoWithOptionsAsync(string InstanceId, string ModelFeatureId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelFeatureFGInfo",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fginfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelFeatureFGInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征的fg.json文件配置信息。
         *
         * @return GetModelFeatureFGInfoResponse
         */
        public GetModelFeatureFGInfoResponse GetModelFeatureFGInfo(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelFeatureFGInfoWithOptions(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取模型特征的fg.json文件配置信息。
         *
         * @return GetModelFeatureFGInfoResponse
         */
        public async Task<GetModelFeatureFGInfoResponse> GetModelFeatureFGInfoAsync(string InstanceId, string ModelFeatureId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelFeatureFGInfoWithOptionsAsync(InstanceId, ModelFeatureId, headers, runtime);
        }

        /**
         * @summary 获取指定Feature Store项目详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProjectWithOptions(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取指定Feature Store项目详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取指定Feature Store项目详细信息。
         *
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 获取指定Feature Store项目详细信息。
         *
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 获取项目下特征实体详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectFeatureEntityResponse
         */
        public GetProjectFeatureEntityResponse GetProjectFeatureEntityWithOptions(string InstanceId, string ProjectId, string FeatureEntityName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectFeatureEntityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取项目下特征实体详细信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectFeatureEntityResponse
         */
        public async Task<GetProjectFeatureEntityResponse> GetProjectFeatureEntityWithOptionsAsync(string InstanceId, string ProjectId, string FeatureEntityName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectFeatureEntity",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/featureentities/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureEntityName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectFeatureEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目下特征实体详细信息
         *
         * @return GetProjectFeatureEntityResponse
         */
        public GetProjectFeatureEntityResponse GetProjectFeatureEntity(string InstanceId, string ProjectId, string FeatureEntityName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectFeatureEntityWithOptions(InstanceId, ProjectId, FeatureEntityName, headers, runtime);
        }

        /**
         * @summary 获取项目下特征实体详细信息
         *
         * @return GetProjectFeatureEntityResponse
         */
        public async Task<GetProjectFeatureEntityResponse> GetProjectFeatureEntityAsync(string InstanceId, string ProjectId, string FeatureEntityName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectFeatureEntityWithOptionsAsync(InstanceId, ProjectId, FeatureEntityName, headers, runtime);
        }

        /**
         * @summary 获取feature store服务账户角色。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceIdentityRoleResponse
         */
        public GetServiceIdentityRoleResponse GetServiceIdentityRoleWithOptions(string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/serviceidentityroles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取feature store服务账户角色。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceIdentityRoleResponse
         */
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleWithOptionsAsync(string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceIdentityRole",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/serviceidentityroles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceIdentityRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取feature store服务账户角色。
         *
         * @return GetServiceIdentityRoleResponse
         */
        public GetServiceIdentityRoleResponse GetServiceIdentityRole(string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceIdentityRoleWithOptions(RoleName, headers, runtime);
        }

        /**
         * @summary 获取feature store服务账户角色。
         *
         * @return GetServiceIdentityRoleResponse
         */
        public async Task<GetServiceIdentityRoleResponse> GetServiceIdentityRoleAsync(string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceIdentityRoleWithOptionsAsync(RoleName, headers, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTaskWithOptions(string InstanceId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string InstanceId, string TaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务详情
         *
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTask(string InstanceId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(InstanceId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskAsync(string InstanceId, string TaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(InstanceId, TaskId, headers, runtime);
        }

        /**
         * @summary 获取数据源下所有表。
         *
         * @param request ListDatasourceTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasourceTablesResponse
         */
        public ListDatasourceTablesResponse ListDatasourceTablesWithOptions(string InstanceId, string DatasourceId, ListDatasourceTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasourceTables",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasourceTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据源下所有表。
         *
         * @param request ListDatasourceTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasourceTablesResponse
         */
        public async Task<ListDatasourceTablesResponse> ListDatasourceTablesWithOptionsAsync(string InstanceId, string DatasourceId, ListDatasourceTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasourceTables",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasourceTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据源下所有表。
         *
         * @param request ListDatasourceTablesRequest
         * @return ListDatasourceTablesResponse
         */
        public ListDatasourceTablesResponse ListDatasourceTables(string InstanceId, string DatasourceId, ListDatasourceTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasourceTablesWithOptions(InstanceId, DatasourceId, request, headers, runtime);
        }

        /**
         * @summary 获取数据源下所有表。
         *
         * @param request ListDatasourceTablesRequest
         * @return ListDatasourceTablesResponse
         */
        public async Task<ListDatasourceTablesResponse> ListDatasourceTablesAsync(string InstanceId, string DatasourceId, ListDatasourceTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasourceTablesWithOptionsAsync(InstanceId, DatasourceId, request, headers, runtime);
        }

        /**
         * @summary 获取数据源列表。
         *
         * @param request ListDatasourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasourcesResponse
         */
        public ListDatasourcesResponse ListDatasourcesWithOptions(string InstanceId, ListDatasourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "ListDatasources",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取数据源列表。
         *
         * @param request ListDatasourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasourcesResponse
         */
        public async Task<ListDatasourcesResponse> ListDatasourcesWithOptionsAsync(string InstanceId, ListDatasourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "ListDatasources",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据源列表。
         *
         * @param request ListDatasourcesRequest
         * @return ListDatasourcesResponse
         */
        public ListDatasourcesResponse ListDatasources(string InstanceId, ListDatasourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasourcesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取数据源列表。
         *
         * @param request ListDatasourcesRequest
         * @return ListDatasourcesResponse
         */
        public async Task<ListDatasourcesResponse> ListDatasourcesAsync(string InstanceId, ListDatasourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征实体列表
         *
         * @param tmpReq ListFeatureEntitiesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureEntitiesResponse
         */
        public ListFeatureEntitiesResponse ListFeatureEntitiesWithOptions(string InstanceId, ListFeatureEntitiesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureEntitiesShrinkRequest request = new ListFeatureEntitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureEntityIds))
            {
                request.FeatureEntityIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureEntityIds, "FeatureEntityIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureEntityIdsShrink))
            {
                query["FeatureEntityIds"] = request.FeatureEntityIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureEntities",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureEntitiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建特征实体列表
         *
         * @param tmpReq ListFeatureEntitiesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureEntitiesResponse
         */
        public async Task<ListFeatureEntitiesResponse> ListFeatureEntitiesWithOptionsAsync(string InstanceId, ListFeatureEntitiesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureEntitiesShrinkRequest request = new ListFeatureEntitiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureEntityIds))
            {
                request.FeatureEntityIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureEntityIds, "FeatureEntityIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureEntityIdsShrink))
            {
                query["FeatureEntityIds"] = request.FeatureEntityIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureEntities",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureentities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建特征实体列表
         *
         * @param request ListFeatureEntitiesRequest
         * @return ListFeatureEntitiesResponse
         */
        public ListFeatureEntitiesResponse ListFeatureEntities(string InstanceId, ListFeatureEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureEntitiesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建特征实体列表
         *
         * @param request ListFeatureEntitiesRequest
         * @return ListFeatureEntitiesResponse
         */
        public async Task<ListFeatureEntitiesResponse> ListFeatureEntitiesAsync(string InstanceId, ListFeatureEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureEntitiesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取特征字段血缘关系。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewFieldRelationshipsResponse
         */
        public ListFeatureViewFieldRelationshipsResponse ListFeatureViewFieldRelationshipsWithOptions(string InstanceId, string FeatureViewId, string FieldName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewFieldRelationships",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/fields/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FieldName) + "/relationships",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewFieldRelationshipsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征字段血缘关系。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewFieldRelationshipsResponse
         */
        public async Task<ListFeatureViewFieldRelationshipsResponse> ListFeatureViewFieldRelationshipsWithOptionsAsync(string InstanceId, string FeatureViewId, string FieldName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewFieldRelationships",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/fields/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FieldName) + "/relationships",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewFieldRelationshipsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征字段血缘关系。
         *
         * @return ListFeatureViewFieldRelationshipsResponse
         */
        public ListFeatureViewFieldRelationshipsResponse ListFeatureViewFieldRelationships(string InstanceId, string FeatureViewId, string FieldName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureViewFieldRelationshipsWithOptions(InstanceId, FeatureViewId, FieldName, headers, runtime);
        }

        /**
         * @summary 获取特征字段血缘关系。
         *
         * @return ListFeatureViewFieldRelationshipsResponse
         */
        public async Task<ListFeatureViewFieldRelationshipsResponse> ListFeatureViewFieldRelationshipsAsync(string InstanceId, string FeatureViewId, string FieldName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureViewFieldRelationshipsWithOptionsAsync(InstanceId, FeatureViewId, FieldName, headers, runtime);
        }

        /**
         * @summary 获取特征视图下的在线特征数据。
         *
         * @param tmpReq ListFeatureViewOnlineFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewOnlineFeaturesResponse
         */
        public ListFeatureViewOnlineFeaturesResponse ListFeatureViewOnlineFeaturesWithOptions(string InstanceId, string FeatureViewId, ListFeatureViewOnlineFeaturesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureViewOnlineFeaturesShrinkRequest request = new ListFeatureViewOnlineFeaturesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JoinIds))
            {
                request.JoinIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JoinIds, "JoinIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinIdsShrink))
            {
                query["JoinIds"] = request.JoinIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewOnlineFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/onlinefeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewOnlineFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图下的在线特征数据。
         *
         * @param tmpReq ListFeatureViewOnlineFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewOnlineFeaturesResponse
         */
        public async Task<ListFeatureViewOnlineFeaturesResponse> ListFeatureViewOnlineFeaturesWithOptionsAsync(string InstanceId, string FeatureViewId, ListFeatureViewOnlineFeaturesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureViewOnlineFeaturesShrinkRequest request = new ListFeatureViewOnlineFeaturesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JoinIds))
            {
                request.JoinIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JoinIds, "JoinIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinIdsShrink))
            {
                query["JoinIds"] = request.JoinIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewOnlineFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/onlinefeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewOnlineFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图下的在线特征数据。
         *
         * @param request ListFeatureViewOnlineFeaturesRequest
         * @return ListFeatureViewOnlineFeaturesResponse
         */
        public ListFeatureViewOnlineFeaturesResponse ListFeatureViewOnlineFeatures(string InstanceId, string FeatureViewId, ListFeatureViewOnlineFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureViewOnlineFeaturesWithOptions(InstanceId, FeatureViewId, request, headers, runtime);
        }

        /**
         * @summary 获取特征视图下的在线特征数据。
         *
         * @param request ListFeatureViewOnlineFeaturesRequest
         * @return ListFeatureViewOnlineFeaturesResponse
         */
        public async Task<ListFeatureViewOnlineFeaturesResponse> ListFeatureViewOnlineFeaturesAsync(string InstanceId, string FeatureViewId, ListFeatureViewOnlineFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureViewOnlineFeaturesWithOptionsAsync(InstanceId, FeatureViewId, request, headers, runtime);
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewRelationshipsResponse
         */
        public ListFeatureViewRelationshipsResponse ListFeatureViewRelationshipsWithOptions(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewRelationships",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/relationships",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewRelationshipsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewRelationshipsResponse
         */
        public async Task<ListFeatureViewRelationshipsResponse> ListFeatureViewRelationshipsWithOptionsAsync(string InstanceId, string FeatureViewId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViewRelationships",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/relationships",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewRelationshipsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @return ListFeatureViewRelationshipsResponse
         */
        public ListFeatureViewRelationshipsResponse ListFeatureViewRelationships(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureViewRelationshipsWithOptions(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @return ListFeatureViewRelationshipsResponse
         */
        public async Task<ListFeatureViewRelationshipsResponse> ListFeatureViewRelationshipsAsync(string InstanceId, string FeatureViewId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureViewRelationshipsWithOptionsAsync(InstanceId, FeatureViewId, headers, runtime);
        }

        /**
         * @summary 获取特征视图列表。
         *
         * @param tmpReq ListFeatureViewsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewsResponse
         */
        public ListFeatureViewsResponse ListFeatureViewsWithOptions(string InstanceId, ListFeatureViewsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureViewsShrinkRequest request = new ListFeatureViewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureViewIds))
            {
                request.FeatureViewIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureViewIds, "FeatureViewIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureViewIdsShrink))
            {
                query["FeatureViewIds"] = request.FeatureViewIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViews",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图列表。
         *
         * @param tmpReq ListFeatureViewsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureViewsResponse
         */
        public async Task<ListFeatureViewsResponse> ListFeatureViewsWithOptionsAsync(string InstanceId, ListFeatureViewsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureViewsShrinkRequest request = new ListFeatureViewsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FeatureViewIds))
            {
                request.FeatureViewIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FeatureViewIds, "FeatureViewIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureViewIdsShrink))
            {
                query["FeatureViewIds"] = request.FeatureViewIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureViews",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图列表。
         *
         * @param request ListFeatureViewsRequest
         * @return ListFeatureViewsResponse
         */
        public ListFeatureViewsResponse ListFeatureViews(string InstanceId, ListFeatureViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureViewsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取特征视图列表。
         *
         * @param request ListFeatureViewsRequest
         * @return ListFeatureViewsResponse
         */
        public async Task<ListFeatureViewsResponse> ListFeatureViewsAsync(string InstanceId, ListFeatureViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureViewsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取Feature Store实例列表。
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Feature Store实例列表。
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Feature Store实例列表。
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
         * @summary 获取Feature Store实例列表。
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
         * @summary 获取Label表列表。
         *
         * @param tmpReq ListLabelTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLabelTablesResponse
         */
        public ListLabelTablesResponse ListLabelTablesWithOptions(string InstanceId, ListLabelTablesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListLabelTablesShrinkRequest request = new ListLabelTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelTableIds))
            {
                request.LabelTableIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelTableIds, "LabelTableIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableIdsShrink))
            {
                query["LabelTableIds"] = request.LabelTableIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLabelTables",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLabelTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Label表列表。
         *
         * @param tmpReq ListLabelTablesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLabelTablesResponse
         */
        public async Task<ListLabelTablesResponse> ListLabelTablesWithOptionsAsync(string InstanceId, ListLabelTablesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListLabelTablesShrinkRequest request = new ListLabelTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelTableIds))
            {
                request.LabelTableIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelTableIds, "LabelTableIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableIdsShrink))
            {
                query["LabelTableIds"] = request.LabelTableIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLabelTables",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLabelTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Label表列表。
         *
         * @param request ListLabelTablesRequest
         * @return ListLabelTablesResponse
         */
        public ListLabelTablesResponse ListLabelTables(string InstanceId, ListLabelTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLabelTablesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取Label表列表。
         *
         * @param request ListLabelTablesRequest
         * @return ListLabelTablesResponse
         */
        public async Task<ListLabelTablesResponse> ListLabelTablesAsync(string InstanceId, ListLabelTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLabelTablesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取注册FG特征时模型特征下可选的所有特征。
         *
         * @param request ListModelFeatureAvailableFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListModelFeatureAvailableFeaturesResponse
         */
        public ListModelFeatureAvailableFeaturesResponse ListModelFeatureAvailableFeaturesWithOptions(string InstanceId, string ModelFeatureId, ListModelFeatureAvailableFeaturesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelFeatureAvailableFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/availablefeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelFeatureAvailableFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取注册FG特征时模型特征下可选的所有特征。
         *
         * @param request ListModelFeatureAvailableFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListModelFeatureAvailableFeaturesResponse
         */
        public async Task<ListModelFeatureAvailableFeaturesResponse> ListModelFeatureAvailableFeaturesWithOptionsAsync(string InstanceId, string ModelFeatureId, ListModelFeatureAvailableFeaturesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelFeatureAvailableFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/availablefeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelFeatureAvailableFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取注册FG特征时模型特征下可选的所有特征。
         *
         * @param request ListModelFeatureAvailableFeaturesRequest
         * @return ListModelFeatureAvailableFeaturesResponse
         */
        public ListModelFeatureAvailableFeaturesResponse ListModelFeatureAvailableFeatures(string InstanceId, string ModelFeatureId, ListModelFeatureAvailableFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelFeatureAvailableFeaturesWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 获取注册FG特征时模型特征下可选的所有特征。
         *
         * @param request ListModelFeatureAvailableFeaturesRequest
         * @return ListModelFeatureAvailableFeaturesResponse
         */
        public async Task<ListModelFeatureAvailableFeaturesResponse> ListModelFeatureAvailableFeaturesAsync(string InstanceId, string ModelFeatureId, ListModelFeatureAvailableFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelFeatureAvailableFeaturesWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 获取模型特征列表。
         *
         * @param tmpReq ListModelFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListModelFeaturesResponse
         */
        public ListModelFeaturesResponse ListModelFeaturesWithOptions(string InstanceId, ListModelFeaturesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelFeaturesShrinkRequest request = new ListModelFeaturesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelFeatureIds))
            {
                request.ModelFeatureIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelFeatureIds, "ModelFeatureIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelFeatureIdsShrink))
            {
                query["ModelFeatureIds"] = request.ModelFeatureIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelFeaturesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征列表。
         *
         * @param tmpReq ListModelFeaturesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListModelFeaturesResponse
         */
        public async Task<ListModelFeaturesResponse> ListModelFeaturesWithOptionsAsync(string InstanceId, ListModelFeaturesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelFeaturesShrinkRequest request = new ListModelFeaturesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelFeatureIds))
            {
                request.ModelFeatureIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelFeatureIds, "ModelFeatureIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelFeatureIdsShrink))
            {
                query["ModelFeatureIds"] = request.ModelFeatureIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelFeatures",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelFeaturesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模型特征列表。
         *
         * @param request ListModelFeaturesRequest
         * @return ListModelFeaturesResponse
         */
        public ListModelFeaturesResponse ListModelFeatures(string InstanceId, ListModelFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelFeaturesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取模型特征列表。
         *
         * @param request ListModelFeaturesRequest
         * @return ListModelFeaturesResponse
         */
        public async Task<ListModelFeaturesResponse> ListModelFeaturesAsync(string InstanceId, ListModelFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelFeaturesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取项目下的所有特征视图、特征信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectFeatureViewsResponse
         */
        public ListProjectFeatureViewsResponse ListProjectFeatureViewsWithOptions(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectFeatureViews",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/featureviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectFeatureViewsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取项目下的所有特征视图、特征信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectFeatureViewsResponse
         */
        public async Task<ListProjectFeatureViewsResponse> ListProjectFeatureViewsWithOptionsAsync(string InstanceId, string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectFeatureViews",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/featureviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectFeatureViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目下的所有特征视图、特征信息。
         *
         * @return ListProjectFeatureViewsResponse
         */
        public ListProjectFeatureViewsResponse ListProjectFeatureViews(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectFeatureViewsWithOptions(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 获取项目下的所有特征视图、特征信息。
         *
         * @return ListProjectFeatureViewsResponse
         */
        public async Task<ListProjectFeatureViewsResponse> ListProjectFeatureViewsAsync(string InstanceId, string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectFeatureViewsWithOptionsAsync(InstanceId, ProjectId, headers, runtime);
        }

        /**
         * @summary 获取Feature Store项目列表。
         *
         * @param tmpReq ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(string InstanceId, ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProjectIds))
            {
                request.ProjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProjectIds, "ProjectIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdsShrink))
            {
                query["ProjectIds"] = request.ProjectIdsShrink;
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
                Action = "ListProjects",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Feature Store项目列表。
         *
         * @param tmpReq ListProjectsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(string InstanceId, ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ProjectIds))
            {
                request.ProjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ProjectIds, "ProjectIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdsShrink))
            {
                query["ProjectIds"] = request.ProjectIdsShrink;
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
                Action = "ListProjects",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Feature Store项目列表。
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(string InstanceId, ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取Feature Store项目列表。
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(string InstanceId, ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取任务日志列表
         *
         * @param request ListTaskLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskLogsResponse
         */
        public ListTaskLogsResponse ListTaskLogsWithOptions(string InstanceId, string TaskId, ListTaskLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTaskLogs",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务日志列表
         *
         * @param request ListTaskLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskLogsResponse
         */
        public async Task<ListTaskLogsResponse> ListTaskLogsWithOptionsAsync(string InstanceId, string TaskId, ListTaskLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTaskLogs",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务日志列表
         *
         * @param request ListTaskLogsRequest
         * @return ListTaskLogsResponse
         */
        public ListTaskLogsResponse ListTaskLogs(string InstanceId, string TaskId, ListTaskLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTaskLogsWithOptions(InstanceId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务日志列表
         *
         * @param request ListTaskLogsRequest
         * @return ListTaskLogsResponse
         */
        public async Task<ListTaskLogsResponse> ListTaskLogsAsync(string InstanceId, string TaskId, ListTaskLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTaskLogsWithOptionsAsync(InstanceId, TaskId, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表
         *
         * @param tmpReq ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasksWithOptions(string InstanceId, ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIds))
            {
                request.TaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIds, "TaskIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdsShrink))
            {
                query["TaskIds"] = request.TaskIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表
         *
         * @param tmpReq ListTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(string InstanceId, ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskIds))
            {
                request.TaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskIds, "TaskIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIdsShrink))
            {
                query["TaskIds"] = request.TaskIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasks(string InstanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksAsync(string InstanceId, ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 将特征视图的离线数据发布/同步到线上。
         *
         * @param request PublishFeatureViewTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFeatureViewTableResponse
         */
        public PublishFeatureViewTableResponse PublishFeatureViewTableWithOptions(string InstanceId, string FeatureViewId, PublishFeatureViewTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTime))
            {
                body["EventTime"] = request.EventTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineToOnline))
            {
                body["OfflineToOnline"] = request.OfflineToOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["Partitions"] = request.Partitions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFeatureViewTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/action/publishtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFeatureViewTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 将特征视图的离线数据发布/同步到线上。
         *
         * @param request PublishFeatureViewTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishFeatureViewTableResponse
         */
        public async Task<PublishFeatureViewTableResponse> PublishFeatureViewTableWithOptionsAsync(string InstanceId, string FeatureViewId, PublishFeatureViewTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTime))
            {
                body["EventTime"] = request.EventTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfflineToOnline))
            {
                body["OfflineToOnline"] = request.OfflineToOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["Partitions"] = request.Partitions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFeatureViewTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/action/publishtable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFeatureViewTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 将特征视图的离线数据发布/同步到线上。
         *
         * @param request PublishFeatureViewTableRequest
         * @return PublishFeatureViewTableResponse
         */
        public PublishFeatureViewTableResponse PublishFeatureViewTable(string InstanceId, string FeatureViewId, PublishFeatureViewTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishFeatureViewTableWithOptions(InstanceId, FeatureViewId, request, headers, runtime);
        }

        /**
         * @summary 将特征视图的离线数据发布/同步到线上。
         *
         * @param request PublishFeatureViewTableRequest
         * @return PublishFeatureViewTableResponse
         */
        public async Task<PublishFeatureViewTableResponse> PublishFeatureViewTableAsync(string InstanceId, string FeatureViewId, PublishFeatureViewTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishFeatureViewTableWithOptionsAsync(InstanceId, FeatureViewId, request, headers, runtime);
        }

        /**
         * @summary 更新数据源信息。
         *
         * @param request UpdateDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDatasourceResponse
         */
        public UpdateDatasourceResponse UpdateDatasourceWithOptions(string InstanceId, string DatasourceId, UpdateDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新数据源信息。
         *
         * @param request UpdateDatasourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDatasourceResponse
         */
        public async Task<UpdateDatasourceResponse> UpdateDatasourceWithOptionsAsync(string InstanceId, string DatasourceId, UpdateDatasourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasource",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新数据源信息。
         *
         * @param request UpdateDatasourceRequest
         * @return UpdateDatasourceResponse
         */
        public UpdateDatasourceResponse UpdateDatasource(string InstanceId, string DatasourceId, UpdateDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasourceWithOptions(InstanceId, DatasourceId, request, headers, runtime);
        }

        /**
         * @summary 更新数据源信息。
         *
         * @param request UpdateDatasourceRequest
         * @return UpdateDatasourceResponse
         */
        public async Task<UpdateDatasourceResponse> UpdateDatasourceAsync(string InstanceId, string DatasourceId, UpdateDatasourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasourceWithOptionsAsync(InstanceId, DatasourceId, request, headers, runtime);
        }

        /**
         * @summary 更新label表。
         *
         * @param request UpdateLabelTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLabelTableResponse
         */
        public UpdateLabelTableResponse UpdateLabelTableWithOptions(string InstanceId, string LabelTableId, UpdateLabelTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                body["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLabelTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新label表。
         *
         * @param request UpdateLabelTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLabelTableResponse
         */
        public async Task<UpdateLabelTableResponse> UpdateLabelTableWithOptionsAsync(string InstanceId, string LabelTableId, UpdateLabelTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasourceId))
            {
                body["DatasourceId"] = request.DatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLabelTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/labeltables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelTableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLabelTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新label表。
         *
         * @param request UpdateLabelTableRequest
         * @return UpdateLabelTableResponse
         */
        public UpdateLabelTableResponse UpdateLabelTable(string InstanceId, string LabelTableId, UpdateLabelTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLabelTableWithOptions(InstanceId, LabelTableId, request, headers, runtime);
        }

        /**
         * @summary 更新label表。
         *
         * @param request UpdateLabelTableRequest
         * @return UpdateLabelTableResponse
         */
        public async Task<UpdateLabelTableResponse> UpdateLabelTableAsync(string InstanceId, string LabelTableId, UpdateLabelTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLabelTableWithOptionsAsync(InstanceId, LabelTableId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征。
         *
         * @param request UpdateModelFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureResponse
         */
        public UpdateModelFeatureResponse UpdateModelFeatureWithOptions(string InstanceId, string ModelFeatureId, UpdateModelFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableId))
            {
                body["LabelTableId"] = request.LabelTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatureViewIds))
            {
                body["SequenceFeatureViewIds"] = request.SequenceFeatureViewIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征。
         *
         * @param request UpdateModelFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureResponse
         */
        public async Task<UpdateModelFeatureResponse> UpdateModelFeatureWithOptionsAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTableId))
            {
                body["LabelTableId"] = request.LabelTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatureViewIds))
            {
                body["SequenceFeatureViewIds"] = request.SequenceFeatureViewIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征。
         *
         * @param request UpdateModelFeatureRequest
         * @return UpdateModelFeatureResponse
         */
        public UpdateModelFeatureResponse UpdateModelFeature(string InstanceId, string ModelFeatureId, UpdateModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelFeatureWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征。
         *
         * @param request UpdateModelFeatureRequest
         * @return UpdateModelFeatureResponse
         */
        public async Task<UpdateModelFeatureResponse> UpdateModelFeatureAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelFeatureWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征的FG特征配置信息。
         *
         * @param request UpdateModelFeatureFGFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureFGFeatureResponse
         */
        public UpdateModelFeatureFGFeatureResponse UpdateModelFeatureFGFeatureWithOptions(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LookupFeatures))
            {
                body["LookupFeatures"] = request.LookupFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawFeatures))
            {
                body["RawFeatures"] = request.RawFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserves))
            {
                body["Reserves"] = request.Reserves;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatures))
            {
                body["SequenceFeatures"] = request.SequenceFeatures;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeatureFGFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fgfeature",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureFGFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征的FG特征配置信息。
         *
         * @param request UpdateModelFeatureFGFeatureRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureFGFeatureResponse
         */
        public async Task<UpdateModelFeatureFGFeatureResponse> UpdateModelFeatureFGFeatureWithOptionsAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGFeatureRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LookupFeatures))
            {
                body["LookupFeatures"] = request.LookupFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawFeatures))
            {
                body["RawFeatures"] = request.RawFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reserves))
            {
                body["Reserves"] = request.Reserves;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFeatures))
            {
                body["SequenceFeatures"] = request.SequenceFeatures;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeatureFGFeature",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fgfeature",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureFGFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征的FG特征配置信息。
         *
         * @param request UpdateModelFeatureFGFeatureRequest
         * @return UpdateModelFeatureFGFeatureResponse
         */
        public UpdateModelFeatureFGFeatureResponse UpdateModelFeatureFGFeature(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelFeatureFGFeatureWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征的FG特征配置信息。
         *
         * @param request UpdateModelFeatureFGFeatureRequest
         * @return UpdateModelFeatureFGFeatureResponse
         */
        public async Task<UpdateModelFeatureFGFeatureResponse> UpdateModelFeatureFGFeatureAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelFeatureFGFeatureWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征的fg.json文件配置信息。
         *
         * @param request UpdateModelFeatureFGInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureFGInfoResponse
         */
        public UpdateModelFeatureFGInfoResponse UpdateModelFeatureFGInfoWithOptions(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeatureFGInfo",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fginfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureFGInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征的fg.json文件配置信息。
         *
         * @param request UpdateModelFeatureFGInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateModelFeatureFGInfoResponse
         */
        public async Task<UpdateModelFeatureFGInfoResponse> UpdateModelFeatureFGInfoWithOptionsAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelFeatureFGInfo",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/modelfeatures/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelFeatureId) + "/fginfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelFeatureFGInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新模型特征的fg.json文件配置信息。
         *
         * @param request UpdateModelFeatureFGInfoRequest
         * @return UpdateModelFeatureFGInfoResponse
         */
        public UpdateModelFeatureFGInfoResponse UpdateModelFeatureFGInfo(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelFeatureFGInfoWithOptions(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新模型特征的fg.json文件配置信息。
         *
         * @param request UpdateModelFeatureFGInfoRequest
         * @return UpdateModelFeatureFGInfoResponse
         */
        public async Task<UpdateModelFeatureFGInfoResponse> UpdateModelFeatureFGInfoAsync(string InstanceId, string ModelFeatureId, UpdateModelFeatureFGInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelFeatureFGInfoWithOptionsAsync(InstanceId, ModelFeatureId, request, headers, runtime);
        }

        /**
         * @summary 更新指定Feature Store项目信息。
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProjectWithOptions(string InstanceId, string ProjectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新指定Feature Store项目信息。
         *
         * @param request UpdateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string InstanceId, string ProjectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新指定Feature Store项目信息。
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProject(string InstanceId, string ProjectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(InstanceId, ProjectId, request, headers, runtime);
        }

        /**
         * @summary 更新指定Feature Store项目信息。
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string InstanceId, string ProjectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(InstanceId, ProjectId, request, headers, runtime);
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param request WriteFeatureViewTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteFeatureViewTableResponse
         */
        public WriteFeatureViewTableResponse WriteFeatureViewTableWithOptions(string InstanceId, string FeatureViewId, WriteFeatureViewTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["Partitions"] = request.Partitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlDatasource))
            {
                body["UrlDatasource"] = request.UrlDatasource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteFeatureViewTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/action/writetable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteFeatureViewTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param request WriteFeatureViewTableRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return WriteFeatureViewTableResponse
         */
        public async Task<WriteFeatureViewTableResponse> WriteFeatureViewTableWithOptionsAsync(string InstanceId, string FeatureViewId, WriteFeatureViewTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["Partitions"] = request.Partitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlDatasource))
            {
                body["UrlDatasource"] = request.UrlDatasource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WriteFeatureViewTable",
                Version = "2023-06-21",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/featureviews/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureViewId) + "/action/writetable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WriteFeatureViewTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param request WriteFeatureViewTableRequest
         * @return WriteFeatureViewTableResponse
         */
        public WriteFeatureViewTableResponse WriteFeatureViewTable(string InstanceId, string FeatureViewId, WriteFeatureViewTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WriteFeatureViewTableWithOptions(InstanceId, FeatureViewId, request, headers, runtime);
        }

        /**
         * @summary 获取特征视图血缘关系。
         *
         * @param request WriteFeatureViewTableRequest
         * @return WriteFeatureViewTableResponse
         */
        public async Task<WriteFeatureViewTableResponse> WriteFeatureViewTableAsync(string InstanceId, string FeatureViewId, WriteFeatureViewTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WriteFeatureViewTableWithOptionsAsync(InstanceId, FeatureViewId, request, headers, runtime);
        }

    }
}
