// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ModelService20220614.Models;

namespace AlibabaCloud.SDK.ModelService20220614
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("modelservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 获取当月的使用量
         *
         * @param request GetMonthAmountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMonthAmountResponse
         */
        public GetMonthAmountResponse GetMonthAmountWithOptions(GetMonthAmountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthAmount",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/month/amount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthAmountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取当月的使用量
         *
         * @param request GetMonthAmountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMonthAmountResponse
         */
        public async Task<GetMonthAmountResponse> GetMonthAmountWithOptionsAsync(GetMonthAmountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMonthAmount",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/month/amount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMonthAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取当月的使用量
         *
         * @param request GetMonthAmountRequest
         * @return GetMonthAmountResponse
         */
        public GetMonthAmountResponse GetMonthAmount(GetMonthAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMonthAmountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取当月的使用量
         *
         * @param request GetMonthAmountRequest
         * @return GetMonthAmountResponse
         */
        public async Task<GetMonthAmountResponse> GetMonthAmountAsync(GetMonthAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMonthAmountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取user相关的appid, token等信息
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/user/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取user相关的appid, token等信息
         *
         * @param request GetUserRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/user/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取user相关的appid, token等信息
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取user相关的appid, token等信息
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 每天的调用量列表
         *
         * @param request ListDayAmountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDayAmountResponse
         */
        public ListDayAmountResponse ListDayAmountWithOptions(ListDayAmountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDayAmount",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/day/amount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDayAmountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 每天的调用量列表
         *
         * @param request ListDayAmountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDayAmountResponse
         */
        public async Task<ListDayAmountResponse> ListDayAmountWithOptionsAsync(ListDayAmountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDayAmount",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/day/amount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDayAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 每天的调用量列表
         *
         * @param request ListDayAmountRequest
         * @return ListDayAmountResponse
         */
        public ListDayAmountResponse ListDayAmount(ListDayAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDayAmountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 每天的调用量列表
         *
         * @param request ListDayAmountRequest
         * @return ListDayAmountResponse
         */
        public async Task<ListDayAmountResponse> ListDayAmountAsync(ListDayAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDayAmountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用户充值列表
         *
         * @param request ListRechargeBillsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRechargeBillsResponse
         */
        public ListRechargeBillsResponse ListRechargeBillsWithOptions(ListRechargeBillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRechargeBills",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/rechargebills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRechargeBillsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户充值列表
         *
         * @param request ListRechargeBillsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRechargeBillsResponse
         */
        public async Task<ListRechargeBillsResponse> ListRechargeBillsWithOptionsAsync(ListRechargeBillsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRechargeBills",
                Version = "2022-06-14",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/rechargebills",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRechargeBillsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户充值列表
         *
         * @param request ListRechargeBillsRequest
         * @return ListRechargeBillsResponse
         */
        public ListRechargeBillsResponse ListRechargeBills(ListRechargeBillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRechargeBillsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户充值列表
         *
         * @param request ListRechargeBillsRequest
         * @return ListRechargeBillsResponse
         */
        public async Task<ListRechargeBillsResponse> ListRechargeBillsAsync(ListRechargeBillsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRechargeBillsWithOptionsAsync(request, headers, runtime);
        }

    }
}
