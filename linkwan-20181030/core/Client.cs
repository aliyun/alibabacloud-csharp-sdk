// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.LinkWAN20181030.Models;

namespace AlibabaCloud.SDK.LinkWAN20181030
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("linkwan", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetKpmEncryptedNodeTuplesByOrderIdResponse GetKpmEncryptedNodeTuplesByOrderIdWithOptions(GetKpmEncryptedNodeTuplesByOrderIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetKpmEncryptedNodeTuplesByOrderIdResponse>(DoRPCRequest("GetKpmEncryptedNodeTuplesByOrderId", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetKpmEncryptedNodeTuplesByOrderIdResponse> GetKpmEncryptedNodeTuplesByOrderIdWithOptionsAsync(GetKpmEncryptedNodeTuplesByOrderIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetKpmEncryptedNodeTuplesByOrderIdResponse>(await DoRPCRequestAsync("GetKpmEncryptedNodeTuplesByOrderId", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetKpmEncryptedNodeTuplesByOrderIdResponse GetKpmEncryptedNodeTuplesByOrderId(GetKpmEncryptedNodeTuplesByOrderIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKpmEncryptedNodeTuplesByOrderIdWithOptions(request, runtime);
        }

        public async Task<GetKpmEncryptedNodeTuplesByOrderIdResponse> GetKpmEncryptedNodeTuplesByOrderIdAsync(GetKpmEncryptedNodeTuplesByOrderIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKpmEncryptedNodeTuplesByOrderIdWithOptionsAsync(request, runtime);
        }

        public SubmitKpmEncryptedNodeTupleOrderResponse SubmitKpmEncryptedNodeTupleOrderWithOptions(SubmitKpmEncryptedNodeTupleOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitKpmEncryptedNodeTupleOrderResponse>(DoRPCRequest("SubmitKpmEncryptedNodeTupleOrder", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitKpmEncryptedNodeTupleOrderResponse> SubmitKpmEncryptedNodeTupleOrderWithOptionsAsync(SubmitKpmEncryptedNodeTupleOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitKpmEncryptedNodeTupleOrderResponse>(await DoRPCRequestAsync("SubmitKpmEncryptedNodeTupleOrder", "2018-10-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitKpmEncryptedNodeTupleOrderResponse SubmitKpmEncryptedNodeTupleOrder(SubmitKpmEncryptedNodeTupleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitKpmEncryptedNodeTupleOrderWithOptions(request, runtime);
        }

        public async Task<SubmitKpmEncryptedNodeTupleOrderResponse> SubmitKpmEncryptedNodeTupleOrderAsync(SubmitKpmEncryptedNodeTupleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitKpmEncryptedNodeTupleOrderWithOptionsAsync(request, runtime);
        }

    }
}
