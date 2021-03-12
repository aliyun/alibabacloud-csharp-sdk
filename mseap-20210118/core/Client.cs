// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mseap20210118.Models;

namespace AlibabaCloud.SDK.Mseap20210118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("mseap", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateLicenseResponse ActivateLicenseWithOptions(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(DoRPCRequest("ActivateLicense", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivateLicenseResponse> ActivateLicenseWithOptionsAsync(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(await DoRPCRequestAsync("ActivateLicense", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateLicenseWithOptions(request, runtime);
        }

        public async Task<ActivateLicenseResponse> ActivateLicenseAsync(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateLicenseWithOptionsAsync(request, runtime);
        }

        public BusinessLicenseOcrResponse BusinessLicenseOcrWithOptions(BusinessLicenseOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BusinessLicenseOcrResponse>(DoRPCRequest("BusinessLicenseOcr", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BusinessLicenseOcrResponse> BusinessLicenseOcrWithOptionsAsync(BusinessLicenseOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BusinessLicenseOcrResponse>(await DoRPCRequestAsync("BusinessLicenseOcr", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BusinessLicenseOcrResponse BusinessLicenseOcr(BusinessLicenseOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BusinessLicenseOcrWithOptions(request, runtime);
        }

        public async Task<BusinessLicenseOcrResponse> BusinessLicenseOcrAsync(BusinessLicenseOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BusinessLicenseOcrWithOptionsAsync(request, runtime);
        }

        public CertificateQualityResponse CertificateQualityWithOptions(CertificateQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificateQualityResponse>(DoRPCRequest("CertificateQuality", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CertificateQualityResponse> CertificateQualityWithOptionsAsync(CertificateQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificateQualityResponse>(await DoRPCRequestAsync("CertificateQuality", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CertificateQualityResponse CertificateQuality(CertificateQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificateQualityWithOptions(request, runtime);
        }

        public async Task<CertificateQualityResponse> CertificateQualityAsync(CertificateQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificateQualityWithOptionsAsync(request, runtime);
        }

        public DescribeAgreementStatusResponse DescribeAgreementStatusWithOptions(DescribeAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAgreementStatusResponse>(DoRPCRequest("DescribeAgreementStatus", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAgreementStatusResponse> DescribeAgreementStatusWithOptionsAsync(DescribeAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAgreementStatusResponse>(await DoRPCRequestAsync("DescribeAgreementStatus", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAgreementStatusResponse DescribeAgreementStatus(DescribeAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAgreementStatusWithOptions(request, runtime);
        }

        public async Task<DescribeAgreementStatusResponse> DescribeAgreementStatusAsync(DescribeAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAgreementStatusWithOptionsAsync(request, runtime);
        }

        public IdentityCardOcrResponse IdentityCardOcrWithOptions(IdentityCardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IdentityCardOcrResponse>(DoRPCRequest("IdentityCardOcr", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IdentityCardOcrResponse> IdentityCardOcrWithOptionsAsync(IdentityCardOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IdentityCardOcrResponse>(await DoRPCRequestAsync("IdentityCardOcr", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IdentityCardOcrResponse IdentityCardOcr(IdentityCardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IdentityCardOcrWithOptions(request, runtime);
        }

        public async Task<IdentityCardOcrResponse> IdentityCardOcrAsync(IdentityCardOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IdentityCardOcrWithOptionsAsync(request, runtime);
        }

        public UpdateAgreementStatusResponse UpdateAgreementStatusWithOptions(UpdateAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAgreementStatusResponse>(DoRPCRequest("UpdateAgreementStatus", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAgreementStatusResponse> UpdateAgreementStatusWithOptionsAsync(UpdateAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAgreementStatusResponse>(await DoRPCRequestAsync("UpdateAgreementStatus", "2021-01-18", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAgreementStatusResponse UpdateAgreementStatus(UpdateAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgreementStatusWithOptions(request, runtime);
        }

        public async Task<UpdateAgreementStatusResponse> UpdateAgreementStatusAsync(UpdateAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgreementStatusWithOptionsAsync(request, runtime);
        }

    }
}
