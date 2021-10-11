// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dytnsapi20200217.Models;

namespace AlibabaCloud.SDK.Dytnsapi20200217
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dytnsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribePhoneNumberStatusResponse DescribePhoneNumberStatusWithOptions(DescribePhoneNumberStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberStatusResponse>(DoRPCRequest("DescribePhoneNumberStatus", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePhoneNumberStatusResponse> DescribePhoneNumberStatusWithOptionsAsync(DescribePhoneNumberStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberStatusResponse>(await DoRPCRequestAsync("DescribePhoneNumberStatus", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePhoneNumberStatusResponse DescribePhoneNumberStatus(DescribePhoneNumberStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberStatusWithOptions(request, runtime);
        }

        public async Task<DescribePhoneNumberStatusResponse> DescribePhoneNumberStatusAsync(DescribePhoneNumberStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberStatusWithOptionsAsync(request, runtime);
        }

        public DescribePhoneNumberAttributeResponse DescribePhoneNumberAttributeWithOptions(DescribePhoneNumberAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberAttributeResponse>(DoRPCRequest("DescribePhoneNumberAttribute", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePhoneNumberAttributeResponse> DescribePhoneNumberAttributeWithOptionsAsync(DescribePhoneNumberAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberAttributeResponse>(await DoRPCRequestAsync("DescribePhoneNumberAttribute", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePhoneNumberAttributeResponse DescribePhoneNumberAttribute(DescribePhoneNumberAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberAttributeWithOptions(request, runtime);
        }

        public async Task<DescribePhoneNumberAttributeResponse> DescribePhoneNumberAttributeAsync(DescribePhoneNumberAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberAttributeWithOptionsAsync(request, runtime);
        }

        public DescribePhoneNumberResaleResponse DescribePhoneNumberResaleWithOptions(DescribePhoneNumberResaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberResaleResponse>(DoRPCRequest("DescribePhoneNumberResale", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePhoneNumberResaleResponse> DescribePhoneNumberResaleWithOptionsAsync(DescribePhoneNumberResaleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhoneNumberResaleResponse>(await DoRPCRequestAsync("DescribePhoneNumberResale", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePhoneNumberResaleResponse DescribePhoneNumberResale(DescribePhoneNumberResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhoneNumberResaleWithOptions(request, runtime);
        }

        public async Task<DescribePhoneNumberResaleResponse> DescribePhoneNumberResaleAsync(DescribePhoneNumberResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhoneNumberResaleWithOptionsAsync(request, runtime);
        }

        public DescribeEmptyNumberDetectResponse DescribeEmptyNumberDetectWithOptions(DescribeEmptyNumberDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEmptyNumberDetectResponse>(DoRPCRequest("DescribeEmptyNumberDetect", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEmptyNumberDetectResponse> DescribeEmptyNumberDetectWithOptionsAsync(DescribeEmptyNumberDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEmptyNumberDetectResponse>(await DoRPCRequestAsync("DescribeEmptyNumberDetect", "2020-02-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEmptyNumberDetectResponse DescribeEmptyNumberDetect(DescribeEmptyNumberDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmptyNumberDetectWithOptions(request, runtime);
        }

        public async Task<DescribeEmptyNumberDetectResponse> DescribeEmptyNumberDetectAsync(DescribeEmptyNumberDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmptyNumberDetectWithOptionsAsync(request, runtime);
        }

    }
}
