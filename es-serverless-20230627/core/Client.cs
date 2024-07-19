// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Es_serverless20230627.Models;

namespace AlibabaCloud.SDK.Es_serverless20230627
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("es-serverless", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 撤销规格审批
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelSpecReviewTaskResponse
         */
        public CancelSpecReviewTaskResponse CancelSpecReviewTaskWithOptions(string appName, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSpecReviewTask",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSpecReviewTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 撤销规格审批
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelSpecReviewTaskResponse
         */
        public async Task<CancelSpecReviewTaskResponse> CancelSpecReviewTaskWithOptionsAsync(string appName, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSpecReviewTask",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSpecReviewTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 撤销规格审批
         *
         * @return CancelSpecReviewTaskResponse
         */
        public CancelSpecReviewTaskResponse CancelSpecReviewTask(string appName, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelSpecReviewTaskWithOptions(appName, taskId, headers, runtime);
        }

        /**
         * @summary 撤销规格审批
         *
         * @return CancelSpecReviewTaskResponse
         */
        public async Task<CancelSpecReviewTaskResponse> CancelSpecReviewTaskAsync(string appName, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelSpecReviewTaskWithOptionsAsync(appName, taskId, headers, runtime);
        }

        /**
         * @summary 创建Serverless应用
         *
         * @param request CreateAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                body["authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateNetwork))
            {
                body["privateNetwork"] = request.PrivateNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaInfo))
            {
                body["quotaInfo"] = request.QuotaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建Serverless应用
         *
         * @param request CreateAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                body["authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["chargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateNetwork))
            {
                body["privateNetwork"] = request.PrivateNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaInfo))
            {
                body["quotaInfo"] = request.QuotaInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Serverless应用
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建Serverless应用
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建端点
         *
         * @param request CreateEndpointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEndpointResponse
         */
        public CreateEndpointResponse CreateEndpointWithOptions(CreateEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointZones))
            {
                body["endpointZones"] = request.EndpointZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建端点
         *
         * @param request CreateEndpointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEndpointResponse
         */
        public async Task<CreateEndpointResponse> CreateEndpointWithOptionsAsync(CreateEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointZones))
            {
                body["endpointZones"] = request.EndpointZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建端点
         *
         * @param request CreateEndpointRequest
         * @return CreateEndpointResponse
         */
        public CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEndpointWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建端点
         *
         * @param request CreateEndpointRequest
         * @return CreateEndpointResponse
         */
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEndpointWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建快照
         *
         * @param request CreateSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSnapshotResponse
         */
        public CreateSnapshotResponse CreateSnapshotWithOptions(string appName, string repository, CreateSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indices))
            {
                body["indices"] = request.Indices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Snapshot))
            {
                body["snapshot"] = request.Snapshot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repository) + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建快照
         *
         * @param request CreateSnapshotRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSnapshotResponse
         */
        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(string appName, string repository, CreateSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indices))
            {
                body["indices"] = request.Indices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Snapshot))
            {
                body["snapshot"] = request.Snapshot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSnapshot",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repository) + "/snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建快照
         *
         * @param request CreateSnapshotRequest
         * @return CreateSnapshotResponse
         */
        public CreateSnapshotResponse CreateSnapshot(string appName, string repository, CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSnapshotWithOptions(appName, repository, request, headers, runtime);
        }

        /**
         * @summary 创建快照
         *
         * @param request CreateSnapshotRequest
         * @return CreateSnapshotResponse
         */
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(string appName, string repository, CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSnapshotWithOptionsAsync(appName, repository, request, headers, runtime);
        }

        /**
         * @summary 删除Serverless应用。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
        public DeleteAppResponse DeleteAppWithOptions(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除Serverless应用。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除Serverless应用。
         *
         * @return DeleteAppResponse
         */
        public DeleteAppResponse DeleteApp(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppWithOptions(appName, headers, runtime);
        }

        /**
         * @summary 删除Serverless应用。
         *
         * @return DeleteAppResponse
         */
        public async Task<DeleteAppResponse> DeleteAppAsync(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppWithOptionsAsync(appName, headers, runtime);
        }

        /**
         * @summary 删除词典
         *
         * @param request DeleteDictRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDictResponse
         */
        public DeleteDictResponse DeleteDictWithOptions(string appName, DeleteDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "DeleteDict",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts/actions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDictResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除词典
         *
         * @param request DeleteDictRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDictResponse
         */
        public async Task<DeleteDictResponse> DeleteDictWithOptionsAsync(string appName, DeleteDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "DeleteDict",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts/actions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDictResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除词典
         *
         * @param request DeleteDictRequest
         * @return DeleteDictResponse
         */
        public DeleteDictResponse DeleteDict(string appName, DeleteDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDictWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 删除词典
         *
         * @param request DeleteDictRequest
         * @return DeleteDictResponse
         */
        public async Task<DeleteDictResponse> DeleteDictAsync(string appName, DeleteDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDictWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 删除端点
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEndpointResponse
         */
        public DeleteEndpointResponse DeleteEndpointWithOptions(string endpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(endpointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除端点
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEndpointResponse
         */
        public async Task<DeleteEndpointResponse> DeleteEndpointWithOptionsAsync(string endpointId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(endpointId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除端点
         *
         * @return DeleteEndpointResponse
         */
        public DeleteEndpointResponse DeleteEndpoint(string endpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEndpointWithOptions(endpointId, headers, runtime);
        }

        /**
         * @summary 删除端点
         *
         * @return DeleteEndpointResponse
         */
        public async Task<DeleteEndpointResponse> DeleteEndpointAsync(string endpointId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEndpointWithOptionsAsync(endpointId, headers, runtime);
        }

        /**
         * @summary 删除快照
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshotWithOptions(string appName, string repository, string snapshot, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repository) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(snapshot),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除快照
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(string appName, string repository, string snapshot, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repository) + "/snapshots/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(snapshot),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除快照
         *
         * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshot(string appName, string repository, string snapshot)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSnapshotWithOptions(appName, repository, snapshot, headers, runtime);
        }

        /**
         * @summary 删除快照
         *
         * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(string appName, string repository, string snapshot)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSnapshotWithOptionsAsync(appName, repository, snapshot, headers, runtime);
        }

        /**
         * @summary 获取Serverless应用详情
         *
         * @param request GetAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
        public GetAppResponse GetAppWithOptions(string appName, GetAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detailed))
            {
                query["detailed"] = request.Detailed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Serverless应用详情
         *
         * @param request GetAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
        public async Task<GetAppResponse> GetAppWithOptionsAsync(string appName, GetAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detailed))
            {
                query["detailed"] = request.Detailed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Serverless应用详情
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public GetAppResponse GetApp(string appName, GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 获取Serverless应用详情
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public async Task<GetAppResponse> GetAppAsync(string appName, GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 获取Serverless应用配额详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppQuotaResponse
         */
        public GetAppQuotaResponse GetAppQuotaWithOptions(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppQuota",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取Serverless应用配额详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppQuotaResponse
         */
        public async Task<GetAppQuotaResponse> GetAppQuotaWithOptionsAsync(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppQuota",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Serverless应用配额详情
         *
         * @return GetAppQuotaResponse
         */
        public GetAppQuotaResponse GetAppQuota(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppQuotaWithOptions(appName, headers, runtime);
        }

        /**
         * @summary 获取Serverless应用配额详情
         *
         * @return GetAppQuotaResponse
         */
        public async Task<GetAppQuotaResponse> GetAppQuotaAsync(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppQuotaWithOptionsAsync(appName, headers, runtime);
        }

        /**
         * @summary 获取监控数据
         *
         * @param request GetMonitorDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMonitorDataResponse
         */
        public GetMonitorDataResponse GetMonitorDataWithOptions(GetMonitorDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonitorData",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/emon/metrics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonitorDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取监控数据
         *
         * @param request GetMonitorDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMonitorDataResponse
         */
        public async Task<GetMonitorDataResponse> GetMonitorDataWithOptionsAsync(GetMonitorDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonitorData",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/emon/metrics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonitorDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取监控数据
         *
         * @param request GetMonitorDataRequest
         * @return GetMonitorDataResponse
         */
        public GetMonitorDataResponse GetMonitorData(GetMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMonitorDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取监控数据
         *
         * @param request GetMonitorDataRequest
         * @return GetMonitorDataResponse
         */
        public async Task<GetMonitorDataResponse> GetMonitorDataAsync(GetMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMonitorDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取自动备份配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotSettingResponse
         */
        public GetSnapshotSettingResponse GetSnapshotSettingWithOptions(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotSetting",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/auto-snapshot-setting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取自动备份配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotSettingResponse
         */
        public async Task<GetSnapshotSettingResponse> GetSnapshotSettingWithOptionsAsync(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotSetting",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/auto-snapshot-setting",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取自动备份配置
         *
         * @return GetSnapshotSettingResponse
         */
        public GetSnapshotSettingResponse GetSnapshotSetting(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSnapshotSettingWithOptions(appName, headers, runtime);
        }

        /**
         * @summary 获取自动备份配置
         *
         * @return GetSnapshotSettingResponse
         */
        public async Task<GetSnapshotSettingResponse> GetSnapshotSettingAsync(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSnapshotSettingWithOptionsAsync(appName, headers, runtime);
        }

        /**
         * @summary 获取配额审批详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpecReviewTaskResponse
         */
        public GetSpecReviewTaskResponse GetSpecReviewTaskWithOptions(string appName, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpecReviewTask",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpecReviewTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取配额审批详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpecReviewTaskResponse
         */
        public async Task<GetSpecReviewTaskResponse> GetSpecReviewTaskWithOptionsAsync(string appName, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpecReviewTask",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpecReviewTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取配额审批详情
         *
         * @return GetSpecReviewTaskResponse
         */
        public GetSpecReviewTaskResponse GetSpecReviewTask(string appName, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSpecReviewTaskWithOptions(appName, taskId, headers, runtime);
        }

        /**
         * @summary 获取配额审批详情
         *
         * @return GetSpecReviewTaskResponse
         */
        public async Task<GetSpecReviewTaskResponse> GetSpecReviewTaskAsync(string appName, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSpecReviewTaskWithOptionsAsync(appName, taskId, headers, runtime);
        }

        /**
         * @summary 查看Serverless应用列表
         *
         * @param request ListAppsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppsResponse
         */
        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApps",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看Serverless应用列表
         *
         * @param request ListAppsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppsResponse
         */
        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListApps",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看Serverless应用列表
         *
         * @param request ListAppsRequest
         * @return ListAppsResponse
         */
        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查看Serverless应用列表
         *
         * @param request ListAppsRequest
         * @return ListAppsResponse
         */
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取词典列表
         *
         * @param request ListDictsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDictsResponse
         */
        public ListDictsResponse ListDictsWithOptions(string appName, ListDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListDicts",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDictsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取词典列表
         *
         * @param request ListDictsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDictsResponse
         */
        public async Task<ListDictsResponse> ListDictsWithOptionsAsync(string appName, ListDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
                Action = "ListDicts",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDictsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取词典列表
         *
         * @param request ListDictsRequest
         * @return ListDictsResponse
         */
        public ListDictsResponse ListDicts(string appName, ListDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDictsWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 获取词典列表
         *
         * @param request ListDictsRequest
         * @return ListDictsResponse
         */
        public async Task<ListDictsResponse> ListDictsAsync(string appName, ListDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDictsWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 获取端点信息列表
         *
         * @param request ListEndpointsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEndpointsResponse
         */
        public ListEndpointsResponse ListEndpointsWithOptions(ListEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEndpoints",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取端点信息列表
         *
         * @param request ListEndpointsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEndpointsResponse
         */
        public async Task<ListEndpointsResponse> ListEndpointsWithOptionsAsync(ListEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEndpoints",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取端点信息列表
         *
         * @param request ListEndpointsRequest
         * @return ListEndpointsResponse
         */
        public ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEndpointsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取端点信息列表
         *
         * @param request ListEndpointsRequest
         * @return ListEndpointsResponse
         */
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEndpointsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查看索引列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndicesResponse
         */
        public ListIndicesResponse ListIndicesWithOptions(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看索引列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIndicesResponse
         */
        public async Task<ListIndicesResponse> ListIndicesWithOptionsAsync(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndices",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/indices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看索引列表
         *
         * @return ListIndicesResponse
         */
        public ListIndicesResponse ListIndices(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndicesWithOptions(appName, headers, runtime);
        }

        /**
         * @summary 查看索引列表
         *
         * @return ListIndicesResponse
         */
        public async Task<ListIndicesResponse> ListIndicesAsync(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndicesWithOptionsAsync(appName, headers, runtime);
        }

        /**
         * @summary 获取快照仓库列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotRepositoriesResponse
         */
        public ListSnapshotRepositoriesResponse ListSnapshotRepositoriesWithOptions(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshotRepositories",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取快照仓库列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotRepositoriesResponse
         */
        public async Task<ListSnapshotRepositoriesResponse> ListSnapshotRepositoriesWithOptionsAsync(string appName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshotRepositories",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshot-repositories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取快照仓库列表
         *
         * @return ListSnapshotRepositoriesResponse
         */
        public ListSnapshotRepositoriesResponse ListSnapshotRepositories(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSnapshotRepositoriesWithOptions(appName, headers, runtime);
        }

        /**
         * @summary 获取快照仓库列表
         *
         * @return ListSnapshotRepositoriesResponse
         */
        public async Task<ListSnapshotRepositoriesResponse> ListSnapshotRepositoriesAsync(string appName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSnapshotRepositoriesWithOptionsAsync(appName, headers, runtime);
        }

        /**
         * @summary 获取仓库的快照列表
         *
         * @param request ListSnapshotsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotsResponse
         */
        public ListSnapshotsResponse ListSnapshotsWithOptions(string appName, ListSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repository))
            {
                query["repository"] = request.Repository;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Snapshot))
            {
                query["snapshot"] = request.Snapshot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取仓库的快照列表
         *
         * @param request ListSnapshotsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotsResponse
         */
        public async Task<ListSnapshotsResponse> ListSnapshotsWithOptionsAsync(string appName, ListSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repository))
            {
                query["repository"] = request.Repository;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Snapshot))
            {
                query["snapshot"] = request.Snapshot;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取仓库的快照列表
         *
         * @param request ListSnapshotsRequest
         * @return ListSnapshotsResponse
         */
        public ListSnapshotsResponse ListSnapshots(string appName, ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSnapshotsWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 获取仓库的快照列表
         *
         * @param request ListSnapshotsRequest
         * @return ListSnapshotsResponse
         */
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(string appName, ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSnapshotsWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 获取规格审批列表
         *
         * @param request ListSpecReviewTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSpecReviewTasksResponse
         */
        public ListSpecReviewTasksResponse ListSpecReviewTasksWithOptions(string appName, ListSpecReviewTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListSpecReviewTasks",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpecReviewTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取规格审批列表
         *
         * @param request ListSpecReviewTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSpecReviewTasksResponse
         */
        public async Task<ListSpecReviewTasksResponse> ListSpecReviewTasksWithOptionsAsync(string appName, ListSpecReviewTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListSpecReviewTasks",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/spec-review-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpecReviewTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取规格审批列表
         *
         * @param request ListSpecReviewTasksRequest
         * @return ListSpecReviewTasksResponse
         */
        public ListSpecReviewTasksResponse ListSpecReviewTasks(string appName, ListSpecReviewTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSpecReviewTasksWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 获取规格审批列表
         *
         * @param request ListSpecReviewTasksRequest
         * @return ListSpecReviewTasksResponse
         */
        public async Task<ListSpecReviewTasksResponse> ListSpecReviewTasksAsync(string appName, ListSpecReviewTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSpecReviewTasksWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 编辑Serverless应用
         *
         * @param request UpdateAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppResponse
         */
        public UpdateAppResponse UpdateAppWithOptions(string appName, UpdateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReason))
            {
                body["applyReason"] = request.ApplyReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                body["authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimiterInfo))
            {
                body["limiterInfo"] = request.LimiterInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateNetwork))
            {
                body["privateNetwork"] = request.PrivateNetwork;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑Serverless应用
         *
         * @param request UpdateAppRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppResponse
         */
        public async Task<UpdateAppResponse> UpdateAppWithOptionsAsync(string appName, UpdateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyReason))
            {
                body["applyReason"] = request.ApplyReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                body["authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimiterInfo))
            {
                body["limiterInfo"] = request.LimiterInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                body["network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateNetwork))
            {
                body["privateNetwork"] = request.PrivateNetwork;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApp",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑Serverless应用
         *
         * @param request UpdateAppRequest
         * @return UpdateAppResponse
         */
        public UpdateAppResponse UpdateApp(string appName, UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 编辑Serverless应用
         *
         * @param request UpdateAppRequest
         * @return UpdateAppResponse
         */
        public async Task<UpdateAppResponse> UpdateAppAsync(string appName, UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 创建或更新词典
         *
         * @param request UpdateDictRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDictResponse
         */
        public UpdateDictResponse UpdateDictWithOptions(string appName, UpdateDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCover))
            {
                query["allowCover"] = request.AllowCover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
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
                Action = "UpdateDict",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDictResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建或更新词典
         *
         * @param request UpdateDictRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDictResponse
         */
        public async Task<UpdateDictResponse> UpdateDictWithOptionsAsync(string appName, UpdateDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCover))
            {
                query["allowCover"] = request.AllowCover;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
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
                Action = "UpdateDict",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/dicts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDictResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建或更新词典
         *
         * @param request UpdateDictRequest
         * @return UpdateDictResponse
         */
        public UpdateDictResponse UpdateDict(string appName, UpdateDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDictWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 创建或更新词典
         *
         * @param request UpdateDictRequest
         * @return UpdateDictResponse
         */
        public async Task<UpdateDictResponse> UpdateDictAsync(string appName, UpdateDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDictWithOptionsAsync(appName, request, headers, runtime);
        }

        /**
         * @summary 修改端点信息
         *
         * @param request UpdateEndpointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEndpointResponse
         */
        public UpdateEndpointResponse UpdateEndpointWithOptions(string endpointId, UpdateEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointZones))
            {
                body["endpointZones"] = request.EndpointZones;
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
                Action = "UpdateEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(endpointId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改端点信息
         *
         * @param request UpdateEndpointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEndpointResponse
         */
        public async Task<UpdateEndpointResponse> UpdateEndpointWithOptionsAsync(string endpointId, UpdateEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointZones))
            {
                body["endpointZones"] = request.EndpointZones;
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
                Action = "UpdateEndpoint",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/endpoints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(endpointId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改端点信息
         *
         * @param request UpdateEndpointRequest
         * @return UpdateEndpointResponse
         */
        public UpdateEndpointResponse UpdateEndpoint(string endpointId, UpdateEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEndpointWithOptions(endpointId, request, headers, runtime);
        }

        /**
         * @summary 修改端点信息
         *
         * @param request UpdateEndpointRequest
         * @return UpdateEndpointResponse
         */
        public async Task<UpdateEndpointResponse> UpdateEndpointAsync(string endpointId, UpdateEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEndpointWithOptionsAsync(endpointId, request, headers, runtime);
        }

        /**
         * @summary 修改自动备份配置
         *
         * @param request UpdateSnapshotSettingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSnapshotSettingResponse
         */
        public UpdateSnapshotSettingResponse UpdateSnapshotSettingWithOptions(string appName, UpdateSnapshotSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuartzRegex))
            {
                body["quartzRegex"] = request.QuartzRegex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSnapshotSetting",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/auto-snapshot-setting",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSnapshotSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改自动备份配置
         *
         * @param request UpdateSnapshotSettingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSnapshotSettingResponse
         */
        public async Task<UpdateSnapshotSettingResponse> UpdateSnapshotSettingWithOptionsAsync(string appName, UpdateSnapshotSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuartzRegex))
            {
                body["quartzRegex"] = request.QuartzRegex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSnapshotSetting",
                Version = "2023-06-27",
                Protocol = "HTTPS",
                Pathname = "/openapi/es-serverless/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appName) + "/auto-snapshot-setting",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSnapshotSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改自动备份配置
         *
         * @param request UpdateSnapshotSettingRequest
         * @return UpdateSnapshotSettingResponse
         */
        public UpdateSnapshotSettingResponse UpdateSnapshotSetting(string appName, UpdateSnapshotSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSnapshotSettingWithOptions(appName, request, headers, runtime);
        }

        /**
         * @summary 修改自动备份配置
         *
         * @param request UpdateSnapshotSettingRequest
         * @return UpdateSnapshotSettingResponse
         */
        public async Task<UpdateSnapshotSettingResponse> UpdateSnapshotSettingAsync(string appName, UpdateSnapshotSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSnapshotSettingWithOptionsAsync(appName, request, headers, runtime);
        }

    }
}
