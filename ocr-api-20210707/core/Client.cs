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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAdvanced",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeAdvancedResponse> RecognizeAdvancedWithOptionsAsync(RecognizeAdvancedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAdvanced",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAdvancedResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAirItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeAirItineraryResponse> RecognizeAirItineraryWithOptionsAsync(RecognizeAirItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAirItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAirItineraryResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAccountLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBankAccountLicenseResponse> RecognizeBankAccountLicenseWithOptionsAsync(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAccountLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAccountLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardWithOptionsAsync(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBasic",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBasicResponse> RecognizeBasicWithOptionsAsync(RecognizeBasicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBasic",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBasicResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBirthCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBirthCertificationResponse> RecognizeBirthCertificationWithOptionsAsync(RecognizeBirthCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBirthCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBirthCertificationResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseWithOptionsAsync(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCarInvoiceResponse> RecognizeCarInvoiceWithOptionsAsync(RecognizeCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarInvoiceResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarNumber",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCarNumberResponse> RecognizeCarNumberWithOptionsAsync(RecognizeCarNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarNumber",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarNumberResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarVinCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCarVinCodeResponse> RecognizeCarVinCodeWithOptionsAsync(RecognizeCarVinCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCarVinCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCarVinCodeResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCtwoMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCtwoMedicalDeviceManageLicenseResponse> RecognizeCtwoMedicalDeviceManageLicenseWithOptionsAsync(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCtwoMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCtwoMedicalDeviceManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseWithOptionsAsync(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduFormula",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduFormulaResponse> RecognizeEduFormulaWithOptionsAsync(RecognizeEduFormulaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduFormula",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduFormulaResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduOralCalculation",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduOralCalculationResponse> RecognizeEduOralCalculationWithOptionsAsync(RecognizeEduOralCalculationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduOralCalculation",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduOralCalculationResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CutType"] = request.CutType;
            query["ImageType"] = request.ImageType;
            query["Subject"] = request.Subject;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperCut",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduPaperCutResponse> RecognizeEduPaperCutWithOptionsAsync(RecognizeEduPaperCutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CutType"] = request.CutType;
            query["ImageType"] = request.ImageType;
            query["Subject"] = request.Subject;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperCut",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperCutResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ImageType"] = request.ImageType;
            query["OutputOricoord"] = request.OutputOricoord;
            query["Subject"] = request.Subject;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduPaperOcrResponse> RecognizeEduPaperOcrWithOptionsAsync(RecognizeEduPaperOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ImageType"] = request.ImageType;
            query["OutputOricoord"] = request.OutputOricoord;
            query["Subject"] = request.Subject;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperOcrResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperStructed",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduPaperStructedResponse> RecognizeEduPaperStructedWithOptionsAsync(RecognizeEduPaperStructedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduPaperStructed",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduPaperStructedResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduQuestionOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEduQuestionOcrResponse> RecognizeEduQuestionOcrWithOptionsAsync(RecognizeEduQuestionOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEduQuestionOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEduQuestionOcrResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEnglish",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEnglishResponse> RecognizeEnglishWithOptionsAsync(RecognizeEnglishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEnglish",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEnglishResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEstateCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeEstateCertificationResponse> RecognizeEstateCertificationWithOptionsAsync(RecognizeEstateCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeEstateCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeEstateCertificationResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeFoodManageLicenseResponse> RecognizeFoodManageLicenseWithOptionsAsync(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeFoodProduceLicenseResponse> RecognizeFoodProduceLicenseWithOptionsAsync(RecognizeFoodProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeFoodProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeFoodProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneral",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeGeneralResponse> RecognizeGeneralWithOptionsAsync(RecognizeGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeGeneral",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeGeneralResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHandwriting",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeHandwritingResponse> RecognizeHandwritingWithOptionsAsync(RecognizeHandwritingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHandwriting",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHandwritingResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHousehold",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeHouseholdResponse> RecognizeHouseholdWithOptionsAsync(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHousehold",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHouseholdResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeIdcardResponse> RecognizeIdcardWithOptionsAsync(RecognizeIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdcardResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeInvoiceResponse> RecognizeInvoiceWithOptionsAsync(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInvoiceResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeJanpanese",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeJanpaneseResponse> RecognizeJanpaneseWithOptionsAsync(RecognizeJanpaneseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeJanpanese",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeJanpaneseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeKorean",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeKoreanResponse> RecognizeKoreanWithOptionsAsync(RecognizeKoreanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeKorean",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeKoreanResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLatin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeLatinResponse> RecognizeLatinWithOptionsAsync(RecognizeLatinRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLatin",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLatinResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeMedicalDeviceManageLicenseResponse> RecognizeMedicalDeviceManageLicenseWithOptionsAsync(RecognizeMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceManageLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceManageLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeMedicalDeviceProduceLicenseResponse> RecognizeMedicalDeviceProduceLicenseWithOptionsAsync(RecognizeMedicalDeviceProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMedicalDeviceProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMedicalDeviceProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMixedInvoices",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeMixedInvoicesResponse> RecognizeMixedInvoicesWithOptionsAsync(RecognizeMixedInvoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMixedInvoices",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMixedInvoicesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Languages"] = request.LanguagesShrink;
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMultiLanguage",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Languages"] = request.LanguagesShrink;
            query["NeedRotate"] = request.NeedRotate;
            query["NeedSortPage"] = request.NeedSortPage;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMultiLanguage",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMultiLanguageResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePassportResponse> RecognizePassportWithOptionsAsync(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceWithOptionsAsync(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRollTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeRollTicketResponse> RecognizeRollTicketWithOptionsAsync(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRollTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRollTicketResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussian",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeRussianResponse> RecognizeRussianWithOptionsAsync(RecognizeRussianRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussian",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussianResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTableOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTableOcrResponse> RecognizeTableOcrWithOptionsAsync(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTableOcr",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableOcrResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceWithOptionsAsync(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeThai",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeThaiResponse> RecognizeThaiWithOptionsAsync(RecognizeThaiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NeedRotate"] = request.NeedRotate;
            query["OutputCharInfo"] = request.OutputCharInfo;
            query["OutputTable"] = request.OutputTable;
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeThai",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeThaiResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTradeMarkCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTradeMarkCertificationResponse> RecognizeTradeMarkCertificationWithOptionsAsync(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTradeMarkCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTradeMarkCertificationResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTrainInvoiceResponse> RecognizeTrainInvoiceWithOptionsAsync(RecognizeTrainInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainInvoiceResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVehicleLicenseResponse> RecognizeVehicleLicenseWithOptionsAsync(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleLicenseResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeWaybill",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeWaybillResponse> RecognizeWaybillWithOptionsAsync(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Url"] = request.Url;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeWaybill",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeWaybillResponse>(await CallApiAsync(params_, req, runtime));
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
