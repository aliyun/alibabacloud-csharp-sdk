// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AppMallsService20180224.Models;

namespace AlibabaCloud.SDK.AppMallsService20180224
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "appms.aliyuncs.com"},
                {"ap-northeast-2-pop", "appms.aliyuncs.com"},
                {"ap-south-1", "appms.aliyuncs.com"},
                {"ap-southeast-1", "appms.aliyuncs.com"},
                {"ap-southeast-2", "appms.aliyuncs.com"},
                {"ap-southeast-3", "appms.aliyuncs.com"},
                {"ap-southeast-5", "appms.aliyuncs.com"},
                {"cn-beijing", "appms.aliyuncs.com"},
                {"cn-beijing-finance-1", "appms.aliyuncs.com"},
                {"cn-beijing-finance-pop", "appms.aliyuncs.com"},
                {"cn-beijing-gov-1", "appms.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "appms.aliyuncs.com"},
                {"cn-chengdu", "appms.aliyuncs.com"},
                {"cn-edge-1", "appms.aliyuncs.com"},
                {"cn-fujian", "appms.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "appms.aliyuncs.com"},
                {"cn-hangzhou", "appms.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "appms.aliyuncs.com"},
                {"cn-hangzhou-finance", "appms.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "appms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "appms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "appms.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "appms.aliyuncs.com"},
                {"cn-hangzhou-test-306", "appms.aliyuncs.com"},
                {"cn-hongkong", "appms.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "appms.aliyuncs.com"},
                {"cn-huhehaote", "appms.aliyuncs.com"},
                {"cn-north-2-gov-1", "appms.aliyuncs.com"},
                {"cn-qingdao", "appms.aliyuncs.com"},
                {"cn-qingdao-nebula", "appms.aliyuncs.com"},
                {"cn-shanghai", "appms.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "appms.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "appms.aliyuncs.com"},
                {"cn-shanghai-finance-1", "appms.aliyuncs.com"},
                {"cn-shanghai-inner", "appms.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "appms.aliyuncs.com"},
                {"cn-shenzhen", "appms.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "appms.aliyuncs.com"},
                {"cn-shenzhen-inner", "appms.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "appms.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "appms.aliyuncs.com"},
                {"cn-wuhan", "appms.aliyuncs.com"},
                {"cn-yushanfang", "appms.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "appms.aliyuncs.com"},
                {"cn-zhangjiakou", "appms.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "appms.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "appms.aliyuncs.com"},
                {"eu-central-1", "appms.aliyuncs.com"},
                {"eu-west-1", "appms.aliyuncs.com"},
                {"eu-west-1-oxs", "appms.aliyuncs.com"},
                {"me-east-1", "appms.aliyuncs.com"},
                {"rus-west-1-pop", "appms.aliyuncs.com"},
                {"us-east-1", "appms.aliyuncs.com"},
                {"us-west-1", "appms.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("appmallsservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetMessagesResponse GetMessagesWithOptions(GetMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessages",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMessagesResponse> GetMessagesWithOptionsAsync(GetMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessages",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMessagesResponse GetMessages(GetMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessagesWithOptions(request, runtime);
        }

        public async Task<GetMessagesResponse> GetMessagesAsync(GetMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessagesWithOptionsAsync(request, runtime);
        }

        public RemoveMessagesResponse RemoveMessagesWithOptions(RemoveMessagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveMessagesShrinkRequest request = new RemoveMessagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MsgIds))
            {
                request.MsgIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MsgIds, "MsgIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgIdsShrink))
            {
                query["MsgIds"] = request.MsgIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMessages",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveMessagesResponse> RemoveMessagesWithOptionsAsync(RemoveMessagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveMessagesShrinkRequest request = new RemoveMessagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MsgIds))
            {
                request.MsgIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MsgIds, "MsgIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgIdsShrink))
            {
                query["MsgIds"] = request.MsgIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMessages",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveMessagesResponse RemoveMessages(RemoveMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveMessagesWithOptions(request, runtime);
        }

        public async Task<RemoveMessagesResponse> RemoveMessagesAsync(RemoveMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveMessagesWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetCinemasResponse TaobaoFilmGetCinemasWithOptions(TaobaoFilmGetCinemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetCinemas",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetCinemasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetCinemasResponse> TaobaoFilmGetCinemasWithOptionsAsync(TaobaoFilmGetCinemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetCinemas",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetCinemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetCinemasResponse TaobaoFilmGetCinemas(TaobaoFilmGetCinemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetCinemasWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetCinemasResponse> TaobaoFilmGetCinemasAsync(TaobaoFilmGetCinemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetCinemasWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetHotShowsResponse TaobaoFilmGetHotShowsWithOptions(TaobaoFilmGetHotShowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetHotShows",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetHotShowsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetHotShowsResponse> TaobaoFilmGetHotShowsWithOptionsAsync(TaobaoFilmGetHotShowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetHotShows",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetHotShowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetHotShowsResponse TaobaoFilmGetHotShows(TaobaoFilmGetHotShowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetHotShowsWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetHotShowsResponse> TaobaoFilmGetHotShowsAsync(TaobaoFilmGetHotShowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetHotShowsWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetRegionListResponse TaobaoFilmGetRegionListWithOptions(TaobaoFilmGetRegionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetRegionList",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetRegionListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetRegionListResponse> TaobaoFilmGetRegionListWithOptionsAsync(TaobaoFilmGetRegionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetRegionList",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetRegionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetRegionListResponse TaobaoFilmGetRegionList(TaobaoFilmGetRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetRegionListWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetRegionListResponse> TaobaoFilmGetRegionListAsync(TaobaoFilmGetRegionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetRegionListWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetSchedulesResponse TaobaoFilmGetSchedulesWithOptions(TaobaoFilmGetSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CinemaId))
            {
                query["CinemaId"] = request.CinemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSchedules",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSchedulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetSchedulesResponse> TaobaoFilmGetSchedulesWithOptionsAsync(TaobaoFilmGetSchedulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CinemaId))
            {
                query["CinemaId"] = request.CinemaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSchedules",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSchedulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetSchedulesResponse TaobaoFilmGetSchedules(TaobaoFilmGetSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetSchedulesWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetSchedulesResponse> TaobaoFilmGetSchedulesAsync(TaobaoFilmGetSchedulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetSchedulesWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetSeatsResponse TaobaoFilmGetSeatsWithOptions(TaobaoFilmGetSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSeats",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSeatsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetSeatsResponse> TaobaoFilmGetSeatsWithOptionsAsync(TaobaoFilmGetSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSeats",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetSeatsResponse TaobaoFilmGetSeats(TaobaoFilmGetSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetSeatsWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetSeatsResponse> TaobaoFilmGetSeatsAsync(TaobaoFilmGetSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetSeatsWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetShowCommentsResponse TaobaoFilmGetShowCommentsWithOptions(TaobaoFilmGetShowCommentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowId))
            {
                query["ShowId"] = request.ShowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetShowComments",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetShowCommentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetShowCommentsResponse> TaobaoFilmGetShowCommentsWithOptionsAsync(TaobaoFilmGetShowCommentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowId))
            {
                query["ShowId"] = request.ShowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetShowComments",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetShowCommentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetShowCommentsResponse TaobaoFilmGetShowComments(TaobaoFilmGetShowCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetShowCommentsWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetShowCommentsResponse> TaobaoFilmGetShowCommentsAsync(TaobaoFilmGetShowCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetShowCommentsWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmGetSoonShowsResponse TaobaoFilmGetSoonShowsWithOptions(TaobaoFilmGetSoonShowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSoonShows",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSoonShowsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmGetSoonShowsResponse> TaobaoFilmGetSoonShowsWithOptionsAsync(TaobaoFilmGetSoonShowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityCode))
            {
                query["CityCode"] = request.CityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmGetSoonShows",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmGetSoonShowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmGetSoonShowsResponse TaobaoFilmGetSoonShows(TaobaoFilmGetSoonShowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmGetSoonShowsWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmGetSoonShowsResponse> TaobaoFilmGetSoonShowsAsync(TaobaoFilmGetSoonShowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmGetSoonShowsWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmIssueOrderResponse TaobaoFilmIssueOrderWithOptions(TaobaoFilmIssueOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtOrderId))
            {
                query["ExtOrderId"] = request.ExtOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                query["TotalPrice"] = request.TotalPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmIssueOrder",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmIssueOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmIssueOrderResponse> TaobaoFilmIssueOrderWithOptionsAsync(TaobaoFilmIssueOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtOrderId))
            {
                query["ExtOrderId"] = request.ExtOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalPrice))
            {
                query["TotalPrice"] = request.TotalPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmIssueOrder",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmIssueOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmIssueOrderResponse TaobaoFilmIssueOrder(TaobaoFilmIssueOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmIssueOrderWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmIssueOrderResponse> TaobaoFilmIssueOrderAsync(TaobaoFilmIssueOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmIssueOrderWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmLockSeatResponse TaobaoFilmLockSeatWithOptions(TaobaoFilmLockSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatIds))
            {
                query["SeatIds"] = request.SeatIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNames))
            {
                query["SeatNames"] = request.SeatNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmLockSeat",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmLockSeatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmLockSeatResponse> TaobaoFilmLockSeatWithOptionsAsync(TaobaoFilmLockSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleId))
            {
                query["ScheduleId"] = request.ScheduleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatIds))
            {
                query["SeatIds"] = request.SeatIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNames))
            {
                query["SeatNames"] = request.SeatNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmLockSeat",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmLockSeatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmLockSeatResponse TaobaoFilmLockSeat(TaobaoFilmLockSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmLockSeatWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmLockSeatResponse> TaobaoFilmLockSeatAsync(TaobaoFilmLockSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmLockSeatWithOptionsAsync(request, runtime);
        }

        public TaobaoFilmUnLockSeatResponse TaobaoFilmUnLockSeatWithOptions(TaobaoFilmUnLockSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmUnLockSeat",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmUnLockSeatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TaobaoFilmUnLockSeatResponse> TaobaoFilmUnLockSeatWithOptionsAsync(TaobaoFilmUnLockSeatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtUserId))
            {
                query["ExtUserId"] = request.ExtUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockSeatApplyKey))
            {
                query["LockSeatApplyKey"] = request.LockSeatApplyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                query["ParamsJson"] = request.ParamsJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TaobaoFilmUnLockSeat",
                Version = "2018-02-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TaobaoFilmUnLockSeatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TaobaoFilmUnLockSeatResponse TaobaoFilmUnLockSeat(TaobaoFilmUnLockSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TaobaoFilmUnLockSeatWithOptions(request, runtime);
        }

        public async Task<TaobaoFilmUnLockSeatResponse> TaobaoFilmUnLockSeatAsync(TaobaoFilmUnLockSeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TaobaoFilmUnLockSeatWithOptionsAsync(request, runtime);
        }

    }
}
