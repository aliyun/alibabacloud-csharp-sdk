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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeBankAcceptanceResponse RecognizeBankAcceptanceWithOptions(RecognizeBankAcceptanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAcceptance",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAcceptanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBankAcceptanceResponse> RecognizeBankAcceptanceWithOptionsAsync(RecognizeBankAcceptanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankAcceptance",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankAcceptanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeBankAcceptanceResponse RecognizeBankAcceptance(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankAcceptanceWithOptions(request, runtime);
        }

        public async Task<RecognizeBankAcceptanceResponse> RecognizeBankAcceptanceAsync(RecognizeBankAcceptanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankAcceptanceWithOptionsAsync(request, runtime);
        }

        public RecognizeBankAccountLicenseResponse RecognizeBankAccountLicenseWithOptions(RecognizeBankAccountLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeBusShipTicketResponse RecognizeBusShipTicketWithOptions(RecognizeBusShipTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusShipTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusShipTicketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBusShipTicketResponse> RecognizeBusShipTicketWithOptionsAsync(RecognizeBusShipTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusShipTicket",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusShipTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeBusShipTicketResponse RecognizeBusShipTicket(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusShipTicketWithOptions(request, runtime);
        }

        public async Task<RecognizeBusShipTicketResponse> RecognizeBusShipTicketAsync(RecognizeBusShipTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusShipTicketWithOptionsAsync(request, runtime);
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicenseWithOptions(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeChinesePassportResponse RecognizeChinesePassportWithOptions(RecognizeChinesePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinesePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinesePassportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeChinesePassportResponse> RecognizeChinesePassportWithOptionsAsync(RecognizeChinesePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinesePassport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinesePassportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeChinesePassportResponse RecognizeChinesePassport(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeChinesePassportWithOptions(request, runtime);
        }

        public async Task<RecognizeChinesePassportResponse> RecognizeChinesePassportAsync(RecognizeChinesePassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeChinesePassportWithOptionsAsync(request, runtime);
        }

        public RecognizeCommonPrintedInvoiceResponse RecognizeCommonPrintedInvoiceWithOptions(RecognizeCommonPrintedInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCommonPrintedInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCommonPrintedInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCommonPrintedInvoiceResponse> RecognizeCommonPrintedInvoiceWithOptionsAsync(RecognizeCommonPrintedInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCommonPrintedInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCommonPrintedInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeCommonPrintedInvoiceResponse RecognizeCommonPrintedInvoice(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCommonPrintedInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeCommonPrintedInvoiceResponse> RecognizeCommonPrintedInvoiceAsync(RecognizeCommonPrintedInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCommonPrintedInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeCosmeticProduceLicenseResponse RecognizeCosmeticProduceLicenseWithOptions(RecognizeCosmeticProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCosmeticProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCosmeticProduceLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCosmeticProduceLicenseResponse> RecognizeCosmeticProduceLicenseWithOptionsAsync(RecognizeCosmeticProduceLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCosmeticProduceLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCosmeticProduceLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeCosmeticProduceLicenseResponse RecognizeCosmeticProduceLicense(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCosmeticProduceLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeCosmeticProduceLicenseResponse> RecognizeCosmeticProduceLicenseAsync(RecognizeCosmeticProduceLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCosmeticProduceLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeCovidTestReportResponse RecognizeCovidTestReportWithOptions(RecognizeCovidTestReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultipleResult))
            {
                query["MultipleResult"] = request.MultipleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCovidTestReport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCovidTestReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCovidTestReportResponse> RecognizeCovidTestReportWithOptionsAsync(RecognizeCovidTestReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultipleResult))
            {
                query["MultipleResult"] = request.MultipleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCovidTestReport",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCovidTestReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeCovidTestReportResponse RecognizeCovidTestReport(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCovidTestReportWithOptions(request, runtime);
        }

        public async Task<RecognizeCovidTestReportResponse> RecognizeCovidTestReportAsync(RecognizeCovidTestReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCovidTestReportWithOptionsAsync(request, runtime);
        }

        public RecognizeCtwoMedicalDeviceManageLicenseResponse RecognizeCtwoMedicalDeviceManageLicenseWithOptions(RecognizeCtwoMedicalDeviceManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeDocumentStructureResponse RecognizeDocumentStructureWithOptions(RecognizeDocumentStructureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNewStyleOutput))
            {
                query["UseNewStyleOutput"] = request.UseNewStyleOutput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDocumentStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDocumentStructureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeDocumentStructureResponse> RecognizeDocumentStructureWithOptionsAsync(RecognizeDocumentStructureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoStamp))
            {
                query["NoStamp"] = request.NoStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Paragraph))
            {
                query["Paragraph"] = request.Paragraph;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Row))
            {
                query["Row"] = request.Row;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseNewStyleOutput))
            {
                query["UseNewStyleOutput"] = request.UseNewStyleOutput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDocumentStructure",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDocumentStructureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeDocumentStructureResponse RecognizeDocumentStructure(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDocumentStructureWithOptions(request, runtime);
        }

        public async Task<RecognizeDocumentStructureResponse> RecognizeDocumentStructureAsync(RecognizeDocumentStructureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDocumentStructureWithOptionsAsync(request, runtime);
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicenseWithOptions(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutType))
            {
                query["CutType"] = request.CutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutType))
            {
                query["CutType"] = request.CutType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOricoord))
            {
                query["OutputOricoord"] = request.OutputOricoord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeExitEntryPermitToHKResponse RecognizeExitEntryPermitToHKWithOptions(RecognizeExitEntryPermitToHKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToHK",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToHKResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeExitEntryPermitToHKResponse> RecognizeExitEntryPermitToHKWithOptionsAsync(RecognizeExitEntryPermitToHKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToHK",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToHKResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeExitEntryPermitToHKResponse RecognizeExitEntryPermitToHK(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToHKWithOptions(request, runtime);
        }

        public async Task<RecognizeExitEntryPermitToHKResponse> RecognizeExitEntryPermitToHKAsync(RecognizeExitEntryPermitToHKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToHKWithOptionsAsync(request, runtime);
        }

        public RecognizeExitEntryPermitToMainlandResponse RecognizeExitEntryPermitToMainlandWithOptions(RecognizeExitEntryPermitToMainlandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToMainland",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToMainlandResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeExitEntryPermitToMainlandResponse> RecognizeExitEntryPermitToMainlandWithOptionsAsync(RecognizeExitEntryPermitToMainlandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeExitEntryPermitToMainland",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeExitEntryPermitToMainlandResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeExitEntryPermitToMainlandResponse RecognizeExitEntryPermitToMainland(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeExitEntryPermitToMainlandWithOptions(request, runtime);
        }

        public async Task<RecognizeExitEntryPermitToMainlandResponse> RecognizeExitEntryPermitToMainlandAsync(RecognizeExitEntryPermitToMainlandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeExitEntryPermitToMainlandWithOptionsAsync(request, runtime);
        }

        public RecognizeFoodManageLicenseResponse RecognizeFoodManageLicenseWithOptions(RecognizeFoodManageLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeHealthCodeResponse RecognizeHealthCodeWithOptions(RecognizeHealthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHealthCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHealthCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeWithOptionsAsync(RecognizeHealthCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHealthCode",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHealthCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeHealthCodeResponse RecognizeHealthCode(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHealthCodeWithOptions(request, runtime);
        }

        public async Task<RecognizeHealthCodeResponse> RecognizeHealthCodeAsync(RecognizeHealthCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHealthCodeWithOptionsAsync(request, runtime);
        }

        public RecognizeHotelConsumeResponse RecognizeHotelConsumeWithOptions(RecognizeHotelConsumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHotelConsume",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHotelConsumeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeHotelConsumeResponse> RecognizeHotelConsumeWithOptionsAsync(RecognizeHotelConsumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeHotelConsume",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeHotelConsumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeHotelConsumeResponse RecognizeHotelConsume(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeHotelConsumeWithOptions(request, runtime);
        }

        public async Task<RecognizeHotelConsumeResponse> RecognizeHotelConsumeAsync(RecognizeHotelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeHotelConsumeWithOptionsAsync(request, runtime);
        }

        public RecognizeHouseholdResponse RecognizeHouseholdWithOptions(RecognizeHouseholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidentPage))
            {
                query["IsResidentPage"] = request.IsResidentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsResidentPage))
            {
                query["IsResidentPage"] = request.IsResidentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQualityInfo))
            {
                query["OutputQualityInfo"] = request.OutputQualityInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFigure))
            {
                query["OutputFigure"] = request.OutputFigure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputQualityInfo))
            {
                query["OutputQualityInfo"] = request.OutputQualityInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeInternationalBusinessLicenseResponse RecognizeInternationalBusinessLicenseWithOptions(RecognizeInternationalBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeInternationalBusinessLicenseResponse> RecognizeInternationalBusinessLicenseWithOptionsAsync(RecognizeInternationalBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeInternationalBusinessLicenseResponse RecognizeInternationalBusinessLicense(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalBusinessLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeInternationalBusinessLicenseResponse> RecognizeInternationalBusinessLicenseAsync(RecognizeInternationalBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalBusinessLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeInternationalIdcardResponse RecognizeInternationalIdcardWithOptions(RecognizeInternationalIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalIdcardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeInternationalIdcardResponse> RecognizeInternationalIdcardWithOptionsAsync(RecognizeInternationalIdcardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeInternationalIdcard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeInternationalIdcardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeInternationalIdcardResponse RecognizeInternationalIdcard(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeInternationalIdcardWithOptions(request, runtime);
        }

        public async Task<RecognizeInternationalIdcardResponse> RecognizeInternationalIdcardAsync(RecognizeInternationalIdcardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeInternationalIdcardWithOptionsAsync(request, runtime);
        }

        public RecognizeInvoiceResponse RecognizeInvoiceWithOptions(RecognizeInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagesShrink))
            {
                query["Languages"] = request.LanguagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguagesShrink))
            {
                query["Languages"] = request.LanguagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedSortPage))
            {
                query["NeedSortPage"] = request.NeedSortPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = tmpReq.Body,
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

        public RecognizeNonTaxInvoiceResponse RecognizeNonTaxInvoiceWithOptions(RecognizeNonTaxInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeNonTaxInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeNonTaxInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeNonTaxInvoiceResponse> RecognizeNonTaxInvoiceWithOptionsAsync(RecognizeNonTaxInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeNonTaxInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeNonTaxInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeNonTaxInvoiceResponse RecognizeNonTaxInvoice(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeNonTaxInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeNonTaxInvoiceResponse> RecognizeNonTaxInvoiceAsync(RecognizeNonTaxInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeNonTaxInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizePassportResponse RecognizePassportWithOptions(RecognizePassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizePaymentRecordResponse RecognizePaymentRecordWithOptions(RecognizePaymentRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePaymentRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePaymentRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePaymentRecordResponse> RecognizePaymentRecordWithOptionsAsync(RecognizePaymentRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePaymentRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePaymentRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizePaymentRecordResponse RecognizePaymentRecord(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePaymentRecordWithOptions(request, runtime);
        }

        public async Task<RecognizePaymentRecordResponse> RecognizePaymentRecordAsync(RecognizePaymentRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePaymentRecordWithOptionsAsync(request, runtime);
        }

        public RecognizePurchaseRecordResponse RecognizePurchaseRecordWithOptions(RecognizePurchaseRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePurchaseRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePurchaseRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePurchaseRecordResponse> RecognizePurchaseRecordWithOptionsAsync(RecognizePurchaseRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePurchaseRecord",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePurchaseRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizePurchaseRecordResponse RecognizePurchaseRecord(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePurchaseRecordWithOptions(request, runtime);
        }

        public async Task<RecognizePurchaseRecordResponse> RecognizePurchaseRecordAsync(RecognizePurchaseRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePurchaseRecordWithOptionsAsync(request, runtime);
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoiceWithOptions(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeRideHailingItineraryResponse RecognizeRideHailingItineraryWithOptions(RecognizeRideHailingItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRideHailingItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRideHailingItineraryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeRideHailingItineraryResponse> RecognizeRideHailingItineraryWithOptionsAsync(RecognizeRideHailingItineraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRideHailingItinerary",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRideHailingItineraryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeRideHailingItineraryResponse RecognizeRideHailingItinerary(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRideHailingItineraryWithOptions(request, runtime);
        }

        public async Task<RecognizeRideHailingItineraryResponse> RecognizeRideHailingItineraryAsync(RecognizeRideHailingItineraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRideHailingItineraryWithOptionsAsync(request, runtime);
        }

        public RecognizeRollTicketResponse RecognizeRollTicketWithOptions(RecognizeRollTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeShoppingReceiptResponse RecognizeShoppingReceiptWithOptions(RecognizeShoppingReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeShoppingReceipt",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeShoppingReceiptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeShoppingReceiptResponse> RecognizeShoppingReceiptWithOptionsAsync(RecognizeShoppingReceiptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeShoppingReceipt",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeShoppingReceiptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeShoppingReceiptResponse RecognizeShoppingReceipt(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeShoppingReceiptWithOptions(request, runtime);
        }

        public async Task<RecognizeShoppingReceiptResponse> RecognizeShoppingReceiptAsync(RecognizeShoppingReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeShoppingReceiptWithOptionsAsync(request, runtime);
        }

        public RecognizeSocialSecurityCardResponse RecognizeSocialSecurityCardWithOptions(RecognizeSocialSecurityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeSocialSecurityCardResponse> RecognizeSocialSecurityCardWithOptionsAsync(RecognizeSocialSecurityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCard",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeSocialSecurityCardResponse RecognizeSocialSecurityCard(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeSocialSecurityCardResponse> RecognizeSocialSecurityCardAsync(RecognizeSocialSecurityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeSocialSecurityCardVersionIIResponse RecognizeSocialSecurityCardVersionIIWithOptions(RecognizeSocialSecurityCardVersionIIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCardVersionII",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardVersionIIResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeSocialSecurityCardVersionIIResponse> RecognizeSocialSecurityCardVersionIIWithOptionsAsync(RecognizeSocialSecurityCardVersionIIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeSocialSecurityCardVersionII",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeSocialSecurityCardVersionIIResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeSocialSecurityCardVersionIIResponse RecognizeSocialSecurityCardVersionII(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeSocialSecurityCardVersionIIWithOptions(request, runtime);
        }

        public async Task<RecognizeSocialSecurityCardVersionIIResponse> RecognizeSocialSecurityCardVersionIIAsync(RecognizeSocialSecurityCardVersionIIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeSocialSecurityCardVersionIIWithOptionsAsync(request, runtime);
        }

        public RecognizeTableOcrResponse RecognizeTableOcrWithOptions(RecognizeTableOcrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHandWriting))
            {
                query["IsHandWriting"] = request.IsHandWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineLess))
            {
                query["LineLess"] = request.LineLess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                query["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHandWriting))
            {
                query["IsHandWriting"] = request.IsHandWriting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineLess))
            {
                query["LineLess"] = request.LineLess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                query["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeTaxClearanceCertificateResponse RecognizeTaxClearanceCertificateWithOptions(RecognizeTaxClearanceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxClearanceCertificate",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxClearanceCertificateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTaxClearanceCertificateResponse> RecognizeTaxClearanceCertificateWithOptionsAsync(RecognizeTaxClearanceCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxClearanceCertificate",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxClearanceCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTaxClearanceCertificateResponse RecognizeTaxClearanceCertificate(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxClearanceCertificateWithOptions(request, runtime);
        }

        public async Task<RecognizeTaxClearanceCertificateResponse> RecognizeTaxClearanceCertificateAsync(RecognizeTaxClearanceCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxClearanceCertificateWithOptionsAsync(request, runtime);
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoiceWithOptions(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRotate))
            {
                query["NeedRotate"] = request.NeedRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputCharInfo))
            {
                query["OutputCharInfo"] = request.OutputCharInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputTable))
            {
                query["OutputTable"] = request.OutputTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeTollInvoiceResponse RecognizeTollInvoiceWithOptions(RecognizeTollInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTollInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTollInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceWithOptionsAsync(RecognizeTollInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTollInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTollInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTollInvoiceResponse RecognizeTollInvoice(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTollInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeTollInvoiceResponse> RecognizeTollInvoiceAsync(RecognizeTollInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTollInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeTradeMarkCertificationResponse RecognizeTradeMarkCertificationWithOptions(RecognizeTradeMarkCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeUsedCarInvoiceResponse RecognizeUsedCarInvoiceWithOptions(RecognizeUsedCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUsedCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUsedCarInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeUsedCarInvoiceResponse> RecognizeUsedCarInvoiceWithOptionsAsync(RecognizeUsedCarInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUsedCarInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUsedCarInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeUsedCarInvoiceResponse RecognizeUsedCarInvoice(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeUsedCarInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeUsedCarInvoiceResponse> RecognizeUsedCarInvoiceAsync(RecognizeUsedCarInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeUsedCarInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeVehicleCertificationResponse RecognizeVehicleCertificationWithOptions(RecognizeVehicleCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleCertificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVehicleCertificationResponse> RecognizeVehicleCertificationWithOptionsAsync(RecognizeVehicleCertificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleCertification",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleCertificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVehicleCertificationResponse RecognizeVehicleCertification(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleCertificationWithOptions(request, runtime);
        }

        public async Task<RecognizeVehicleCertificationResponse> RecognizeVehicleCertificationAsync(RecognizeVehicleCertificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleCertificationWithOptionsAsync(request, runtime);
        }

        public RecognizeVehicleLicenseResponse RecognizeVehicleLicenseWithOptions(RecognizeVehicleLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public RecognizeVehicleRegistrationResponse RecognizeVehicleRegistrationWithOptions(RecognizeVehicleRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleRegistration",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleRegistrationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVehicleRegistrationResponse> RecognizeVehicleRegistrationWithOptionsAsync(RecognizeVehicleRegistrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
                Stream = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVehicleRegistration",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVehicleRegistrationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVehicleRegistrationResponse RecognizeVehicleRegistration(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVehicleRegistrationWithOptions(request, runtime);
        }

        public async Task<RecognizeVehicleRegistrationResponse> RecognizeVehicleRegistrationAsync(RecognizeVehicleRegistrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVehicleRegistrationWithOptionsAsync(request, runtime);
        }

        public RecognizeWaybillResponse RecognizeWaybillWithOptions(RecognizeWaybillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
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

        public VerifyBusinessLicenseResponse VerifyBusinessLicenseWithOptions(VerifyBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                query["CreditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                query["LegalPerson"] = request.LegalPerson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyBusinessLicenseResponse> VerifyBusinessLicenseWithOptionsAsync(VerifyBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["CompanyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                query["CreditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPerson))
            {
                query["LegalPerson"] = request.LegalPerson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyBusinessLicense",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyBusinessLicenseResponse VerifyBusinessLicense(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyBusinessLicenseWithOptions(request, runtime);
        }

        public async Task<VerifyBusinessLicenseResponse> VerifyBusinessLicenseAsync(VerifyBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyBusinessLicenseWithOptionsAsync(request, runtime);
        }

        public VerifyVATInvoiceResponse VerifyVATInvoiceWithOptions(VerifyVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                query["InvoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceDate))
            {
                query["InvoiceDate"] = request.InvoiceDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                query["InvoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSum))
            {
                query["InvoiceSum"] = request.InvoiceSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVATInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVATInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyVATInvoiceResponse> VerifyVATInvoiceWithOptionsAsync(VerifyVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                query["InvoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceDate))
            {
                query["InvoiceDate"] = request.InvoiceDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                query["InvoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceSum))
            {
                query["InvoiceSum"] = request.InvoiceSum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyCode))
            {
                query["VerifyCode"] = request.VerifyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVATInvoice",
                Version = "2021-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVATInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyVATInvoiceResponse VerifyVATInvoice(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyVATInvoiceWithOptions(request, runtime);
        }

        public async Task<VerifyVATInvoiceResponse> VerifyVATInvoiceAsync(VerifyVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyVATInvoiceWithOptionsAsync(request, runtime);
        }

    }
}
