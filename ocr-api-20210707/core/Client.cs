// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ocr_api20210707.Models;

namespace AlibabaCloud.SDK.Ocr_api20210707
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ocr-api", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public RecognizeAdvancedResponse RecognizeAdvancedWithOptions(RecognizeAdvancedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(DoRPCRequest("RecognizeAdvanced", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedWithOptionsAsync(RecognizeAdvancedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(await DoRPCRequestAsync("RecognizeAdvanced", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeAdvancedResponse RecognizeAdvanced(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAdvancedWithOptions(request, runtime);
        }

        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedAsync(RecognizeAdvancedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAdvancedWithOptionsAsync(request, runtime);
        }

        public RecognizeAirItineraryResponse RecognizeAirItineraryWithOptions(RecognizeAirItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(DoRPCRequest("RecognizeAirItinerary", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryWithOptionsAsync(RecognizeAirItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(await DoRPCRequestAsync("RecognizeAirItinerary", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeAirItineraryResponse RecognizeAirItinerary(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAirItineraryWithOptions(request, runtime);
        }

        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryAsync(RecognizeAirItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAirItineraryWithOptionsAsync(request, runtime);
        }

        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicenseWithOptions(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(DoRPCRequest("RecognizeBankAccountLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseWithOptionsAsync(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(await DoRPCRequestAsync("RecognizeBankAccountLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicense(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAccountLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseAsync(RecognizeBankAccountLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAccountLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeBankCardResponse RecognizeBankCardWithOptions(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(DoRPCRequest("RecognizeBankCard", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardWithOptionsAsync(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(await DoRPCRequestAsync("RecognizeBankCard", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeBankCardResponse RecognizeBankCard(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankCardWithOptions(request, runtime);
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardAsync(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankCardWithOptionsAsync(request, runtime);
        }

        public RecognizeBasicResponse RecognizeBasicWithOptions(RecognizeBasicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(DoRPCRequest("RecognizeBasic", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeBasicResponse> RecognizeBasicWithOptionsAsync(RecognizeBasicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(await DoRPCRequestAsync("RecognizeBasic", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeBasicResponse RecognizeBasic(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBasicWithOptions(request, runtime);
        }

        public async Task<RecognizeBasicResponse> RecognizeBasicAsync(RecognizeBasicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBasicWithOptionsAsync(request, runtime);
        }

        public RecognizeBirthCertificationResponse RecognizeBirthCertificationWithOptions(RecognizeBirthCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(DoRPCRequest("RecognizeBirthCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationWithOptionsAsync(RecognizeBirthCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(await DoRPCRequestAsync("RecognizeBirthCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeBirthCertificationResponse RecognizeBirthCertification(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBirthCertificationWithOptions(request, runtime);
        }

        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationAsync(RecognizeBirthCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBirthCertificationWithOptionsAsync(request, runtime);
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicenseWithOptions(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(DoRPCRequest("RecognizeBusinessLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseWithOptionsAsync(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(await DoRPCRequestAsync("RecognizeBusinessLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicense(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusinessLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusinessLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeCarInvoiceResponse RecognizeCarInvoiceWithOptions(RecognizeCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(DoRPCRequest("RecognizeCarInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceWithOptionsAsync(RecognizeCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(await DoRPCRequestAsync("RecognizeCarInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeCarInvoiceResponse RecognizeCarInvoice(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceAsync(RecognizeCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeCarNumberResponse RecognizeCarNumberWithOptions(RecognizeCarNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(DoRPCRequest("RecognizeCarNumber", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberWithOptionsAsync(RecognizeCarNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(await DoRPCRequestAsync("RecognizeCarNumber", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeCarNumberResponse RecognizeCarNumber(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarNumberWithOptions(request, runtime);
        }

        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberAsync(RecognizeCarNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarNumberWithOptionsAsync(request, runtime);
        }

        public RecognizeCarVinCodeResponse RecognizeCarVinCodeWithOptions(RecognizeCarVinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(DoRPCRequest("RecognizeCarVinCode", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeWithOptionsAsync(RecognizeCarVinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(await DoRPCRequestAsync("RecognizeCarVinCode", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeCarVinCodeResponse RecognizeCarVinCode(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarVinCodeWithOptions(request, runtime);
        }

        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeAsync(RecognizeCarVinCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarVinCodeWithOptionsAsync(request, runtime);
        }

        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicenseWithOptions(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(DoRPCRequest("RecognizeCtwoMedicalDeviceManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(await DoRPCRequestAsync("RecognizeCtwoMedicalDeviceManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicense(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCtwoMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicenseWithOptions(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(DoRPCRequest("RecognizeDrivingLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseWithOptionsAsync(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(await DoRPCRequestAsync("RecognizeDrivingLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicense(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDrivingLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseAsync(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDrivingLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeEduFormulaResponse RecognizeEduFormulaWithOptions(RecognizeEduFormulaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(DoRPCRequest("RecognizeEduFormula", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaWithOptionsAsync(RecognizeEduFormulaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(await DoRPCRequestAsync("RecognizeEduFormula", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduFormulaResponse RecognizeEduFormula(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduFormulaWithOptions(request, runtime);
        }

        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaAsync(RecognizeEduFormulaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduFormulaWithOptionsAsync(request, runtime);
        }

        public RecognizeEduOralCalculationResponse RecognizeEduOralCalculationWithOptions(RecognizeEduOralCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(DoRPCRequest("RecognizeEduOralCalculation", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationWithOptionsAsync(RecognizeEduOralCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(await DoRPCRequestAsync("RecognizeEduOralCalculation", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduOralCalculationResponse RecognizeEduOralCalculation(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduOralCalculationWithOptions(request, runtime);
        }

        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationAsync(RecognizeEduOralCalculationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduOralCalculationWithOptionsAsync(request, runtime);
        }

        public RecognizeEduPaperCutResponse RecognizeEduPaperCutWithOptions(RecognizeEduPaperCutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(DoRPCRequest("RecognizeEduPaperCut", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutWithOptionsAsync(RecognizeEduPaperCutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(await DoRPCRequestAsync("RecognizeEduPaperCut", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduPaperCutResponse RecognizeEduPaperCut(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperCutWithOptions(request, runtime);
        }

        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutAsync(RecognizeEduPaperCutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperCutWithOptionsAsync(request, runtime);
        }

        public RecognizeEduPaperOcrResponse RecognizeEduPaperOcrWithOptions(RecognizeEduPaperOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(DoRPCRequest("RecognizeEduPaperOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrWithOptionsAsync(RecognizeEduPaperOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(await DoRPCRequestAsync("RecognizeEduPaperOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduPaperOcrResponse RecognizeEduPaperOcr(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperOcrWithOptions(request, runtime);
        }

        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrAsync(RecognizeEduPaperOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperOcrWithOptionsAsync(request, runtime);
        }

        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructedWithOptions(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(DoRPCRequest("RecognizeEduPaperStructed", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedWithOptionsAsync(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(await DoRPCRequestAsync("RecognizeEduPaperStructed", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduPaperStructedResponse RecognizeEduPaperStructed(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduPaperStructedWithOptions(request, runtime);
        }

        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedAsync(RecognizeEduPaperStructedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduPaperStructedWithOptionsAsync(request, runtime);
        }

        public RecognizeEduQuestionOcrResponse RecognizeEduQuestionOcrWithOptions(RecognizeEduQuestionOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(DoRPCRequest("RecognizeEduQuestionOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrWithOptionsAsync(RecognizeEduQuestionOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(await DoRPCRequestAsync("RecognizeEduQuestionOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEduQuestionOcrResponse RecognizeEduQuestionOcr(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEduQuestionOcrWithOptions(request, runtime);
        }

        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrAsync(RecognizeEduQuestionOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEduQuestionOcrWithOptionsAsync(request, runtime);
        }

        public RecognizeEnglishResponse RecognizeEnglishWithOptions(RecognizeEnglishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(DoRPCRequest("RecognizeEnglish", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEnglishResponse> RecognizeEnglishWithOptionsAsync(RecognizeEnglishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(await DoRPCRequestAsync("RecognizeEnglish", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEnglishResponse RecognizeEnglish(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEnglishWithOptions(request, runtime);
        }

        public async Task<RecognizeEnglishResponse> RecognizeEnglishAsync(RecognizeEnglishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEnglishWithOptionsAsync(request, runtime);
        }

        public RecognizeEstateCertificationResponse RecognizeEstateCertificationWithOptions(RecognizeEstateCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(DoRPCRequest("RecognizeEstateCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationWithOptionsAsync(RecognizeEstateCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(await DoRPCRequestAsync("RecognizeEstateCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeEstateCertificationResponse RecognizeEstateCertification(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeEstateCertificationWithOptions(request, runtime);
        }

        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationAsync(RecognizeEstateCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeEstateCertificationWithOptionsAsync(request, runtime);
        }

        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicenseWithOptions(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(DoRPCRequest("RecognizeFoodManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseWithOptionsAsync(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(await DoRPCRequestAsync("RecognizeFoodManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicense(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodManageLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseAsync(RecognizeFoodManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodManageLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeFoodProduceLicenseResponse RecognizeFoodProduceLicenseWithOptions(RecognizeFoodProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(DoRPCRequest("RecognizeFoodProduceLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseWithOptionsAsync(RecognizeFoodProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(await DoRPCRequestAsync("RecognizeFoodProduceLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeFoodProduceLicenseResponse RecognizeFoodProduceLicense(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeFoodProduceLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseAsync(RecognizeFoodProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeFoodProduceLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeGeneralResponse RecognizeGeneralWithOptions(RecognizeGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(DoRPCRequest("RecognizeGeneral", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeGeneralResponse> RecognizeGeneralWithOptionsAsync(RecognizeGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(await DoRPCRequestAsync("RecognizeGeneral", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeGeneralResponse RecognizeGeneral(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeGeneralWithOptions(request, runtime);
        }

        public async Task<RecognizeGeneralResponse> RecognizeGeneralAsync(RecognizeGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeGeneralWithOptionsAsync(request, runtime);
        }

        public RecognizeHandwritingResponse RecognizeHandwritingWithOptions(RecognizeHandwritingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(DoRPCRequest("RecognizeHandwriting", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingWithOptionsAsync(RecognizeHandwritingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(await DoRPCRequestAsync("RecognizeHandwriting", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeHandwritingResponse RecognizeHandwriting(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHandwritingWithOptions(request, runtime);
        }

        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingAsync(RecognizeHandwritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHandwritingWithOptionsAsync(request, runtime);
        }

        public RecognizeHouseholdResponse RecognizeHouseholdWithOptions(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(DoRPCRequest("RecognizeHousehold", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdWithOptionsAsync(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(await DoRPCRequestAsync("RecognizeHousehold", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeHouseholdResponse RecognizeHousehold(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHouseholdWithOptions(request, runtime);
        }

        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdAsync(RecognizeHouseholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHouseholdWithOptionsAsync(request, runtime);
        }

        public RecognizeIdcardResponse RecognizeIdcardWithOptions(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(DoRPCRequest("RecognizeIdcard", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeIdcardResponse> RecognizeIdcardWithOptionsAsync(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(await DoRPCRequestAsync("RecognizeIdcard", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeIdcardResponse RecognizeIdcard(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeIdcardWithOptions(request, runtime);
        }

        public async Task<RecognizeIdcardResponse> RecognizeIdcardAsync(RecognizeIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeIdcardWithOptionsAsync(request, runtime);
        }

        public RecognizeInvoiceResponse RecognizeInvoiceWithOptions(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(DoRPCRequest("RecognizeInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceWithOptionsAsync(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(await DoRPCRequestAsync("RecognizeInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeInvoiceResponse RecognizeInvoice(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceAsync(RecognizeInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeJanpaneseResponse RecognizeJanpaneseWithOptions(RecognizeJanpaneseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(DoRPCRequest("RecognizeJanpanese", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseWithOptionsAsync(RecognizeJanpaneseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(await DoRPCRequestAsync("RecognizeJanpanese", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeJanpaneseResponse RecognizeJanpanese(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeJanpaneseWithOptions(request, runtime);
        }

        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseAsync(RecognizeJanpaneseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeJanpaneseWithOptionsAsync(request, runtime);
        }

        public RecognizeKoreanResponse RecognizeKoreanWithOptions(RecognizeKoreanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(DoRPCRequest("RecognizeKorean", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeKoreanResponse> RecognizeKoreanWithOptionsAsync(RecognizeKoreanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(await DoRPCRequestAsync("RecognizeKorean", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeKoreanResponse RecognizeKorean(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeKoreanWithOptions(request, runtime);
        }

        public async Task<RecognizeKoreanResponse> RecognizeKoreanAsync(RecognizeKoreanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeKoreanWithOptionsAsync(request, runtime);
        }

        public RecognizeLatinResponse RecognizeLatinWithOptions(RecognizeLatinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(DoRPCRequest("RecognizeLatin", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeLatinResponse> RecognizeLatinWithOptionsAsync(RecognizeLatinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(await DoRPCRequestAsync("RecognizeLatin", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeLatinResponse RecognizeLatin(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeLatinWithOptions(request, runtime);
        }

        public async Task<RecognizeLatinResponse> RecognizeLatinAsync(RecognizeLatinRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeLatinWithOptionsAsync(request, runtime);
        }

        public RecognizeMedicalDeviceManageLicenseResponse RecognizeMedicalDeviceManageLicenseWithOptions(RecognizeMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(DoRPCRequest("RecognizeMedicalDeviceManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseWithOptionsAsync(RecognizeMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(await DoRPCRequestAsync("RecognizeMedicalDeviceManageLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeMedicalDeviceManageLicenseResponse RecognizeMedicalDeviceManageLicense(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceManageLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseAsync(RecognizeMedicalDeviceManageLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceManageLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeMedicalDeviceProduceLicenseResponse RecognizeMedicalDeviceProduceLicenseWithOptions(RecognizeMedicalDeviceProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(DoRPCRequest("RecognizeMedicalDeviceProduceLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(RecognizeMedicalDeviceProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(await DoRPCRequestAsync("RecognizeMedicalDeviceProduceLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeMedicalDeviceProduceLicenseResponse RecognizeMedicalDeviceProduceLicense(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMedicalDeviceProduceLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseAsync(RecognizeMedicalDeviceProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeMixedInvoicesResponse RecognizeMixedInvoicesWithOptions(RecognizeMixedInvoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(DoRPCRequest("RecognizeMixedInvoices", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesWithOptionsAsync(RecognizeMixedInvoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(await DoRPCRequestAsync("RecognizeMixedInvoices", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeMixedInvoicesResponse RecognizeMixedInvoices(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMixedInvoicesWithOptions(request, runtime);
        }

        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesAsync(RecognizeMixedInvoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMixedInvoicesWithOptionsAsync(request, runtime);
        }

        public RecognizeMultiLanguageResponse RecognizeMultiLanguageWithOptions(RecognizeMultiLanguageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeMultiLanguageShrinkRequest request = new RecognizeMultiLanguageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Languages))
            {
                request.LanguagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Languages, "Languages", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(DoRPCRequest("RecognizeMultiLanguage", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeMultiLanguageResponse> RecognizeMultiLanguageWithOptionsAsync(RecognizeMultiLanguageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeMultiLanguageShrinkRequest request = new RecognizeMultiLanguageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Languages))
            {
                request.LanguagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Languages, "Languages", "simple");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(await DoRPCRequestAsync("RecognizeMultiLanguage", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeMultiLanguageResponse RecognizeMultiLanguage(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMultiLanguageWithOptions(request, runtime);
        }

        public async Task<RecognizeMultiLanguageResponse> RecognizeMultiLanguageAsync(RecognizeMultiLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMultiLanguageWithOptionsAsync(request, runtime);
        }

        public RecognizePassportResponse RecognizePassportWithOptions(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizePassportResponse>(DoRPCRequest("RecognizePassport", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizePassportResponse> RecognizePassportWithOptionsAsync(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizePassportResponse>(await DoRPCRequestAsync("RecognizePassport", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizePassportResponse RecognizePassport(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePassportWithOptions(request, runtime);
        }

        public async Task<RecognizePassportResponse> RecognizePassportAsync(RecognizePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePassportWithOptionsAsync(request, runtime);
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoiceWithOptions(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(DoRPCRequest("RecognizeQuotaInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceWithOptionsAsync(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(await DoRPCRequestAsync("RecognizeQuotaInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoice(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeQuotaInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeQuotaInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeRollTicketResponse RecognizeRollTicketWithOptions(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(DoRPCRequest("RecognizeRollTicket", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketWithOptionsAsync(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(await DoRPCRequestAsync("RecognizeRollTicket", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeRollTicketResponse RecognizeRollTicket(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRollTicketWithOptions(request, runtime);
        }

        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketAsync(RecognizeRollTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRollTicketWithOptionsAsync(request, runtime);
        }

        public RecognizeRussianResponse RecognizeRussianWithOptions(RecognizeRussianRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(DoRPCRequest("RecognizeRussian", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeRussianResponse> RecognizeRussianWithOptionsAsync(RecognizeRussianRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(await DoRPCRequestAsync("RecognizeRussian", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeRussianResponse RecognizeRussian(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRussianWithOptions(request, runtime);
        }

        public async Task<RecognizeRussianResponse> RecognizeRussianAsync(RecognizeRussianRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRussianWithOptionsAsync(request, runtime);
        }

        public RecognizeTableOcrResponse RecognizeTableOcrWithOptions(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(DoRPCRequest("RecognizeTableOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrWithOptionsAsync(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(await DoRPCRequestAsync("RecognizeTableOcr", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeTableOcrResponse RecognizeTableOcr(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTableOcrWithOptions(request, runtime);
        }

        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrAsync(RecognizeTableOcrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTableOcrWithOptionsAsync(request, runtime);
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoiceWithOptions(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(DoRPCRequest("RecognizeTaxiInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceWithOptionsAsync(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(await DoRPCRequestAsync("RecognizeTaxiInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoice(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxiInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxiInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeThaiResponse RecognizeThaiWithOptions(RecognizeThaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(DoRPCRequest("RecognizeThai", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeThaiResponse> RecognizeThaiWithOptionsAsync(RecognizeThaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(await DoRPCRequestAsync("RecognizeThai", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeThaiResponse RecognizeThai(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeThaiWithOptions(request, runtime);
        }

        public async Task<RecognizeThaiResponse> RecognizeThaiAsync(RecognizeThaiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeThaiWithOptionsAsync(request, runtime);
        }

        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertificationWithOptions(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(DoRPCRequest("RecognizeTradeMarkCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationWithOptionsAsync(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(await DoRPCRequestAsync("RecognizeTradeMarkCertification", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertification(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTradeMarkCertificationWithOptions(request, runtime);
        }

        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationAsync(RecognizeTradeMarkCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTradeMarkCertificationWithOptionsAsync(request, runtime);
        }

        public RecognizeTrainInvoiceResponse RecognizeTrainInvoiceWithOptions(RecognizeTrainInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(DoRPCRequest("RecognizeTrainInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceWithOptionsAsync(RecognizeTrainInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(await DoRPCRequestAsync("RecognizeTrainInvoice", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeTrainInvoiceResponse RecognizeTrainInvoice(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTrainInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceAsync(RecognizeTrainInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTrainInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeVehicleLicenseResponse RecognizeVehicleLicenseWithOptions(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(DoRPCRequest("RecognizeVehicleLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseWithOptionsAsync(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(await DoRPCRequestAsync("RecognizeVehicleLicense", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeVehicleLicenseResponse RecognizeVehicleLicense(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseAsync(RecognizeVehicleLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeWaybillResponse RecognizeWaybillWithOptions(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(DoRPCRequest("RecognizeWaybill", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecognizeWaybillResponse> RecognizeWaybillWithOptionsAsync(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(await DoRPCRequestAsync("RecognizeWaybill", "2021-07-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecognizeWaybillResponse RecognizeWaybill(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeWaybillWithOptions(request, runtime);
        }

        public async Task<RecognizeWaybillResponse> RecognizeWaybillAsync(RecognizeWaybillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeWaybillWithOptionsAsync(request, runtime);
        }

    }
}
