// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CDT20210813.Models;

namespace AlibabaCloud.SDK.CDT20210813
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cdt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetCdtServiceStatusResponse GetCdtServiceStatusWithOptions(GetCdtServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdtServiceStatusResponse>(DoRPCRequest("GetCdtServiceStatus", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCdtServiceStatusResponse> GetCdtServiceStatusWithOptionsAsync(GetCdtServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdtServiceStatusResponse>(await DoRPCRequestAsync("GetCdtServiceStatus", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCdtServiceStatusResponse GetCdtServiceStatus(GetCdtServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCdtServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetCdtServiceStatusResponse> GetCdtServiceStatusAsync(GetCdtServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCdtServiceStatusWithOptionsAsync(request, runtime);
        }

        public OpenCdtServiceResponse OpenCdtServiceWithOptions(OpenCdtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdtServiceResponse>(DoRPCRequest("OpenCdtService", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenCdtServiceResponse> OpenCdtServiceWithOptionsAsync(OpenCdtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdtServiceResponse>(await DoRPCRequestAsync("OpenCdtService", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenCdtServiceResponse OpenCdtService(OpenCdtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCdtServiceWithOptions(request, runtime);
        }

        public async Task<OpenCdtServiceResponse> OpenCdtServiceAsync(OpenCdtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCdtServiceWithOptionsAsync(request, runtime);
        }

        public GetCdtCbServiceStatusResponse GetCdtCbServiceStatusWithOptions(GetCdtCbServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdtCbServiceStatusResponse>(DoRPCRequest("GetCdtCbServiceStatus", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCdtCbServiceStatusResponse> GetCdtCbServiceStatusWithOptionsAsync(GetCdtCbServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdtCbServiceStatusResponse>(await DoRPCRequestAsync("GetCdtCbServiceStatus", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCdtCbServiceStatusResponse GetCdtCbServiceStatus(GetCdtCbServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCdtCbServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetCdtCbServiceStatusResponse> GetCdtCbServiceStatusAsync(GetCdtCbServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCdtCbServiceStatusWithOptionsAsync(request, runtime);
        }

        public OpenCdtCbServiceResponse OpenCdtCbServiceWithOptions(OpenCdtCbServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdtCbServiceResponse>(DoRPCRequest("OpenCdtCbService", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenCdtCbServiceResponse> OpenCdtCbServiceWithOptionsAsync(OpenCdtCbServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenCdtCbServiceResponse>(await DoRPCRequestAsync("OpenCdtCbService", "2021-08-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenCdtCbServiceResponse OpenCdtCbService(OpenCdtCbServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCdtCbServiceWithOptions(request, runtime);
        }

        public async Task<OpenCdtCbServiceResponse> OpenCdtCbServiceAsync(OpenCdtCbServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCdtCbServiceWithOptionsAsync(request, runtime);
        }

    }
}
