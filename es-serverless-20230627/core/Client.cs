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

    }
}
