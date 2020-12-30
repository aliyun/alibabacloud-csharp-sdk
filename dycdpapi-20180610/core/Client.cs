// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dycdpapi20180610.Models;

namespace AlibabaCloud.SDK.Dycdpapi20180610
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dycdpapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public QueryCdpOfferResponse QueryCdpOfferWithOptions(QueryCdpOfferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOfferResponse>(DoRPCRequest("QueryCdpOffer", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCdpOfferResponse> QueryCdpOfferWithOptionsAsync(QueryCdpOfferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOfferResponse>(await DoRPCRequestAsync("QueryCdpOffer", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCdpOfferResponse QueryCdpOffer(QueryCdpOfferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCdpOfferWithOptions(request, runtime);
        }

        public async Task<QueryCdpOfferResponse> QueryCdpOfferAsync(QueryCdpOfferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCdpOfferWithOptionsAsync(request, runtime);
        }

        public QueryCdpOfferByIdResponse QueryCdpOfferByIdWithOptions(QueryCdpOfferByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOfferByIdResponse>(DoRPCRequest("QueryCdpOfferById", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCdpOfferByIdResponse> QueryCdpOfferByIdWithOptionsAsync(QueryCdpOfferByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOfferByIdResponse>(await DoRPCRequestAsync("QueryCdpOfferById", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCdpOfferByIdResponse QueryCdpOfferById(QueryCdpOfferByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCdpOfferByIdWithOptions(request, runtime);
        }

        public async Task<QueryCdpOfferByIdResponse> QueryCdpOfferByIdAsync(QueryCdpOfferByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCdpOfferByIdWithOptionsAsync(request, runtime);
        }

        public QueryCdpOrderResponse QueryCdpOrderWithOptions(QueryCdpOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOrderResponse>(DoRPCRequest("QueryCdpOrder", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCdpOrderResponse> QueryCdpOrderWithOptionsAsync(QueryCdpOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCdpOrderResponse>(await DoRPCRequestAsync("QueryCdpOrder", "2018-06-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCdpOrderResponse QueryCdpOrder(QueryCdpOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCdpOrderWithOptions(request, runtime);
        }

        public async Task<QueryCdpOrderResponse> QueryCdpOrderAsync(QueryCdpOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCdpOrderWithOptionsAsync(request, runtime);
        }

    }
}
