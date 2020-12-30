// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Snsuapi20180709.Models;

namespace AlibabaCloud.SDK.Snsuapi20180709
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("snsuapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BandOfferOrderResponse BandOfferOrderWithOptions(BandOfferOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandOfferOrderResponse>(DoRPCRequest("BandOfferOrder", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandOfferOrderResponse> BandOfferOrderWithOptionsAsync(BandOfferOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandOfferOrderResponse>(await DoRPCRequestAsync("BandOfferOrder", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandOfferOrderResponse BandOfferOrder(BandOfferOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandOfferOrderWithOptions(request, runtime);
        }

        public async Task<BandOfferOrderResponse> BandOfferOrderAsync(BandOfferOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandOfferOrderWithOptionsAsync(request, runtime);
        }

        public BandPrecheckResponse BandPrecheckWithOptions(BandPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandPrecheckResponse>(DoRPCRequest("BandPrecheck", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandPrecheckResponse> BandPrecheckWithOptionsAsync(BandPrecheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandPrecheckResponse>(await DoRPCRequestAsync("BandPrecheck", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandPrecheckResponse BandPrecheck(BandPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandPrecheckWithOptions(request, runtime);
        }

        public async Task<BandPrecheckResponse> BandPrecheckAsync(BandPrecheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandPrecheckWithOptionsAsync(request, runtime);
        }

        public BandStartSpeedUpResponse BandStartSpeedUpWithOptions(BandStartSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStartSpeedUpResponse>(DoRPCRequest("BandStartSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandStartSpeedUpResponse> BandStartSpeedUpWithOptionsAsync(BandStartSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStartSpeedUpResponse>(await DoRPCRequestAsync("BandStartSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandStartSpeedUpResponse BandStartSpeedUp(BandStartSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandStartSpeedUpWithOptions(request, runtime);
        }

        public async Task<BandStartSpeedUpResponse> BandStartSpeedUpAsync(BandStartSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandStartSpeedUpWithOptionsAsync(request, runtime);
        }

        public BandStatusQueryResponse BandStatusQueryWithOptions(BandStatusQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStatusQueryResponse>(DoRPCRequest("BandStatusQuery", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandStatusQueryResponse> BandStatusQueryWithOptionsAsync(BandStatusQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStatusQueryResponse>(await DoRPCRequestAsync("BandStatusQuery", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandStatusQueryResponse BandStatusQuery(BandStatusQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandStatusQueryWithOptions(request, runtime);
        }

        public async Task<BandStatusQueryResponse> BandStatusQueryAsync(BandStatusQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandStatusQueryWithOptionsAsync(request, runtime);
        }

        public BandStopSpeedUpResponse BandStopSpeedUpWithOptions(BandStopSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStopSpeedUpResponse>(DoRPCRequest("BandStopSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandStopSpeedUpResponse> BandStopSpeedUpWithOptionsAsync(BandStopSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandStopSpeedUpResponse>(await DoRPCRequestAsync("BandStopSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandStopSpeedUpResponse BandStopSpeedUp(BandStopSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandStopSpeedUpWithOptions(request, runtime);
        }

        public async Task<BandStopSpeedUpResponse> BandStopSpeedUpAsync(BandStopSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandStopSpeedUpWithOptionsAsync(request, runtime);
        }

        public MobileStartSpeedUpResponse MobileStartSpeedUpWithOptions(MobileStartSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStartSpeedUpResponse>(DoRPCRequest("MobileStartSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MobileStartSpeedUpResponse> MobileStartSpeedUpWithOptionsAsync(MobileStartSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStartSpeedUpResponse>(await DoRPCRequestAsync("MobileStartSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MobileStartSpeedUpResponse MobileStartSpeedUp(MobileStartSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileStartSpeedUpWithOptions(request, runtime);
        }

        public async Task<MobileStartSpeedUpResponse> MobileStartSpeedUpAsync(MobileStartSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileStartSpeedUpWithOptionsAsync(request, runtime);
        }

        public MobileStatusQueryResponse MobileStatusQueryWithOptions(MobileStatusQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStatusQueryResponse>(DoRPCRequest("MobileStatusQuery", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MobileStatusQueryResponse> MobileStatusQueryWithOptionsAsync(MobileStatusQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStatusQueryResponse>(await DoRPCRequestAsync("MobileStatusQuery", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MobileStatusQueryResponse MobileStatusQuery(MobileStatusQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileStatusQueryWithOptions(request, runtime);
        }

        public async Task<MobileStatusQueryResponse> MobileStatusQueryAsync(MobileStatusQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileStatusQueryWithOptionsAsync(request, runtime);
        }

        public MobileStopSpeedUpResponse MobileStopSpeedUpWithOptions(MobileStopSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStopSpeedUpResponse>(DoRPCRequest("MobileStopSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MobileStopSpeedUpResponse> MobileStopSpeedUpWithOptionsAsync(MobileStopSpeedUpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MobileStopSpeedUpResponse>(await DoRPCRequestAsync("MobileStopSpeedUp", "2018-07-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MobileStopSpeedUpResponse MobileStopSpeedUp(MobileStopSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MobileStopSpeedUpWithOptions(request, runtime);
        }

        public async Task<MobileStopSpeedUpResponse> MobileStopSpeedUpAsync(MobileStopSpeedUpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MobileStopSpeedUpWithOptionsAsync(request, runtime);
        }

    }
}
