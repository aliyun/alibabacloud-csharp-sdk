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

        public HistoricalResponse HistoricalWithOptions(HistoricalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HistoricalResponse>(DoRPCRequest("Historical", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HistoricalResponse> HistoricalWithOptionsAsync(HistoricalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HistoricalResponse>(await DoRPCRequestAsync("Historical", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StationDayResponse>(DoRPCRequest("StationDay", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StationDayResponse> StationDayWithOptionsAsync(StationDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StationDayResponse>(await DoRPCRequestAsync("StationDay", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeatherforecastResponse>(DoRPCRequest("Weatherforecast", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WeatherforecastResponse> WeatherforecastWithOptionsAsync(WeatherforecastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeatherforecastResponse>(await DoRPCRequestAsync("Weatherforecast", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeatherforecastTimeResponse>(DoRPCRequest("WeatherforecastTime", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WeatherforecastTimeResponse> WeatherforecastTimeWithOptionsAsync(WeatherforecastTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeatherforecastTimeResponse>(await DoRPCRequestAsync("WeatherforecastTime", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeathermonitorResponse>(DoRPCRequest("Weathermonitor", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<WeathermonitorResponse> WeathermonitorWithOptionsAsync(WeathermonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<WeathermonitorResponse>(await DoRPCRequestAsync("Weathermonitor", "2021-09-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
