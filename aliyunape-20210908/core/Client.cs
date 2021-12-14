// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aliyunape20210908.Models;

namespace AlibabaCloud.SDK.Aliyunape20210908
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aliyunape", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ApeInnerCommonApiResponse ApeInnerCommonApiWithOptions(ApeInnerCommonApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApeInnerCommonApi",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApeInnerCommonApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ApeInnerCommonApiResponse> ApeInnerCommonApiWithOptionsAsync(ApeInnerCommonApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApeInnerCommonApi",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApeInnerCommonApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ApeInnerCommonApiResponse ApeInnerCommonApi(ApeInnerCommonApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApeInnerCommonApiWithOptions(request, runtime);
        }

        public async Task<ApeInnerCommonApiResponse> ApeInnerCommonApiAsync(ApeInnerCommonApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApeInnerCommonApiWithOptionsAsync(request, runtime);
        }

        public HistoricalResponse HistoricalWithOptions(HistoricalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OrderId"] = request.OrderId;
            query["PageNum"] = request.PageNum;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["Station"] = request.Station;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Historical",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HistoricalResponse>(CallApi(params_, req, runtime));
        }

        public async Task<HistoricalResponse> HistoricalWithOptionsAsync(HistoricalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OrderId"] = request.OrderId;
            query["PageNum"] = request.PageNum;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["Station"] = request.Station;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Historical",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<HistoricalResponse>(await CallApiAsync(params_, req, runtime));
        }

        public HistoricalResponse Historical(HistoricalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HistoricalWithOptions(request, runtime);
        }

        public async Task<HistoricalResponse> HistoricalAsync(HistoricalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HistoricalWithOptionsAsync(request, runtime);
        }

        public StationDayResponse StationDayWithOptions(StationDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            query["StartForecast"] = request.StartForecast;
            query["Station"] = request.Station;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StationDay",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StationDayResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StationDayResponse> StationDayWithOptionsAsync(StationDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OrderId"] = request.OrderId;
            query["StartForecast"] = request.StartForecast;
            query["Station"] = request.Station;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StationDay",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StationDayResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StationDayResponse StationDay(StationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StationDayWithOptions(request, runtime);
        }

        public async Task<StationDayResponse> StationDayAsync(StationDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StationDayWithOptionsAsync(request, runtime);
        }

        public WeatherforecastResponse WeatherforecastWithOptions(WeatherforecastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Lat"] = request.Lat;
            query["Lon"] = request.Lon;
            query["OrderId"] = request.OrderId;
            query["StartForecast"] = request.StartForecast;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Weatherforecast",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeatherforecastResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WeatherforecastResponse> WeatherforecastWithOptionsAsync(WeatherforecastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Lat"] = request.Lat;
            query["Lon"] = request.Lon;
            query["OrderId"] = request.OrderId;
            query["StartForecast"] = request.StartForecast;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Weatherforecast",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeatherforecastResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WeatherforecastResponse Weatherforecast(WeatherforecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WeatherforecastWithOptions(request, runtime);
        }

        public async Task<WeatherforecastResponse> WeatherforecastAsync(WeatherforecastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WeatherforecastWithOptionsAsync(request, runtime);
        }

        public WeatherforecastTimeResponse WeatherforecastTimeWithOptions(WeatherforecastTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurHour"] = request.CurHour;
            query["Lat"] = request.Lat;
            query["Lon"] = request.Lon;
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WeatherforecastTime",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeatherforecastTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WeatherforecastTimeResponse> WeatherforecastTimeWithOptionsAsync(WeatherforecastTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurHour"] = request.CurHour;
            query["Lat"] = request.Lat;
            query["Lon"] = request.Lon;
            query["OrderId"] = request.OrderId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WeatherforecastTime",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeatherforecastTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WeatherforecastTimeResponse WeatherforecastTime(WeatherforecastTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WeatherforecastTimeWithOptions(request, runtime);
        }

        public async Task<WeatherforecastTimeResponse> WeatherforecastTimeAsync(WeatherforecastTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WeatherforecastTimeWithOptionsAsync(request, runtime);
        }

        public WeathermonitorResponse WeathermonitorWithOptions(WeathermonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurHour"] = request.CurHour;
            query["OrderId"] = request.OrderId;
            query["PageNum"] = request.PageNum;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Weathermonitor",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeathermonitorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WeathermonitorResponse> WeathermonitorWithOptionsAsync(WeathermonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CurHour"] = request.CurHour;
            query["OrderId"] = request.OrderId;
            query["PageNum"] = request.PageNum;
            query["PageSize"] = request.PageSize;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Weathermonitor",
                Version = "2021-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WeathermonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WeathermonitorResponse Weathermonitor(WeathermonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WeathermonitorWithOptions(request, runtime);
        }

        public async Task<WeathermonitorResponse> WeathermonitorAsync(WeathermonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WeathermonitorWithOptionsAsync(request, runtime);
        }

    }
}
