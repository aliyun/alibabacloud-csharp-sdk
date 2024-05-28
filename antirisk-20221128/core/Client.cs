// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Antirisk20221128.Models;

namespace AlibabaCloud.SDK.Antirisk20221128
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("antirisk", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 获取实时反作弊信息
         *
         * @param request GetRealTimeRiskInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealTimeRiskInfoResponse
         */
        public GetRealTimeRiskInfoResponse GetRealTimeRiskInfoWithOptions(GetRealTimeRiskInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["extra"] = request.Extra;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealTimeRiskInfo",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getRealTimeRiskInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealTimeRiskInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实时反作弊信息
         *
         * @param request GetRealTimeRiskInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRealTimeRiskInfoResponse
         */
        public async Task<GetRealTimeRiskInfoResponse> GetRealTimeRiskInfoWithOptionsAsync(GetRealTimeRiskInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                query["extra"] = request.Extra;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealTimeRiskInfo",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getRealTimeRiskInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealTimeRiskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实时反作弊信息
         *
         * @param request GetRealTimeRiskInfoRequest
         * @return GetRealTimeRiskInfoResponse
         */
        public GetRealTimeRiskInfoResponse GetRealTimeRiskInfo(GetRealTimeRiskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRealTimeRiskInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实时反作弊信息
         *
         * @param request GetRealTimeRiskInfoRequest
         * @return GetRealTimeRiskInfoResponse
         */
        public async Task<GetRealTimeRiskInfoResponse> GetRealTimeRiskInfoAsync(GetRealTimeRiskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRealTimeRiskInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary atoken换zid+tags
         *
         * @param request GetZidTagByAtokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetZidTagByAtokenResponse
         */
        public GetZidTagByAtokenResponse GetZidTagByAtokenWithOptions(GetZidTagByAtokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetZidTagByAtoken",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getZidTagByAtoken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZidTagByAtokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary atoken换zid+tags
         *
         * @param request GetZidTagByAtokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetZidTagByAtokenResponse
         */
        public async Task<GetZidTagByAtokenResponse> GetZidTagByAtokenWithOptionsAsync(GetZidTagByAtokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetZidTagByAtoken",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getZidTagByAtoken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZidTagByAtokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary atoken换zid+tags
         *
         * @param request GetZidTagByAtokenRequest
         * @return GetZidTagByAtokenResponse
         */
        public GetZidTagByAtokenResponse GetZidTagByAtoken(GetZidTagByAtokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetZidTagByAtokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary atoken换zid+tags
         *
         * @param request GetZidTagByAtokenRequest
         * @return GetZidTagByAtokenResponse
         */
        public async Task<GetZidTagByAtokenResponse> GetZidTagByAtokenAsync(GetZidTagByAtokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetZidTagByAtokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary atoken换zid+tags+风险分
         *
         * @param request GetZidTagScoreByAtokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetZidTagScoreByAtokenResponse
         */
        public GetZidTagScoreByAtokenResponse GetZidTagScoreByAtokenWithOptions(GetZidTagScoreByAtokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetZidTagScoreByAtoken",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getZidTagScoreByAtoken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZidTagScoreByAtokenResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary atoken换zid+tags+风险分
         *
         * @param request GetZidTagScoreByAtokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetZidTagScoreByAtokenResponse
         */
        public async Task<GetZidTagScoreByAtokenResponse> GetZidTagScoreByAtokenWithOptionsAsync(GetZidTagScoreByAtokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Atoken))
            {
                query["atoken"] = request.Atoken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetZidTagScoreByAtoken",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/getZidTagScoreByAtoken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetZidTagScoreByAtokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary atoken换zid+tags+风险分
         *
         * @param request GetZidTagScoreByAtokenRequest
         * @return GetZidTagScoreByAtokenResponse
         */
        public GetZidTagScoreByAtokenResponse GetZidTagScoreByAtoken(GetZidTagScoreByAtokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetZidTagScoreByAtokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary atoken换zid+tags+风险分
         *
         * @param request GetZidTagScoreByAtokenRequest
         * @return GetZidTagScoreByAtokenResponse
         */
        public async Task<GetZidTagScoreByAtokenResponse> GetZidTagScoreByAtokenAsync(GetZidTagScoreByAtokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetZidTagScoreByAtokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary  渠道风险明细
         *
         * @param request ListChannelRiskDetailsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChannelRiskDetailsResponse
         */
        public ListChannelRiskDetailsResponse ListChannelRiskDetailsWithOptions(ListChannelRiskDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllChannel))
            {
                query["isAllChannel"] = request.IsAllChannel;
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
                Action = "ListChannelRiskDetails",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/listChannelRiskDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChannelRiskDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary  渠道风险明细
         *
         * @param request ListChannelRiskDetailsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChannelRiskDetailsResponse
         */
        public async Task<ListChannelRiskDetailsResponse> ListChannelRiskDetailsWithOptionsAsync(ListChannelRiskDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["end"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAllChannel))
            {
                query["isAllChannel"] = request.IsAllChannel;
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
                Action = "ListChannelRiskDetails",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/anti/listChannelRiskDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChannelRiskDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary  渠道风险明细
         *
         * @param request ListChannelRiskDetailsRequest
         * @return ListChannelRiskDetailsResponse
         */
        public ListChannelRiskDetailsResponse ListChannelRiskDetails(ListChannelRiskDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChannelRiskDetailsWithOptions(request, headers, runtime);
        }

        /**
         * @summary  渠道风险明细
         *
         * @param request ListChannelRiskDetailsRequest
         * @return ListChannelRiskDetailsResponse
         */
        public async Task<ListChannelRiskDetailsResponse> ListChannelRiskDetailsAsync(ListChannelRiskDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChannelRiskDetailsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 卸载明细列表
         *
         * @param request ListUninstallDetailRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUninstallDetailResponse
         */
        public ListUninstallDetailResponse ListUninstallDetailWithOptions(ListUninstallDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDs))
            {
                query["endDs"] = request.EndDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDs))
            {
                query["startDs"] = request.StartDs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUninstallDetail",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/uninstall/listUninstallDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUninstallDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 卸载明细列表
         *
         * @param request ListUninstallDetailRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUninstallDetailResponse
         */
        public async Task<ListUninstallDetailResponse> ListUninstallDetailWithOptionsAsync(ListUninstallDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDs))
            {
                query["endDs"] = request.EndDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDs))
            {
                query["startDs"] = request.StartDs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUninstallDetail",
                Version = "2022-11-28",
                Protocol = "HTTPS",
                Pathname = "/uninstall/listUninstallDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUninstallDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 卸载明细列表
         *
         * @param request ListUninstallDetailRequest
         * @return ListUninstallDetailResponse
         */
        public ListUninstallDetailResponse ListUninstallDetail(ListUninstallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUninstallDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 卸载明细列表
         *
         * @param request ListUninstallDetailRequest
         * @return ListUninstallDetailResponse
         */
        public async Task<ListUninstallDetailResponse> ListUninstallDetailAsync(ListUninstallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUninstallDetailWithOptionsAsync(request, headers, runtime);
        }

    }
}
